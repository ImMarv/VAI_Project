using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment
{
     class DBConnection
    {
        //attributes
        //private object of the class itself
        private static DBConnection? _instance;

        //the connection string
        private string dBConnectionString;

        //constructor
        private DBConnection()
        {
            //initialise the DBConnectionString
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }


        //methods ---
        /**
         * static method that gives access to the private object
         */
        public static DBConnection getInstanceOfDBConnection() 
        {
            if(_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(dBConnectionString);
        }
        /// <summary>
        /// originally, it didn't accept SQLParameter objects, but now I've done this to avoid SQL injection.
        /// This is so user data is treated as ACTUAL DATA and not SQL code.
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        // parameter query that will be sent to the database.
        public DataSet getDataSet( string sqlQuery, SqlParameter[]? parameters = null) 
        {
            //create the dataset object 
            DataSet dataset = new DataSet();

            
            try
            {
                using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
                {
                    // open connection
                    connToDB.Open();
                    ///
                    /// originally, this "using" block was not here. 
                    /// all it really does is create the Sqlcommand cmd using the provided sqlQuery and SqlConnection.
                    ///
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connToDB))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        // send SQL Query to the database 
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        // fill in the dataset
                        adapter.Fill(dataset);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exeception: Recheck " + ex.Message);
            }

            return dataset;

        }
    }
}
