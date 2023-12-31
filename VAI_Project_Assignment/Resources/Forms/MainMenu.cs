using System.ComponentModel;
using System.Data;
using VAI_Project_Assignment.Forms;
using VAI_Project_Assignment.UserControls;

namespace VAI_Project_Assignment
{
    public partial class MainMenu : Form
    {
        public MainMenu(UserSession userSession)
        {
            InitializeComponent();

            // populating the Admin Combobox with all tools (add entry, delete entry)
            adminToolbox.Items.Add("Add entry...");
            adminToolbox.Items.Add("Delete entry...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateEntryData(""); //empty strings here just to simulate no query until text is added.
        }

        // creating an instance of the Database Operations, named _dbOPS for accessing the database
        private DatabaseOperationsMM _dbOps = new DatabaseOperationsMM();

        /// <summary>
        /// this method is in charge of populating the entryViewPanel with our list view!
        /// gotten from by the same person who helped with the customlist user control!
        /// </summary>
        private void PopulateEntryData(string search)
        {
            // get the data from the database first before anything else
            DataTable entryData = _dbOps.GetEntryData(search);

            // clear the panel first to before adding new items
            entryViewPanel.Controls.Clear();

            // now: this will go through each row in the Table created.
            foreach (DataRow row in entryData.Rows)
            {
                // create a new ListItem for each row of data: the entry title, the entrytype (established date), and the reviewdate.
                var listItem = new ListItem
                {
                    entryTitle = row["company_name"].ToString(),
                    entryType = "Established in: " + row["company_established"].ToString(),
                    entryReviewDate = "Most recent review: " + row["last_reviewed_date"].ToString()
                };

                // parsing the review date to be used in a caluculation to warn the user about reviewing an entry.
                DateTime lastReviewedDate = DateTime.Parse(row["last_reviewed_date"].ToString());
                TimeSpan fortnight = DateTime.Now - lastReviewedDate;

                // changes the text of the entry_review_date to orange if it has been 7 days or more red IF it has been more than 14 days.
                if (fortnight.TotalDays > 14)
                {
                    listItem.ForeColor = Color.Red;
                }
                else if (fortnight.Days >= 7)
                {
                    listItem.ForeColor = Color.Orange;
                }

                // add the ListItem to the panel
                entryViewPanel.Controls.Add(listItem);
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            // log-out logic
            Environment.Exit(0);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateEntryData(searchTextBox.Text); // runs the command as soon as it changes
        }

        private void adminToolbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selected = adminToolbox.SelectedItem as string;

            switch (selected)
            {
                case "Add entry...":
                    OpenAddEntryForm<EntryAdd>();
                    break;
                case "Delete entry...":
                    OpenDeleteEntryForm<EntryDelete>();
                    break;

            }
        }

        private void OpenAddEntryForm<NewEntryForm>() where NewEntryForm : EntryAdd, new()
        {
            NewEntryForm newEntryForm = new NewEntryForm();
            object value = newEntryForm.ShowDialog();
        }

        private void OpenDeleteEntryForm<NewEntryForm>() where NewEntryForm : EntryDelete, new()
        {
            NewEntryForm newEntryForm = new NewEntryForm();
            newEntryForm.ShowDialog();
        }
    }
}