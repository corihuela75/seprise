using Clinica_SePrise.Datos;
using System.Xml.Linq;

namespace Clinica_SePrise.Medicos
{
    public partial class ListadoMedicos : Form
    {
        public string Nombre;
        public int Matricula;
        public string Especialidad;
        public string Telefono;
        public string Email;


        public ListadoMedicos()
        {
            InitializeComponent();
        }

        private void ListadoMedicos_Load(object sender, EventArgs e)
        {
            // Llamamos al método para mostrar los pacientes cuando el formulario se carga
            MostrarMedicos();
        }

        private void MostrarMedicos()
        {
            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear una instancia de Paciente, pasando la conexión
            Medico medico = new Medico(conexion);

            // Obtener todos los pacientes
            List<Medico> medicos = medico.ObtenerTodosMedicos();

            //Limpiar el DataGridView antes de cargar nuevos datos
            dgvListadoMedicos.Rows.Clear();

            // Verifica si el DataGridView tiene columnas. Si no, las agrega.
            if (dgvListadoMedicos.Columns.Count == 0)
            {
                // Agregar las columnas al DataGridView
                dgvListadoMedicos.Columns.Add("Nombre", "Nombre");
                dgvListadoMedicos.Columns.Add("Matricula", "Matricula");
                dgvListadoMedicos.Columns.Add("Especialidad", "Especialidad");
                dgvListadoMedicos.Columns.Add("Telefono", "Telefono");
                dgvListadoMedicos.Columns.Add("Email", "Email");

                // Modificar el ancho de las columnas
                dgvListadoMedicos.Columns["Nombre"].Width = 180;
                dgvListadoMedicos.Columns["Matricula"].Width = 120;
                dgvListadoMedicos.Columns["Especialidad"].Width = 150;
                dgvListadoMedicos.Columns["Telefono"].Width = 130;
                dgvListadoMedicos.Columns["Email"].Width = 180;
            }

            // Comprobar si hay pacientes en la lista
            if (medicos.Count == 0)
            {
                MessageBox.Show("No se encontraron pacientes en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Recorrer la lista de medicos y agregarlos al DataGridView
                foreach (Medico m in medicos)
                {
                    // Agregar cada médico como una nueva fila en el DataGridView
                    dgvListadoMedicos.Rows.Add(m.Nombre, m.Matricula, m.Especialidad, m.Telefono, m.Email); ;
                }
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
