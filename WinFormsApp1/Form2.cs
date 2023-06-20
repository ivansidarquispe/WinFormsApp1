using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Pen pincel = new Pen(Color.Red, 5);
        private void bgtriangulo_Click(object sender, EventArgs e)
        {
            /* double l1, l2, l3;
             int a, b, c;
             l1 = double.Parse(textBox1.Text);
             l1 = double.Parse(textBox2.Text);
             l1 = double.Parse(textBox3.Text);

             a = Convert.ToInt32(l1);
             b = Convert.ToInt32(l1);
             c = Convert.ToInt32(l1);*/

            Graphics triangulo;
            triangulo = ptgraficar.CreateGraphics();
            triangulo.DrawLine(pincel, 40, 200, 400, 200);
            triangulo.DrawLine(pincel, 40, 200, 200, 40);
            triangulo.DrawLine(pincel, 200, 40, 400, 200);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void ptgraficar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
