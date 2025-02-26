using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Repertoire
    {
        private string Nom;
        private int Nbr_fichiers;
        private Fichier[] files; 

        public Repertoire(string nom, int nbr_fichiers)
        {
            Nom = nom;
            Nbr_fichiers = nbr_fichiers;
            files = new Fichier[30];
        }
        public string name
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public int nbr_F
        {
            get { return Nbr_fichiers; }
            set { Nbr_fichiers = value; }
        }
        public void Afficher()
        {
            Console.WriteLine("Le nom du repertoire est : "+Nom);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine("Fichier : "+files[i]);
            }
        }
        public int Rechercher(string nom)
        {
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].name == nom) {  return i; } 
            }
            return -1;
        }
        public void Ajouter(Fichier fich)
        {
            if (Nbr_fichiers < 30)
            {
                files[Nbr_fichiers] = new Fichier(fich.name, fich.extn, fich.taille);
                //si le repertoire vide => nbr_fchier=0 => on insere dans files[0]
                //si le repertoire non vide (on suppose contient 5 elements) => nbr_fihiers=5 =>on insere dans files[5]
                Nbr_fichiers++;
            }
            else
                Console.WriteLine("Le repertoire est plein");
        }
        public void Rechercher()
        {
            for(int i = 0;i < files.Length; i++)
            {
                if (files[i].extn == "pdf")
                    Console.WriteLine("fichier qui porte l'extension pdf :" + files[i]);
            }
        }
        public void Supprimer(string nom)
        {
            
            int pos = Rechercher(nom);
            if (pos != Nbr_fichiers - 1)
            {
                files[pos] = files[pos + 1];
                Nbr_fichiers--;
            }
            else if (pos == Nbr_fichiers - 1)
            {
                Nbr_fichiers--;
            }
            else
                Console.WriteLine("Il n'y a pas de fichier qui porte ce nom");
        }
        public void Renommer(string nom)
        {
            int pos = Rechercher(nom);
            if (pos != -1)
            {
                files[pos].name = nom;
            }
            else
                Console.WriteLine("Il n'existe pas de fichier avec ce nom");
        }

        public void Modifier(float taille, string nom)
        {
            int pos = Rechercher(nom);
            if (pos != -1)
            {
                files[pos].taille = taille;
            }
            else
                Console.WriteLine("Il n'existe pas de fichier avec ce nom");
        }
        public float getTaille()
        {
            float somme=0;
            for (int i = 0; i < files.Length; i++)
            {
                somme += files[i].taille; 
            }
            return somme/1000;
        }
    }
}
