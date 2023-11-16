using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLoadData_Click(object sender, EventArgs e)
        {
            //returns the object the DBConnection class
            DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
            DataSet datasetProduct = dbConn.getDataSet("SELECT * FROM ProductInfo");
            dgvProduct.DataSource = datasetProduct.Tables[0];
        }
    }
}
