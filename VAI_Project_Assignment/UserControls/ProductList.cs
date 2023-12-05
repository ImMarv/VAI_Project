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



        // basically it will view the row data according to the slected product by user
        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            DBOperationsPdt dbProductInfo = new DBOperationsPdt();


            string softwareName = productTitle;

            // Call the method in DBOperationsPdt to get the data for the specified name.
            DataRow productData = dbProductInfo.GetProductByName(softwareName);

            // Now, you can use 'productData' to display or process the information as needed.
            if (productData != null)
            {
                string softwareType = productData["software_type"].ToString();
                string description = productData["software_description"].ToString();


                MessageBox.Show($"Software Type: {softwareType}\nDescription: {description}");
            }
            else
            {
                MessageBox.Show($"Product with name '{softwareName}' not found.");
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
