using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3
{
    internal abstract class Personnel:Personne
    {
        private string bureau;
        private double salaire;
        private double prime;

        public Personnel(string bureau, double salaire, double prime, int code, string nom, string prenom):base(code, nom , prenom)
        {
            this.bureau = bureau;
            this.salaire = salaire;
            this.prime = prime;
        }
        public string Bureau
        {
            get { return bureau; }
            set { bureau = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public double Prime
        {
            get { return prime; }
            set { prime = value; }
        }
    }
}
