namespace WinFormsApp1
{
    partial class Form2
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
            bgtriangulo = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ptgraficar = new Panel();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // bgtriangulo
            // 
            bgtriangulo.Location = new Point(0, 390);
            bgtriangulo.Name = "bgtriangulo";
            bgtriangulo.Size = new Size(101, 52);
            bgtriangulo.TabIndex = 0;
            bgtriangulo.Text = "Graficar";
            bgtriangulo.UseVisualStyleBackColor = true;
            bgtriangulo.Click += bgtriangulo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // ptgraficar
            // 
            ptgraficar.Dock = DockStyle.Right;
            ptgraficar.Location = new Point(120, 0);
            ptgraficar.Name = "ptgraficar";
            ptgraficar.Size = new Size(421, 454);
            ptgraficar.TabIndex = 3;
            ptgraficar.Paint += ptgraficar_Paint;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 279);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Lado 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 210);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Lado 2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Lado 3";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 454);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(ptgraficar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(bgtriangulo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bgtriangulo;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel ptgraficar;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}