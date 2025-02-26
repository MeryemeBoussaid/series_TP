using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    internal class Projet
    {
        private int code;
        private string sujet;
        private int duree_semaine;
        private int nbr_programmeurs;
        private Programmeur[] pr;
        private Consos_Cafe[] cc;


        public int code_p
        {
            get { return code; }
            set { code = value; }
        }
        public string sujet_p
        {
            get { return sujet; }
            set { sujet = value; }
        }
        public int duree_s
        {
            get { return duree_semaine; }
            set {  duree_semaine = value; }
        }
        public int nbr_prog
        {
            get { return nbr_programmeurs; }
            set { nbr_programmeurs = value; }
        }
        public Projet(int code,string sujet, int duree_semaine, int nbr_programmeurs)
        {
            this.code = code;
            this.sujet = sujet;
            this.duree_semaine=duree_semaine;
            this.nbr_programmeurs=nbr_programmeurs;

        }
        public void Ajouter(Programmeur prog)
        {
            Programmeur P = new Programmeur(prog.id_prog, prog.name, prog.lastname, prog.no_bureau);
            nbr_programmeurs++;
        }
        public Programmeur Rechercher(int id)
        {
            for (int i = 0; i < pr.Length; i++)
            {
                if (pr[i].id_prog == id) { return pr[i]; }
            }
            return null;
        }
        public void Afficher(int id)
        {
            Programmeur prog = Rechercher(id);
            if (prog != null)
                Console.WriteLine("le programmeur est :" + prog);
            else Console.WriteLine("il n'existe aucun programmeur avec cet id");

        }
        public void Afficher_list()
        {
            Console.WriteLine("La liste des programmeurs :");
            for (int i = 0; i < pr.Length; i++)
                Console.WriteLine(pr[i]);
        }
        public void Supprimer(int id)
        {
            for(int i = 0;i < pr.Length;i++)
            {
                if(pr[i].id_prog == id)
                {
                    if(i!= pr.Length - 1)
                    {
                        pr[i] = pr[i+1];
                        nbr_programmeurs--;
                        return;
                    }
                    nbr_programmeurs--;
                    return;
                    
                }

                    
            }
            Console.WriteLine("id n'existe pas");


        }
        public int Total_tasses(int no_semaine)
        {
            int total = 0;
            for(int i = 0; i < cc.Length; i++)
            {
                if (cc[i].num_semaine == no_semaine)
                {
                    total += cc[i].nbr_tasses;
                }
            }
            return total;
        } 
        public void AjouterConsosCafe(int idProg ,int num_semaine , int nbr_tasses)
        {
            for (int i = 0; i < pr.Length; i++)
            {
                if( pr[i].id_prog == idProg)
                {
                    Consos_Cafe C = new Consos_Cafe(num_semaine,idProg,nbr_tasses);
                }
            }
        }

    }
}
