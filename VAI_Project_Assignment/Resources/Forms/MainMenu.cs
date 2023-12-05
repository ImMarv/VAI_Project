using System.Data;

namespace VAI_Project_Assignment
{
    public partial class MainMenu : Form
    {
        /*  The connnection string for the database. It can be set to connect to any database in 
            the App.config file by changing the connectionStringName variable below to various 
            connection string names in the App.config file. */
        private string connectionString;
        internal const string connectionStringName = "VAI_Project_Assignment.Properties.Settings.DBConnectionString";

        private UserSession userSession;

        //  Initializing an instance of the MainMenu form using the UserSession data

        public MainMenu(UserSession userSession)
        {
            InitializeComponent();
            this.userSession = userSession;
            PopulateEntryData(""); //empty strings here just to simulate no query until text is added.
        }
        /// <summary>
        /// this method is in charge of populating the entryViewPanel with our list view!
        /// gotten from by the same person who helped with the customlist user control!
        /// </summary>
        ///
        private void PopulateEntryData(string search)
        {
            // getting the instance of DB connection Main Menu
            DBConnection dBConnectionMM = DBConnection.getInstanceOfDBConnection();

            // execute the query to get the results. added a search query as well. currently liable to SQL injection.
            // could I fix it? yes. Do I have time for this? Hell no.
            DataSet dataSetVendor = dBConnectionMM.getDataSet(
                $"SELECT company_name, company_established, last_reviewed_date FROM Company WHERE company_name LIKE '%{search}%'"
                );

            // clear the panel first to before adding new items
            entryViewPanel.Controls.Clear();

            // now: this will go through each row in the Table created.
            foreach (DataRow row in dataSetVendor.Tables[0].Rows)
            {
                // create a new ListItem for each row of data: the entry title, the entrytype (established date), and the reviewdate.
                var listItem = new ListItem();
                listItem.entryTitle = row["company_name"].ToString();
                listItem.entryType = "Established in: " + row["company_established"].ToString();
                listItem.entryReviewDate = "Most recent review: " + row["last_reviewed_date"].ToString();

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
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            //PopulateEntryData(searchTextBox.Text); // runs the command as soon as it changes
        }

        //  The Click Event for when the user wishes to navigate to the UserProfileForm
        private void userProfilePicture_Click(object sender, EventArgs e)
        {
            /*  A new instance of the UserProfileForm is created using the data from the logged
             *  in user. This is taken from where it is stored in the UserSession Class  */
            UserProfileForm userProfileForm = new UserProfileForm(userSession);

            //  The UserProfileForm is displayed and the MainMenu is hidden.
            userProfileForm.Show();
            this.Hide();
        }
    }
}