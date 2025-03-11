using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3
{
    internal class Administratif:Personnel
    {
        public Administratif(string bureau,double salaire, double prime, int code,string nom, string prenom) : base(bureau, salaire, prime, code, nom, prenom) { }
    }
}
