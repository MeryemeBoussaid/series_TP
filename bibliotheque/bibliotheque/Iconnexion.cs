using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheque
{
    public  interface Iconnexion
    {
        void OpenConnection();

        // Fermer la connexion à la base de données
        void CloseConnection();

        // Vérifier si la connexion est ouverte
        bool IsConnectionOpen();
    }
}
