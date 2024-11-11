using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Clinica_SePrise
{
    public partial class ConfigForm : Form
    {
        private Conexion conexion;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var config = new DatabaseConfig
            {
                MySqlConnection = new MySqlConfig
                {
                    Server = txtServer.Text,
                    Database = txtDatabase.Text,
                    User = txtUser.Text,
                    Password = txtPassword.Text
                }
            };

            try
            {
                // Serializar el objeto completo DatabaseConfig en lugar de MySqlConfig usando System.Text.Json
                var jsonContent = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("config.json", jsonContent);
                MessageBox.Show("Configuración guardada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar configuración: {ex.Message}");
            }

            try
            {
                // Crear una instancia de la clase Conexion
                conexion = new Conexion();

                // Probar la conexión después de guardar la configuración
                if (!conexion.TestConnection()) // Usar el método TestConnection de la clase Conexion
                {
                    MessageBox.Show("No se pudo establecer una conexión con la base de datos. Verifique la configuración. " +
                        "Edite manualmente el archivo config.json o borrelo y vuelva a ejecutar el programa para completar " +
                        "nuevamente el formulario de conexion", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); // Cerrar la aplicación si la conexión falla
                }
                else
                {
                    MessageBox.Show("Conexión a la base de datos exitosa.", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close(); // Cerrar formulario y continuar con la aplicación
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar configuración: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
