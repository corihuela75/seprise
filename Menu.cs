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

        private List<Button> btns = new List<Button>();

        private Form btnOneForm;
        private Form btnTwoForm;
        private Form btnThreeForm;
        private Form btnFourForm;

        // -- FORMS GESTION ADMINISTRATIVA --
        private NuevoPaciente formPacientes;
        private NuevoAgenda formAgenda;
        private NuevoMedico formMedico;

        // -- FORMS GESTION TURNOS --
        private RatificarTurno formRatTurno;


        public Menu(int id, string name, string rol)
        {
            this.name = name;
            this.id = id;
            this.rol = rol;
            InitializeComponent();
            this.btns.Add(btnAdministrativa);
            this.btns.Add(btnAtencion);
            this.btns.Add(btnEspera);
            this.btns.Add(btnTurnos);
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

        private void deselected(Button btn)
        {
            btn.BackColor = Color.Azure;
            btn.FlatAppearance.BorderColor = Color.LightBlue;
            btn.ForeColor = Color.SteelBlue;
        }

        private void btnSelected(Button btn)
        {
            btn.BackColor = Color.SteelBlue;
            btn.FlatAppearance.BorderColor = Color.DarkBlue;
            btn.ForeColor = Color.White;
            this.btns.ForEach(b => { if (b != btn) this.deselected(b); });
        }

        // --- OPCIONES PRINCIPALES ---

        private void btnAdministrativa_Click(object? sender, EventArgs? e)
        {

            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = true;
            btnFour.Visible = false;
            btnOne.Text = "GESTIONAR PERSONAL MEDICO";
            btnTwo.Text = "GESTIONAR AGENDA";
            btnThree.Text = "GESTIONAR PACIENTES";
            this.btnOneForm = this.formPacientes ?? new NuevoPaciente();
            this.btnTwoForm = this.formAgenda ?? new NuevoAgenda();
            this.btnThreeForm = this.formMedico ?? new NuevoMedico();
            this.btnSelected(btnAdministrativa);

        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            btnOne.Visible = false;
            btnTwo.Visible = true;
            btnThree.Visible = false;
            btnFour.Visible = false;

            btnTwo.Text = "RATIFICAR TURNO";
            this.btnTwoForm = this.formRatTurno ?? new RatificarTurno(lblIngreso.Text);
            this.btnSelected(btnTurnos);

        }

        private void btnSalaEspera_Click(object sender, EventArgs e)
        {
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
        }

        // --- OPCIONES OPCIONALES ---
        private void btnOpOne_Click(object sender, EventArgs e)
        {
            this.btnOneForm.ShowDialog();
        }

        private void btnOpTwo_Click(object sender, EventArgs e)
        {
            this.btnTwoForm.ShowDialog();
        }
        private void btnOpThree_Click(object sender, EventArgs e)
        {
            this.btnThreeForm.ShowDialog();
        }

        private void btnOpFour_Click(object sender, EventArgs e)
        {
            this.btnFourForm.ShowDialog();

        }

        
        


        private void restablecerBotones()
        {
        }

        
    }
}
