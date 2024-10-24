using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;


namespace Clinica_SePrise.Turnos
{
    public partial class NuevoAgenda : Form
    {
        private DateTime fecha;
        private int consultorio;
        private string paciente;
        private string medico;
        private string hora_inicio;
        private string hora_fin;
        private string turno_periodo;
        private string duracion;
        private string estado;
        private string especialidad;


        public NuevoAgenda()
        {
            InitializeComponent();
            LlenarComboBox();
        }



        private void LlenarComboBox()
        {
            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Hacemos la consulta doble para traer el medico y su especialidad
            string query = "SELECT nombre_medi, especialidad FROM medico";

            // Usar la conexión para obtener los datos de la consulta
            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Crear un comando MySQL
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Ejecutar la consulta y obtener un MySqlDataReader
                    MySqlDataReader reader = command.ExecuteReader();

                    // Crear un DataTable para asignar al ComboBox
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Asignar DataTable como fuente de datos del ComboBox
                    cboMedico.DataSource = dt;
                    cboMedico.DisplayMember = "nombre_medi";  // Lo que se muestra en el ComboBox
                    cboMedico.ValueMember = "especialidad";        // El valor subyacente

                    // Cerrar el lector
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu principal = new Menu();
            principal.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboConsultorio.Text = "";
            cboMedico.Text = "";
            cboTurno.Text = "";
            dtpFecha.Focus();
        }

        //COMPROBAMOS INGRESO DE CAMPOS OBLIGATORIOS
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cboConsultorio.Text == "" || cboMedico.Text == "" || cboTurno.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fecha = dtpFecha.Value;
                consultorio = Int32.Parse(cboConsultorio.Text);
                medico = cboMedico.Text;
                turno_periodo = cboTurno.Text;
                especialidad = Convert.ToString(cboMedico.SelectedValue);
                estado = "Disponible";

                // Determinar la franja horaria según el periodo (mañana o tarde)
                TimeSpan horaInicio;
                TimeSpan horaFin;

                // Validamos el turno_periodo
                if (turno_periodo == "mañana")
                {
                    horaInicio = new TimeSpan(8, 0, 0);  // 08:00 AM
                    horaFin = new TimeSpan(14, 0, 0);    // 14:00 PM
                }
                else if (turno_periodo == "tarde")
                {
                    horaInicio = new TimeSpan(14, 0, 0); // 14:00 PM
                    horaFin = new TimeSpan(20, 0, 0);    // 20:00 PM
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un turno válido (mañana o tarde).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Intervalo de 30 minutos entre turnos
                TimeSpan intervalo = new TimeSpan(0, 30, 0);  // Intervalo de 30 minutos

                // Crear una instancia de la clase Conexion
                Conexion conexion = new Conexion();

                // Crear una instancia de Turno, pasando la conexión
                Turno turnoNuevo = new Turno(conexion);

                // Insertar un nuevo paciente
                try
                {
                    // Ciclo para generar turnos cada 30 minutos entre las horas definidas
                    for (TimeSpan horaActual = horaInicio; horaActual < horaFin; horaActual = horaActual.Add(intervalo))
                    {
                        // Definir la hora de inicio y fin del turno
                        DateTime turnoHoraInicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, horaActual.Hours, horaActual.Minutes, 0);
                        DateTime turnoHoraFin = turnoHoraInicio.AddMinutes(30);

                        // Insertar el turno en la base de datos
                        turnoNuevo.InsertarTurno(consultorio, medico, especialidad, paciente, fecha,
                                                 turnoHoraInicio.ToString("HH:mm"), turnoHoraFin.ToString("HH:mm"),
                                                 turno_periodo, "30", estado);

                        // Puedes mostrar un mensaje opcional o seguir con el ciclo
                    }

                    MessageBox.Show("Se han insertado los turnos correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al insertar los turnos: " + ex.Message);
                }


                Menu principal = new Menu();
                principal.Show();
                this.Close();
            }
        }
    }
}
