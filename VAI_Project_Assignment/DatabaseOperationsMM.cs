using System.Data;
using System.Data.SqlClient;

namespace VAI_Project_Assignment
{
    /// <summary>
    /// this class will be in charge of all things relating to accessing the database. This should contain
    /// most operatioons to do with reading, writing and updating entries and more within the main menu. 
    /// Let's see how it goes...
    /// All queries are now parametrized, which should cancel out most basic SQLInjection attempts.
    /// </summary>
    internal class DatabaseOperationsMM
    {
        public DatabaseOperationsMM()
        {
        }

        // getting the instance of DB connection 
        private DBConnection dBConnBE = DBConnection.getInstanceOfDBConnection();

        public DataTable GetEntryData(string search)
        {

            // this previously handled it horribly and was liable to SQL injection. I am so glad I fixed it all on time!
            // sets the query string here
            string sqlQuery = "SELECT company_name, company_established, last_reviewed_date FROM Company WHERE company_name LIKE @Search";
            try
            // creates a new parametrised query, handling the search for the Company entries.
            {
                SqlParameter[] parameters = { new SqlParameter("@Search", SqlDbType.VarChar, 100) { Value = "%" + search + "%" } };

                // this executes the query, and stores the resulting table inside the dataSetVendor object. 
                DataSet dataSetVendor = dBConnBE.getDataSet(sqlQuery, parameters);
                // this returns said table generated.
                return dataSetVendor.Tables[0];
            }
            catch (Exception searchError)
            {
                MessageBox.Show("Search error, thing is being silly:" + searchError.Message);
                throw new Exception($"Error retrieving data: {searchError.Message}", searchError);
            }

        }

        // all that this method does is create a new entry. this is grabbed from the "EntryAdd" form.
        public void AddEntry(
            string companyName,
            string companyWebsite,
            string companyEstablished,
            string numOfEmployees,
            bool internalServices,
            DateTime lastDemo,
            DateTime lastReview
            ) // I am setting the parameters dealing with the data grabbing stuff :p
        {
            // this is the query that takes the whole entry and inserts it into company. 
            // for some reason, it does not work? there is an issue with the company_name.
            string sqlQuery = "INSERT INTO Company (company_name, company_website, company_established, no_of_employees, " +
                              "internal_prof_services, last_demo_date, last_reviewed_date) " +
                              "VALUES (@CompanyName, @CompanyWebsite, @CompanyEstablished, " +
                              "@NoOfEmployees, @InternalProfServices, @LastDemoDate, @LastReviewedDate)";
            try
            {
                SqlParameter[] parameters = // here the parameters are set for the add entry section!
                {
                    new SqlParameter("@CompanyName", SqlDbType.VarChar, 100) { Value = companyName },
                    new SqlParameter("@CompanyWebsite", SqlDbType.VarChar, 250) { Value = companyWebsite },
                    new SqlParameter("@CompanyEstablished", SqlDbType.Int) { Value = companyEstablished },
                    new SqlParameter("@NoOfEmployees", SqlDbType.Int) { Value = numOfEmployees },
                    new SqlParameter("@InternalProfServices", SqlDbType.Bit) { Value = internalServices },
                    new SqlParameter("@LastDemoDate", SqlDbType.Date) { Value = lastDemo },
                    new SqlParameter("@LastReviewedDate", SqlDbType.Date) { Value = lastReview }
                };
                dBConnBE.getDataSet(sqlQuery, parameters); // executes the query - in this case, we are inserting the new entry in the "Company" table.
            }
            // just a nice little catch so we know when something goes wrong.
            catch (Exception entryerror)
            {
                MessageBox.Show("Exception: " + entryerror.Message);
            }
        }

        public void DeleteEntry(int companyID)
        {
            Console.WriteLine("DeleteEntry called with Company_ID: " + companyID);
            string sqlQuery = "DELETE FROM Company WHERE Company_ID = @Company_ID";
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Company_ID", SqlDbType.Int) { Value = companyID }
                };

                dBConnBE.setDataSet(sqlQuery, parameters);
            }
            catch (Exception deleteError)
            {

                MessageBox.Show("Exception: " + deleteError.Message);
            }
        }

        public void UpdateEntry(int companyID,
            string companyName,
            string companyWebsite,
            int companyEstablished,
            int? numOfEmployees,
            bool? internalServices,
            DateTime? lastDemo,
            DateTime? lastReview)
        {
            string sqlQuery = "UPDATE Company SET " +
                         "company_name = @CompanyName, " +
                         "company_website = @CompanyWebsite, " +
                         "company_established = @CompanyEstablished, " +
                         "no_of_employees = @NoOfEmployees, " +
                         "internal_prof_services = @InternalProfServices, " +
                         "last_demo_date = @LastDemoDate, " +
                         "last_reviewed_date = @LastReviewedDate " +
                         "WHERE Company_ID = @CompanyID";

            try
            {
                SqlParameter[] parameters = // here the parameters are set for the add entry section!
                {
                    new SqlParameter("@CompanyName", SqlDbType.VarChar, 100) { Value = companyName },
                    new SqlParameter("@CompanyWebsite", SqlDbType.VarChar, 250) { Value = companyWebsite },
                    new SqlParameter("@CompanyEstablished", SqlDbType.Int) { Value = companyEstablished },
                    new SqlParameter("@NoOfEmployees", SqlDbType.Int) { Value = numOfEmployees },
                    new SqlParameter("@InternalProfServices", SqlDbType.Bit) { Value = internalServices },
                    new SqlParameter("@LastDemoDate", SqlDbType.Date) { Value = lastDemo },
                    new SqlParameter("@LastReviewedDate", SqlDbType.Date) { Value = lastReview }
                };
                dBConnBE.setDataSet(sqlQuery, parameters); // executes the query - in this case, we are inserting the new entry in the "Company" table.
            }
            catch (Exception updateError)
            {
                MessageBox.Show("Error: " + updateError.Message);
            }
        }
    }
}
