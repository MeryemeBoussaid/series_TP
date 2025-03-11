using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3
{
    internal class Groupe
    {
        string nom;
        List<Etudiant> LE;

        public Groupe(string nom)
        {
            this.nom = nom;
            LE = new List<Etudiant>();
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public void Ajouter_etudiant(Etudiant etd)
        {
            foreach (Etudiant e in LE) 
            { 
                if(etd.Code == e.Code)
                {
                    Console.WriteLine(" etudiant deja existant ");
                    return;
                }
            }
            LE.Add(etd);
            Console.WriteLine("etudiant ajoute avec succes");
        }
    }
}
