using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Clinica_SePrise.Atencion
{
    public partial class AtencionPaciente : Form
    {
        private string documentoPaciente;

        public AtencionPaciente()
        {
            InitializeComponent();
        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            LlenarComboBoxPacientes();
        }

        private void LlenarComboBoxPacientes()
        {
            Conexion conexion = new Conexion();
            string query = "SELECT nombre_paci, doc_paci FROM paciente";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Desactivar temporalmente el evento para evitar ejecución prematura
                    cboPacientes.SelectedIndexChanged -= cboPacientes_SelectedIndexChanged;

                    cboPacientes.DataSource = dt;
                    cboPacientes.DisplayMember = "nombre_paci";  // Texto visible
                    cboPacientes.ValueMember = "doc_paci";       // Valor interno

                    // Volver a activar el evento después de cargar
                    cboPacientes.SelectedIndexChanged += cboPacientes_SelectedIndexChanged;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPacientes.SelectedValue != null)
            {
                string docPacienteSeleccionado = cboPacientes.SelectedValue.ToString();
                MostrarDatosPaciente(docPacienteSeleccionado);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            documentoPaciente = txtBuscarPaciente.Text.Trim();
            if (string.IsNullOrEmpty(documentoPaciente))
            {
                MessageBox.Show("Ingrese un número de documento para buscar.", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            MostrarDatosPaciente(documentoPaciente);
        }

        private void MostrarDatosPaciente(string docPaciente)
        {
            Conexion conexion = new Conexion();
            string query = "SELECT nombre_paci, doc_paci, fecha_nac_paci, obra_social_paci FROM paciente WHERE doc_paci = @paciente";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@paciente", docPaciente);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblNombre.Text = reader["nombre_paci"].ToString();
                        lblDocumento.Text = reader["doc_paci"].ToString();
                        lblFechaNacimiento.Text = Convert.ToDateTime(reader["fecha_nac_paci"]).ToString("dd/MM/yyyy");
                        lblObraSocial.Text = reader["obra_social_paci"].ToString();

                        CargarHistoriaClinica(docPaciente);
                        // Limpiar los campos de búsqueda
                        txtBuscarPaciente.Text = ""; // Borra el contenido del TextBox de búsqueda
                        cboPacientes.SelectedIndex = -1; // Quita la selección en el ComboBox
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


        private void CargarHistoriaClinica(String docPacienteStr)
        {
            // Intentar convertir el documento del paciente a int
            if (!int.TryParse(docPacienteStr, out int docPaciente))
            {
                MessageBox.Show("El documento ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conexion conexion = new Conexion();
            string query = "SELECT historial_paci FROM paciente WHERE doc_paci = @docPaciente";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@docPaciente", docPaciente);

                    string historiaClinica = command.ExecuteScalar()?.ToString();
                    if (historiaClinica != null)
                    {
                        richTextBoxHistoria.Text = historiaClinica;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la historia clínica para este paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la historia clínica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
