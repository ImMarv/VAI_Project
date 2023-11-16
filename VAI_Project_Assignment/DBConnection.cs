using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAI_Project_Assignment
{
     class DBConnection
    {
        //attributes
        //private object of the class itself
        private static DBConnection _instance;

        //the connection string
        private string dBConnectionString;

        //constructor
        private DBConnection()
        {
            //initialise the DBConnectionString
            dBConnectionString = Properties.Settings.Default.DBConnectionString;
        }

        //methods
        /**
         * static method that gives access to the private object
         */
        public static DBConnection getInstanceOfDBConnection() 
        {
            if(_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        //parameter query that will be sent to the database
        public DataSet getDataSet( string sqlQuery) 
        {
            //create the dataset object 
            DataSet dataset = new DataSet();


            try
            {
                using (SqlConnection connToDB = new SqlConnection(dBConnectionString))
                {
                    // open connection
                    connToDB.Open();

                    // send SQL Query to the database 
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connToDB);

                    // fill in the dataset
                    adapter.Fill(dataset);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exeception: recheck " + ex.Message);
            }

            return dataset;

        }
    }
}
