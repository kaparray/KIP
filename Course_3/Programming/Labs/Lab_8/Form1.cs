using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public int i = 0; // Counter for the number of items in the list
        public Form1()
        {
            InitializeComponent();
        }

        // Exit for mrogramm
        private void button7_Click(object sender, EventArgs e)
        {

            Width = 525;
            Height = 400;
            DialogResult dialogResult = MessageBox.Show("Вы точно выйти из программы?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Width = 525;
            Height = 400;
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                MessageBox.Show("Вы не ввели продукт!");
                textBox1.Focus();
            }
            else
            {
                foreach (string b in listBox1.Items)
                {
                    if (textBox1.Text == b)
                    {
                        MessageBox.Show("Вы уже вводили этот продукт!");
                        textBox1.Text = "";
                    }
                }
                string s = textBox1.Text;
                    if (s.Trim() == string.Empty)
                    {
                    textBox1.Text = "";
                    textBox1.Focus();
                    }
                    else
                    {
                        listBox1.Items.Add(textBox1.Text);
                        textBox1.Clear();
                        textBox1.Focus();
                        i += 1;
                        label4.Text = Convert.ToString(i);
                    }   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 0;
            label4.Text = Convert.ToString(i);
        }

        // Delete item
        private void button4_Click(object sender, EventArgs e)
        {
            Width = 525;
            Height = 400;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы ничего не выбрали!");
            }
            else
            {
                int x = listBox1.SelectedIndices.Count - 1;
                if (x >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить эти  элемент(ы)?", "Удаление", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
                        {
                            int idx = listBox1.SelectedIndices[x];
                            listBox1.Items.RemoveAt(idx);
                            textBox1.Focus();
                            i -= 1;
                            label4.Text = Convert.ToString(i);
                        }
                    }
                    else if (dialogResult == DialogResult.Yes)
                    {

                    }
                }
            }
        }

        // Edit item in list
        private void button3_Click(object sender, EventArgs e)
        {
            Width = 525;
            Height = 400;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы ничего не выбрали!");
            }
            else
            {
                    textBox1.Text = Convert.ToString(listBox1.SelectedItem.ToString());
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    textBox1.Focus();
                    i -= 1;
                    label4.Text = Convert.ToString(i);
            }
        }

        // Delete all list
        private void button5_Click(object sender, EventArgs e)
        {
            Width = 525;
            Height = 400;
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить все элементы?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                i = 0;
                label4.Text = Convert.ToString(i);
                textBox1.Focus();
            }
            else if (dialogResult == DialogResult.No)
            {
                textBox1.Focus();
            }
            
        }

        // Sorted list
        private void button6_Click(object sender, EventArgs e)
        {
            Width = 525;
            Height = 400;
            listBox1.Sorted = true;
            listBox1.Sorted = false;
            listBox2.Sorted = true;
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Create String Array
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            listBox2.Visible = true;

            Width = 880;
            Height = 400;

            string[] ar = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(ar, 0);
            for (int j = 0; j < ar.Length; j++)
            {
                listBox2.Items.Add(ar[j]);
            }
        }
    }
}
