using MySql.Data.MySqlClient;
using System.Text.Json;
using System.Diagnostics;

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

            try
            {
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
                    throw new Exception("La configuración de la base de datos es inválida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer la configuración de la base de datos: {ex.Message}",
                                "Error de configuración",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    Debug.WriteLine("*** Conexión exitosa a la base de datos MySQL.");
                    return true; // La conexión fue exitosa
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"*** Error al conectar a la base de datos: {ex.Message}");
                return false; // La conexión falló
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