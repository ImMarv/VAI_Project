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
    public partial class RatingsAndComments : Form
    {
        internal const string connectionStringName = "VAI_Project_Assignment.Properties.Settings.DBConnection";
        private string conntectionString;
        
        public string UserComment;
        public int UserRating;
        public RatingsAndComments()
        {
            InitializeComponent();
            //connectionString = _2217052_DBMethod.GetConnectionString(connectionStringName);
            //_2217052_DBMethod dBMethod = new _2217052_DBMethod(connectionString);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {   
            int CharCount = 0;
            for (int i = 0; i < CommentInput.Text.Length; i++)
            {
                CharCount++;
            }

            if (CharCount == 0 || CharCount > 500)
            {
                string ErrorMessage = "Invalid amount of Characters, Please Try Again.";
                MessageBox.Show(ErrorMessage);
            }

            else
            {
                string UserComment = CommentInput.Text;
            }
            

            int StarCount = 0;
            for (int i = 0; i < RatingBox.SelectedText.Length; i++)
            {
                StarCount++;
            }
            int UserRating = StarCount;

            //_2217052_DBMethod dbMethod = new _2217052_DBMethod(connectionString);
            //dbMethod.InsertUserRating(UserComment, UserRating);
        }
    }
}
