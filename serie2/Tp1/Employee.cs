using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie2.TP1
{
    internal class Employee
    {
        string Nom;
        float salaire;
        string poste;
        string date_embauche;
        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public float Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }
        public string Date_embauche
        {
            get { return date_embauche; }
            set { date_embauche = value; }
        }
        public Employee(string Nom, float Salaire, string Poste, string Date_embauche)
        {
            this.Nom = Nom;
            this.Salaire = Salaire;
            this.Poste = Poste;
            this.Date_embauche = Date_embauche;
        }
      
    }
}