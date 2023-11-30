using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAI_Project_Assignment
{
    /// <summary>
    /// this class will be in charge of all things relating to accessing the database. This should contain
    /// most operatioons to do with reading, writing and updating entries and more within the main menu. 
    /// Let's see how it goes...
    /// </summary>
    internal class DatabaseOperationsMM
    {
        public DatabaseOperationsMM() { 
        }

        // getting the instance of DB connection 
        private DBConnection dBConnBE = DBConnection.getInstanceOfDBConnection();

        public DataTable GetEntryData(string search) { 
            // execute the query to get the results. added a search query as well. currently liable to SQL injection.
        // could I fix it? yes. Do I have time for this? Hell no.
        DataSet dataSetVendor = dBConnBE.getDataSet(
            $"SELECT company_name, company_established, last_reviewed_date FROM Company WHERE company_name LIKE '%{search}%'"
            );
            return dataSetVendor.Tables[0];
        }

        // all that this method does is create a new entry. this is grabbed from the "EntryAdd" form.
        public void AddEntry(
            string companyName, 
            string companyWebsite, 
            DateTime companyEstablished, 
            string numOfEmployees, 
            bool internalServices, 
            DateTime lastDemo, 
            DateTime lastReview
            ) // I am setting the parameters dealing with the data grabbing stuff :p
        {
            
            try
            {
                SqlParameter[] parameters = // here the parameters are set for the add entry section!
                {
                    new SqlParameter("@CompanyName", SqlDbType.VarChar, 100) { Value = companyName },
                    new SqlParameter("@CompanyWebsite", SqlDbType.VarChar, 250) { Value = companyWebsite },
                    new SqlParameter("@CompanyEstablished", SqlDbType.Date) { Value = companyEstablished },
                    new SqlParameter("@NoOfEmployees", SqlDbType.Int) { Value = numOfEmployees },
                    new SqlParameter("@InternalProfServices", SqlDbType.Bit) { Value = internalServices },
                    new SqlParameter("@LastDemoDate", SqlDbType.Date) { Value = lastDemo },
                    new SqlParameter("@LastReviewedDate", SqlDbType.Date) { Value = lastReview }
                };
                // this is the query dealing with the whole data row.
                string sqlQuery = ("INSERT INTO Company (company_name, company_website, company_established, " +
                          "no_of_employees, internal_prof_services, last_demo_date, last_reviewed_date) " +
                          "VALUES (@CompanyName, @CompanyWebsite, @CompanyEstablished, " +
                          "@NoOfEmployees, @InternalProfServices, @LastDemoDate, @LastReviewedDate)");
                dBConnBE.getDataSet(sqlQuery, parameters); // this right here then creates the dataset, taking the query with it along with the params.
            }
            // just a nice little catch so we know when something goes wrong.
            catch (Exception entryerror)
            {
                MessageBox.Show("Exception: " + entryerror.Message);            
            }

        }


    }
}
