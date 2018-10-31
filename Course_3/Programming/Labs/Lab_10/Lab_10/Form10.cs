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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "Demo: " + '\n' + "   Result is:\n";
            string msg = textBox1.Text;
            string[] strarr = msg.Split(textBox2.Text[0]);
            for (int i = 0; i < strarr.Length; i++)
            {
                label6.Text += strarr[i] + '\n';
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
