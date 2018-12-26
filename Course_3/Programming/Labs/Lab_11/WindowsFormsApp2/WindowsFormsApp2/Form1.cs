using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;

            a = Convert.ToInt32(textBox1.Text);

            for (int x = -20; x <= 20; x++)
            {
                Класс exp = new Класс(x, a);
                if (double.IsNaN(exp.Y))
                    dataGridView1.Rows.Add(x, "Не считается");
                else if (double.IsNegativeInfinity(exp.Y))
                    dataGridView1.Rows.Add(x, "-Бесконечность");
                else
                    dataGridView1.Rows.Add(x, String.Format("{0:f3}", exp.Y));
            }
        }
    }
}
