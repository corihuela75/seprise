using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Clinica_SePrise.Datos
{
    public class Paciente
    {
        // Propiedades del paciente
        public string Nombre { get; set; }
        public int Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public string Historial { get; set; }
        public string ObraSocial { get; set; }


        // Referencia a la clase de conexión que maneja la conexión con la base de datos
        private Conexion conexion;

        // Constructor que recibe una instancia de la conexión
        public Paciente(Conexion conexion)
        {
            this.conexion = conexion; // Asignamos la conexión a un campo de la clase
        }


        // CREAR PACIENTE

        public void InsertarPaciente(string nombre, int documento, DateTime nacimiento,
            int edad, string genero, string telefono, string direccion, string email,
            string estado, string historial, string obrasocial)


        {
            // Abrimos una conexión con la base de datos
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO paciente (nombre_paci, doc_paci, fecha_nac_paci," +
                        "edad_paci, genero_paci, tel_paci, direccion_paci, email_paci, estado_civil_paci," +
                        "historial_paci, obra_social_paci) VALUES " +
                        "(@nombre, @documento, @nacimiento, @edad, @genero, @telefono, @direccion, @email," +
                        "@estado, @historial, @obrasocial)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@documento", documento);
                        command.Parameters.AddWithValue("@nacimiento", nacimiento.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@edad", edad);
                        command.Parameters.AddWithValue("@genero", genero);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@direccion", direccion);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@estado", estado);
                        command.Parameters.AddWithValue("@historial", historial);
                        command.Parameters.AddWithValue("@obrasocial", obrasocial);
                        // Ejecuta la consulta SQL (INSERT)
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("El paciente a sido añadido a la base de datos correctamente ",
                             "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Console.WriteLine("No se pudo insertar el registro.");
                            MessageBox.Show("No se pudo insertar el médico.Verifique los datos y la conexión a la base de datos. ",
                              "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex) // Captura cualquier excepción que ocurra durante la operación
                {
                    Debug.WriteLine($"Error al insertar el registro: {ex.Message}");
                    Debug.WriteLine(ex.StackTrace); // Esto te mostrará más detalles sobre el error
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Método para obtener todos los pacientes de la base de datos
        public List<Paciente> ObtenerTodosPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();

            // Abrimos una conexión con la base de datos
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM paciente"; // Consulta SQL para obtener todos los pacientes
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Crear una nueva instancia de Paciente para cada registro
                                Paciente paciente = new Paciente(conexion)
                                {
                                    Nombre = reader["nombre_paci"].ToString(),
                                    Documento = Convert.ToInt32(reader["doc_paci"]),
                                    FechaNacimiento = Convert.ToDateTime(reader["fecha_nac_paci"]),
                                    Edad = Convert.ToInt32(reader["edad_paci"]),
                                    Genero = reader["genero_paci"].ToString(),
                                    Telefono = reader["tel_paci"].ToString(),
                                    Direccion = reader["direccion_paci"].ToString(),
                                    Email = reader["email_paci"].ToString(),
                                    Estado = reader["estado_civil_paci"].ToString(),
                                    Historial = reader["historial_paci"].ToString(),
                                    ObraSocial = reader["obra_social_paci"].ToString()
                                };

                                pacientes.Add(paciente);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error al obtener los registros: {ex.Message}");
                    Debug.WriteLine(ex.StackTrace); // Esto te mostrará más detalles sobre el error
                    MessageBox.Show("Error al obtener los pacientes de la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return pacientes;
        }
    }
}







