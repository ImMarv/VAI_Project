namespace VAI_Project_Assignment
{
    partial class Product
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblTime = new Label();
            panel2 = new Panel();
            cmbSearchItems = new ComboBox();
            panel3 = new Panel();
            txtProductHeading = new Label();
            recommendationPanel = new Panel();
            recommendationViewPanel = new Panel();
            txtRecommendation = new Label();
            loadProductPanel = new FlowLayoutPanel();
            timeCounter = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            recommendationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(lblTime);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 554);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 57);
            panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lblTime.Location = new Point(824, 8);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(97, 40);
            lblTime.TabIndex = 0;
            lblTime.Text = "Time";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(cmbSearchItems);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 134);
            panel2.TabIndex = 1;
            // 
            // cmbSearchItems
            // 
            cmbSearchItems.FormattingEnabled = true;
            cmbSearchItems.Location = new Point(12, 95);
            cmbSearchItems.Name = "cmbSearchItems";
            cmbSearchItems.Size = new Size(307, 33);
            cmbSearchItems.TabIndex = 4;
            cmbSearchItems.SelectedIndexChanged += cmbSearchItems_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(102, 178, 255);
            panel3.Controls.Add(txtProductHeading);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1038, 76);
            panel3.TabIndex = 3;
            // 
            // txtProductHeading
            // 
            txtProductHeading.AutoSize = true;
            txtProductHeading.BackColor = Color.WhiteSmoke;
            txtProductHeading.Font = new Font("Arial Narrow", 22F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductHeading.Location = new Point(444, 9);
            txtProductHeading.Name = "txtProductHeading";
            txtProductHeading.Size = new Size(158, 52);
            txtProductHeading.TabIndex = 0;
            txtProductHeading.Text = "Product";
            // 
            // recommendationPanel
            // 
            recommendationPanel.BackColor = SystemColors.AppWorkspace;
            recommendationPanel.Controls.Add(recommendationViewPanel);
            recommendationPanel.Controls.Add(txtRecommendation);
            recommendationPanel.Dock = DockStyle.Right;
            recommendationPanel.Location = new Point(738, 134);
            recommendationPanel.Name = "recommendationPanel";
            recommendationPanel.Size = new Size(300, 420);
            recommendationPanel.TabIndex = 2;
            // 
            // recommendationViewPanel
            // 
            recommendationViewPanel.Location = new Point(17, 81);
            recommendationViewPanel.Name = "recommendationViewPanel";
            recommendationViewPanel.Size = new Size(271, 333);
            recommendationViewPanel.TabIndex = 1;
            // 
            // txtRecommendation
            // 
            txtRecommendation.AutoSize = true;
            txtRecommendation.BackColor = Color.White;
            txtRecommendation.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecommendation.Location = new Point(17, 16);
            txtRecommendation.Name = "txtRecommendation";
            txtRecommendation.Size = new Size(271, 45);
            txtRecommendation.TabIndex = 0;
            txtRecommendation.Text = "Recommendation";
            // 
            // loadProductPanel
            // 
            loadProductPanel.AutoScroll = true;
            loadProductPanel.Dock = DockStyle.Fill;
            loadProductPanel.Location = new Point(0, 134);
            loadProductPanel.Name = "loadProductPanel";
            loadProductPanel.Size = new Size(738, 420);
            loadProductPanel.TabIndex = 3;
            // 
            // timeCounter
            // 
            timeCounter.Enabled = true;
            timeCounter.Tick += timeCounter_Tick;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 611);
            Controls.Add(loadProductPanel);
            Controls.Add(recommendationPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            recommendationPanel.ResumeLayout(false);
            recommendationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label txtProductHeading;
        private Panel recommendationPanel;
        private Label txtRecommendation;
        private Panel recommendationViewPanel;
        private Panel panel3;
        private ComboBox cmbSearchItems;
        private FlowLayoutPanel loadProductPanel;
        private Label lblTime;
        private System.Windows.Forms.Timer timeCounter;
    }
}