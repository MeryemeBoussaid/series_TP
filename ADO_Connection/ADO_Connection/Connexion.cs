using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace ADO_Connection
{
    internal class Connexion
    {
        private string connectionString = "Server=localhost;Database=db_c#;User Id=root;Password=123456;";


        private MySqlConnection conn;

        public Connexion()
        {
            conn = new MySqlConnection(connectionString);
        }

        public void set(string sql) // update/delete/ insert
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public MySqlDataReader get(string sql) // select
        {
            MySqlDataReader dr = null;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
            return dr;
        }
    }
}
