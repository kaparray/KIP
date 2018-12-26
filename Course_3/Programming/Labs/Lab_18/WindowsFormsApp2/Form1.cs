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
        string file;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var kod = System.Text.Encoding.GetEncoding(1251);
                var reader = new System.IO.StreamReader(file, kod);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (System.IO.FileNotFoundException sit)
            {
                MessageBox.Show(sit.Message + "\n No File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception sit)
            {
                MessageBox.Show(sit.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File save");
            try
            {
                var kod = System.Text.Encoding.GetEncoding(1251);
                var reader = new System.IO.StreamWriter(file, false, kod);
                reader.Write(textBox1.Text);
                reader.Close();
            }
            catch (Exception isk)
            {
                MessageBox.Show(isk.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Windows 1251";
            file = @"D:\Text1.txt";
        }
    }
}