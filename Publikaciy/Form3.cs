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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.loginpass". При необходимости она может быть перемещена или удалена.
            this.loginpassTableAdapter.Fill(this.dataSet1.loginpass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.loginpass". При необходимости она может быть перемещена или удалена.
            this.loginpassTableAdapter.Fill(this.dataSet1.loginpass);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == passTextBox.Text)
            {
                Form myForm = new Form4();
                myForm.ShowDialog();
            }
            else
            
                MessageBox.Show("Неверное имя пользователя или пароль. Повторите ввод пароля(111)");
            textBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
