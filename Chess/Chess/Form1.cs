﻿using System;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double tal = 1;
        int räknare = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            while (räknare < 64)
            {
                textBox1.AppendText(tal + " \r\n");
                tal = tal * 2;
                räknare++;
            }
        }
    }
}
