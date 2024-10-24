using MySql.Data.MySqlClient;
using System;


namespace Clinica_SePrise.Datos
{
    public class Medico
    {
        private Conexion conexion;

        public Medico(Conexion conexion)
        {
            this.conexion = conexion;
        }

        // CREAR MEDICO

        public void InsertarMedico(string nombre, int matricula, string especialidad,
            string telefono, string email)
        {
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO medico (nombre_medi, matricula, especialidad," +
                        " tel_medi, email_medi) VALUES (@nombre, @apellido, @matricula, @especialidad, @telefono," +
                        " @email)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@matricula", matricula);
                        command.Parameters.AddWithValue("@especialidad", especialidad);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("El médico ha sido añadido a la base de datos correctamente.",
                                            "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el médico. Verifique los datos y la conexión a la base de datos.",
                            "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error al insertar el médico: {ex.Message}");
                }
            }
        }
    }
}