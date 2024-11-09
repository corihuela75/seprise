using Clinica_SePrise.Datos;
using System.Xml.Linq;

namespace Clinica_SePrise.Pacientes
{
    public partial class ListadoPacientes : Form
    {
        private String nombre;
        private int documento;
        private String direccion;
        private String telefono;
        private String email;
        private DateTime nacimiento;
        private int edad;
        private String genero;
        private String estado;
        private String obra;
        private String historia;


        public ListadoPacientes()
        {
            InitializeComponent();
        }

        private void ListadoPacientes_Load(object sender, EventArgs e)
        {
            // Llamamos al método para mostrar los pacientes cuando el formulario se carga
            MostrarPacientes();
        }

        private void MostrarPacientes()
        {
            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear una instancia de Paciente, pasando la conexión
            Paciente paciente = new Paciente(conexion);

            // Obtener todos los pacientes
            List<Paciente> pacientes = paciente.ObtenerTodosPacientes();

            // Limpiar el DataGridView antes de cargar nuevos datos
            dgvListadoPacientes.Rows.Clear();

            // Verifica si el DataGridView tiene columnas. Si no, las agrega.
            if (dgvListadoPacientes.Columns.Count == 0)
            {
                // Agregar las columnas al DataGridView
                dgvListadoPacientes.Columns.Add("Nombre", "Nombre");
                dgvListadoPacientes.Columns.Add("Documento", "Documento");
                dgvListadoPacientes.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
                dgvListadoPacientes.Columns.Add("Edad", "Edad");
                dgvListadoPacientes.Columns.Add("Genero", "Género");
                dgvListadoPacientes.Columns.Add("Telefono", "Teléfono");
                dgvListadoPacientes.Columns.Add("Direccion", "Dirección");
                dgvListadoPacientes.Columns.Add("Email", "Email");
                dgvListadoPacientes.Columns.Add("Estado", "Estado Civil");
                dgvListadoPacientes.Columns.Add("Historial", "Historial");
                dgvListadoPacientes.Columns.Add("ObraSocial", "Obra Social");
            }

            // Comprobar si hay pacientes en la lista
            if (pacientes.Count == 0)
            {
                MessageBox.Show("No se encontraron pacientes en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Recorrer la lista de pacientes y agregarlos al DataGridView
                foreach (Paciente p in pacientes)
                {
                    // Agregar cada paciente como una nueva fila
                    dgvListadoPacientes.Rows.Add(p.Nombre, p.Documento, p.FechaNacimiento.ToString("dd/MM/yyyy"), p.Edad, p.Genero, p.Telefono, p.Direccion, p.Email, p.Estado, p.Historial, p.ObraSocial);
                }
            }
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
