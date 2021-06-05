using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtsStore
{
    class ConnectDB
    {
        
        public OracleConnection conn = new OracleConnection("Data Source=localhost:1521/orcl;User Id=bookstore;Password=pts;");
        public OracleConnection GetConnectionDB()
        {
            conn.Open();
            return conn;
        }

        public void CloseConnection()
        {
            conn.Close();
        }

    }
}
