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
            populateEntryData();
        }

        // this method is in charge of populating the entryViewPanel with our list view!
        private void populateEntryData()
        {
            ListItem[] listItems = new ListItem[20]; // where 10 is placed, we'd add a callout for the count of data.

            // loops through each item
            for (int i = 0; i < listItems.Length; i++)
            {
                // issue here: I forgot to create the list object. I've been stuck here for half an hour. I'm dumb.
                listItems[i] = new ListItem();
                listItems[i].entryTitle = "Database callout for titles";
                listItems[i].entryType = "Database callout for subtitles";
                listItems[i].entryDescription = "Database callout for description";
                // here we add it straight to the flowlayout >:)
                // we'll create an if so as to ensure that if the entryViewPanel's count is less more than 0, then we clear it (?)
                if (entryViewPanel.Controls.Count < 0)
                {
                    entryViewPanel.Controls.Clear();
                }
                else
                    entryViewPanel.Controls.Add(listItems[i]);

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

        private void entryViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}