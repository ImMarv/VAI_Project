namespace VAI_Project_Assignment.UserControls
{
    partial class EntryAdd
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
            companyNameText = new TextBox();
            companyWebsiteText = new TextBox();
            companyEstablishedDate = new DateTimePicker();
            companyNumOfEmployeesText = new TextBox();
            isProfessionalServices = new CheckBox();
            companyLastDemoDate = new DateTimePicker();
            lastReviewDate = new DateTimePicker();
            sendNewEntryButton = new Button();
            companyNameLabel = new Label();
            companyWebsiteLabel = new Label();
            companyEstablishedLabel = new Label();
            numOfEmployeesLabel = new Label();
            companyServicesLabel = new Label();
            companyDemoLabel = new Label();
            companyReviewLabel = new Label();
            SuspendLayout();
            // 
            // companyNameText
            // 
            companyNameText.Location = new Point(162, 23);
            companyNameText.Name = "companyNameText";
            companyNameText.Size = new Size(210, 23);
            companyNameText.TabIndex = 0;
            // 
            // companyWebsiteText
            // 
            companyWebsiteText.Location = new Point(162, 52);
            companyWebsiteText.Name = "companyWebsiteText";
            companyWebsiteText.Size = new Size(210, 23);
            companyWebsiteText.TabIndex = 1;
            // 
            // companyEstablishedDate
            // 
            companyEstablishedDate.Format = DateTimePickerFormat.Short;
            companyEstablishedDate.Location = new Point(162, 81);
            companyEstablishedDate.Name = "companyEstablishedDate";
            companyEstablishedDate.Size = new Size(210, 23);
            companyEstablishedDate.TabIndex = 2;
            // 
            // companyNumOfEmployeesText
            // 
            companyNumOfEmployeesText.Location = new Point(162, 110);
            companyNumOfEmployeesText.Name = "companyNumOfEmployeesText";
            companyNumOfEmployeesText.Size = new Size(210, 23);
            companyNumOfEmployeesText.TabIndex = 3;
            // 
            // isProfessionalServices
            // 
            isProfessionalServices.AutoSize = true;
            isProfessionalServices.Location = new Point(162, 139);
            isProfessionalServices.Name = "isProfessionalServices";
            isProfessionalServices.Size = new Size(140, 19);
            isProfessionalServices.TabIndex = 4;
            isProfessionalServices.Text = "isProfessionalServices";
            isProfessionalServices.UseVisualStyleBackColor = true;
            // 
            // companyLastDemoDate
            // 
            companyLastDemoDate.Format = DateTimePickerFormat.Short;
            companyLastDemoDate.Location = new Point(162, 164);
            companyLastDemoDate.Name = "companyLastDemoDate";
            companyLastDemoDate.Size = new Size(210, 23);
            companyLastDemoDate.TabIndex = 5;
            // 
            // lastReviewDate
            // 
            lastReviewDate.Format = DateTimePickerFormat.Short;
            lastReviewDate.Location = new Point(162, 193);
            lastReviewDate.Name = "lastReviewDate";
            lastReviewDate.Size = new Size(210, 23);
            lastReviewDate.TabIndex = 7;
            lastReviewDate.Value = new DateTime(2023, 11, 30, 16, 13, 43, 0);
            // 
            // sendNewEntryButton
            // 
            sendNewEntryButton.Location = new Point(102, 235);
            sendNewEntryButton.Name = "sendNewEntryButton";
            sendNewEntryButton.Size = new Size(178, 53);
            sendNewEntryButton.TabIndex = 8;
            sendNewEntryButton.Text = "Send New Entry";
            sendNewEntryButton.UseVisualStyleBackColor = true;
            sendNewEntryButton.Click += sendNewEntryButton_Click;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(12, 26);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(95, 15);
            companyNameLabel.TabIndex = 9;
            companyNameLabel.Text = "Company name:";
            // 
            // companyWebsiteLabel
            // 
            companyWebsiteLabel.AutoSize = true;
            companyWebsiteLabel.Location = new Point(12, 52);
            companyWebsiteLabel.Name = "companyWebsiteLabel";
            companyWebsiteLabel.Size = new Size(105, 15);
            companyWebsiteLabel.TabIndex = 10;
            companyWebsiteLabel.Text = "Company website:";
            // 
            // companyEstablishedLabel
            // 
            companyEstablishedLabel.AutoSize = true;
            companyEstablishedLabel.Location = new Point(12, 87);
            companyEstablishedLabel.Name = "companyEstablishedLabel";
            companyEstablishedLabel.Size = new Size(82, 15);
            companyEstablishedLabel.TabIndex = 11;
            companyEstablishedLabel.Text = "Established in:";
            // 
            // numOfEmployeesLabel
            // 
            numOfEmployeesLabel.AutoSize = true;
            numOfEmployeesLabel.Location = new Point(12, 113);
            numOfEmployeesLabel.Name = "numOfEmployeesLabel";
            numOfEmployeesLabel.Size = new Size(128, 15);
            numOfEmployeesLabel.TabIndex = 12;
            numOfEmployeesLabel.Text = "Number of employees:";
            // 
            // companyServicesLabel
            // 
            companyServicesLabel.AutoSize = true;
            companyServicesLabel.Location = new Point(12, 140);
            companyServicesLabel.Name = "companyServicesLabel";
            companyServicesLabel.Size = new Size(112, 15);
            companyServicesLabel.TabIndex = 13;
            companyServicesLabel.Text = "Company Services?:";
            // 
            // companyDemoLabel
            // 
            companyDemoLabel.AutoSize = true;
            companyDemoLabel.Location = new Point(12, 170);
            companyDemoLabel.Name = "companyDemoLabel";
            companyDemoLabel.Size = new Size(122, 15);
            companyDemoLabel.TabIndex = 14;
            companyDemoLabel.Text = "Company demo date:";
            // 
            // companyReviewLabel
            // 
            companyReviewLabel.AutoSize = true;
            companyReviewLabel.Location = new Point(12, 199);
            companyReviewLabel.Name = "companyReviewLabel";
            companyReviewLabel.Size = new Size(125, 15);
            companyReviewLabel.TabIndex = 15;
            companyReviewLabel.Text = "Company review date:";
            // 
            // EntryAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 300);
            Controls.Add(companyReviewLabel);
            Controls.Add(companyDemoLabel);
            Controls.Add(companyServicesLabel);
            Controls.Add(numOfEmployeesLabel);
            Controls.Add(companyEstablishedLabel);
            Controls.Add(companyWebsiteLabel);
            Controls.Add(companyNameLabel);
            Controls.Add(sendNewEntryButton);
            Controls.Add(lastReviewDate);
            Controls.Add(companyLastDemoDate);
            Controls.Add(isProfessionalServices);
            Controls.Add(companyNumOfEmployeesText);
            Controls.Add(companyEstablishedDate);
            Controls.Add(companyWebsiteText);
            Controls.Add(companyNameText);
            MaximizeBox = false;
            Name = "EntryAdd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new entry!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox companyNameText;
        private TextBox companyWebsiteText;
        private DateTimePicker companyEstablishedDate;
        private TextBox companyNumOfEmployeesText;
        private CheckBox isProfessionalServices;
        private DateTimePicker companyLastDemoDate;
        private DateTimePicker lastReviewDate;
        private Button sendNewEntryButton;
        private Label companyNameLabel;
        private Label companyWebsiteLabel;
        private Label companyEstablishedLabel;
        private Label numOfEmployeesLabel;
        private Label companyServicesLabel;
        private Label companyDemoLabel;
        private Label companyReviewLabel;
    }
}