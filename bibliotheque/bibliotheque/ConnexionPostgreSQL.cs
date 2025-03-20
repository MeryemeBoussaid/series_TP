using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace bibliotheque
{





    public class ConnexionPostgreSQL : Iconnexion
    {
        private NpgsqlConnection cnx;

        public ConnexionPostgreSQL(string dbName, string host = "localhost", string username = "postgres", string password = "")
        {
            string connectionString = $"Host={host};Username={username};Password={password};Database={dbName}";
            cnx = new NpgsqlConnection(connectionString);
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

        public NpgsqlConnection PostgreSqlConnection
        {
            get { return cnx; }
        }
    }
}