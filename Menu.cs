using Clinica_SePrise.Datos;
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
            /* Notifica a todos los surtidores de mensajes que deben terminar 
             * y, a continuación, cierra todas las ventanas de la aplicación 
             *______________________________________________________________________ */
            Application.Exit();
        }

        private void btnAltaSocio_Click(object sender, EventArgs e)
        {
            //NuevoCliente frmNuevoCliente = new NuevoCliente();
            //frmNuevoCliente.ShowDialog();
            //this.Hide();
        }

        private void btnReporSocios_Click(object sender, EventArgs e)
        {
            btnAltaSocio.Visible = false;
            btnCarnet.Visible = false;
            btnReporSocios.Visible = false;
            btnSalir.Visible = false;
            btnCuotaHoy.Visible = true;
            btnCuotaVencer.Visible = true;
            btnCuotaVencida.Visible = true;
            btnTodos.Visible = true;
        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            //EntergaCarnet frmPagar = new EntergaCarnet();
            //frmPagar.ShowDialog();
            //this.Hide();
        }

        private void btnCuotaVencida_Click(object sender, EventArgs e)
        {
            //frmReporCliente.listado = "1";
            //frmReporCliente.ShowDialog();
            //restablecerBotones();
            //frmReporCliente.Hide();
        }

        private void btnCuotaHoy_Click(object sender, EventArgs e)
        {
            //frmReporCliente.listado = "2";
            //frmReporCliente.ShowDialog();
            //restablecerBotones();
            //frmReporCliente.Hide();

        }

        private void btnCuotaVencer_Click(object sender, EventArgs e)
        {
            //frmReporCliente.listado = "3";
            //frmReporCliente.ShowDialog();
            //restablecerBotones();
            //frmReporCliente.Hide();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //frmReporCliente.listado = "4";
            //frmReporCliente.ShowDialog();
            //restablecerBotones();
            //frmReporCliente.Hide();
        }


        private void restablecerBotones()
        {
            btnAltaSocio.Visible = true;
            btnCarnet.Visible = true;
            btnReporSocios.Visible = true;
            btnSalir.Visible = true;
            btnCuotaHoy.Visible = false;
            btnCuotaVencer.Visible = false;
            btnCuotaVencida.Visible = false;
            btnTodos.Visible = false;
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }
    }
}
