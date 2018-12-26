using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        string file;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            this.Text = "Кодировка unicode";
            file=@"D:\Text1.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                var Reader=new System.IO.StreamReader(file);
                textBox1.Text=Reader.ReadToEnd();
                var mass=System.IO.File.ReadAllLines(@"D:\Text1.txt");
            }
            catch(System.IO.FileNotFoundException sit)
            {
                MessageBox.Show(sit.Message + "\n No File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception sit)
            {
                MessageBox.Show(sit.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File save");
            try
            {
                var user=new System.IO.
                StreamWriter(file,false);
                user.Write(textBox1.Text);
                user.Close();
            }
            catch (Exception iskl)
            {
                MessageBox.Show(iskl.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            textBox1.Clear();
        }

    }
}
