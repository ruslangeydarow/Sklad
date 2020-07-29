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
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.FilterByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(2020, 01, 01);
            dateTimePicker2.Value = DateTime.Now;
            f1 = this.Owner as Form1;
        }
    }
}