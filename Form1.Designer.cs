namespace hitung_luas
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(253, 174);
            button1.Name = "button1";
            button1.Size = new Size(266, 57);
            button1.TabIndex = 0;
            button1.Text = "Hitung Luas Persegi Panjang";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Bodoni MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(268, 94);
            label1.Name = "label1";
            label1.Size = new Size(228, 24);
            label1.TabIndex = 1;
            label1.Text = "Pilih Menu Perhitungan ";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(253, 263);
            button2.Name = "button2";
            button2.Size = new Size(266, 54);
            button2.TabIndex = 2;
            button2.Text = "Hitung Luas Persegi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Font = new Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(345, 379);
            button3.Name = "button3";
            button3.Size = new Size(84, 32);
            button3.TabIndex = 3;
            button3.Text = "Keluar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}
