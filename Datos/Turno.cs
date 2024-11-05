using MySql.Data.MySqlClient;
using System;


namespace Clinica_SePrise.Datos
{
    public class Turno
    {
        private Conexion conexion;

        public Turno(Conexion conexion)
        {
            this.conexion = conexion;
        }

        // CREAR TURNO

        public void InsertarTurno(int consultorio, string medico, string especialidad, int paciente, DateTime fecha, string hora_inicio, string hora_fin,
            string turno_periodo, int duracion, string pago, string estado,bool fromAgenda = false)
        {
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO turnos (consultorio, medico, especialidad, paciente, fecha, hora_inicio," +
                        " hora_fin, turno_periodo, duracion, pago, estado) VALUES (@consultorio, @medicoId, @especialidad, @pacienteId," +
                        " @fecha, @horaInicio, @horaFin, @turnoPeriodo, @duracion, @pago, @estado)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@consultorio", consultorio);
                        command.Parameters.AddWithValue("@medicoId", medico);
                        command.Parameters.AddWithValue("@especialidad", especialidad);
                        command.Parameters.AddWithValue("@pacienteId", paciente);
                        command.Parameters.AddWithValue("@fecha", fecha);
                        command.Parameters.AddWithValue("@horaInicio", hora_inicio);
                        command.Parameters.AddWithValue("@horaFin", hora_fin);
                        command.Parameters.AddWithValue("@turnoPeriodo", turno_periodo);
                        command.Parameters.AddWithValue("@duracion", duracion);
                        command.Parameters.AddWithValue("@pago", pago);
                        command.Parameters.AddWithValue("@estado", estado);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (fromAgenda) { return; }
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("El turno a sido añadido a la base de datos correctamente ",
                                         "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el turno. Verifique los datos y la conexión a la base de datos.",
                                        "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al insertar el turno: {ex.Message}",
                                 "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}