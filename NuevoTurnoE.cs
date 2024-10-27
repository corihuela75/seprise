using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;


namespace Clinica_SePrise.TurnoE

{
    public partial class NuevoTurnoE : Form
    {
        public NuevoTurnoE()
        {
            InitializeComponent();
        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            LlenarComboBoxEspecialidades();
        }

        private void LlenarComboBoxEspecialidades()
        {
            Conexion conexion = new Conexion();
            string query = "SELECT DISTINCT especialidad FROM medico"; // Ajusta la consulta según tu base de datos

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cboEspecialidad.DataSource = dt;
                    cboEspecialidad.DisplayMember = "especialidad";
                    cboEspecialidad.ValueMember = "especialidad";

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
