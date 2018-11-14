using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int rowNmb = 0;
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
                StringBuilder word = new StringBuilder();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        word.Append(dataGridView1[j, i].Value);
                        dataGridView1[j, i].Value = "";
                    }
                    word.Append("\r\n");
                }
                textBox1.Text = word.ToString();                          
                      
        }

        private DataGridViewColumn createColumn(int i)
        {
            DataGridViewColumn colum = new DataGridViewColumn();
            colum.HeaderText = i.ToString();
            colum.Name = "column" + i.ToString();
            colum.CellTemplate = new DataGridViewTextBoxCell();
            return colum;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            char c;
            Random rnd = new Random();
            DataGridViewColumn col = new DataGridViewColumn();
            for (int i = 0; i < 10; i++)
            {

                dataGridView1.Columns.Add(createColumn(i));
            }
            dataGridView1.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    c = (char)rnd.Next(65, 93);
                    dataGridView1[i, j].Value = c;
                }
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows[0].Selected = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String copy;
            int i = 0, j = 0;
            copy = textBox1.Text;
            for (int m = 0; m < copy.Length; m++)
            {
                if ((copy[m] != '\r') && (copy[m] != '\n'))
                {
                    if (i >= dataGridView1.RowCount)
                    {
                        dataGridView1.Rows.Add(1);
                    }
                    if (j >= dataGridView1.ColumnCount)
                    {
                        dataGridView1.Columns.Add(createColumn(j));
                    }
                    dataGridView1[j, i].Value = copy[m];
                    j++;

                }
                else if (copy[m] == '\n')
                {
                    j = 0;
                    i++;

                }
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char c;
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    c = (char)rnd.Next(65, 93);
                    dataGridView1[i, j].Value = c;
                }
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder word = new StringBuilder();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    word.Append(dataGridView1[j, i].Value);
                    dataGridView1[j, i].Value = "";
                    word.Append("\t");
                }
                word.Append("\r\n");

            }
            textBox2.Text = word.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String copy;
            int i = 0, j = 0;
            copy = textBox2.Text;
            for (int m = 0; m < copy.Length; m++)
            {
                if ((copy[m] != '\r') && (copy[m] != '\n') && (copy[m] != '\t'))
                {
                    if (i >= dataGridView1.RowCount)
                    {
                        dataGridView1.Rows.Add(1);
                    }
                    if (j >= dataGridView1.ColumnCount)
                    {
                        dataGridView1.Columns.Add(createColumn(j));
                    }
                    dataGridView1[j, i].Value = copy[m];
                    j++;

                }
                else if (copy[m] == '\n')
                {
                    j = 0;
                    i++;

                }
            }
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
                textBox3.Clear();
                for(int i = 0; i < 10;i++) {
                    textBox3.Text += dataGridView1[i,dataGridView1.CurrentRow.Index].Value.ToString();
                    dataGridView1[i, dataGridView1.CurrentRow.Index].Value = "";
                }
                dataGridView1.Rows[0].Selected = false;
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string [] s = new string [10];
            for (int i = 0; i < 10; i++)
            {
                s[i] += dataGridView1[i, dataGridView1.CurrentRow.Index].Value.ToString();

            }

            for (int i = 0; i < 10; i++)
            {
                dataGridView1[i, dataGridView1.CurrentRow.Index].Value = textBox3.Text[i];
                
            }
            textBox3.Clear();

            for (int i = 0; i < 10; i++)
            {
                textBox3.Text += s[i];
            }
                


           
            dataGridView1.Rows[0].Selected = false;
        }
    }
}

