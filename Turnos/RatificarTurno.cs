using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;

namespace Clinica_SePrise.Turnos
{
    public partial class RatificarTurno : Form
    {
        private Conexion conn = new Conexion();

        private int idTurno;
        public RatificarTurno(string name)
        {
            InitializeComponent();
        }
        //declaramos la variable para ampliar su alcance
        private int consultorio;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdTurno.Text, out int numero);

            if (numero <= 0)
            {
                MessageBox.Show("El número ingresado es inválido", "MENSAJE DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (var connection = conn.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT consultorio, estado, paciente FROM turnos WHERE id_turno = @numero";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numero", numero);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string estadoTurno = reader.GetString("estado");
                            int idPaciente = reader.GetInt32("paciente");
                            consultorio = reader.GetInt32("consultorio");

                            if (estadoTurno == "reservado")
                            {
                                reader.Close(); // Cerramos el lector antes de realizar otra consulta

                                // Consulta adicional para obtener datos del paciente
                                string pacienteQuery = "SELECT nombre_paci, doc_paci, fecha_nac_paci, obra_social_paci FROM" +
                                    " paciente WHERE doc_paci = @idPaciente";

                                MySqlCommand pacienteCommand = new MySqlCommand(pacienteQuery, connection);
                                pacienteCommand.Parameters.AddWithValue("@idPaciente", idPaciente);

                                using (MySqlDataReader pacienteReader = pacienteCommand.ExecuteReader())
                                {
                                    if (pacienteReader.Read())
                                    {
                                        // Asigna los datos obtenidos de la base de datos a los Label
                                        lblNombre.Text = pacienteReader["nombre_paci"].ToString();
                                        lblDocumento.Text = pacienteReader["doc_paci"].ToString();
                                        lblFechaNacimiento.Text = Convert.ToDateTime(pacienteReader["fecha_nac_paci"]).ToString("dd/MM/yyyy");
                                        lblObraSocial.Text = pacienteReader["obra_social_paci"].ToString();


                                        if (pacienteReader["obra_social_paci"].ToString() == "")
                                        {
                                            rbtParticular.Checked = true;
                                            rbtObraSocial.Enabled = false;
                                        }
                                        else
                                        {
                                            rbtObraSocial.Enabled = true;
                                            rbtObraSocial.Checked = true;
                                        }
                                        rbtObraSocial.Text = "Obra Social : " + pacienteReader["obra_social_paci"].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se encontraron datos del paciente.", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show($"El turno no está en estado reservado.\n\n Se ecuentra {estadoTurno.ToUpper()}, por favor verifique.", "MENSAJE DEL SISTEMA",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Turno no encontrado, verifique el número ingresado.", "MENSAJE DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    connection.Close();
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRatificar_click(object sender, EventArgs e)
        {
            // Verifica si hay un número de turno válido
            if (!int.TryParse(txtIdTurno.Text, out int numero) || numero <= 0)
            {
                MessageBox.Show("El número ingresado es inválido.", "MENSAJE DEL SISTEMA",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            using (var connection = conn.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Determina el tipo de pago según el RadioButton seleccionado
                    string metodoPago = rbtParticular.Checked ? "Particular" : "Obra Social";

                    // Actualizamos el estado a "ratificado"
                    string updateQuery = "UPDATE turnos SET estado = 'ratificado', pago = @pago WHERE id_turno = @numero";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@numero", numero);
                    updateCommand.Parameters.AddWithValue("@pago", metodoPago);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El turno ha sido ratificado exitosamente.\n\n" +
                           "Debe dirigirse al consultorio:\n\n" +
                           $"---      {consultorio}      ---\n\n" +
                           "¡Gracias por su visita!",
                           "TURNO RATIFICADO",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

                        // Llama al método para resetear el formulario
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ratificar el turno. Intente nuevamente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        // Método para resetear el formulario
        private void ResetForm()
        {
            txtIdTurno.Text = string.Empty;
            lblNombre.Text = string.Empty;
            lblDocumento.Text = string.Empty;
            lblFechaNacimiento.Text = string.Empty;
            lblObraSocial.Text = string.Empty;
            rbtParticular.Checked = false;
            rbtObraSocial.Checked = false;
            rbtObraSocial.Enabled = true;
        }

        private void RatificarTurno_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtIdTurno.ResetText();
            dgvTurno.Visible = false;
        }

        private void btnRatificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = conn.GetConnection())
                {
                    connection.Open();
                    int id = this.idTurno;
                    string query = "UPDATE turnos SET estado = 'ratificado' WHERE id_turno = @id";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", this.idTurno);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Turno ratificado exitosamente y agregado a la lista de espera.");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar turno.");
                        }
                    }
                    connection.Close();
                }
            } catch
            {
                MessageBox.Show("No es posible realizar esta operación, por favor revise los campos ingresados.");
            }
        }
    }
}
