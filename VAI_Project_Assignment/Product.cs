using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAI_Project_Assignment.Forms;
using System.Windows.Forms;
using VAI_Project_Assignment.UserControls;
using System.Data.SqlClient;

namespace VAI_Project_Assignment
{
    public partial class Product : Form
    {

        public Product()
        {

            InitializeComponent();

        }

        DBConnection dbConn = DBConnection.getInstanceOfDBConnection();

        private void Product_Load(object sender, EventArgs e)
        {
            PopulateProductData("");
            timeCounter.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            FILLComboSearchCode();


        }

        private void FILLComboSearchCode()
        {
            cmbSearchItems.Items.Clear();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                conn.Open(); // Open the connection

                // Create a command using the connection
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT software_name FROM Product";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbSearchItems.Items.Add(dr["software_name"].ToString());
                    }
                }
            }

        }


        // creating an instance of the Database Operations, named _dbOPS for accessing the database
        private DBOperationsPdt _dbOps = new DBOperationsPdt();

        /// <summary>
        /// this method is in charge of populating the loadProductPanel with list of product view!
        /// gotten from by the same person who helped with the customlist user control!
        /// </summary>
        private void PopulateProductData(string search)
        {
            // get the data from the database first before anything else
            DataTable productNameData = _dbOps.GetProductName(search);
            
            // clear the panel first to before adding new items
            loadProductPanel.Controls.Clear();

            // now: this will go through each row in the Table created.
            foreach (DataRow row in productNameData.Rows)
            {
                // create a new ListItem for each row of data: just software name.
                var productList = new ProductList
                {
                    productTitle = row["software_name"].ToString(),

                };



                // add the ListItem to the panel
                loadProductPanel.Controls.Add(productList);
            }
        }




        private void timeCounter_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timeCounter.Start();
        }

        private void cmbSearchItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProductData(cmbSearchItems.Text);
           
        }
    }
}
