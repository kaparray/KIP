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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            double S1 = 0;
            double S2 = 0;
            double S3 = 0;
            double V = 0;

            try
            {

                double R1 = double.Parse(textBox1.Text);
                double R2 = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);
                double L = double.Parse(textBox3.Text);

                if ((R1 < 1) || (R2 < 1) || (h < 1) || (L < 1))
                {
                    MessageBox.Show("Значения не могут быть отрицательными!");
                    textBox1.Focus();
                }
                else
                {

                    S1 = 3.14 * (R1 * R1);
                    S2 = 3.14 * (R2 * R2);
                    S3 = 3.14 * L * (R1 + R2);
                    V = (h * ((R2 * R2) + R2 * R1 + (R1 * R1))) / 3;

                    label1.Text = "" + string.Format("{0:f2}", S1);
                    label9.Text = "" + string.Format("{0:f2}", S2);
                    label10.Text = "" + string.Format("{0:f2}", S3);
                    label11.Text = "" + string.Format("{0:f2}", V);
                }

            }
            catch (FormatException)
            {
               if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
               {
                    MessageBox.Show("Нужно ввести радиус1(R1), радиус2(R2) и высоту(h)");
                    textBox1.Focus();
                } else if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Нужно ввести радиус1(R1), радиус2(R2)");
                    textBox1.Focus();
                } else if (textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Нужно ввести радиус2(R2), высоту(h)");
                    textBox2.Focus();
                }
                else if (textBox1.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Нужно ввести радиус1(R1), высоту(h)");
                    textBox1.Focus();
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Нужно ввести радиус1(R1)");
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Нужно ввести радиус2(R2)");
                    textBox1.Focus();
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Нужно ввести высоту(h)");
                    textBox1.Focus();
                }
               else if (!textBox1.Text[0].Equals('0')  && !textBox1.Text[0].Equals('1') && !textBox1.Text[0].Equals('2') && !textBox1.Text[0].Equals('3') && !textBox1.Text[0].Equals('4') && !textBox1.Text[0].Equals('5') && !textBox1.Text[0].Equals('6') && !textBox1.Text[0].Equals('7') && !textBox1.Text[0].Equals('8') && !textBox1.Text[0].Equals('9'))
                {
                    MessageBox.Show("Некоректное значение в радиус1(R1) " + !textBox1.Text[0].Equals('0'));
                    textBox1.Focus();
                }
                else if (!textBox2.Text[0].Equals('0') && !textBox2.Text[0].Equals('1') && !textBox2.Text[0].Equals('2') && !textBox2.Text[0].Equals('3') && !textBox2.Text[0].Equals('4') && !textBox2.Text[0].Equals('5') && !textBox2.Text[0].Equals('6') && !textBox2.Text[0].Equals('7') && !textBox2.Text[0].Equals('8') && !textBox2.Text[0].Equals('9'))
                {
                    MessageBox.Show("Некоректное значение в радиус2(R2)");
                    textBox2.Focus();
                }
                else if (!textBox3.Text[0].ToString().Equals('0') && !textBox3.Text[0].ToString().Equals('1') && !textBox3.Text[0].ToString().Equals('2') && !textBox3.Text[0].ToString().Equals('3') && !textBox3.Text[0].ToString().Equals('4') && !textBox3.Text[0].ToString().Equals('5') && !textBox3.Text[0].ToString().Equals('6') && !textBox3.Text[0].ToString().Equals('7') && !textBox3.Text[0].ToString().Equals('8') && !textBox3.Text[0].ToString().Equals('9'))
                {
                    MessageBox.Show("Некоректное значение в высота(h)");
                    textBox3.Focus();
                }
                return;
            }
        }
    }
}
