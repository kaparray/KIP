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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(textBox2.Text))
               label6.Text = "Demo:    " + textBox1.Text +  " = " + textBox2.Text + "Eqals result is " + textBox1.Text.Equals(textBox2.Text);
            else
                label6.Text = "Demo:    " + textBox1.Text + " not = " + textBox2.Text + "Eqals result is " + textBox1.Text.Equals(textBox2.Text);
        }
    }
}
