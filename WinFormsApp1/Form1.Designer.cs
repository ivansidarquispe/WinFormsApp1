namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            bparalelogramo = new Button();
            brectangulo = new Button();
            btriangulo = new Button();
            pdatos = new Panel();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pcontenedor = new Panel();
            panel1.SuspendLayout();
            pdatos.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(bparalelogramo);
            panel1.Controls.Add(brectangulo);
            panel1.Controls.Add(btriangulo);
            panel1.Controls.Add(pdatos);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 506);
            panel1.TabIndex = 6;
            // 
            // bparalelogramo
            // 
            bparalelogramo.Dock = DockStyle.Top;
            bparalelogramo.Location = new Point(0, 387);
            bparalelogramo.Name = "bparalelogramo";
            bparalelogramo.Size = new Size(200, 55);
            bparalelogramo.TabIndex = 8;
            bparalelogramo.Text = "Paralelogramo";
            bparalelogramo.UseVisualStyleBackColor = true;
            bparalelogramo.Click += bparalelogramo_Click;
            // 
            // brectangulo
            // 
            brectangulo.Dock = DockStyle.Top;
            brectangulo.Location = new Point(0, 341);
            brectangulo.Name = "brectangulo";
            brectangulo.Size = new Size(200, 46);
            brectangulo.TabIndex = 0;
            brectangulo.Text = "Rectangulo";
            brectangulo.UseVisualStyleBackColor = true;
            brectangulo.Click += button1_Click;
            // 
            // btriangulo
            // 
            btriangulo.Dock = DockStyle.Top;
            btriangulo.Location = new Point(0, 286);
            btriangulo.Name = "btriangulo";
            btriangulo.Size = new Size(200, 55);
            btriangulo.TabIndex = 3;
            btriangulo.Text = "Triangulo";
            btriangulo.UseVisualStyleBackColor = true;
            btriangulo.Click += btriangulo_Click;
            // 
            // pdatos
            // 
            pdatos.Controls.Add(textBox3);
            pdatos.Controls.Add(textBox1);
            pdatos.Controls.Add(textBox2);
            pdatos.Dock = DockStyle.Top;
            pdatos.Location = new Point(0, 0);
            pdatos.Name = "pdatos";
            pdatos.Size = new Size(200, 286);
            pdatos.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 51);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 219);
            textBox3.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 23);
            textBox2.TabIndex = 8;
            // 
            // pcontenedor
            // 
            pcontenedor.Dock = DockStyle.Fill;
            pcontenedor.Location = new Point(200, 0);
            pcontenedor.Name = "pcontenedor";
            pcontenedor.Size = new Size(626, 506);
            pcontenedor.TabIndex = 7;
            pcontenedor.Paint += pcontenedor_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 506);
            Controls.Add(pcontenedor);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto win";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            pdatos.ResumeLayout(false);
            pdatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btriangulo;
        private Panel pcontenedor;
        private Panel pdatos;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button bparalelogramo;
        private Button brectangulo;
    }
}