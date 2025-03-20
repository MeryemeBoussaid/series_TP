using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bibliotheque
{



    internal class Connexion : Iconnexion
    {
        // Instance unique de la classe Connexion (Singleton)
        private static Connexion instance = null;

        // Objet de connexion MySQL
        private MySqlConnection cnx;
        private MySqlCommand cmd;

        // Constructeur privé pour empêcher l'instanciation directe
        private Connexion(string db_name, string host = "localhost", string username = "root", string password = "123456")
        {
            // Construire la chaîne de connexion
            string chaine_cnx = $"User Id={username};Password={password};Host={host};Database={db_name}";
            cnx = new MySqlConnection(chaine_cnx);
            cmd = new MySqlCommand
            {
                Connection = cnx
            };
        }

        // Méthode pour obtenir une instance unique de Connexion (Singleton)
        public static Connexion GetInstance(string db_name, string host = "localhost", string username = "root", string password = "123456")
        {
            // Si l'instance n'existe pas encore, on la crée
            if (instance == null)
            {
                instance = new Connexion(db_name, host, username, password);
            }
            return instance;
        }

        // Ouvrir la connexion
        public void OpenConnection()
        {
            if (cnx.State != System.Data.ConnectionState.Open)
            {
                cnx.Open();
            }
        }

        // Fermer la connexion
        public void CloseConnection()
        {
            if (cnx.State != System.Data.ConnectionState.Closed)
            {
                cnx.Close();
            }
        }

        // Vérifier si la connexion est ouverte
        public bool IsConnectionOpen()
        {
            return cnx.State == System.Data.ConnectionState.Open;
        }
    
     // Propriété pour accéder à MySqlConnection
    public MySqlConnection MySqlConnection
        {
            get { return cnx; }
        }

    } }
