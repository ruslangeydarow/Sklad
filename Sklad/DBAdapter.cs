using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

namespace Sklad
{
    /// <summary>
    /// Класс с методами работы с БД
    /// </summary>
    class DBAdapter
    {
        static private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
            + ConfigurationSettings.AppSettings.Get("PathToDataBaseFile") + "SkladDb.accdb;";
        static private OleDbConnection DBConnection = new OleDbConnection(connectionString);

        public DataTable GetData()
        {
            DataSet DS = new DataSet();

            OleDbCommand DBCommand = new OleDbCommand(
                "SELECT Table1.Key, Table1.Product, Table1.Count, Table1.Status, Table1.StatusChange FROM Table1 Order By Table1.Product",
                DBConnection
                );
            OleDbDataAdapter DA = new OleDbDataAdapter(DBCommand);
            try { DBConnection.Open(); DA.Fill(DS); }
            catch (Exception ex) { MessageBox.Show("Не удалось загрузить информацию из базы данных.\nПодробнее об ошибке:\n" + ex.Message); }
            finally { DBConnection.Close(); }

            return DS.Tables.Count > 0 ? DS.Tables[0] : null;
        }

        private int ExecuteCommand(string command)
        {
            OleDbCommand writeCommand = new OleDbCommand(String.Empty, DBConnection);
            writeCommand.CommandText = command;
            int result = -1;
            try
            {
                DBConnection.Open();
                result = writeCommand.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show("Не удалось выполнить операцию с БД.\nПодробнее:" + ex.Message); }
            finally { DBConnection.Close(); }
            return result;
        }

        public int WriteToDB(Model model)
        {
            string command = "INSERT INTO [Table1] ([Product], [Count],[StatusChange],[Status]) VALUES (" + model.StringForDB() + ")";
            return ExecuteCommand(command);
        }

        public int DeleteFromDB(string product)
        {
            string command = "DELETE Table1.Product FROM Table1 WHERE (((Table1.Product)=\""+product+"\"))";
            return ExecuteCommand(command);
        }

        public int UpdateInDB(string status, string product)
        {
            string command = "UPDATE Table1 SET Table1.[Status] = \""+status
                +"\", Table1.[StatusChange] = \""+DateTime.Now.ToString()+"\"  WHERE Table1.Product=\""+product+"\"";
            return ExecuteCommand(command);
        }
    }
}
