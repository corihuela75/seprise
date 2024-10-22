using Clinica_SePrise.Datos;

namespace Clinica_SePrise.Pacientes
{
    public partial class NuevoPaciente : Form
    {
        private String nombre;
        private int documento;
        private String direccion;
        private String telefono;
        private String email;
        private String nacimiento;
        private int edad;
        private String genero;
        private String estado;
        private String obra;
        private String historia;

        public NuevoPaciente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu principal = new Menu();
            principal.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDocu.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNacimiento.Text = "";
            txtEdad.Text = "";
            cboGenero.Text = "";
            cboEstado.Text = "";
            txtObra.Text = "";
            txtHistoria.Text = "";
            txtNombre.Focus();
        }
        //COMPROBAMOS INGRESO DE CAMPOS OBLIGATORIOS
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDocu.Text == "" || txtEmail.Text == "" || txtNacimiento.Text == ""
                || cboGenero.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombre = txtNombre.Text;
                documento = Int32.Parse(txtDocu.Text);
                direccion = txtDireccion.Text;
                telefono = txtTelefono.Text;
                email = txtEmail.Text;
                nacimiento = txtNacimiento.Text;
                edad = Int32.Parse(txtEdad.Text);
                genero = cboGenero.Text;
                estado = cboEstado.Text;
                obra = txtObra.Text;
                historia = txtHistoria.Text;

                // Crear una instancia de la clase Conexion
                Conexion conexion = new Conexion();

                // Crear una instancia de Paciente, pasando la conexión
                Paciente pacienteNuevo = new Paciente(conexion);

                // Insertar un nuevo paciente
                pacienteNuevo.InsertarPaciente(nombre, documento, nacimiento,edad,genero, telefono,
                  direccion, email, estado, historia, obra);

                MessageBox.Show("El paciente a sido añadido a la base de datos correctamente ",
                             "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu principal = new Menu();
                principal.Show();
                this.Close();
            }
        }
    }
}
