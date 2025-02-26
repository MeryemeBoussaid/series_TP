using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie2.TP1
{
    internal class Directeur
    {
        GestionEmployes GestEmp;
        static Directeur instance;
        private Directeur()
        {
         GestEmp = new GestionEmployes();
        }
        public void setGestionEmployes(GestionEmployes Gemp)
        {
            GestEmp = Gemp;
        }
        public static Directeur getInstance()
        {
            if (instance == null)
            {
                instance = new Directeur();
            }
            return instance;
        }

        public double SalaireTotalEmp()
        {
            return GestEmp.CalculSalTotal();
        }
        public double SalaireMoyEmp()
        {
            return GestEmp.SalaireMoyen();
        }
    }
}
