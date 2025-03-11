using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie3
{
    internal class Enseignant:Personnel
    {
        string grade;
        double VH;
        double nbr_hr_sup;
        Dictionary<string, List<Etudiant>> Grp;

        public Enseignant(string grade, double vH, double nbr_hr_sup,string bureau,double salaire, double prime, int code , string nom , string prenom): base(bureau, salaire, prime, code, nom, prenom) 
        {
            this.grade = grade;
            VH = vH;
            this.nbr_hr_sup = nbr_hr_sup;
        }
        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public double vh
        {
            get { return VH; }
            set { VH = value; }
        }
        public double Nbr_hr_sup
        {
            get { return nbr_hr_sup; }
            set { nbr_hr_sup = value; }
        }
        public void Ajouter_groupe(Groupe grp)
        {

        }

    }
}
