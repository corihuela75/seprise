using Clinica_SePrise.Datos;
using Clinica_SePrise.Medicos;
using Clinica_SePrise.Pacientes;
using Clinica_SePrise.Turnos;
using System.Data;


namespace Clinica_SePrise
{
    public partial class Menu : Form
    {
        //public ReporteClientes frmReporCliente = new ReporteClientes();

        public Menu()
        {
            InitializeComponent();
        }
        /* ___________ VARIABLES tipo INTERNAL__________________________________
        * Serán accesibles desde el ensamblado en el cual están declarados
        * y tampoco se pueden utilizar en el interior de una función.
        * _________________________________________________________________   */
        internal string? rol;
        internal string? usuario;
        private void Principal_Load(object sender, EventArgs e)
        {
            // MUESTRA LOS DATOS DEL USUARIO CONECTADO
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol +
           ")";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            btnTurnos.Visible = false;
            btnRecepcion.Visible = false;
            btnGestion.Visible = false;
            btnSalir.Visible = false;
            btnAtencion.Visible = false;
            btnMedicos.Visible = true;
            btnAgenda.Visible = true;
            btnPacientes.Visible = true;
            btnVolver.Visible = true;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu principal = new Menu();
            principal.Show();
            this.Close();
        }
        private void btnCarnet_Click(object sender, EventArgs e)
        {
            //EntergaCarnet frmPagar = new EntergaCarnet();
            //frmPagar.ShowDialog();
            //this.Hide();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            NuevoPaciente frmNuevoPaciente = new NuevoPaciente();
            frmNuevoPaciente.ShowDialog();
            this.Hide();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            NuevoMedico frmNuevoMedico = new NuevoMedico();
            frmNuevoMedico.ShowDialog();
            this.Hide();

        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            //NuevoTurno frmNuevoTurno = new NuevoTurno();
            //frmNuevoTurno.ShowDialog();
            //this.Hide();
        }
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            NuevoAgenda frmNuevoTurno = new NuevoAgenda();
            frmNuevoTurno.ShowDialog();
            this.Hide();
        }


        private void restablecerBotones()
        {
            btnTurnos.Visible = true;
            btnRecepcion.Visible = true;
            btnGestion.Visible = true;
            btnSalir.Visible = true;
            btnMedicos.Visible = false;
            btnAgenda.Visible = false;
            btnPacientes.Visible = false;
            btnVolver.Visible = false;
        }


    }
}
