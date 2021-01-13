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
    public partial class Form4 : Form
    {

        public string TxtBox
        {
            get { return kod_teachersTextBox.Text; }
            set { kod_teachersTextBox.Text = value; }
        }

        public Form4()
        {
            Program.f4 = this; // теперь f4 будет ссылкой на форму Form1
            InitializeComponent();
        }

        private BindingSource publication;
            
        private void publicationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.publicationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.dataSet1.teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.arhiv". При необходимости она может быть перемещена или удалена.
            this.arhivTableAdapter.Fill(this.dataSet1.arhiv);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.publication". При необходимости она может быть перемещена или удалена.
            this.publicationTableAdapter.Fill(this.dataSet1.publication);

        }

        private void publicationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить публикацию? После удаления она будет перемещена в архив!", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                publicationBindingSource.RemoveCurrent();
                this.Validate();
                this.publicationBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                publicationBindingSource.Filter = "[Название публикации] LIKE '" + textBox1.Text + "*'";
            else


                publicationBindingSource.Filter = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.arhivTableAdapter addarhiv = new DataSet1TableAdapters.arhivTableAdapter();
            addarhiv.Insert(Convert.ToString(dataSet1.publication.Название_публикацииColumn),
                Convert.ToString(dataSet1.publication.ГодColumn),
                Convert.ToString(dataSet1.publication.ТематикаColumn),
                Convert.ToString(dataSet1.publication.Краткое_содержаниеColumn),
                Convert.ToString(dataSet1.publication.УровеньColumn), фИОTextBox.Text);
            this.arhivTableAdapter.Fill(this.dataSet1.arhiv);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void teachersDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                publicationBindingSource1.Filter = "[Название публикации] LIKE '" + textBox3.Text + "*'";

            else
            
               publicationBindingSource1.Filter = null;
            if (publicationDataGridView1.Rows.Count < 2)
                MessageBox.Show("Поиск не дал результатов");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form myForm = new Form6();
            myForm.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                teachersBindingSource.Filter = "[ФИО] LIKE '" + textBox2.Text + "*'";

            else

                teachersBindingSource.Filter = null;
            if (teachersDataGridView.Rows.Count < 2)
                MessageBox.Show("Поиск не дал результатов");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
                publicationBindingSource1.Filter = "[Уровень] LIKE '" + comboBox1.Text + "*'";

            else

                publicationBindingSource1.Filter = null;
            if (publicationDataGridView1.Rows.Count < 2)
                MessageBox.Show("Поиск не дал результатов");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
        }

        public void kod_teachersTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //обновление найти
            this.publicationTableAdapter.Fill(this.dataSet1.publication);
            this.teachersTableAdapter.Fill(this.dataSet1.teachers);

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (publicationDataGridView1.Rows.Count < 2)
                MessageBox.Show("Что вы собираетесь удалить в пустой таблице?!");
            else
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранную публикацию?!", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    publicationBindingSource1.RemoveCurrent();
                    this.Validate();
                    this.publicationBindingSource1.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "обновить")
                button7_Click(sender, e);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (publicationDataGridView1.Rows.Count > 1)
                MessageBox.Show("У вас не получится удалить преподавателя, пока у него есть публикации!");
            else
            {

                if (MessageBox.Show("Вы действительно хотите удалить выбранного преподавателя?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    teachersBindingSource.RemoveCurrent();
                    this.Validate();
                    this.teachersBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dataSet1);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form myForm = new Form5();
            myForm.ShowDialog();
        }
    }
}
