using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Clinica_SePrise.Diagnosticar
{
    public partial class Diagnostico : Form
    {
        private int pacienteId;
        //DATOS LOGIN
        private string name;
        private string rol;
        private int id;

        public Diagnostico(int idPaciente, int id, string name, string rol)
        {
            InitializeComponent();
            this.pacienteId = idPaciente;
            MostrarDatosPaciente(pacienteId);
            this.name = name;
            this.id = id;
            this.rol = rol;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + name.ToUpper() + " (Id: " + id.ToString() + ") " + "\nROL: " + rol.ToUpper();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MostrarDatosPaciente(int idPaciente)
        {
            Conexion conexion = new Conexion();
            string query = "SELECT cod_paci, nombre_paci, doc_paci, fecha_nac_paci, obra_social_paci FROM paciente WHERE cod_paci = @paciente";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@paciente", idPaciente);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool camposCompletos = true;

            // Verificar si cada RichTextBox tiene texto; si no, cambia el color de fondo a rojo
            if (string.IsNullOrWhiteSpace(richConsulta.Text))
            {
                richConsulta.BackColor = Color.LightCoral; // Rojo claro para indicar error
                camposCompletos = false;
            }
            else
            {
                richConsulta.BackColor = Color.White; // Color original si está completo
            }

            if (string.IsNullOrWhiteSpace(richExamen.Text))
            {
                richExamen.BackColor = Color.LightCoral;
                camposCompletos = false;
            }
            else
            {
                richExamen.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(richDiagnostico.Text))
            {
                richDiagnostico.BackColor = Color.LightCoral;
                camposCompletos = false;
            }
            else
            {
                richDiagnostico.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(richTratamiento.Text))
            {
                richTratamiento.BackColor = Color.LightCoral;
                camposCompletos = false;
            }
            else
            {
                richTratamiento.BackColor = Color.White;
            }

            // Si todos los campos están completos, procede con la acción
            if (camposCompletos)
            {

                // Concatenar el contenido de los RichTextBox
                string nuevoContenido = $"\n\nREGISTRO DE ATENCION MEDICA DE FECHA: {DateTime.Today.ToString("dd/MM/yyyy")}" +
                    $"\n--------------------------------------------------------------" +
                    $"\n\nMotivo de la consulta:\n{richConsulta.Text}" +
                    $"\n\nHistoria Médica:\n{richHistoria.Text}" +
                    $"\n\nExámenn Físico:\n{richExamen.Text}" +
                    $"\n\nDiagnóstico:\n{richDiagnostico.Text}" +
                    $"\n\nTratamiento:\n{richTratamiento.Text}" +
                    $"\n\nNotas:\n{richNotas.Text}" +
                    $"\n\nMédico: {name}" +
                    $"\nHora: {DateTime.Now.ToString("HH:mm")}";

                // Ahora guarda el contenido concatenado en la base de datos
                AgregarContenidoEnBaseDeDatos(nuevoContenido);

                // Aquí puedes agregar un mensaje de éxito o cualquier otra acción después de registrar
                MessageBox.Show("Contenido registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregarContenidoEnBaseDeDatos(string nuevoContenido)
        {
            Conexion conexion = new Conexion();
            string query = "SELECT historial_paci FROM paciente WHERE cod_paci = @pacienteId"; // Obtener contenido actual

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Recuperar el contenido actual
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@pacienteId", pacienteId);
                    string contenidoActual = command.ExecuteScalar()?.ToString() ?? string.Empty; // Maneja si no hay contenido

                    // Concatenar el contenido existente con el nuevo
                    string contenidoFinal = $"{contenidoActual}\n{nuevoContenido}";

                    // Actualizar el campo en la base de datos
                    string updateQuery = "UPDATE paciente SET historial_paci = @contenido WHERE cod_paci = @pacienteId";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@contenido", contenidoFinal);
                    updateCommand.Parameters.AddWithValue("@pacienteId", pacienteId);

                    updateCommand.ExecuteNonQuery(); // Ejecuta la consulta de actualización
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
