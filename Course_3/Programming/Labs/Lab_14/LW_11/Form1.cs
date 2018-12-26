using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate double Operation(double a);
        Operation _delegate;
        double а;
        private void button1_Click(object sender, EventArgs e)
        {
            _delegate = null;
            listBox1.Items.Clear();
            textBox2.Text = "_delegate = null;" + Environment.NewLine;
        }

        string NL { get { return Environment.NewLine; } }

        private void button2_Click(object sender, EventArgs e)
        {
            _delegate += Minus_5;
            listBox1.Items.Add("Minus_5()" + NL);
            textBox2.AppendText("_delegate += Minus_5;" + NL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _delegate += Plus_5;
            listBox1.Items.Add("Plus_5()" + NL);
            textBox2.AppendText("_delegate += Plus_5;" + NL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _delegate += Multiply_2;
            listBox1.Items.Add("Multiply_2" + NL);
            textBox2.AppendText("_delegate += Multiply_2;" + NL);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _delegate += Devision_2;
            listBox1.Items.Add("Devision_2" + NL);
            textBox2.AppendText("_delegate += Devision_2;" + NL);
        }

        private double Minus_5(double a)
        {
            textBox1.AppendText("Отнимаем от " + а + " число 5" + NL);
            а = а - 5;
            return а;
        }

        private double Plus_5(double a)
        {
            textBox1.AppendText("Прибавляем к " + а + " число 5" + NL);
            а = а + 5;
            return а;
        }

        private double Multiply_2(double a)
        {
            textBox1.AppendText("Умножаем " + а + " на 2" + NL);
            а = а * 2;
            return а;
        }

        private double Devision_2(double a)
        {
            textBox1.AppendText("Делим " + а + " на 2" + NL);
            а = а / 2;
            return а;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (_delegate == null) return;
            double a = (double)numericUpDown2.Value;                                                                                                                            а = a;
            double res = _delegate.Invoke(a);
            textBox2.AppendText("double res = _delegate.Invoke(a);\n");
            textBox1.AppendText("Результат: " + res);
        }

    }
}
