namespace VAI_Project_Assignment.UserControls
{
    partial class ProductList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pdtTitle = new Label();
            onBtnViewInfo = new Button();
            checkBox1 = new CheckBox();
            sidePanel = new Panel();
            bottomPanel = new Panel();
            btnReview = new Button();
            SuspendLayout();
            // 
            // pdtTitle
            // 
            pdtTitle.AutoSize = true;
            pdtTitle.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            pdtTitle.Location = new Point(52, 32);
            pdtTitle.Name = "pdtTitle";
            pdtTitle.Size = new Size(272, 60);
            pdtTitle.TabIndex = 1;
            pdtTitle.Text = "Product Title";
            pdtTitle.Click += pdtTitle_Click;
            // 
            // onBtnViewInfo
            // 
            onBtnViewInfo.Location = new Point(378, 32);
            onBtnViewInfo.Name = "onBtnViewInfo";
            onBtnViewInfo.Size = new Size(198, 49);
            onBtnViewInfo.TabIndex = 2;
            onBtnViewInfo.Text = "View Information";
            onBtnViewInfo.UseVisualStyleBackColor = true;
            onBtnViewInfo.Click += btnViewInfo_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(593, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Like";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(255, 178, 102);
            sidePanel.Dock = DockStyle.Bottom;
            sidePanel.Location = new Point(46, 141);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(645, 10);
            sidePanel.TabIndex = 4;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.FromArgb(153, 204, 255);
            bottomPanel.Dock = DockStyle.Left;
            bottomPanel.Location = new Point(0, 0);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(46, 151);
            bottomPanel.TabIndex = 5;
            // 
            // btnReview
            // 
            btnReview.Location = new Point(378, 87);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(199, 35);
            btnReview.TabIndex = 6;
            btnReview.Text = "Review";
            btnReview.UseVisualStyleBackColor = true;
            // 
            // ProductList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReview);
            Controls.Add(checkBox1);
            Controls.Add(onBtnViewInfo);
            Controls.Add(pdtTitle);
            Controls.Add(sidePanel);
            Controls.Add(bottomPanel);
            Name = "ProductList";
            Size = new Size(691, 151);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label pdtTitle;
        private Button onBtnViewInfo;
        private CheckBox checkBox1;
        private Panel sidePanel;
        private Panel bottomPanel;
        private Button btnReview;
    }
}
