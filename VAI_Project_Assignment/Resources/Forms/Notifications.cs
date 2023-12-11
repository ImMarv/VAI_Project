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

        // starts a session using a seperate program made to grab details from the DB when needed.
        private ProductSession productSession;

        public Notifications(ProductSession productSession)
        {
            InitializeComponent();
            this.productSession = productSession;
            // allows the session to work in the program
        }

        public void UpdateInfo()
        {
            // pretty long and arguably excessive way of handling the information BUT considering the format I used it actually looks decent.
            lblAllProductInfo.Text = $"{productSession.SoftwareName}\n {productSession.SoftwareType}\n {productSession.SoftwareDescription}\n {productSession.BusinessAreas}\n  {productSession.Modules}\n {productSession.ClientTypes}\n {productSession.Cloud}\n {productSession.AdditionalInfo}";
        }
        
        // this is meant to pop up one of those grey notification bubble from the left corner of the screen.
        public void Notifications_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(500, "New Item has been added!", "Click here to see more.", ToolTipIcon.Info);
            }
        }
        // once that grey notification is double pressed, textbox gets all the details and displays the window with all the information. 
        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            NewInfoBox.Text = lblAllProductInfo.Text;
            this.Show();
        }
    }
}
