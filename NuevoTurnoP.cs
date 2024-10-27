using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Clinica_SePrise.TurnoP
{
    public partial class NuevoTurnoP : Form
    {
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
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
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
            string query = "SELECT Id_turno, fecha, hora_inicio, hora_fin, estado FROM turnos WHERE  estado = 'Disponible' AND medico = @medico";

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
                    dataGridViewTurnos.Columns["hora_fin"].Width = 160;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string documentoPaciente = txtBuscarPaciente.Text.Trim();
            if (string.IsNullOrEmpty(documentoPaciente))
            {
                MessageBox.Show("Ingrese un número de documento para buscar.");
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
                        MessageBox.Show("Paciente no encontrado.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

