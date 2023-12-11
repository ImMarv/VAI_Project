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
        private Label lblAllProductInfo;

        private ProductSession productSession;

        public Notifications(ProductSession productSession)
        {
            InitializeComponent();
            this.productSession = productSession;
        }

        public void UpdateInfo()
        {
            lblAllProductInfo.Text = $"{productSession.SoftwareName}\n {productSession.SoftwareType}\n {productSession.SoftwareDescription}\n {productSession.BusinessAreas}\n  {productSession.Modules}\n {productSession.ClientTypes}\n {productSession.Cloud}\n {productSession.AdditionalInfo}";
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
            NewInfoBox.Text = lblAllProductInfo.Text;
            this.Show();
        }
    }
}
