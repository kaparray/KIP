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


                if (R < 0)
                {
                    MessageBox.Show("Радиус не может быть отрицательными!");
                    textBox1.Focus();
                }

                else
                {
                    Сфера sph = new Сфера();

                    label4.Text = "" + string.Format("{0:f2}", sph.S(R));
                    label5.Text = "" + string.Format("{0:f2}", sph.V(R));

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Необходимо радиус в виде числовом виде!");
                textBox1.TabIndex = 0;
                return;
            }
        }
    }
}
