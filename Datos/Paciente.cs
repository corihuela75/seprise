using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_SePrise.Datos
{
    public class Paciente
    {
        // Referencia a la clase de conexión que maneja la conexión con la base de datos
        private Conexion conexion;

        // Constructor que recibe una instancia de la conexión
        public Paciente(Conexion conexion)
        {
            this.conexion = conexion; // Asignamos la conexión a un campo de la clase
        }


        // CREAR PACIENTE

        public void InsertarPaciente(string nombre, int documento, string nacimiento,
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
                        // Intentar convertir el string de nacimiento a DateTime para el formato adecuado en SQL
                        DateTime nacimientoDate;
                        if (DateTime.TryParse(nacimiento, out nacimientoDate))
                        {
                            command.Parameters.AddWithValue("@nacimiento", nacimientoDate.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            throw new Exception("El formato de fecha de nacimiento es incorrecto.");
                        }
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
                            Console.WriteLine("No se pudo insertar el registro.");
                            MessageBox.Show("No se pudo insertar el médico.Verifique los datos y la conexión a la base de datos. ",
                              "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex) // Captura cualquier excepción que ocurra durante la operación
                {
                    Console.WriteLine($"Error al insertar el registro: {ex.Message}");
                    Console.WriteLine(ex.StackTrace); // Esto te mostrará más detalles sobre el error

                }
            }
        }
    }
}







