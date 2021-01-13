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
    public partial class Form6 : Form
    {
        
        public Form6()
        {
            
            InitializeComponent();
           

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Заполните все данные");
            }
            textBox5.Text = Program.f4.kod_teachersTextBox.Text;



            DataSet1TableAdapters.publicationTableAdapter addpubl = new DataSet1TableAdapters.publicationTableAdapter();
            _ = addpubl.Insert(textBox3.Text, 
                textBox2.Text,
                textBox1.Text, 
                textBox4.Text,
                Convert.ToString(comboBox1.Text), 
                Convert.ToInt32(textBox5.Text));
            MessageBox.Show("Публикация добавлена");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            
            Program.f4.textBox4.Text = "обновить";
            Program.f4.textBox4.Text = "";

            Close();
           
            
           

        }

        private void publicationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publicationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.dataSet1.teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.publication". При необходимости она может быть перемещена или удалена.
            this.publicationTableAdapter.Fill(this.dataSet1.publication);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
            
            this.Close();



        }

        public void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
