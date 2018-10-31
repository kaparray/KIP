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
            double S1 = 0;
            double S2 = 0;
            double V = 0;

            try
            {
                double R = double.Parse(textBox1.Text);
                double h = double.Parse(textBox2.Text);
                double L = double.Parse(textBox6.Text);

                if ((R < 0) || (h < 0) || (L < 0))
                {
                    MessageBox.Show("Значения не могут быть отрицательными!");
                    textBox1.Focus();
                }
                else
                {
                    S1 = 3.14 * (R * R);
                    S2 = 3.14 * R * L;
                    V = (3.14 * (R * R) * h) / 3;
                    textBox3.Text = "" + S1;
                    textBox4.Text = "" + S2;
                    textBox5.Text = "" + V;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Необходимо ввести число!");
                textBox1.Focus();
                return;
            }
        }
    }
}
