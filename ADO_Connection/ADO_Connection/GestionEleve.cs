using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ADO_Connection
{
    internal class GestionEleve
    {
        private Connexion conn = new Connexion();

        // Ajouter un élève
        public void ajouter(Eleve e)
        {
            string sql = $"INSERT INTO eleve (nom, prenom, ville, specialite) VALUES ('{e.Nom}', '{e.Prenom}', '{e.Ville}', '{e.Specialite}')";
            conn.set(sql);
        }

        // Modifier un élève
        public void modifier(Eleve e)
        {
            string sql = $"UPDATE eleve SET nom = '{e.Nom}', prenom = '{e.Prenom}', ville = '{e.Ville}', specialite = '{e.Specialite}' WHERE code = {e.Code}";
            conn.set(sql);
        }

        // Supprimer un élève
        public void supprimer(int id)
        {
            string sql = $"DELETE FROM eleve WHERE code = {id}";
            conn.set(sql);
        }
        // Rechercher un élève par ID
        public Eleve rechercher(int id)
        {
            string sql = $"SELECT * FROM eleve WHERE code = {id}";
            MySqlDataReader dr = conn.get(sql);
            Eleve e = null;
            if (dr.Read())
            {
                e = new Eleve
                {
                    Code = dr.GetInt32(0),
                    Nom = dr.GetString(1),
                    Prenom = dr.GetString(2),
                    Ville = dr.GetString(3),
                    Specialite = dr.GetString(4)
                };
            }
            dr.Close();
            return e;
        }

        // Récupérer la liste des élèves
        public List<Eleve> liste()
        {
            string sql = "SELECT * FROM eleve";
            MySqlDataReader dr = conn.get(sql);
            List<Eleve> listeEleves = new List<Eleve>();

            while (dr.Read())
            {
                Eleve e = new Eleve
                {
                    Code = dr.GetInt32(0),
                    Nom = dr.GetString(1),
                    Prenom = dr.GetString(2),
                    Ville = dr.GetString(3),
                    Specialite = dr.GetString(4)
                };
                listeEleves.Add(e);
            }
            dr.Close();
            return listeEleves;
        }


    }
}
