namespace VAI_Project_Assignment
{
    partial class ProductInfoForm
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
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 32);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 11;
            label5.Text = "Vendor Product ";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(484, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 268);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 107);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 13;
            label1.Text = "Company Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 332);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 14;
            label2.Text = "Type of Software";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 254);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 15;
            label3.Text = "Software Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 178);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 16;
            label4.Text = "Company Website";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 413);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 17;
            label6.Text = "Description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 413);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(611, 31);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 31);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 31);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(197, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(219, 31);
            textBox4.TabIndex = 21;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(197, 178);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 31);
            textBox5.TabIndex = 22;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Name = "ProductForm";
            Text = "ProductInfoForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        internal Label label5;
    }
}