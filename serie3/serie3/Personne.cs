using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3
{
    internal abstract class Personne
    {
        private int code;
        private string nom;
        private string prenom;

        public Personne(int code,string nom,string prenom)
        {
            this.code = code;  
            this.nom = nom;
            this.prenom = prenom;
        }
        public int Code
        {
            get { return code; }
            set {  code=value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
    }
}
