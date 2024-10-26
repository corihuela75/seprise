using Clinica_SePrise.Datos;
using Clinica_SePrise.Medicos;
using Clinica_SePrise.Pacientes;
using Clinica_SePrise.Agenda;
using Clinica_SePrise.TurnoE;
using Clinica_SePrise.TurnoP;
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
        private NuevoTurnoE formTurnosEspe;
        private NuevoTurnoP formTurnosProf;


        public Menu(int id, string name, string rol)
        {
            this.name = name;
            this.id = id;
            this.rol = rol;
            InitializeComponent();
            this.btnAdministrativa_Click(null, null);
        }

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
            btn.FlatAppearance.BorderColor = Color.LightBlue;
            btn.ForeColor = Color.White;
        }
        private void btnUnSelected(Button btn)
        {
            btn.BackColor = Color.Azure;
            btn.FlatAppearance.BorderColor = Color.SteelBlue;
            btn.ForeColor = Color.SteelBlue;
        }

        // EVENTOS DE BOTONES MENU PRINCIPAL

        private void btnAdministrativa_Click(object? sender, EventArgs? e)
        {
            this.restablecerBotones();

            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = true;
            btnFour.Visible = false;
            btnOne.Text = "GESTIONAR PERSONAL MEDICO";
            btnTwo.Text = "GESTIONAR AGENDA";
            btnThree.Text = "GESTIONAR PACIENTES";
            this.btnSelected(btnAdministrativa);
            this.btnOneForm = this.formPacientes ?? new NuevoPaciente();
            this.btnTwoForm = this.formAgenda ?? new NuevoAgenda();
            this.btnThreeForm = this.formMedico ?? new NuevoMedico();

        }
        private void btnTurnos_Click(object sender, EventArgs e)
        {
            this.restablecerBotones();
            btnOne.Visible = true;
            btnTwo.Visible = true;
            btnThree.Visible = false;
            btnFour.Visible = false;
            btnOne.Text = "SOLICITAR TURNO POR ESPECIALIDAD";
            btnTwo.Text = "SOLICITAR TURNO POR PROFESIONAL";
            this.btnSelected(btnTurnos);
            this.btnOneForm = this.formTurnosEspe ?? new NuevoTurnoE();
            this.btnTwoForm = this.formTurnosProf ?? new NuevoTurnoP();
        }

        private void btnSalaEspera_Click(object sender, EventArgs e)
        {
        }
        private void btnAtencion_Click(object sender, EventArgs e)
        {
        }



        // EVENTOS DE LOS BOTONES DE LOS SUB MENUS

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
            this.btnUnSelected(btnAdministrativa);
            this.btnUnSelected(btnTurnos);
            this.btnUnSelected(btnEspera); 
            this.btnUnSelected(btnAtencion);

            btnOne.Visible = false;
            btnTwo.Visible = false;  
            btnThree.Visible = false;
            btnFour.Visible = false;
        } 


    }
}
