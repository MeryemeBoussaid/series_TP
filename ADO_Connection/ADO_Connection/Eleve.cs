using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Connection
{
    internal class Eleve
    {
        int code;
        string nom;
        string prenom;
        string ville;
        string specialite;

        public Eleve(string nom=" ", string prenom=" ", string ville=" ", string specialite=" ")
        {
            
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
            this.specialite = specialite;
        }
        
        public int Code
        {
            get { return code; }
            set { code = value; }
            
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
        public string Ville
        {
            get { return ville; }
            set { ville = value; }

        }
        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }

        }


    }
}
