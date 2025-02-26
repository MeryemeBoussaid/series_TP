using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    internal class Programmeur
    {
        private int id;
        private string nom;
        private string prenom;
        private int bureau;

        public int id_prog
        {
            get { return id; }
            set { id = value; }
        }
        public string name
        {
            get { return nom; }
            set { nom = value; }
        }
        public string lastname
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public int no_bureau
        {
            get { return bureau; }
            set { bureau = value; }
        }
        public Programmeur(int id, string nom, string prenom, int bureau)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.bureau = bureau;
        }
    }
}
