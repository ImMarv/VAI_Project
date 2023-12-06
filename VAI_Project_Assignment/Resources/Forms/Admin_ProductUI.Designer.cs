namespace VAI_Project_Assignment
{
    partial class Admin_ProductUI
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
            lblProductHead = new Label();
            dgvProductInfo = new DataGridView();
            btnSearch = new Button();
            cmbSoftwareName = new ComboBox();
            txtSoftware = new Label();
            txtSoftwareType = new TextBox();
            lblClientType = new Label();
            lblModule = new Label();
            lblBusinessAreas = new Label();
            lblSoftwareType = new Label();
            txtAdditionalInfo = new TextBox();
            txtDescription = new TextBox();
            txtModule = new TextBox();
            txtBusinessAreas = new TextBox();
            txtClientType = new TextBox();
            lblAdditionalInfo = new Label();
            lblDescription = new Label();
            lblCloud = new Label();
            txtCloud = new TextBox();
            btnUpdate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductInfo).BeginInit();
            SuspendLayout();
            // 
            // lblProductHead
            // 
            lblProductHead.AutoSize = true;
            lblProductHead.BackColor = SystemColors.ButtonHighlight;
            lblProductHead.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblProductHead.Location = new Point(658, 26);
            lblProductHead.Name = "lblProductHead";
            lblProductHead.Size = new Size(169, 46);
            lblProductHead.TabIndex = 0;
            lblProductHead.Text = "Product";
            // 
            // dgvProductInfo
            // 
            dgvProductInfo.AllowUserToOrderColumns = true;
            dgvProductInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductInfo.Dock = DockStyle.Bottom;
            dgvProductInfo.Location = new Point(0, 342);
            dgvProductInfo.Name = "dgvProductInfo";
            dgvProductInfo.RowHeadersWidth = 62;
            dgvProductInfo.RowTemplate.Height = 33;
            dgvProductInfo.Size = new Size(1562, 225);
            dgvProductInfo.TabIndex = 1;
            dgvProductInfo.CellContentClick += dgvProductInfo_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(356, 102);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbSoftwareName
            // 
            cmbSoftwareName.FormattingEnabled = true;
            cmbSoftwareName.Location = new Point(168, 104);
            cmbSoftwareName.Name = "cmbSoftwareName";
            cmbSoftwareName.Size = new Size(182, 33);
            cmbSoftwareName.TabIndex = 3;
            // 
            // txtSoftware
            // 
            txtSoftware.AutoSize = true;
            txtSoftware.Location = new Point(30, 107);
            txtSoftware.Name = "txtSoftware";
            txtSoftware.Size = new Size(134, 25);
            txtSoftware.TabIndex = 4;
            txtSoftware.Text = "Software Name";
            // 
            // txtSoftwareType
            // 
            txtSoftwareType.Location = new Point(168, 164);
            txtSoftwareType.Name = "txtSoftwareType";
            txtSoftwareType.Size = new Size(182, 31);
            txtSoftwareType.TabIndex = 5;
            // 
            // lblClientType
            // 
            lblClientType.AutoSize = true;
            lblClientType.Location = new Point(414, 235);
            lblClientType.Name = "lblClientType";
            lblClientType.Size = new Size(98, 25);
            lblClientType.TabIndex = 6;
            lblClientType.Text = "Client Type";
            // 
            // lblModule
            // 
            lblModule.AutoSize = true;
            lblModule.Location = new Point(414, 167);
            lblModule.Name = "lblModule";
            lblModule.Size = new Size(73, 25);
            lblModule.TabIndex = 7;
            lblModule.Text = "Module";
            // 
            // lblBusinessAreas
            // 
            lblBusinessAreas.AutoSize = true;
            lblBusinessAreas.Location = new Point(30, 226);
            lblBusinessAreas.Name = "lblBusinessAreas";
            lblBusinessAreas.Size = new Size(128, 25);
            lblBusinessAreas.TabIndex = 8;
            lblBusinessAreas.Text = "Business Areas";
            // 
            // lblSoftwareType
            // 
            lblSoftwareType.AutoSize = true;
            lblSoftwareType.Location = new Point(30, 164);
            lblSoftwareType.Name = "lblSoftwareType";
            lblSoftwareType.Size = new Size(124, 25);
            lblSoftwareType.TabIndex = 9;
            lblSoftwareType.Text = "Software Type";
            // 
            // txtAdditionalInfo
            // 
            txtAdditionalInfo.Location = new Point(168, 290);
            txtAdditionalInfo.Name = "txtAdditionalInfo";
            txtAdditionalInfo.Size = new Size(982, 31);
            txtAdditionalInfo.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(894, 229);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(377, 31);
            txtDescription.TabIndex = 12;
            // 
            // txtModule
            // 
            txtModule.Location = new Point(536, 164);
            txtModule.Name = "txtModule";
            txtModule.Size = new Size(182, 31);
            txtModule.TabIndex = 13;
            // 
            // txtBusinessAreas
            // 
            txtBusinessAreas.Location = new Point(168, 226);
            txtBusinessAreas.Name = "txtBusinessAreas";
            txtBusinessAreas.Size = new Size(182, 31);
            txtBusinessAreas.TabIndex = 14;
            // 
            // txtClientType
            // 
            txtClientType.Location = new Point(536, 235);
            txtClientType.Name = "txtClientType";
            txtClientType.Size = new Size(182, 31);
            txtClientType.TabIndex = 11;
            // 
            // lblAdditionalInfo
            // 
            lblAdditionalInfo.AutoSize = true;
            lblAdditionalInfo.Location = new Point(30, 290);
            lblAdditionalInfo.Name = "lblAdditionalInfo";
            lblAdditionalInfo.Size = new Size(131, 25);
            lblAdditionalInfo.TabIndex = 15;
            lblAdditionalInfo.Text = "Additional Info";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(786, 235);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 16;
            lblDescription.Text = "Description";
            // 
            // lblCloud
            // 
            lblCloud.AutoSize = true;
            lblCloud.Location = new Point(786, 167);
            lblCloud.Name = "lblCloud";
            lblCloud.Size = new Size(59, 25);
            lblCloud.TabIndex = 17;
            lblCloud.Text = "Cloud";
            // 
            // txtCloud
            // 
            txtCloud.Location = new Point(890, 164);
            txtCloud.Name = "txtCloud";
            txtCloud.Size = new Size(182, 31);
            txtCloud.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1212, 155);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1369, 167);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1369, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1212, 288);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Admin_ProductUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1562, 567);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(txtCloud);
            Controls.Add(lblCloud);
            Controls.Add(lblDescription);
            Controls.Add(lblAdditionalInfo);
            Controls.Add(txtBusinessAreas);
            Controls.Add(txtModule);
            Controls.Add(txtDescription);
            Controls.Add(txtClientType);
            Controls.Add(txtAdditionalInfo);
            Controls.Add(lblSoftwareType);
            Controls.Add(lblBusinessAreas);
            Controls.Add(lblModule);
            Controls.Add(lblClientType);
            Controls.Add(txtSoftwareType);
            Controls.Add(txtSoftware);
            Controls.Add(cmbSoftwareName);
            Controls.Add(btnSearch);
            Controls.Add(dgvProductInfo);
            Controls.Add(lblProductHead);
            Name = "Admin_ProductUI";
            Text = "Admin_ProductUI";
            Load += Admin_ProductUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductHead;
        private DataGridView dgvProductInfo;
        private Button btnSearch;
        private ComboBox cmbSearch;
        private TextBox txtSoftwareType;
        private Label lblClientType;
        private Label lblModule;
        private Label lblBusinessAreas;
        private Label lblSoftwareType;
        private TextBox txtAdditionalInfo;
        private TextBox txtDescription;
        private TextBox txtModule;
        private TextBox txtBusinessAreas;
        private TextBox txtClientType;
        private Label lblAdditionalInfo;
        private Label lblDescription;
        private Label lblCloud;
        private TextBox txtCloud;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnDelete;
        private Button btnCancel;
        private Label txtSoftware;
        private ComboBox cmbSoftwareName;
    }
}