﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Pen pincel = new Pen(Color.Red, 5);
        private void bgtriangulo_Click(object sender, EventArgs e)
        {
            Graphics rectangulo;
            rectangulo = ptgraficar.CreateGraphics();
            rectangulo.DrawRectangle(pincel, 20, 20, 200, 200);
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ptgraficar_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
