using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAI_Project_Assignment
{
    
    internal class _2217052_DBMethod
    {
        private readonly string connectionString;

        public _2217052_DBMethod(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public static string GetConnectionString(string connectionStringName)
        {
            var connectionStringSettings = ConfigurationManager.ConnectionStrings[connectionStringName];
            return connectionStringSettings.ConnectionString;
        }
        public UserSession RetrieveUserData(string activeUserData)
        {
            UserSession userSession = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM [User] INNER JOIN ContactInfo ON [User].Contact_Info_ID = ContactInfo.Contact_Info_ID WHERE [User].username = @username", connection))
                {
                    command.Parameters.AddWithValue("@username", activeUserData);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        userSession = new UserSession();

                        userSession.UserId = reader.GetInt32(reader.GetOrdinal("user_id"));
                        userSession.Username = reader["username"].ToString();
                        userSession.FirstName = reader["first_name"].ToString();
                        userSession.LastName = reader["last_name"].ToString();
                        userSession.EmailAddress = reader["email_address"].ToString();
                        userSession.PhoneNumber = reader["phone_number"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }

            return userSession;
        }
        public ProductSession RetrieveProductData(string productData)
        {
            ProductSession productSession = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT [product_Id], [software_name], [software_type], [software_description], [business_areas], [modules], [client_types], [cloud], [additional_info], [number_of_likes]\r\nFROM [dbo].[Product];", connection))
                {
                    command.Parameters.AddWithValue("@Product", productData);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        productSession = new ProductSession();

                        productSession.ProductID = reader.GetInt32(reader.GetOrdinal("product_Id"));
                        productSession.SoftwareName = reader["software_name"].ToString();
                        productSession.SoftwareType = reader["software_type"].ToString();
                        productSession.SoftwareDescription = reader["software_description"].ToString();
                        productSession.BusinessAreas = reader["business_areas"].ToString();
                        productSession.Modules = reader["modules"].ToString();
                        productSession.ClientTypes = reader["client_types"].ToString();
                        productSession.Cloud = reader["cloud"].ToString();
                        productSession.AdditionalInfo = reader["additional_info"].ToString();
                        productSession.NumberOfLikes = reader["number_of_likes"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }

            return productSession;
        }
    }
}
