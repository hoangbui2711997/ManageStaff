using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManageStaff.Data
{
    public class MakeConnection
    {
        const string connectionString = @"Data Source = DESKTOP-MK3LFHG; Initial Catalog = ManagerStaff; Integrated Security=True";

        private SqlConnection conn;
        private static MakeConnection getInstance;

        public static MakeConnection GetInstance ()
        {
            if(MakeConnection.getInstance == null)
            {
                getInstance = new MakeConnection();
            }

            return getInstance;
        }

        private MakeConnection()
        {
            GetSqlConnection();
        }

        public SqlConnection GetSqlConnection()
        {
            if(conn == null) { 
                conn = new SqlConnection(connectionString);
            }

            return conn;
        }
    }
}