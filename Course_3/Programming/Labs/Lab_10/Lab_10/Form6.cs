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
    public partial class Form6 : Form
    {
        public Form6()
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
            String[] strings = { textBox1.Text, textBox2.Text };
            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(textBox3.Text);
                label6.Text = "Demo:   '" + value + "' ends in a period: " + endsInPeriod;
            }
        }
    }
}
