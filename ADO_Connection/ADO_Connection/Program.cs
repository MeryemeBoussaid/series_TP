using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ADO_Connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionEleve gestionEleve = new GestionEleve();

            // ajouter eleve 

            Eleve nouvelEleve = new Eleve("Boussaid", "Meryeme", "Fes", "Informatique");
            gestionEleve.ajouter(nouvelEleve);
            Console.WriteLine("Élève ajouté avec succès !");

            // Modifier un élève (supposons que l'élève ajouté a l'ID 1)
            nouvelEleve.Code = 1;
            nouvelEleve.Ville = "Casablanca"; // Changer la ville
            gestionEleve.modifier(nouvelEleve);
            Console.WriteLine("Élève modifié avec succès !");

            // Afficher un élève spécifique
            Eleve eleveTrouve = gestionEleve.rechercher(1);
            if (eleveTrouve != null)
            {
                Console.WriteLine($"Élève trouvé : {eleveTrouve.Nom} {eleveTrouve.Prenom} - {eleveTrouve.Ville} - {eleveTrouve.Specialite}");
            }
            else
            {
                Console.WriteLine("Élève non trouvé !");
            }

            // Afficher tous les élèves
            List<Eleve> listeEleves = gestionEleve.liste();
            Console.WriteLine("Liste des élèves :");
            foreach (Eleve e in listeEleves)
            {
                Console.WriteLine($"{e.Code} - {e.Nom} {e.Prenom} - {e.Ville} - {e.Specialite}");
            }

            // Supprimer un élève
            gestionEleve.supprimer(1);
            Console.WriteLine("Élève supprimé avec succès !");

        }
    }
}