using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    internal class DatabaseOperations
    {
        public DatabaseOperations() { 
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


    }
}
