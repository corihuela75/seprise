using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Clinica_SePrise.Datos;
using Microsoft.VisualBasic.Logging;

namespace Clinica_SePrise
{
    internal static class Program
    {
        static void Main()
        {
            // Inicializar configuración de la aplicación
            ApplicationConfiguration.Initialize();

            // Verificar si config.json está configurado correctamente
            if (!IsConfigValid())
            {
                // Si la configuración no es válida, mostrar el formulario de configuración
                MessageBox.Show("La configuración de la base de datos no es válida o está incompleta. Por favor, configúrela antes de continuar.", "Configuración requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Run(new ConfigForm()); // Cargar formulario de configuración
            }

            // Después de confirmar que la configuración es válida, cargar el formulario de inicio de sesión
            Application.Run(new Login());
        }

        // Método para verificar la validez del archivo de configuración
        private static bool IsConfigValid()
        {
            try
            {
                // Verificar si el archivo config.json existe
                if (!File.Exists("config.json"))
                {
                    return false;
                }

                // Leer y deserializar el contenido del archivo config.json
                var configContent = File.ReadAllText("config.json");
                var config = JsonSerializer.Deserialize<DatabaseConfig>(configContent);

                // Verificar que todos los campos necesarios tengan valores
                return config?.MySqlConnection != null &&
                       !string.IsNullOrWhiteSpace(config.MySqlConnection.Server) &&
                       !string.IsNullOrWhiteSpace(config.MySqlConnection.Database) &&
                       !string.IsNullOrWhiteSpace(config.MySqlConnection.User) &&
                       !string.IsNullOrWhiteSpace(config.MySqlConnection.Password);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar la configuración: {ex.Message}");
                return false;
            }
        }

    }

    public class Config
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
