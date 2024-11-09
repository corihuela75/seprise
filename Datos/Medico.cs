using MySql.Data.MySqlClient;
using System;


namespace Clinica_SePrise.Datos
{
    public class Medico
    {
        private Conexion conexion;

        // Propiedades para la clase Medico
        public string Nombre { get; set; }
        public int Matricula { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

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
                        " tel_medi, email_medi) VALUES (@nombre, @matricula, @especialidad, @telefono, @email" +
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
                    MessageBox.Show($"Error al insertar el médico: {ex.Message}");
                }
            }
        }
        // OBTENER TODOS LOS MÉDICOS
        public List<Medico> ObtenerTodosMedicos()
        {
            List<Medico> medicos = new List<Medico>();

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT nombre_medi, matricula, especialidad, tel_medi, email_medi FROM medico";
                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Medico medico = new Medico(conexion)
                            {
                                Nombre = reader.GetString("nombre_medi"),
                                Matricula = reader.GetInt32("matricula"),
                                Especialidad = reader.GetString("especialidad"),
                                Telefono = reader.GetString("tel_medi"),
                                Email = reader.GetString("email_medi")
                            };
                            medicos.Add(medico);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al obtener los médicos: {ex.Message}");
                }
            }
            return medicos;
        }
    }
}