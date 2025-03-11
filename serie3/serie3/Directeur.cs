using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3
{
    internal class Directeur:Personnel
    {
        static Directeur instance;
        private Directeur(string bureau, double salaire , double prime ,int code,string nom , string prenom) : base(bureau, salaire, prime,code,nom,prenom){}

        public static Directeur GetInstance(string bureau, double salaire, double prime, int code, string nom, string prenom)
        {
            if (instance == null)
            {     
                instance = new Directeur(bureau, salaire, prime, code, nom, prenom);
            }
            return instance;
        }
    }
}
