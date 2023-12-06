using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment.UserControls
{
    public partial class EntryAdd : Form
    {
        public EntryAdd()
        {
            InitializeComponent();
        }

        private DatabaseOperationsMM _dbOPS = new DatabaseOperationsMM();
        private void sendNewEntryButton_Click(object sender, EventArgs e)
        // takes every single textbox and attach it to it's correspondent string variable (this is so looooong)
        {
            try
            {
                string companyName = companyNameText.Text;
                string companyWebsite = companyWebsiteText.Text;
                string companyEstablished = companyEstablishedText.Text;
                string numOfEmployees = companyNumOfEmployeesText.Text;
                bool internalProfServices = isProfessionalServices.Checked;
                DateTime lastDemoDate = companyLastDemoDate.Value;
                DateTime lastReviewedDate = lastReviewDate.Value;

                _dbOPS.AddEntry(
                    companyName, companyWebsite, companyEstablished, numOfEmployees, internalProfServices, lastDemoDate, lastReviewedDate
                    );

                MessageBox.Show("Entry added successfully!");
                this.Close();
            }

            catch (Exception exNewEntry)
            {
                MessageBox.Show("Error adding entry: " + exNewEntry.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
