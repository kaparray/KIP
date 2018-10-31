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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if (textBox1.Text.IndexOf(textBox2.Text) != -1)
            {
                label6.Text = "Demo: in " + textBox1.Text + " found " + textBox2.Text + "."  + "    Result: index = " + textBox1.Text.IndexOf(textBox2.Text);
            }
            else
            {
                label6.Text = "Demo: in " + textBox1.Text + " not found " + textBox2.Text + "." + "    Result index = " + textBox1.Text.IndexOf(textBox2.Text);

            }
        }
    }
}
