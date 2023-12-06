using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAI_Project_Assignment
{
    internal class DBOperationsPdt
    {
        public DBOperationsPdt()
        {
        }

        // getting the instance of DB connection 
        private DBConnection dBConnBE = DBConnection.getInstanceOfDBConnection();
        

        public DataTable GetProductName(string search)
        {
           
            DataSet dataSetProduct = dBConnBE.getDataSet(
                $"SELECT software_name, software_type FROM Product WHERE software_name LIKE '%{search}%'"
                );
            return dataSetProduct.Tables[0];
            
        }

        public DataRow GetProductByName(string softwareName)
        {
            //parameterized queries to prevent SQL injection 
            SqlParameter[] parameters = {
            new SqlParameter("@softwareName", SqlDbType.NVarChar) { Value = softwareName }
        };

            DataSet dataSetProduct = dBConnBE.getDataSet(
                "SELECT * FROM Product WHERE software_name = @softwareName",
                parameters
            );

            // knowing that productId is unique, return the first (and only) row, or null if not found.
            return dataSetProduct.Tables[0].Rows.Count > 0
                ? dataSetProduct.Tables[0].Rows[0]
                : null;
        }

        
    }
}
