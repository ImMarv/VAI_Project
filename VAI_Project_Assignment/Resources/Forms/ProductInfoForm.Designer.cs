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
            lblSoftware = new Label();
            lblBusiness = new Label();
            lblModules = new Label();
            lblClientTypes = new Label();
            lblClouds = new Label();
            lblDescriptions = new Label();
            lblProductInfo = new Label();
            lblAdditionalInfos = new Label();
            txtAdditionalInfo = new TextBox();
            txtDescription = new TextBox();
            txtCloud = new TextBox();
            txtClientType = new TextBox();
            txtModule = new TextBox();
            txtBusinessArea = new TextBox();
            txtSoftwareType = new TextBox();
            SuspendLayout();
            // 
            // lblSoftware
            // 
            lblSoftware.AutoSize = true;
            lblSoftware.Location = new Point(62, 99);
            lblSoftware.Name = "lblSoftware";
            lblSoftware.Size = new Size(124, 25);
            lblSoftware.TabIndex = 0;
            lblSoftware.Text = "Software Type";
            // 
            // lblBusiness
            // 
            lblBusiness.AutoSize = true;
            lblBusiness.Location = new Point(62, 176);
            lblBusiness.Name = "lblBusiness";
            lblBusiness.Size = new Size(120, 25);
            lblBusiness.TabIndex = 1;
            lblBusiness.Text = "Business Area";
            // 
            // lblModules
            // 
            lblModules.AutoSize = true;
            lblModules.Location = new Point(62, 258);
            lblModules.Name = "lblModules";
            lblModules.Size = new Size(73, 25);
            lblModules.TabIndex = 2;
            lblModules.Text = "Module";
            // 
            // lblClientTypes
            // 
            lblClientTypes.AutoSize = true;
            lblClientTypes.Location = new Point(62, 327);
            lblClientTypes.Name = "lblClientTypes";
            lblClientTypes.Size = new Size(98, 25);
            lblClientTypes.TabIndex = 3;
            lblClientTypes.Text = "Client Type";
            // 
            // lblClouds
            // 
            lblClouds.AutoSize = true;
            lblClouds.Location = new Point(62, 408);
            lblClouds.Name = "lblClouds";
            lblClouds.Size = new Size(59, 25);
            lblClouds.TabIndex = 4;
            lblClouds.Text = "Cloud";
            // 
            // lblDescriptions
            // 
            lblDescriptions.AutoSize = true;
            lblDescriptions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescriptions.Location = new Point(562, 99);
            lblDescriptions.Name = "lblDescriptions";
            lblDescriptions.Size = new Size(135, 32);
            lblDescriptions.TabIndex = 5;
            lblDescriptions.Text = "Description";
            // 
            // lblProductInfo
            // 
            lblProductInfo.AutoSize = true;
            lblProductInfo.BackColor = SystemColors.ButtonHighlight;
            lblProductInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductInfo.ForeColor = SystemColors.ControlText;
            lblProductInfo.Location = new Point(438, 19);
            lblProductInfo.Name = "lblProductInfo";
            lblProductInfo.Size = new Size(340, 48);
            lblProductInfo.TabIndex = 7;
            lblProductInfo.Text = "Product Information";
            // 
            // lblAdditionalInfos
            // 
            lblAdditionalInfos.AutoSize = true;
            lblAdditionalInfos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdditionalInfos.Location = new Point(876, 99);
            lblAdditionalInfos.Name = "lblAdditionalInfos";
            lblAdditionalInfos.Size = new Size(247, 32);
            lblAdditionalInfos.TabIndex = 8;
            lblAdditionalInfos.Text = "Additional Infomation";
            // 
            // txtAdditionalInfo
            // 
            txtAdditionalInfo.Location = new Point(876, 138);
            txtAdditionalInfo.Multiline = true;
            txtAdditionalInfo.Name = "txtAdditionalInfo";
            txtAdditionalInfo.Size = new Size(281, 315);
            txtAdditionalInfo.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(562, 138);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(191, 315);
            txtDescription.TabIndex = 10;
            // 
            // txtCloud
            // 
            txtCloud.Location = new Point(215, 402);
            txtCloud.Name = "txtCloud";
            txtCloud.Size = new Size(213, 31);
            txtCloud.TabIndex = 11;
            // 
            // txtClientType
            // 
            txtClientType.Location = new Point(215, 321);
            txtClientType.Name = "txtClientType";
            txtClientType.Size = new Size(213, 31);
            txtClientType.TabIndex = 12;
            // 
            // txtModule
            // 
            txtModule.Location = new Point(215, 252);
            txtModule.Name = "txtModule";
            txtModule.Size = new Size(213, 31);
            txtModule.TabIndex = 13;
            // 
            // txtBusinessArea
            // 
            txtBusinessArea.Location = new Point(215, 170);
            txtBusinessArea.Name = "txtBusinessArea";
            txtBusinessArea.Size = new Size(213, 31);
            txtBusinessArea.TabIndex = 14;
            // 
            // txtSoftwareType
            // 
            txtSoftwareType.Location = new Point(215, 99);
            txtSoftwareType.Name = "txtSoftwareType";
            txtSoftwareType.Size = new Size(213, 31);
            txtSoftwareType.TabIndex = 15;
            // 
            // ProductInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1212, 488);
            Controls.Add(txtSoftwareType);
            Controls.Add(txtBusinessArea);
            Controls.Add(txtModule);
            Controls.Add(txtClientType);
            Controls.Add(txtCloud);
            Controls.Add(txtDescription);
            Controls.Add(txtAdditionalInfo);
            Controls.Add(lblAdditionalInfos);
            Controls.Add(lblProductInfo);
            Controls.Add(lblDescriptions);
            Controls.Add(lblClouds);
            Controls.Add(lblClientTypes);
            Controls.Add(lblModules);
            Controls.Add(lblBusiness);
            Controls.Add(lblSoftware);
            Name = "ProductInfoForm";
            Text = "ProductInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoftware;
        private Label lblBusiness;
        private Label lblModules;
        private Label lblClientTypes;
        private Label lblClouds;
        private Label lblDescriptions;
        private Label lblProductInfo;
        private Label lblAdditionalInfos;
        private TextBox txtAdditionalInfo;
        private TextBox txtDescription;
        private TextBox txtCloud;
        private TextBox txtClientType;
        private TextBox txtModule;
        private TextBox txtBusinessArea;
        private TextBox txtSoftwareType;
    }
}