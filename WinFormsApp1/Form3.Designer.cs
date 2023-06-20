namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            ptgraficar = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            bgtriangulo = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 210);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 14;
            label2.Text = "Lado 2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Lado 1";
            label1.Click += label1_Click;
            // 
            // ptgraficar
            // 
            ptgraficar.Dock = DockStyle.Right;
            ptgraficar.Location = new Point(198, 0);
            ptgraficar.Name = "ptgraficar";
            ptgraficar.Size = new Size(421, 458);
            ptgraficar.TabIndex = 11;
            ptgraficar.Paint += ptgraficar_Paint;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // bgtriangulo
            // 
            bgtriangulo.Location = new Point(0, 390);
            bgtriangulo.Name = "bgtriangulo";
            bgtriangulo.Size = new Size(101, 52);
            bgtriangulo.TabIndex = 8;
            bgtriangulo.Text = "Graficar";
            bgtriangulo.UseVisualStyleBackColor = true;
            bgtriangulo.Click += bgtriangulo_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 458);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ptgraficar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(bgtriangulo);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Panel ptgraficar;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button bgtriangulo;
    }
}