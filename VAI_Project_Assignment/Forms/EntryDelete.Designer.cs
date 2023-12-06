namespace VAI_Project_Assignment.Forms
{
    partial class EntryDelete
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
            entryDataGrid = new DataGridView();
            entryDeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)entryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // entryDataGrid
            // 
            entryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            entryDataGrid.Location = new Point(12, 12);
            entryDataGrid.Name = "entryDataGrid";
            entryDataGrid.RowTemplate.Height = 25;
            entryDataGrid.Size = new Size(379, 337);
            entryDataGrid.TabIndex = 0;
            entryDataGrid.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // entryDeleteButton
            // 
            entryDeleteButton.Location = new Point(245, 355);
            entryDeleteButton.Name = "entryDeleteButton";
            entryDeleteButton.Size = new Size(146, 41);
            entryDeleteButton.TabIndex = 1;
            entryDeleteButton.Text = "Delete entry!";
            entryDeleteButton.UseVisualStyleBackColor = true;
            entryDeleteButton.Click += entryDeleteButton_Click;
            // 
            // EntryDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 408);
            Controls.Add(entryDeleteButton);
            Controls.Add(entryDataGrid);
            MaximizeBox = false;
            Name = "EntryDelete";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Delete Entry!";
            ((System.ComponentModel.ISupportInitialize)entryDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView entryDataGrid;
        private Button entryDeleteButton;
    }
}