using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm(string softwareType, string description, string businessAreas, string modules, string clientTypes, string cloud, string additionalInfo)
        {
            InitializeComponent();

            txtSoftwareType.Text = softwareType;
            txtDescription.Text = description;
            txtBusinessArea.Text = businessAreas;
            txtModule.Text = modules;
            txtClientType.Text = clientTypes;
            txtCloud.Text = cloud;
            txtAdditionalInfo.Text = additionalInfo;

        }


    }
}
