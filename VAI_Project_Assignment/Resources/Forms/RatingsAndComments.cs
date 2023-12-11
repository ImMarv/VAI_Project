using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 2217052

namespace VAI_Project_Assignment
{
    public partial class RatingsAndComments : Form
    {
        // worked for a while but after a few pulls it just didn't want to store or connect to the DB anymore :/
        internal const string connectionStringName = "VAI_Project_Assignment.Properties.Settings.DBConnection";
        private string conntectionString;
        
        // allows me to pass the variables when needed.
        public string UserComment;
        public int UserRating;
        public RatingsAndComments()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {   // counts every character that's being put into the textbox
            int CharCount = 0;
            for (int i = 0; i < CommentInput.Text.Length; i++)
            {
                CharCount++;
            }
            // checks if the comment has at least one character or less than 500 (max varchar 500 in DB)
            if (CharCount == 0 || CharCount > 500)
            {
                string ErrorMessage = "Invalid amount of Characters, Please Try Again.";
                MessageBox.Show(ErrorMessage);
            }
            // stores the comment in a variable ready to be sent to the database
            else
            {
                string UserComment = CommentInput.Text;
            }
            
            // simple way of turning the stars from the drop down menu into integers, by counting how many characters there are
            int StarCount = 0;
            for (int i = 0; i < RatingBox.SelectedText.Length; i++)
            {
                StarCount++;
            }
            int UserRating = StarCount;
        }
        //kinda silly but understandable feature
        private void AnonymousButton_CheckedChanged(object sender, EventArgs e)
        {
            string Anonymous = "Your username will not be used in this review.";
            MessageBox.Show(Anonymous);
        }
    }
}
