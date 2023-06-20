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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Pen pincel = new Pen(Color.Red, 5);
        //  private void bgtriangulo_Click(object sender, EventArgs e)
        // {
        //    {


        //      }
        //  }

        private void bgparalelogramo_Click(object sender, EventArgs e, Graphics paralelogramo)
        {
            




        }

        private void bgparalelogramo_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = a / 2 + 1;
            int c = 10;//contador de lineas
            int i = 0; //cantidad de espacios

            

          
            Graphics plelogramo;
           
           for (int j = 0; j < b; j++) {
                plelogramo = ppgraficar2.CreateGraphics();
                plelogramo.DrawLine(pincel, 40+j, 200-c, 300+j, 200-c);
                c--;

            }
        }
    }
}
