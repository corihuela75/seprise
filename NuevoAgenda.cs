using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


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
        private int minutos = 30;


        public NuevoAgenda()
        {
            InitializeComponent();
            LlenarComboBox();
            dtpFecha.Value = DateTime.Now;
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
                    cboMedico.SelectedIndex = -1;
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
            btnLimpiar_Click(sender, e);
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboConsultorio.SelectedIndex = -1;
            cboMedico.SelectedIndex = -1;
            cboTurno.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
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

                // Intervalo de 30, 60 o 90  minutos entre turnos
                if (especialidad == "Kinesiologia *")
                {
                    minutos = 60;
                }
                else if (especialidad == "Psiquiatría **")
                {
                    minutos = 90;
                }

                TimeSpan intervalo = new TimeSpan(0, minutos, 0);  // Intervalo de 30 minutos

                // Crear una instancia de la clase Conexion
                Conexion conexion = new Conexion();

                // Crear una instancia de Turno, pasando la conexión
                Turno turnoNuevo = new Turno(conexion);


                // Verificar si ya existen turnos para la misma fecha, consultorio, médico y periodo de turno
                if (ExisteTurno(fecha, consultorio, turno_periodo))
                {
                    MessageBox.Show("Ya existen turnos asignados en el periodo seleccionado (mañana/tarde) para este médico en este consultorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    // Insertar un nuevo paciente
                    try
                    {
                        // Ciclo para generar turnos cada 30 minutos entre las horas definidas
                        for (TimeSpan horaActual = horaInicio; horaActual < horaFin; horaActual = horaActual.Add(intervalo))
                        {
                            // Definir la hora de inicio y fin del turno
                            DateTime turnoHoraInicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, horaActual.Hours, horaActual.Minutes, 0);
                            DateTime turnoHoraFin = turnoHoraInicio.AddMinutes(minutos);

                            // Insertar el turno en la base de datos
                            turnoNuevo.InsertarTurno(consultorio, medico, especialidad, paciente, fecha,
                                                     turnoHoraInicio.ToString("HH:mm"), turnoHoraFin.ToString("HH:mm"),
                                                     turno_periodo, minutos, estado);

                            // Puedes mostrar un mensaje opcional o seguir con el ciclo
                        }

                        MessageBox.Show("Se han insertado los turnos correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al insertar los turnos: " + ex.Message);
                    }


                    //Menu principal = new Menu();
                    //principal.Show();
                    //this.Close();
                }
            }
        }

        //Comprobamos que no este ocupado el consultorio
        private bool ExisteTurno(DateTime fecha, int consultorio, string turno_periodo)
        {
            // Crea una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Crea la consulta para verificar si ya existen turnos para la misma fecha, consultorio y turno_periodo
            string queryVerificarTurnos = "SELECT COUNT(*) FROM turnos WHERE fecha = @fecha AND consultorio = @consultorio AND turno_periodo = @turno_periodo";

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Crear un comando MySQL
                    MySqlCommand command = new MySqlCommand(queryVerificarTurnos, connection);
                    command.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@consultorio", consultorio);
                    command.Parameters.AddWithValue("@turno_periodo", turno_periodo);

                    // Ejecutar la consulta y obtener el número de registros encontrados
                    int turnoExistente = Convert.ToInt32(command.ExecuteScalar());

                    // Retornar verdadero si hay turnos existentes, falso en caso contrario
                    return turnoExistente > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al verificar los turnos: " + ex.Message);
                    return false;
                }
            }
        }

        private void NuevoAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.btnLimpiar_Click(sender, e);
        }
    }
}
