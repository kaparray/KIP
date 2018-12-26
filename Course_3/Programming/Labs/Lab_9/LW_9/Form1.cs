using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Client a1, a2, a3;

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a1 = new Client();
            a1.name = "Джафаров Ренад Рамин оглы";
            a1.number = 17;
            a1.balance = 8;
            textBox1.Text = "Создан объект a1" + Environment.NewLine + Environment.NewLine + a1;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a2 = a1;
            a2.name = "Джафаров Давид Раминович";
            a2.number = 23;
            a2.balance = 5;
            textBox2.Text = "Инициализирован объект a2 объектом a1" + Environment.NewLine + Environment.NewLine + a2;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            a3 = a1;
            textBox3.Text = "Инициализирован объект a3 объектом a1" + Environment.NewLine + Environment.NewLine + a3;
        }

    }

    class Client
    {
        public string name;
        public int number;
        public int balance;
        public Client() { }
        public Client(int k)
        {
           
        }

        public override string ToString()
        {
            return string.Format("Имя: {0}\r\nНомер: {1}\r\nСчёт: {2}", name, number, balance);
        }

    }
}
