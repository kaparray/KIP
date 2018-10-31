using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double R = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);



                if ((R < 0) || (h < 0))
                {
                    if ((R < 0) && (h < 0))
                    {
                        MessageBox.Show("Значения радиуса(R) и высоты(k) не могут быть отрицательными!");
                        textBox1.Focus();
                    }
                    else if (h < 0)
                    {
                        MessageBox.Show("Значения высоты(h) не могут быть отрицательными!");
                        textBox2.Focus();
                    }
                    else if (R < 0)
                    {
                        MessageBox.Show("Значения радиуса(R) не могут быть отрицательными!");
                        textBox1.Focus();
                    }
                }
                else
                {
                    Конус kon = new Конус();
                    label6.Text = "" + string.Format("{0:f2}", kon.Sосн(R, h));
                    label7.Text = "" + string.Format("{0:f2}", kon.Sбок(R, h));
                    label8.Text = "" + string.Format("{0:f2}", kon.V(R, h));
                }

            }
            catch (FormatException)
            {
                if (textBox1.Text == "" && textBox2.Text == "") {
                    MessageBox.Show("Нужно ввести радиус(R) и высоту(h)");
                    textBox1.Focus();
                }
                else if (textBox1.Text == null || textBox1.Text == "")
                {
                    MessageBox.Show("Нужно ввести значения радиуса(R) ");
                    textBox1.Focus();
                }
                else if (textBox2.Text == null || textBox2.Text == "")
                {
                    MessageBox.Show("Нужно ввести значения высоты(h) ");
                    textBox2.Focus();
                }
            }
        }
    }
}
