﻿namespace WinFormsApp1
{
    partial class Form4
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
            ppgraficar2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            bgparalelogramo = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 210);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 20;
            label2.Text = "Lado 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 160);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 19;
            label1.Text = "Lado 1";
            // 
            // ppgraficar2
            // 
            ppgraficar2.Dock = DockStyle.Right;
            ppgraficar2.Location = new Point(212, 0);
            ppgraficar2.Name = "ppgraficar2";
            ppgraficar2.Size = new Size(421, 465);
            ppgraficar2.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(89, 23);
            textBox1.TabIndex = 16;
            // 
            // bgparalelogramo
            // 
            bgparalelogramo.Location = new Point(45, 355);
            bgparalelogramo.Name = "bgparalelogramo";
            bgparalelogramo.Size = new Size(102, 23);
            bgparalelogramo.TabIndex = 0;
            bgparalelogramo.Text = "button1";
            bgparalelogramo.UseVisualStyleBackColor = true;
            bgparalelogramo.Click += bgparalelogramo_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 465);
            Controls.Add(bgparalelogramo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ppgraficar2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel ppgraficar2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button bgparalelogramo;
    }
}