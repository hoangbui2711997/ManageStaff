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

        /// <summary>
        /// Khong tra ve gi ca
        /// </summary>
        public static void DoVoidQuery(String query)
        {
            try
            {
                // Truyen gia tri cho cmd
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                // Mo truy van
                connection.Open();

                cmd.ExecuteReader();
                // dong truy van
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Tra ve du lieu
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
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