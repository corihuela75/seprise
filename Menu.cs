using Clinica_SePrise.Datos;
using Clinica_SePrise.Medicos;
using Clinica_SePrise.Pacientes;
using Clinica_SePrise.Turnos;
using System.Data;


namespace Clinica_SePrise
{
    public partial class Menu : Form
    {
        private string name;
        private string rol;
        private int id;

        private Form btnOneForm;
        private Form btnTwoForm;
        private Form btnThreeForm;
        private Form btnFourForm;

        // -- FORMS GESTION ADMINISTRATIVA --
        private NuevoPaciente formPacientes;
        private NuevoAgenda formAgenda;
        private NuevoMedico formMedico;

        // -- FORMS GESTION TURNOS --


        public Menu(int id, string name, string rol)
        {
            this.name = name;
            this.id = id;
            this.rol = rol;
            InitializeComponent();
            this.btnAdministrativa_Click(null, null);
        }
        /* ___________ VARIABLES tipo INTERNAL__________________________________
        * Serán accesibles desde el ensamblado en el cual están declarados
        * y tampoco se pueden utilizar en el interior de una función.
        * _________________________________________________________________   */
        private void Principal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = id.ToString() + '-' + name.ToUpper() + '\n' + rol.ToUpper();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSelected(Button btn)
        {
            btn.BackColor = Color.SteelBlue;
            btn.FlatAppearance.BorderColor = Color.DarkBlue;
            btn.ForeColor = Color.White;
        }

        private void btnAdministrativa_Click(object? sender, EventArgs? e)
        {

            btnFour.Visible = false;
            btnOne.Text = "GESTIONAR PERSONAL MEDICO";
            btnTwo.Text = "GESTIONAR AGENDA";
            btnThree.Text = "GESTIONAR PACIENTES";
            this.btnSelected(btnAdministrativa);

            this.btnOneForm = this.formPacientes ?? new NuevoPaciente();
            this.btnTwoForm = this.formAgenda ?? new NuevoAgenda();
            this.btnThreeForm = this.formMedico ?? new NuevoMedico();

        }
        private void btnOpFour_Click(object sender, EventArgs e)
        {
            this.btnFourForm.ShowDialog();

        }
        private void btnSalaEspera_Click(object sender, EventArgs e)
        {
        }

        private void btnOpOne_Click(object sender, EventArgs e)
        {
            this.btnOneForm.ShowDialog();
        }

        private void btnOpThree_Click(object sender, EventArgs e)
        {
            this.btnThreeForm.ShowDialog();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
        }
        private void btnOpTwo_Click(object sender, EventArgs e)
        {
            this.btnTwoForm.ShowDialog();
        }


        private void restablecerBotones()
        {
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
        }
    }
}
