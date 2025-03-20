using System;
using System.Collections.Generic;
using bibliotheque;

public class Program
{
    static void Main(string[] args)
    {
        // Crée une instance de connexion MySQL
        Iconnexion connexion = Connexion.GetInstance("db_c#");

        // Crée une instance de DAO pour l'entité Eleve
        var dao = new DAO<Eleve>(connexion);

        // Test de la méthode Add
        var newEleve = new Eleve { Nom = "Boussaid", Prenom = "Meryeme", Ville = "Fes", Specialite = "Informatique" };
        dao.Add(newEleve);
        Console.WriteLine("Eleve ajouté");

        // Test de la méthode Get (récupérer l'élève par son code)
        var eleve = dao.Get(5); // Supposons que l'ID du nouvel élève est 2
        if (eleve != null)
        {
            Console.WriteLine($"Eleve récupéré: {eleve.Nom}, {eleve.Prenom}, {eleve.Ville}, {eleve.Specialite}");
        }

        // Test de la méthode Update
        if (eleve != null)
        {
            eleve.Prenom = "Rachid updated"; // Met à jour le prénom de l'élève
            dao.Update(eleve); // Met à jour l'élève dans la base de données
            Console.WriteLine("Eleve mis à jour");
        }

        // Test de la méthode Delete
        dao.Delete(4);  // Supposons que l'ID de l'élève à supprimer est 2
        Console.WriteLine("Eleve supprimé");

        // Test de la méthode GetAll
        var allEleves = dao.GetAll();
        foreach (var e in allEleves)
        {
            Console.WriteLine($"{e.Nom}, {e.Prenom}, {e.Ville}, {e.Specialite}");
        }
    }
}
