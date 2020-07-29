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
    public partial class Form2 : Form
    {
        Form1 main;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            main = this.Owner as Form1;
            checkBox1.Checked = true;
            comboBox1.Items.AddRange(new string[] {"Принят","Склад","Продан"});
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model model = new Model() {Product = textBox1.Text, status = comboBox1.SelectedItem.ToString()};
            try { model.Count = Convert.ToInt32(textBox2.Text); }
            catch { }
            Random random = new Random();
            DateTime dtmin = new DateTime(2020,01,01);
            int diff = (DateTime.Today - dtmin).Days;
            if (checkBox1.Checked) model.StatusChange = dtmin.AddDays(random.Next(diff));
            else model.StatusChange = DateTime.Today;
            int temp = -1;
            if(new DBAdapter().WriteToDB(model) > -1) temp = main.addDataToDataTable(model);
            if (temp != -1) MessageBox.Show("Добавлена " + temp + "запись");
            else MessageBox.Show("Не удалось добавить запись. Проверьте введённые данные.");

            this.Close();
        }
    }
}
