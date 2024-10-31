using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Clinica_SePrise
{
    public partial class Login : Form

    {
        private Conexion conexion;  // Campo para la conexión
        public Login()
        {
            conexion = new Conexion();
            InitializeComponent();
        }

        // Se prueba la conexion a la BD cuando se carga el formulario
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Probar la conexión a la base de datos al cargar el formulario
                conexion.TestConnection();
                Debug.WriteLine("*** Conexión a la base de datos exitosa.");
            }
            catch (Exception ex)
            {
                // Manejo de errores de conexión
                Debug.WriteLine($"*** Error al conectar a la base de datos: {ex.Message}");
            }
        }




        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando se va el foco */
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }
        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtPass.Text;

            using (var connection = conexion.GetConnection())
            {
                connection.Open();

                string query = "SELECT U.`RolUsu`, U.`NombreUsu`,R.`NomRol`,U.`activo` FROM(usuario as U INNER JOIN roles as R ON U.`RolUsu` = R.`RolUsu` ) WHERE NombreUsu = @usuario AND PassUsu = @contrasena";
               
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@contrasena", contrasena);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        int id = reader.GetInt16(0);
                        string name = reader.GetString(1);
                        string rol = reader.GetString(2);
                        bool active = reader.GetBoolean(3);

                        if (!active)
                        {
                            MessageBox.Show("Actualmente no posee permisos para ingresar \n Comuniquese con un administrador");
                        } else
                        {
                        // Usuario encontrado, login exitoso
                        Debug.WriteLine("*** Inicio de sesión exitoso.");
                        // CONTINUA CON EL MENU
                        Menu menu = new Menu(id,name,rol);
                        menu.Show(); // se llama al formulario principal
                        this.Hide(); // se oculta el formulario del login
                        }
                    }
                    else
                    {
                        // Usuario no encontrado
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
        }
    }
}
