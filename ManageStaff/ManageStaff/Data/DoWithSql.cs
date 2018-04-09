using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageStaff.Data
{
    public class DoWithSql
    {
        private static SqlConnection connection = MakeConnection.GetInstance().GetSqlConnection();
        public static DataTable DoQuery(String query)
        {
            try
            {
                DataTable dataTable = new DataTable();
                // Mo truy van
                connection.Open();

                // bo chuyen doi du lieu
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);

                // chuyen doi du lieu
                sqlDataAdapter.Fill(dataTable);

                // dong truy van
                connection.Close();
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}