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

        public void InsertarMedico(string nombre, string apellido, int matricula, string especialidad,
            string telefono, string email)
        {
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO medico (nombre_medi, apellido_medi, matricula, especialidad," +
                        " tel_medi, email_medi) VALUES (@nombre, @apellido, @matricula, @especialidad, @telefono," +
                        " @email)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@matricula", matricula);
                        command.Parameters.AddWithValue("@especialidad", especialidad);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Médico insertado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar el médico. Verifique los datos y la conexión a la base de datos.");
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