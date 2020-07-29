using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad
{
    public partial class Form1 : Form
    {
        private DataTable DataFromDB;
        private Color color;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataFromDB = new DBAdapter().GetData();
            color = button1.ForeColor;
            FirstLoad();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            e.Graphics.FillRectangle(solidBrush, 0, 0, 200, 600);
        }

        private void buttonClick(object sender)
        {
            if (((Button)sender).ForeColor != color) { RefreshDataGridView(DataFromDB); highlightButton(sender, false); }
            else
                try
                {
                    RefreshDataGridView(DataFromDB.AsEnumerable().
                        Where(x => x["Status"].ToString() == ((Button)sender).Text).Select(x => x).ToArray().CopyToDataTable<DataRow>());
                    highlightButton(sender, true);
                }
                catch (Exception ex) { MessageBox.Show("Нет записей со статусом \"" + ((Button)sender).Text + "\".\nТаблица не обновлена!"); }
            refreshLabel();
        }

        private void highlightButton(object sender, bool b)
        {
            if (((Button)sender).ForeColor == color)
            {
                button1.ForeColor = button2.ForeColor = button3.ForeColor = color;
                if (b) ((Button)sender).ForeColor = Color.Red;
            }
            else ((Button)sender).ForeColor = color;
        }

        private void refreshLabel()
        {
            label1.Text = "Всего записей: " + dataGridView1.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonClick(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 addProductForm = new Form2();
            addProductForm.ShowDialog(this);
        }

        public int addDataToDataTable(Model model)
        {
            int count = DataFromDB.Rows != null ? DataFromDB.Rows.Count : 0;
            DataFromDB.Rows.Add(new object[] { CreateUniqueID(), model.Product, model.Count, model.status, model.StatusChange });
            RefreshDataGridView(DataFromDB);
            highlightButton(button1, false);
            refreshLabel();
            return (DataFromDB.Rows.Count - count) > -1 ? (DataFromDB.Rows.Count - count) : -1;
        }

        private int CreateUniqueID()
        {
            var temp = DateTime.Now;
            return Convert.ToInt32(temp.Day) + Convert.ToInt32(temp.Month) +
                Convert.ToInt32(temp.Year) + Convert.ToInt32(temp.Hour) +
                Convert.ToInt32(temp.Minute) + Convert.ToInt32(temp.Second);
        }

        public void FilterByDate(DateTime start, DateTime end)
        {
            try
            {
                DataTable tempDataFromDB = DataFromDB.AsEnumerable().
                    Where(x => (x.Field<DateTime>("StatusChange") > start) && (x.Field<DateTime>("StatusChange") < end)).
                    Select(x => x).ToArray().CopyToDataTable<DataRow>();
                RefreshDataGridView(tempDataFromDB);
                highlightButton(button1, false);
                refreshLabel();
            }
            catch { MessageBox.Show("Не удалось отфильтровать по выбранным датам"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 FilterSet = new Form3();
            FilterSet.ShowDialog(this);
        }

    }

}
