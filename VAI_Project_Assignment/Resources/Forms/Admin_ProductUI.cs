using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAI_Project_Assignment.Resources.Forms;

namespace VAI_Project_Assignment
{
    public partial class Admin_ProductUI : Form
    {

        DBConnection dbConn = DBConnection.getInstanceOfDBConnection();

        public Admin_ProductUI()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbSearch.Text = string.Empty;
            txtSoftwareType.Text = string.Empty;
            txtModule.Text = string.Empty;
            txtClientType.Text = string.Empty;
            txtCloud.Text = string.Empty;
            txtBusinessAreas.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtAdditionalInfo.Text = string.Empty;
        }

        private void dgvProductInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void FILLDGV()
        {
            try
            {

                string sqlQuery = "SELECT * FROM Product";

                DataSet dt = dbConn.getDataSet(sqlQuery);

                if (dt.Tables.Count > 0)
                {
                    dgvProductInfo.DataSource = dt.Tables[0];
                }
                else
                {
                    MessageBox.Show("No data found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Recheck" + ex.Message);
            }
        }

        private void FILLComboSearchCode()
        {
            cmbSoftwareName.Items.Clear();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                conn.Open(); // Open the connection

                // Create a command using the connection
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT software_name FROM Product";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbSoftwareName.Items.Add(dr["software_name"].ToString());
                    }
                }
            }

        }

        private void Admin_ProductUI_Load(object sender, EventArgs e)
        {
            FILLComboSearchCode();
            FILLDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the user really wants to delete
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = dbConn.GetConnection())
                    {
                        conn.Open(); // Open the connection

                        // Create a command using the connection
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;

                            // Use parameterized query to prevent SQL injection
                            string query = "DELETE FROM [Product] WHERE software_name = @SoftwareName";
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@SoftwareName", cmbSoftwareName.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Deleted Successfully.");
                            FILLDGV();

                            // Clear controls
                            txtSoftwareType.Text = string.Empty;
                            txtModule.Text = string.Empty;
                            txtClientType.Text = string.Empty;
                            txtCloud.Text = string.Empty;
                            txtBusinessAreas.Text = string.Empty;
                            txtDescription.Text = string.Empty;
                            txtAdditionalInfo.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Recheck " + ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                // Get a SqlConnection from the DBConnection instance
                using (SqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open(); // Open the connection

                    // Create a command using the connection
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [Product] (software_name, software_type, software_description, business_areas, modules, client_types, cloud, additional_info) " +
                                          "VALUES (@SoftwareName, @SoftwareType, @Description, @BusinessAreas, @Modules, @ClientType, @Cloud, @AdditionalInfo)";

                        // Add parameters with actual values
                        cmd.Parameters.AddWithValue("@SoftwareName", cmbSoftwareName.Text);
                        cmd.Parameters.AddWithValue("@SoftwareType", txtSoftwareType.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@BusinessAreas", txtBusinessAreas.Text);
                        cmd.Parameters.AddWithValue("@Modules", txtModule.Text);
                        cmd.Parameters.AddWithValue("@ClientType", txtClientType.Text);
                        cmd.Parameters.AddWithValue("@Cloud", txtCloud.Text);
                        cmd.Parameters.AddWithValue("@AdditionalInfo", txtAdditionalInfo.Text);

                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Saved Succesfully");

                Notifications notifications = new Notifications();
                notifications.NewNotification = $"{cmbSoftwareName.Text} {txtSoftwareType.Text} {txtDescription.Text} {txtBusinessAreas.Text} {txtModule.Text} {txtClientType.Text} {txtCloud.Text} {txtAdditionalInfo.Text}";



                // Clear controls
                cmbSoftwareName.Text = string.Empty;
                txtSoftwareType.Text = string.Empty;
                txtModule.Text = string.Empty;
                txtClientType.Text = string.Empty;
                txtCloud.Text = string.Empty;
                txtBusinessAreas.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtAdditionalInfo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Recheck " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get a SqlConnection from the DBConnection instance
                using (SqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open(); // Open the connection

                    // Create a command using the connection
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Product SET " +
                                          "software_name = @SoftwareName, " +
                                          "software_type = @SoftwareType, " +
                                          "software_description = @Description, " +
                                          "business_areas = @BusinessAreas, " +
                                          "modules = @Modules, " +
                                          "client_types = @ClientType, " +
                                          "cloud = @Cloud, " +
                                          "additional_info = @AdditionalInfo " +
                                          "WHERE software_name = @SoftwareName";

                        // parameterized queries to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@SoftwareName", cmbSoftwareName.Text);
                        cmd.Parameters.AddWithValue("@SoftwareType", txtSoftwareType.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@BusinessAreas", txtBusinessAreas.Text);
                        cmd.Parameters.AddWithValue("@Modules", txtModule.Text);
                        cmd.Parameters.AddWithValue("@ClientType", txtClientType.Text);
                        cmd.Parameters.AddWithValue("@Cloud", txtCloud.Text);
                        cmd.Parameters.AddWithValue("@AdditionalInfo", txtAdditionalInfo.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Update the DataGridView
                FILLDGV();

                // Clear controls

                cmbSoftwareName.Text = string.Empty;
                txtSoftwareType.Text = string.Empty;
                txtModule.Text = string.Empty;
                txtClientType.Text = string.Empty;
                txtCloud.Text = string.Empty;
                txtBusinessAreas.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtAdditionalInfo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Recheck " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open(); // Open the connection

                    // Create a command using the connection
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;

                        // Use parameterized query to prevent SQL injection
                        string query = "SELECT * FROM Product WHERE software_name = @SoftwareName";
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        da.SelectCommand.Parameters.AddWithValue("@SoftwareName", cmbSoftwareName.Text);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Check if any rows were returned
                        if (dt.Rows.Count > 0)
                        {
                            // Populate the textboxes with the retrieved values
                            txtSoftwareType.Text = dt.Rows[0]["software_type"].ToString();
                            txtDescription.Text = dt.Rows[0]["software_description"].ToString();
                            txtBusinessAreas.Text = dt.Rows[0]["business_areas"].ToString();
                            txtModule.Text = dt.Rows[0]["modules"].ToString();
                            txtClientType.Text = dt.Rows[0]["client_types"].ToString();
                            txtCloud.Text = dt.Rows[0]["cloud"].ToString();
                            txtAdditionalInfo.Text = dt.Rows[0]["additional_info"].ToString();
                        }
                        else
                        {
                            // Handle case where no matching records were found
                            MessageBox.Show("No records found for the specified software_name.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Recheck " + ex.Message);
            }
        }

    }
}
