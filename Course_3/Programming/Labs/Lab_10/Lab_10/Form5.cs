﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "Demo:   " + string.Concat(textBox1.Text, textBox2.Text);
        }
    }
}
