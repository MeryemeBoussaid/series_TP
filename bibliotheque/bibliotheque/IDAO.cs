using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque
{
    internal interface IDAO<T> where T : class
    
   
    {
        // Ajouter un objet à la base de données
        void Add(T entity);

        // Mettre à jour un objet dans la base de données
        void Update(T entity);

        // Supprimer un objet de la base de données
        void Delete(int id);

        // Récupérer un objet par son ID
        T Get(int id);

        // Récupérer tous les objets d'un type
        IEnumerable<T> GetAll();
    }

}
