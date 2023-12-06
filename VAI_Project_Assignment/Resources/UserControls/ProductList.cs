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
    public partial class ProductList : UserControl
    {
        public ProductList()
        {
            InitializeComponent();
        }


        private string _pdtTitle;


        private void pdtTitle_Click(object sender, EventArgs e)
        {

        }

        private string GetStringFromDataRow(DataRow dataRow, string columnName)
        {
            return dataRow[columnName]?.ToString();
        }



        // basically it will view the row data according to the slected product by user
        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DBOperationsPdt dbProductInfo = new DBOperationsPdt();


                string softwareName = productTitle;

                // Call the method in DBOperationsPdt to get the data for the specified name.
                DataRow productData = dbProductInfo.GetProductByName(softwareName);

                // Now, you can use 'productData' to display or process the information as needed.
                //used the ('?') to ensure that 'ToStriing' method won't throw an exception.
                if (productData != null)
                {
                    string softwareType = GetStringFromDataRow(productData, "software_type");
                    string description = GetStringFromDataRow(productData, "software_description");

             
                    string businessAreas = GetStringFromDataRow(productData, "business_areas");
                    string modules = GetStringFromDataRow(productData, "modules");
                    string clientTypes = GetStringFromDataRow(productData, "client_types");
                    string cloud = GetStringFromDataRow(productData, "cloud");
                    string additionalInfo = GetStringFromDataRow(productData, "additional_info");


                    ProductInfoForm productInfoForm = new ProductInfoForm(softwareType, description, businessAreas, modules, clientTypes, cloud, additionalInfo);
                    productInfoForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Product with name '{softwareName}' not found.");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        [Category("Custom Props")]
        public string productTitle
        {
            get { return _pdtTitle; }
            set { _pdtTitle = value; pdtTitle.Text = value; }
        }




    }
}
