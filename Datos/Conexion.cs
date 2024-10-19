using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text.Json;

namespace Clinica_SePrise.Datos
{

    public class Conexion
    {
        private string? connectionString;

        public Conexion()
        {
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            // Ruta del archivo de configuración
            string configFilePath = "config.json";

            // Lee el archivo JSON
            string jsonContent = File.ReadAllText(configFilePath);

            // Parsear el contenido del archivo JSON
            var config = JsonSerializer.Deserialize<DatabaseConfig>(jsonContent);
       

            if (config != null && config.MySqlConnection != null)
            {
                // Construir la cadena de conexión
                connectionString = $"Server={config.MySqlConnection.Server};" +
                                   $"Database={config.MySqlConnection.Database};" +
                                   $"User={config.MySqlConnection.User};" +
                                   $"Password={config.MySqlConnection.Password};";
            }
            else
            {
                throw new Exception("Error al leer la configuración de la conexión MySQL.");
            }
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos MySQL.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
                }
            }
        }
    }

    // Clase que representa la estructura del archivo JSON
    public class DatabaseConfig
    {
        public MySqlConfig? MySqlConnection { get; set; }
    }

    public class MySqlConfig
    {
        public string? Server { get; set; }
        public string? Database { get; set; }
        public string? User { get; set; }
        public string? Password { get; set; }
    }


}