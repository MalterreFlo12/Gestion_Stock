using MySqlConnector;
using System;
using System.Threading.Tasks;

namespace Tonton_primeur
{
    internal class Database
    {
        private readonly string _connectionString;

        public string ConnectionString => _connectionString;

        // Constructeur direct via une chaîne de connexion déjà prête
        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Constructeur via paramètres individuels
        public Database(string server, string database, string user, string password, uint port = 3306)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = server,
                UserID = user,
                Password = password,
                Database = database,
                Port = port,
            };
            _connectionString = builder.ConnectionString;
        }

        // Retourne une connexion prête à être ouverte
        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        // Version asynchrone, déjà ouverte
        public async Task<MySqlConnection> OpenConnectionAsync()
        {
            var connection = new MySqlConnection(_connectionString);
            try
            {
                await connection.OpenAsync();
                return connection;
            }
            catch (MySqlException ex)
            {
                connection.Dispose();
                throw new Exception("Échec de connexion à la base de données.", ex);
            }
        }
    }
}