using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Fichier
    {
        private string Nom;
        private string Extension;
        private float Taille;

        public Fichier(string nom, string extension, float taille)
        {
            Nom = nom;
            Extension = extension;
            Taille = taille;
        }
        public string name
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string extn
        {
            get { return Extension; }
            set { Extension = value; }
        }
      public float taille
        {
            get { return Taille; }
            set { Taille = value; }
        }
    }

}
