//usign namespace std; 
//#include "form2.cs"


using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Frm = new Form3();
            Frm.TopLevel = false;
            pcontenedor.Controls.Add(Frm);
            Frm.Dock = DockStyle.Fill;
            Frm.Show();

        }
        private void abrirformhija(object formhija)
        {
            //  if (this.pcontenedor.controls.count˃0 )
            //      this.pcontenedor.Controls.RemoveAt(0);
            //  Form fh= formhija as Form;
            // fh.TopLevel = false;
            //  fh.Dock = DockStyle.Fill;
            //   this.pcontenedor.Tag = fh;


        }

        private void pcontenedor_Paint(object sender, PaintEventArgs e)
        {
            //template ˂class t˃
            //   void abrirpanel(t formhijo)
            //  { 
            //         if (this-˃pcontenedor-˃controls-˃count˃0 )
            //              this.pcontenedor.Controls.RemoveAt(0);
            //       formhijo.toplevel=false;
            //      formhijo.dock = DockStyle::fill;
            //      this.pcontenedor.Controls.Add(formhijo);
            //      this.pcontenedor.Tag = formhijo;
            //   formhijo.show();



            // }
        }

        private void btriangulo_Click(object sender, EventArgs e)
        {

            //abrirformhija(new.form2[]);
            // Form formulariot = new Form2();
            //formulariot.Dock = DockStyle.Fill;

            Form2 Frm = new Form2();
            Frm.TopLevel = false;
            pcontenedor.Controls.Add(Frm);
            Frm.Dock = DockStyle.Fill;
            Frm.Show();


            // formulariot.ShowDialog();
        }

        private void bparalelogramo_Click(object sender, EventArgs e)
        {

            Form4 Frm = new Form4();
            Frm.TopLevel = false;
            pcontenedor.Controls.Add(Frm);
            Frm.Dock = DockStyle.Fill;
            Frm.Show();

        }
    }
}