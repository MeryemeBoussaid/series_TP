using System;
using Oracle.ManagedDataAccess.Client;

namespace bibliotheque
{
    public class ConnexionOracle : Iconnexion
    {
        private OracleConnection cnx;

        public ConnexionOracle(string dbName, string host = "localhost", string port = "1521", string serviceName = "ORCL", string username = "your_username", string password = "your_password")
        {
            string connectionString = $"User Id={username};Password={password};Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={port})))(CONNECT_DATA=(SERVICE_NAME={serviceName})));";
            cnx = new OracleConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (cnx.State != System.Data.ConnectionState.Open)
            {
                cnx.Open();
            }
        }

        public void CloseConnection()
        {
            if (cnx.State != System.Data.ConnectionState.Closed)
            {
                cnx.Close();
            }
        }

        public bool IsConnectionOpen()
        {
            return cnx.State == System.Data.ConnectionState.Open;
        }

        public OracleConnection OracleConnection
        {
            get { return cnx; }
        }
    }
}