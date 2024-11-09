using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace Clinica_SePrise
{
    public partial class CronogramaSalaEspera : Form
    {

        private List<System.Windows.Forms.ListView> views;
        private ListViewItem itemSelected = null;

        //DATOS DE LOGIN
        private string name;
        private string rol;
        private int id;

        public CronogramaSalaEspera(int id, string name, string rol)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;
            this.rol = rol;
        }

        private void CronogramaSalaEspera_Load(object sender, EventArgs e)
        {
            this.loadCboTurno();
            this.loadListViews();
            lv1.ItemSelectionChanged += ListView_ItemSelectionChanged;
            lv2.ItemSelectionChanged += ListView_ItemSelectionChanged;
            lv3.ItemSelectionChanged += ListView_ItemSelectionChanged;
            lv4.ItemSelectionChanged += ListView_ItemSelectionChanged;
            lv5.ItemSelectionChanged += ListView_ItemSelectionChanged;
            lblIngreso.Text = "USUARIO: " + name.ToUpper() + " (Id: " + id.ToString() + ") " + "\nROL: " + rol.ToUpper();
        }

        private void loadListViews()
        {
            this.LoadDataFromDatabase("1", lv1);
            this.LoadDataFromDatabase("2", lv2);
            this.LoadDataFromDatabase("3", lv3);
            this.LoadDataFromDatabase("4", lv4);
            this.LoadDataFromDatabase("5", lv5);
        }


        private void LoadDataFromDatabase(string value, System.Windows.Forms.ListView lv)
        {
            lv.FullRowSelect = true;

            string turno = cboTurno.Text;
            string today = DateTime.Now.ToString("yyyy-MM-dd");

            Conexion con = new Conexion();
            string query = "SELECT distinct T.id_turno, T.hora_inicio, T.hora_fin,  T.estado,  COALESCE(P.nombre_paci, 'Sin asignar') AS nombre_paci," +
                " COALESCE(P.doc_paci, 0) AS doc_paci FROM turnos as T LEFT JOIN paciente as P on T.paciente = P.doc_paci " +
                           "WHERE T.consultorio = @value AND T.turno_periodo = @turno " +
                           "AND T.fecha = @today AND (T.paciente = 0 OR T.paciente = P.doc_paci) ORDER BY T.hora_inicio";



            using (var connection = con.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@value", value);
                    command.Parameters.AddWithValue("@turno", turno);
                    command.Parameters.AddWithValue("@today", today);

                    MySqlDataReader reader = command.ExecuteReader();

                    // Consulta SQL para obtener los datos de la tabla Documentos
                    lv.View = View.Details;

                    // Limpia el ListView antes de cargar datos
                    lv.Visible = true;
                    lv.Columns.Clear();

                    lv.Columns.Add("ID", 30);
                    lv.Columns.Add("Inicio", 50, HorizontalAlignment.Center);
                    lv.Columns.Add("Fin", 50, HorizontalAlignment.Center);
                    lv.Columns.Add("DNI", 70, HorizontalAlignment.Center);
                    lv.Columns.Add("Paciente", 150, HorizontalAlignment.Center);
                    lv.Columns.Add("Estado", 85, HorizontalAlignment.Center);

                    lv.Items.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string inicio = reader.GetTimeSpan(1).ToString(@"hh\:mm");
                        string fin = reader.GetTimeSpan(2).ToString(@"hh\:mm");
                        string estado = reader.GetString(3);
                        string nombre = reader.GetString(4);
                        int doc = reader.GetInt32(5);

                        string patientInfo = $"{doc}\n{nombre}";

                        ListViewItem item = new ListViewItem(id.ToString());
                        item.SubItems.Add(inicio);
                        item.SubItems.Add(fin);
                        item.SubItems.Add(doc.ToString());
                        item.SubItems.Add(nombre);
                        item.SubItems.Add(estado);

                        // Cambiar color según el estado del turno
                        switch (estado.ToLower())
                        {
                            case "reservado":
                                item.BackColor = Color.Gold; // Amarillo para reservado
                                break;
                            case "ratificado":
                                item.BackColor = Color.MediumAquamarine; // Verde para reservado
                                break;
                            case "en curso":
                                item.BackColor = Color.SkyBlue; // Azul para en curso
                                break;
                            case "completado":
                                item.BackColor = Color.LightCyan; // Cyan para completado
                                break;
                            case "cancelado":
                                item.BackColor = Color.Tomato; // Rojo para cancelado
                                break;
                            case "atendido":
                                item.BackColor = Color.Fuchsia; // Fucsia para cancelado
                                break;
                            default:
                                item.BackColor = Color.White; // Blanco para otros estados
                                break;
                        }
                        lv.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void loadCboTurno()
        {
            lblFechaHoy.Text = "Turnos para Hoy: " + DateTime.Now.ToString("dd-MM-yyyy");
            cboTurno.DisplayMember = "mañana";
            cboTurno.ValueMember = "mañana";
            cboTurno.DisplayMember = "tarde";
            cboTurno.ValueMember = "tarde";

            TimeSpan horaLimite = new TimeSpan(14, 0, 0);
            cboTurno.SelectedIndex = DateTime.Now.TimeOfDay < horaLimite ? 0 : 1;
        }

        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                itemSelected = e.Item;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView[] listViews = { lv1, lv2, lv3, lv4, lv5 };

            bool encontrado = false;
            string dniBuscado = txtDni.Text.Trim();

            foreach (var lv in listViews)
            {
                lv.SelectedItems.Clear(); // Limpia la selección en cada ListView

                foreach (ListViewItem item in lv.Items)
                {
                    if (item.SubItems[3].Text.Equals(dniBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        // Resalta el item encontrado
                        item.Selected = true;
                        item.Focused = true;

                        // Asegura que el item sea visible
                        lv.EnsureVisible(item.Index);

                        encontrado = true;
                        break;
                    }
                }
                if (encontrado)
                {
                    lv.Focus(); // Establece el foco en el ListView que contiene el item encontrado
                    break;
                }
            }
            if (!encontrado)
            {
                MessageBox.Show("DNI no encontrado.");
            }
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadListViews();
        }

        // LLAMADO DEL PACIENTE A CONSULTORIO
        private void btnAConsultorio_Click(object sender, EventArgs e)
        {
            if (itemSelected != null)
            {
                string estadoTurno = itemSelected.SubItems[5].Text; // Obtener el estado del turno

                // Verificar si el estado es 'ratificado'
                if (estadoTurno.ToLower() == "ratificado")
                {
                    int idTurno = int.Parse(itemSelected.SubItems[0].Text);

                    try
                    {
                        Conexion conn = new Conexion();
                        using (var connection = conn.GetConnection())
                        {
                            connection.Open();
                            string query = "UPDATE turnos SET estado = 'en curso' WHERE id_turno = @idTurno";
                            using (var command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@idTurno", idTurno);

                                int result = command.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    itemSelected.BackColor = Color.SkyBlue; // Azul para en curso
                                    itemSelected.SubItems[5].Text = "en curso"; // Actualizar estado en el ListView
                                    itemSelected.ListView.Refresh();
                                    MessageBox.Show("Turno actualizado exitosamente.");
                                }
                                else
                                {
                                    MessageBox.Show("Error al llamar a consultorio.");
                                }
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No es posible realizar esta operación, por favor revise los campos ingresados.\n" + ex.Message);
                    }
                }
                else
                {
                    // Si el estado no es 'ratificado', mostrar advertencia
                    MessageBox.Show("El paciente seleccionado no está en sala de espera. Solo tunos RATIFICADOS pueden ser llamados al consultorio. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay un elemento seleccionado.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // CIERRE DEL DIA: PASA TODOS LOS TURNOS NO USADOS A ESTADO "VENCIDO"
        private void btnCierre_Click(object sender, EventArgs e)
        {
            // Verificar si el rol del usuario es "Administrador"
            if (this.rol.ToLower() != "administrador")
            {
                // Mostrar mensaje de advertencia y salir del método
                MessageBox.Show("¡Acción restringida! Solo los administradores pueden realizar esta operación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si es administrador, mostrar confirmación
            string confirmacion = Microsoft.VisualBasic.Interaction.InputBox(
                "¿Está seguro de que desea actualizar el estado de los turnos a 'vencido'? Ingrese 'OK' para confirmar.",
                "Confirmación");

            if (confirmacion.Trim().ToUpper() == "OK")
            {
                try
                {
                    Conexion conn = new Conexion();
                    using (var connection = conn.GetConnection())
                    {
                        connection.Open();

                        string query = "UPDATE turnos " +
                                       "SET estado = 'vencido' " +
                                       "WHERE fecha <= @fechaHoy " +
                                       "AND (estado = 'disponible' OR estado = 'ratificado' OR estado = 'reservado')";

                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@fechaHoy", DateTime.Now.ToString("yyyy-MM-dd"));

                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Turnos actualizados a 'vencido' exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron turnos para actualizar.");
                            }
                        }

                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar turnos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (itemSelected != null)
            {
                string estadoTurno = itemSelected.SubItems[5].Text; // Obtener el estado del turno

                // Verificar si el estado es 'ratificado'
                if (estadoTurno.ToLower() == "en curso")
                {
                    int idTurno = int.Parse(itemSelected.SubItems[0].Text);

                    try
                    {
                        Conexion conn = new Conexion();
                        using (var connection = conn.GetConnection())
                        {
                            connection.Open();
                            string query = "UPDATE turnos SET estado = 'atendido' WHERE id_turno = @idTurno";
                            using (var command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@idTurno", idTurno);

                                int result = command.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    itemSelected.BackColor = Color.Fuchsia; // Fucsia para cancelado
                                    itemSelected.SubItems[5].Text = "atendido"; // Actualizar estado en el ListView
                                    itemSelected.ListView.Refresh();
                                    MessageBox.Show("Turno actualizado exitosamente.");
                                }
                                else
                                {
                                    MessageBox.Show("Error al llamar a consultorio.");
                                }
                            }
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No es posible realizar esta operación, por favor revise los campos ingresados.\n" + ex.Message);
                    }
                }
                else
                {
                    // Si el estado no es 'ratificado', mostrar advertencia
                    MessageBox.Show("El paciente seleccionado no está en Consultorio. Solo tunos EN CURSO pueden ser finalizados. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay un elemento seleccionado.");
            }
        }
    }
}
    