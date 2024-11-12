namespace hitung_luas
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Bodoni MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 80);
            label1.Name = "label1";
            label1.Size = new Size(200, 24);
            label1.TabIndex = 0;
            label1.Text = "Luas Persegi Panjang";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 151);
            label2.Name = "label2";
            label2.Size = new Size(56, 24);
            label2.TabIndex = 1;
            label2.Text = "Panjang";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(324, 235);
            button1.Name = "button1";
            button1.Size = new Size(87, 32);
            button1.TabIndex = 3;
            button1.Text = "Hitung";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 309);
            label3.Name = "label3";
            label3.Size = new Size(200, 24);
            label3.TabIndex = 4;
            label3.Text = "Luas Persegi Panjang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(362, 354);
            label4.Name = "label4";
            label4.Size = new Size(25, 23);
            label4.TabIndex = 5;
            label4.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bodoni MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(224, 188);
            label5.Name = "label5";
            label5.Size = new Size(40, 22);
            label5.TabIndex = 6;
            label5.Text = "Lebar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form2";
            Text = "Hitung Luas Persegi Panjang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
    }
}