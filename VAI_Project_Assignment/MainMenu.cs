using System.Data;

namespace VAI_Project_Assignment
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateEntryData();
        }

        // this method is in charge of populating the entryViewPanel with our list view!
        private void PopulateEntryData()
        {
            // getting the instance of DB connection
            DBConnection dBConnectionMM = DBConnection.getInstanceOfDBConnection();

            // execute the query to get the results
            DataSet dataSetVendor = dBConnectionMM.getDataSet(
                "SELECT company_name, company_established, last_reviewed_date FROM Company"
                );

            // clear the panel first to before adding new items
            entryViewPanel.Controls.Clear();

            // now: this will go through each row in the Table created.
            foreach (DataRow row in dataSetVendor.Tables[0].Rows)
            {
                // create a new ListItem for each row
                var listItem = new ListItem();
                listItem.entryTitle = row["company_name"].ToString();
                listItem.entryType = row["company_established"].ToString();
                listItem.entryDescription = row["last_reviewed_date"].ToString();

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
            // search engine logic
        }
    }
}