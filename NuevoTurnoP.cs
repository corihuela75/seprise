﻿using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Clinica_SePrise.TurnoP
{
    public partial class NuevoTurnoP : Form
    {
        private string documentoPaciente;
        public NuevoTurnoP()
        {
            InitializeComponent();
        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            LlenarComboBoxMedicos();
        }

        private void LlenarComboBoxMedicos()
        {
            Conexion conexion = new Conexion();
            string query = "SELECT nombre_medi FROM medico";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cboMedico.DataSource = dt;
                    cboMedico.DisplayMember = "nombre_medi";
                    cboMedico.ValueMember = "nombre_medi";

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTurnosDisponibles(cboMedico.SelectedValue.ToString());
        }

        private void CargarTurnosDisponibles(string medico)
        {
            Conexion conexion = new Conexion();
            string query = "SELECT Id_turno, fecha, hora_inicio, hora_fin, estado FROM turnos WHERE" +
                "  estado = 'Disponible' AND medico = @medico";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@medico", medico);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dataGridViewTurnos.DataSource = dt;

                    // Cambiamos los títulos de las columnas
                    dataGridViewTurnos.Columns["Id_turno"].HeaderText = "ID del Turno";
                    dataGridViewTurnos.Columns["fecha"].HeaderText = "Fecha";
                    dataGridViewTurnos.Columns["hora_inicio"].HeaderText = "Hora de Inicio";
                    dataGridViewTurnos.Columns["hora_fin"].HeaderText = "Hora de Fin";
                    dataGridViewTurnos.Columns["estado"].HeaderText = "Estado";

                    // Ajustamos el ancho de las columnas
                    dataGridViewTurnos.Columns["Id_turno"].Width = 90;
                    dataGridViewTurnos.Columns["fecha"].Width = 120;
                    dataGridViewTurnos.Columns["hora_inicio"].Width = 100;
                    dataGridViewTurnos.Columns["hora_fin"].Width = 100;
                    dataGridViewTurnos.Columns["estado"].Width = 160;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            documentoPaciente = txtBuscarPaciente.Text.Trim();
            if (string.IsNullOrEmpty(documentoPaciente))
            {
                MessageBox.Show("Ingrese un número de documento para buscar.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Conexion conexion = new Conexion();
            string query = "SELECT nombre_paci, doc_paci, fecha_nac_paci, obra_social_paci FROM paciente WHERE doc_paci = @paciente";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@paciente", documentoPaciente);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Asigna los datos obtenidos de la base de datos a los Label
                        lblNombre.Text = reader["nombre_paci"].ToString();
                        lblDocumento.Text = reader["doc_paci"].ToString();
                        lblFechaNacimiento.Text = Convert.ToDateTime(reader["fecha_nac_paci"]).ToString("dd/MM/yyyy");
                        lblObraSocial.Text = reader["obra_social_paci"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Paciente no encontrado.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // VERIFICAMOS EL ID DEL TURNO SELECCIONADO EN EL DATAGRID
        private int turnoSeleccionadoId;

        private void dataGridViewTurnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de la fila sea válido
            if (e.RowIndex >= 0)
            {
                // Obtén el valor del ID desde la columna 0 (ajusta el índice si está en otra columna)
                turnoSeleccionadoId = Convert.ToInt32(dataGridViewTurnos.Rows[e.RowIndex].Cells[0].Value);
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verifica si hay un turno seleccionado
            if (turnoSeleccionadoId > 0)
            {
                if (string.IsNullOrEmpty(documentoPaciente))
                {
                    MessageBox.Show("Verifique el documento del paciente para asignar el turno.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Conexion conexion = new Conexion();
                string query = "UPDATE turnos SET paciente = @paciente, estado = 'reservado' WHERE Id_turno = @turnoId";

                using (var connection = conexion.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@paciente", Convert.ToInt32(documentoPaciente));
                        command.Parameters.AddWithValue("@turnoId", turnoSeleccionadoId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Muestra un mensaje de confirmación con el ID del turno y los datos del paciente
                            string mensajeConfirmacion = $"El turno se ha registrado correctamente.\n\n" +
                                                         $"ID del Turno: {turnoSeleccionadoId}\n" +
                                                         $"Nombre del Paciente: {lblNombre.Text}\n" +
                                                         $"Documento: {lblDocumento.Text}\n" +
                                                         $"Fecha de Nacimiento: {lblFechaNacimiento.Text}\n" +
                                                         $"Obra Social: {lblObraSocial.Text}";

                            MessageBox.Show(mensajeConfirmacion, "TURNO REGISTRADO CORRECTAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Actualiza el DataGridView para reflejar el cambio y limpia el campo de Documento
                            CargarTurnosDisponibles(cboMedico.SelectedValue.ToString());
                            txtBuscarPaciente.Text = "";
                            documentoPaciente = "";
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el turno. Intente nuevamente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un turno antes de registrar.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado es un número o una tecla de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, boquea el carácter
                e.Handled = true;
            }
        }
    }
}

