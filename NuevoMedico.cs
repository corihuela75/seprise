﻿using Clinica_SePrise.Datos;
using Clinica_SePrise.Pacientes;

namespace Clinica_SePrise.Medicos
{
    public partial class NuevoMedico : Form
    {
        // Campos para almacenar la información del médico
        private string nombre;
        private int matricula;
        private string especialidad;
        private string telefono;
        private string email;
        private string usuario;
        private string contraseña;

        public NuevoMedico()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtMatricula.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cboEspecialidad.SelectedIndex = -1;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtNombre.Focus();
        }
        //COMPROBAMOS INGRESO DE CAMPOS OBLIGATORIOS

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtMatricula.Text) ||
                string.IsNullOrEmpty(cboEspecialidad.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.",
                                "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Asignación de valores a las variables
            nombre = txtNombre.Text;
            //matricula = int.Parse(txtMatricula.Text);

            // Validación de matrícula numérica
            if (!int.TryParse(txtMatricula.Text, out matricula))
            {
                MessageBox.Show("La matrícula debe ser un número válido.",
                                "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            especialidad = cboEspecialidad.Text;
            telefono = txtTelefono.Text;
            email = txtEmail.Text;

            //SE DEJAN ESTAS VARIABLES PARA GUARDAR EN TABLA USUARIOS
            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crear una instancia de Medico, pasando la conexión
            Medico medicoNuevo = new Medico(conexion);

            // Insertar un nuevo médico
            medicoNuevo.InsertarMedico(nombre, matricula, especialidad, telefono, email);

            // AÑADIMOS EL USUARIO A LA TABLA

            // Crear una instancia de Usuario, pasando la conexión
            Usuario usuarioNuevo = new Usuario(conexion);

            // Insertar un nuevo usuario
            usuarioNuevo.InsertarUsuario(usuario, contraseña, 122); //122:ROL DE MEDICO

            // Limpiar el formulario
            btnLimpiar_Click(sender, e);

            // Volver al menú principal
            //Menu principal = new Menu();
            //principal.Show();
            this.Close();
        }

        private void NuevoMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnLimpiar_Click(sender, e);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListadoMedicos listado = new ListadoMedicos();
            listado.Show();
        }
    }
}