using Clinica_SePrise.Datos;
using System.Xml.Linq;

namespace Clinica_SePrise.Pacientes
{
    public partial class NuevoPaciente : Form
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
        //DATOS DE LOGIN
        private string name;
        private string rol;
        private int id;

        public NuevoPaciente(int id, string name, string rol)
        {
            this.name = name;
            this.id = id;
            this.rol = rol;
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + name.ToUpper() + " (Id: " + id.ToString() + ") " + "\nROL: " + rol.ToUpper();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.btnLimpiar_Click(sender, e);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDocu.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            dtpNacimiento.Value = DateTime.Now;
            cboGenero.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            txtObra.Text = "";
            txtHistoria.Text = "";
            txtEdad.ResetText();
            txtNombre.Focus();
        }
        //COMPROBAMOS INGRESO DE CAMPOS OBLIGATORIOS
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDocu.Text == "" || txtEmail.Text == "" || cboGenero.Text == "" ||
                txtDireccion.Text == "" || txtTelefono.Text == "")
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
                nacimiento = dtpNacimiento.Value;
                // Valida si txtEdad tiene valor antes de convertir
                if (!string.IsNullOrEmpty(txtEdad.Text))
                {
                    edad = Int32.Parse(txtEdad.Text);
                }
                genero = cboGenero.Text;
                estado = cboEstado.Text;
                obra = txtObra.Text;
                historia = txtHistoria.Text;

                // Crear una instancia de la clase Conexion
                Conexion conexion = new Conexion();

                // Crear una instancia de Paciente, pasando la conexión
                Paciente pacienteNuevo = new Paciente(conexion);

                // Insertar un nuevo paciente
                pacienteNuevo.InsertarPaciente(nombre, documento, nacimiento, edad, genero, telefono,
                  direccion, email, estado, historia, obra);

                // Limpiar el formulario
                // btnLimpiar_Click(sender, e);

                //Menu principal = new Menu();
                //principal.Show();
            }
        }


        // DESHABILITA EL INGRESO DE LETRAS EN CAMPO NUMERICO
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado es un número o una tecla de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, bloquea el carácter
                e.Handled = true;
            }
        }
        private void txtDocu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado es un número o una tecla de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, bloquea el carácter
                e.Handled = true;
            }
        }

        private void NuevoPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.btnLimpiar_Click(sender, e);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListadoPacientes listado = new ListadoPacientes();
            listado.Show();
        }
    }
}
