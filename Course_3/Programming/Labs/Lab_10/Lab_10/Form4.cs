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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int cmpVal = textBox1.Text.CompareTo(textBox2.Text);

            if (cmpVal == 0) // The strings are the same.
                label6.Text = "Demo:   The strings occur in the same position in the sort order." + "    Compare in bool is " + cmpVal;
            else if (cmpVal < 0)
                label6.Text = "Demo:  The first string precedes the second in the sort order." + "    Compare in bool is " + cmpVal;
            else
                label6.Text = "Demo:  The first string follows the second in the sort order." + "    Compare in bool is " + cmpVal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect
            f1.ShowDialog();
        }
    }
}
