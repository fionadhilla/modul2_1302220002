﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JURNAL03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        int b;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 1;
        }

       

        private void button10_Click(object sender, EventArgs e)
        {
            a = int.Parse(label1.Text);
            label1.Text = "  ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = int.Parse(label1.Text);
            int c = a + b;
            label1.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + 0;
        }
    }
}
