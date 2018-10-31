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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = double.Parse(textBox1.Text);
                double S = 0;
                double V = 0;

                if (R < 0)
                {
                    MessageBox.Show("Радиус не может быть отрицательными!");
                    textBox1.Focus();
                }

                else
                {
                    S = 4 * 3.14 * (R * R);
                    V = 4 * 3.14 * (R * R * R);
                    textBox2.Text = "" + S;
                    textBox3.Text = "" + V;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Необходимо ввести число!");
                textBox1.TabIndex = 0;
                return;
            }
        }
    }
}
