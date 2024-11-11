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
            // Inicializar configuraci�n de la aplicaci�n
            ApplicationConfiguration.Initialize();

            // Verificar si config.json est� configurado correctamente
            if (!IsConfigValid())
            {
                // Si la configuraci�n no es v�lida, mostrar el formulario de configuraci�n
                MessageBox.Show("La configuraci�n de la base de datos no es v�lida o est� incompleta. Por favor, config�rela antes de continuar.", "Configuraci�n requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Run(new ConfigForm()); // Cargar formulario de configuraci�n
            }

            // Despu�s de confirmar que la configuraci�n es v�lida, cargar el formulario de inicio de sesi�n
            Application.Run(new Login());
        }

        // M�todo para verificar la validez del archivo de configuraci�n
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
                Console.WriteLine($"Error al verificar la configuraci�n: {ex.Message}");
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
