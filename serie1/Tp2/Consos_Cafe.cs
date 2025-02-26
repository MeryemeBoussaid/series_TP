using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    internal class Consos_Cafe
    {
        private int no_semaine;
        private int programmeur;
        private int nb_tasses;

        public int num_semaine
        {
            get { return no_semaine; }
            set { no_semaine = value; }
        }
        public int prog
        {
            get { return programmeur; }
            set { programmeur = value; }
        }
        public int nbr_tasses
        {
            get { return nb_tasses; }
            set { nb_tasses = value; }
        }
        public Consos_Cafe(int no_semaine=0, int programmeur=0, int nb_tasses=0)
        {
            this.no_semaine = no_semaine;
            this.programmeur = programmeur;
            this.nb_tasses = nb_tasses;
        }

    }
}
