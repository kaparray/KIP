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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "Demo:  your string = " + textBox1.Text + "  After remove: " + textBox1.Text.Remove(Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect
            f1.ShowDialog();
        }
    }
}
