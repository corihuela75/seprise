using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica_SePrise
{
    public partial class CronogramaSalaEspera : Form
    {

        private List<System.Windows.Forms.ListView> views;
        private ListViewItem itemSelected = null;
        public CronogramaSalaEspera()
        {

            InitializeComponent();

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
            //string today = "2024-11-05";
            //string turno = "mañana";

            Conexion con = new Conexion();
            string query = "SELECT T.id_turno,T.hora_inicio, T.estado, P.nombre_paci, P.doc_paci FROM turnos as T INNER JOIN paciente as P on T.paciente = P.doc_paci WHERE T.`consultorio` = @value and T.turno_periodo = @turno and T.fecha = @today ORDER BY hora_inicio";

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

                    lv.Columns.Add("ID", 0);
                    lv.Columns.Add("Inicio", 50, HorizontalAlignment.Center);
                    lv.Columns.Add("DNI", 70, HorizontalAlignment.Center);
                    lv.Columns.Add("Paciente", 150, HorizontalAlignment.Center);
                    lv.Columns.Add("Estado", 85, HorizontalAlignment.Center);

                    lv.Items.Clear();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string inicio = reader.GetTimeSpan(1).ToString(@"hh\:mm");

                        string estado = reader.GetString(2);
                        string nombre = reader.GetString(3);
                        int doc = reader.GetInt32(4);

                        string patientInfo = $"{doc}\n{nombre}";

                        ListViewItem item = new ListViewItem(id.ToString());
                        item.SubItems.Add(inicio);
                        item.SubItems.Add(doc.ToString());
                        item.SubItems.Add(nombre);
                        item.SubItems.Add(estado);

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
            lblFechaHoy.Text = "Fecha: " + DateTime.Now.ToString("yyyy-MM-dd");
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

                lv.SelectedItems.Clear();

                foreach (ListViewItem item in lv.Items)
                {
                    if (item.SubItems[1].Text.Equals(dniBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        item.Selected = true;
                        item.Focused = true;
                        lv.EnsureVisible(item.Index);
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
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

        private void btnAConsultorio_Click(object sender, EventArgs e)
        {
            if (itemSelected != null)
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
                                itemSelected.SubItems[4].Text = "en curso";
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
                MessageBox.Show("No hay un elemento seleccionado.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
