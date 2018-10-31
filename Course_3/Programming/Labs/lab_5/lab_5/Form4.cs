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
                double R2 = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
                double L = double.Parse(textBox4.Text);

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

                    textBox7.Text = "" + S1;
                    textBox5.Text = "" + S2;
                    textBox6.Text = "" + S3;
                    textBox8.Text = "" + V;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Необходимо ввести число!");
                textBox1.Focus(); ;
                return;
            }
        }
    }
}
