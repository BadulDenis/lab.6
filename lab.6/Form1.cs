﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab._6
{
    public partial class Form1 : Form
    {
        public String s;
        public int n0, n1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            s = textBox1.Text;
            n0 = 0;
            n1 = 0;
            foreach (Char c in s)
            {
                if (c == 48)     // 48 - Код цифры 0
                    n0++;
                else if (c == 49)   // 49 - Код цифры 1
                    n1++;
            }
            label1.Text = "Количество нулей = " +
            n0.ToString();
            label2.Text = "Количество единиц = " +
           n1.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
