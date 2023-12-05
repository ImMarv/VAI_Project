namespace VAI_Project_Assignment.UserControls
{
    partial class EntryAdminControl
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
            companyNameText = new TextBox();
            companyWebsiteText = new TextBox();
            employeeNumberText = new TextBox();
            internalServicesText = new TextBox();
            lastDemoDate = new DateTimePicker();
            lastReviewDate = new DateTimePicker();
            companyNameLabel = new Label();
            companyWebsiteLabel = new Label();
            companyEstablisedLabel = new Label();
            numberOfEmployeesLabel = new Label();
            internalServicesLabel = new Label();
            lastDemoDateLabel = new Label();
            lastReviewLabel = new Label();
            establishedInDate = new DateTimePicker();
            SuspendLayout();
            // 
            // companyNameText
            // 
            companyNameText.Location = new Point(116, 23);
            companyNameText.Name = "companyNameText";
            companyNameText.Size = new Size(123, 23);
            companyNameText.TabIndex = 0;
            // 
            // companyWebsiteText
            // 
            companyWebsiteText.Location = new Point(116, 52);
            companyWebsiteText.Name = "companyWebsiteText";
            companyWebsiteText.Size = new Size(123, 23);
            companyWebsiteText.TabIndex = 1;
            // 
            // employeeNumberText
            // 
            employeeNumberText.Location = new Point(116, 110);
            employeeNumberText.Name = "employeeNumberText";
            employeeNumberText.Size = new Size(123, 23);
            employeeNumberText.TabIndex = 3;
            // 
            // internalServicesText
            // 
            internalServicesText.Location = new Point(116, 139);
            internalServicesText.Name = "internalServicesText";
            internalServicesText.Size = new Size(123, 23);
            internalServicesText.TabIndex = 4;
            // 
            // lastDemoDate
            // 
            lastDemoDate.Location = new Point(116, 168);
            lastDemoDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            lastDemoDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            lastDemoDate.Name = "lastDemoDate";
            lastDemoDate.Size = new Size(123, 23);
            lastDemoDate.TabIndex = 5;
            // 
            // lastReviewDate
            // 
            lastReviewDate.Location = new Point(116, 197);
            lastReviewDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            lastReviewDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            lastReviewDate.Name = "lastReviewDate";
            lastReviewDate.Size = new Size(123, 23);
            lastReviewDate.TabIndex = 6;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(6, 26);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(97, 15);
            companyNameLabel.TabIndex = 7;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyWebsiteLabel
            // 
            companyWebsiteLabel.AutoSize = true;
            companyWebsiteLabel.Location = new Point(6, 55);
            companyWebsiteLabel.Name = "companyWebsiteLabel";
            companyWebsiteLabel.Size = new Size(107, 15);
            companyWebsiteLabel.TabIndex = 8;
            companyWebsiteLabel.Text = "Company Website:";
            // 
            // companyEstablisedLabel
            // 
            companyEstablisedLabel.AutoSize = true;
            companyEstablisedLabel.Location = new Point(6, 84);
            companyEstablisedLabel.Name = "companyEstablisedLabel";
            companyEstablisedLabel.Size = new Size(82, 15);
            companyEstablisedLabel.TabIndex = 9;
            companyEstablisedLabel.Text = "Established in:";
            // 
            // numberOfEmployeesLabel
            // 
            numberOfEmployeesLabel.AutoSize = true;
            numberOfEmployeesLabel.Location = new Point(6, 113);
            numberOfEmployeesLabel.Name = "numberOfEmployeesLabel";
            numberOfEmployeesLabel.Size = new Size(103, 15);
            numberOfEmployeesLabel.TabIndex = 10;
            numberOfEmployeesLabel.Text = "No. of employees:";
            // 
            // internalServicesLabel
            // 
            internalServicesLabel.AutoSize = true;
            internalServicesLabel.Location = new Point(6, 142);
            internalServicesLabel.Name = "internalServicesLabel";
            internalServicesLabel.Size = new Size(90, 15);
            internalServicesLabel.TabIndex = 11;
            internalServicesLabel.Text = "Internal Service:";
            // 
            // lastDemoDateLabel
            // 
            lastDemoDateLabel.AutoSize = true;
            lastDemoDateLabel.Location = new Point(6, 174);
            lastDemoDateLabel.Name = "lastDemoDateLabel";
            lastDemoDateLabel.Size = new Size(93, 15);
            lastDemoDateLabel.TabIndex = 12;
            lastDemoDateLabel.Text = "Last Demo Date:";
            // 
            // lastReviewLabel
            // 
            lastReviewLabel.AutoSize = true;
            lastReviewLabel.Location = new Point(6, 203);
            lastReviewLabel.Name = "lastReviewLabel";
            lastReviewLabel.Size = new Size(98, 15);
            lastReviewLabel.TabIndex = 13;
            lastReviewLabel.Text = "Last Review Date:";
            // 
            // establishedInDate
            // 
            establishedInDate.Location = new Point(116, 81);
            establishedInDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            establishedInDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            establishedInDate.Name = "establishedInDate";
            establishedInDate.Size = new Size(123, 23);
            establishedInDate.TabIndex = 14;
            // 
            // EntryAdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(establishedInDate);
            Controls.Add(lastReviewLabel);
            Controls.Add(lastDemoDateLabel);
            Controls.Add(internalServicesLabel);
            Controls.Add(numberOfEmployeesLabel);
            Controls.Add(companyEstablisedLabel);
            Controls.Add(companyWebsiteLabel);
            Controls.Add(companyNameLabel);
            Controls.Add(lastReviewDate);
            Controls.Add(lastDemoDate);
            Controls.Add(internalServicesText);
            Controls.Add(employeeNumberText);
            Controls.Add(companyWebsiteText);
            Controls.Add(companyNameText);
            Name = "EntryAdminControl";
            Size = new Size(250, 253);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox companyNameText;
        private TextBox companyWebsiteText;
        private TextBox employeeNumberText;
        private TextBox internalServicesText;
        private DateTimePicker lastDemoDate;
        private DateTimePicker lastReviewDate;
        private Label companyNameLabel;
        private Label companyWebsiteLabel;
        private Label companyEstablisedLabel;
        private Label numberOfEmployeesLabel;
        private Label internalServicesLabel;
        private Label lastDemoDateLabel;
        private Label lastReviewLabel;
        private DateTimePicker establishedInDate;
    }
}
