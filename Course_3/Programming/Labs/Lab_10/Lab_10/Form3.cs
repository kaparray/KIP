using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.Compare(textBox1.Text, textBox2.Text) == 0)
            {
                label6.Text = "Demo:    " + textBox1.Text + " and " + textBox2.Text + " are equal." + "    Compare in bool is " + String.Compare(textBox1.Text, textBox2.Text);
            }
            else
            {
                label6.Text = "Demo:    " + textBox2.Text + " and " + textBox2.Text + " are not equal." + "    Compare in bool is " + String.Compare(textBox1.Text, textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect
            f1.ShowDialog();
        }
    }
}
