using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3
{
    internal class Etudiant: Personne
    {
        private string niveau;
        private double moyenne; //moyenne anuelle

        public Etudiant(string niveau , double moyenne, int code ,string nom,string prenom): base(code, nom, prenom)
        {
            this.niveau = niveau;
            this.moyenne = moyenne;
        }
        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        public double Moyenne
        {
            get { return moyenne; }
            set { moyenne = value; }
        }

    }
}
