using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(textBox1.Text.ToString());

            label7.Text = "Длина строки: " +  sb.Length +  Environment.NewLine + "Емкость строки: " + sb.Capacity +
                 Environment.NewLine + "Cтрока: " + sb + Environment.NewLine + "Максимальная емкость строки: " + sb.MaxCapacity;
          
        }

   
    }
}
