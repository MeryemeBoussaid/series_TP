using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections;
namespace Serie2.TP1
{
    internal class GestionEmployes
    {
        int Nbr_Employee;
        List<Employee> emp = new List<Employee>();

        public void AjouterEmployee(Employee e)
        { 
            emp.Add(e);
        }
        public void SupprimerEmployee(Employee e)
        {
            if (emp.Contains(e))
            {
                emp.Remove(e);
            }
            Console.WriteLine("L'employee n'existe pas");
        }
        public double CalculSalTotal()
        {
            double Total = 0;
            foreach (var employe in emp)
            {
                Total += employe.Salaire;
            }
            return Total;
        }
        public double SalaireMoyen()
        {
            if (emp.Count!=0)
            {
                double moy = CalculSalTotal() / emp.Count;
            return moy;
            }
            return 0;
        }
    }
}
