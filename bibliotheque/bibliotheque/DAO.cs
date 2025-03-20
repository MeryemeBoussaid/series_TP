using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using bibliotheque;

public class DAO<T> : IDAO<T> where T : class
{
    private readonly Iconnexion connexion;

    // Constructeur qui reçoit la connexion pour l'utiliser dans les opérations CRUD
    public DAO(Iconnexion connexion)
    {
        this.connexion = connexion;
    }

    // Ajouter un objet dans la base de données
    public void Add(T entity)
    {
        string tableName = typeof(T).Name;
        var properties = typeof(T).GetProperties();

        string columns = string.Join(",", properties.Select(p => p.Name)); // Liste des colonnes
        string values = string.Join(",", properties.Select(p => $"'{p.GetValue(entity)}'")); // Valeurs à insérer

        string sql = $"INSERT INTO {tableName} ({columns}) VALUES ({values})";

        using (var cmd = new MySqlCommand(sql, ((Connexion)connexion).MySqlConnection))
        {
            connexion.OpenConnection();
            cmd.ExecuteNonQuery();
            connexion.CloseConnection();
        }
    }

    // Mettre à jour un objet dans la base de données
    public void Update(T entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "L'entité ne peut pas être nulle");
        }

        string tableName = typeof(T).Name;
        var properties = typeof(T).GetProperties();

        // Création de la clause SET
        string setClause = string.Join(",", properties.Select(p => $"{p.Name} = '{p.GetValue(entity)}'"));

        // Vérifiez si la propriété 'code' existe bien
        var codeProperty = typeof(T).GetProperty("code");
        if (codeProperty == null)
        {
            throw new InvalidOperationException("La propriété 'code' n'a pas été trouvée sur le type " + typeof(T).Name);
        }

        // Récupération de la valeur de 'code'
        var codeValue = codeProperty.GetValue(entity);

        // Construction de la requête SQL
        string sql = $"UPDATE {tableName} SET {setClause} WHERE code = '{codeValue}'";

        // Exécution de la commande SQL
        using (var cmd = new MySqlCommand(sql, ((Connexion)connexion).MySqlConnection))
        {
            connexion.OpenConnection();
            cmd.ExecuteNonQuery();
            connexion.CloseConnection();
        }
    }


    // Supprimer un objet de la base de données
    public void Delete(int id)
    {
        string tableName = typeof(T).Name;
        string sql = $"DELETE FROM {tableName} WHERE code = {id}";  // Utilisation de "code" au lieu de "Id"

        using (var cmd = new MySqlCommand(sql, ((Connexion)connexion).MySqlConnection))
        {
            connexion.OpenConnection();
            cmd.ExecuteNonQuery();
            connexion.CloseConnection();
        }
    }

    // Récupérer un objet par son code
    public T Get(int id)
    {
        string tableName = typeof(T).Name;
        string sql = $"SELECT * FROM {tableName} WHERE code = {id}";  // Utilisation de "code" au lieu de "Id"

        using (var cmd = new MySqlCommand(sql, ((Connexion)connexion).MySqlConnection))
        {
            connexion.OpenConnection();
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                T entity = Activator.CreateInstance<T>();
                foreach (var property in typeof(T).GetProperties())
                {
                    property.SetValue(entity, reader[property.Name]);
                }
                connexion.CloseConnection();
                return entity;
            }
            connexion.CloseConnection();
            return null;
        }
    }

    // Récupérer tous les objets d'un type donné
    public IEnumerable<T> GetAll()
    {
        List<T> entities = new List<T>();
        string tableName = typeof(T).Name;
        string sql = $"SELECT * FROM {tableName}";

        using (var cmd = new MySqlCommand(sql, ((Connexion)connexion).MySqlConnection))
        {
            connexion.OpenConnection();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                T entity = Activator.CreateInstance<T>();
                foreach (var property in typeof(T).GetProperties())
                {
                    property.SetValue(entity, reader[property.Name]);
                }
                entities.Add(entity);
            }
            connexion.CloseConnection();
        }
        return entities;
    }
}