using MySql.Data.MySqlClient;
using System;



namespace Clinica_SePrise.Datos
{
    public class Usuario
    {
        private Conexion conexion;

        public Usuario(Conexion conexion)
        {
            this.conexion = conexion;
        }

        // CREAR USUARIO

        public void InsertarUsuario(string nombre, string contraseña, int rol)
        {
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO usuario (NombreUsu, PassUsu, RolUsu) VALUES (@nombre," +
                        " @contraseña, @rol)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        command.Parameters.AddWithValue("@rol", rol);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Usuario insertado exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar el usuario. Verifique los datos y la conexión a la base de datos.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error al insertar el usuario: {ex.Message}");
                }
            }
        }
    }
}