using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment.Resources.Forms
{
    public partial class Notifications : Form
    {
        private Label lblSoftwareName;
        private Label lblSoftwareType;
        private Label lblSoftwareDescription;
        private Label lblBusinessAreas;
        private Label lblModules;
        private Label lblClientTypes;
        private Label lblCloud;
        private Label lblAdditionalInfo;


        private ProductSession productSession;

        public Notifications(ProductSession productSession)
        {
            InitializeComponent();
            this.productSession = productSession;
        }

        public void UpdateInfo()
        {
            lblSoftwareName.Text = productSession.SoftwareName;
            lblSoftwareType.Text = productSession.SoftwareType;
            lblSoftwareDescription.Text = productSession.SoftwareDescription;
            lblBusinessAreas.Text = productSession.BusinessAreas;
            lblModules.Text = productSession.Modules;
            lblClientTypes.Text = productSession.ClientTypes;
            lblCloud.Text = productSession.Cloud;
            lblAdditionalInfo.Text = productSession.AdditionalInfo;
        }

        public void Notifications_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(500, "New Item has been added!", "Click here to see more.", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            NewTextBox.text = 
            this.Show();
        }

        private void NewInfoBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
