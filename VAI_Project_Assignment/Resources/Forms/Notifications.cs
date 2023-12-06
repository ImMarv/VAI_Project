using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment.Resources.Forms
{
    public partial class Notifications : Form
    {
        public static Notifications instance;
        public TextBox NewNotification;
        public Notifications()
        {
            InitializeComponent();
            instance = this;
            NewNotification = NewInfoBox;
        }
        
        private void Notifications_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(500, "New Item has been added!", "Click here to see more.", ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
