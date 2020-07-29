using System.Data;
using System.Linq;


namespace Sklad
{
    partial class Form1
    {

        private int variable;
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(120, 70);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Принят";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(13, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Склад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(13, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Продан";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Добавить товар";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Всего записей: 0";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(167, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Фильтр по датам";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;

        void FirstLoad()
        {
            variable = 0;

            //Form
            this.Size = new System.Drawing.Size(800, 600);

            //Button "Принят"
            button1.SetBounds(25, 90, 150, 80);

            //Button "Склад"
            button2.SetBounds(25, 90 + 80 + 90, 150, 80);

            //Button "Продан"
            button3.SetBounds(25, 90 + 80 + 90 + 80 + 90, 150, 80);

            //DataGridView
            dataGridView1.SetBounds(220, 10, 560, 500);
            RefreshDataGridView(DataFromDB);

            //Label "Всего позиций"
            label1.Location = new System.Drawing.Point(220, 510 + 10);
            label1.Text = "Всего записей: " + dataGridView1.Rows.Count;

            //Button "Добавить позицию"
            button4.SetBounds(450, 530, 100, 30);

            //Button "Отфильтровать по датам"
            button5.SetBounds(450 + 100 + 100, 530, 110, 30);
        }
        void RefreshDataGridView(DataTable DT)
        {
            try
            {
                if (dataGridView1.Rows != null) dataGridView1.Rows.Clear();
                if (dataGridView1.Columns != null) dataGridView1.Columns.Clear();

                if (DT != null)
                {
                    foreach (DataColumn DC in DT.Columns)
                    {
                        System.Windows.Forms.DataGridViewColumn Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        if (DC.ColumnName == "Key") Column.Width = 70;
                        if (DC.ColumnName == "Product") Column.Width = 148;
                        if (DC.ColumnName == "Count") Column.Width = 65;
                        if (DC.ColumnName == "StatusChange") Column.Width = 168;
                        if (DC.ColumnName == "Status") Column.Width = 65;
                        Column.HeaderText = DC.ColumnName;
                        Column.Name = DC.ColumnName;
                        Column.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                        Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
                        dataGridView1.Columns.Add(Column);
                        Column.Dispose();
                        Column = null;
                    }
                    int j = 0;
                    foreach (DataRow DR in DT.Rows)
                    {
                        //var Row = new System.Windows.Forms.DataGridViewRow();
                        dataGridView1.Rows.Add();
                        int i = 0;

                        foreach (var IA in DR.ItemArray)
                        {
                            dataGridView1[i++, j].Value = IA;
                        }
                        j++;
                    }
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.AllowUserToOrderColumns = false;
                    dataGridView1.AllowUserToResizeColumns = false;
                    dataGridView1.AllowUserToResizeRows = false;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.CellMouseClick -= dataGridView1_CellMouseClick;
                    dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
                }
            }
            catch { }
        }

        void dataGridView1_CellMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                if (e.ColumnIndex == dataGridView1.Columns["Status"].Index)
                {
                    try
                    {
                        var menuItems = new System.Collections.Generic.List<string>() { "Принят", "Склад", "Продан", "Удалить" };
                        var menu = new System.Windows.Forms.ContextMenu();
                        menuItems.Remove(dataGridView1["Status", e.RowIndex].Value.ToString());
                        foreach (var m in menuItems)
                        {
                            menu.MenuItems.Add(m, new System.EventHandler(menuClick));
                        };
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                        menu.Show(dataGridView1, new System.Drawing.Point(e.Location.X + 200, e.Location.Y));
                    }
                    catch { }
                }
        }

        void menuClick(object sender, System.EventArgs e)
        {
            string condition = dataGridView1["Product", dataGridView1.SelectedRows[0].Index].Value.ToString();
            if (((System.Windows.Forms.MenuItem)sender).Text == "Удалить")
            {
                new DBAdapter().DeleteFromDB(condition);
                try
                {
                    DataFromDB =
                        DataFromDB.AsEnumerable().Where(x => x.Field<string>("Product") != condition).Select(x => x).CopyToDataTable<DataRow>();
                }
                catch { DataFromDB.Rows.Clear(); }
                finally { RefreshDataGridView(DataFromDB); }
            }
            else
            {
                new DBAdapter().UpdateInDB(((System.Windows.Forms.MenuItem)sender).Text, condition);
                try
                {
                    int cond = System.Convert.ToInt32(dataGridView1["Key", dataGridView1.SelectedRows[0].Index].Value.ToString());

                    var row = DataFromDB.AsEnumerable().SingleOrDefault(r => r.Field<int>("Key") == cond);
                    var rowIndex = DataFromDB.Rows.IndexOf(row);
                    DataFromDB.Rows[rowIndex].SetField("Status", ((System.Windows.Forms.MenuItem)sender).Text);
                    DataFromDB.Rows[rowIndex].SetField("StatusChange", System.DateTime.Now);
                }
                catch { }
                finally { RefreshDataGridView(DataFromDB); }
            }
            refreshLabel();
        }

        private System.Windows.Forms.Button button5;
    }
}

