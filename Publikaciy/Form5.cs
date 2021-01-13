using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publikaciy
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "")|| (textBox2.Text == "")||(textBox3.Text == "")||(textBox4.Text == ""))
            {
                MessageBox.Show("Заполните все данные");
            }

           
            else
            {

                DataSet1TableAdapters.teachersTableAdapter addteachers = new DataSet1TableAdapters.teachersTableAdapter();
                addteachers.Insert(textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    Convert.ToDateTime(dateTimePicker1.Value));

                this.teachersTableAdapter.Fill(this.dataSet1.teachers);
                MessageBox.Show("Преподаватель добавлен");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                Program.f4.textBox4.Text = "обновить";
                Program.f4.textBox4.Text = "";
                this.Close();
            }  


        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.dataSet1.teachers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            this.Close();
        }
    }
}
