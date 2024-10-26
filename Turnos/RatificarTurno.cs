using Clinica_SePrise.Datos;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_SePrise.Turnos
{
    public partial class RatificarTurno : Form
    {
        private Conexion conn = new Conexion();
        public RatificarTurno(string name)
        {
            InitializeComponent();
            lblName.Text = name;
        }

        private void RatificarTurno_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnRatificar.FlatAppearance.BorderColor = Color.LightBlue;
            btnRatificar.ForeColor = Color.SteelBlue;
            btnRatificar.Enabled = false;
            int.TryParse(txtIdTurno.Text, out int numero);

            if (numero <= 0)
            {
                MessageBox.Show("El número ingresado es inválido");
            }
            else
            {
                using (var connection = conn.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM turnos WHERE id_turno = @numero";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numero", numero);
                    using (MySqlDataReader reader = command.ExecuteReader())

                    {
                        if (reader.Read())
                        {
                            dgvTurno.Rows.Clear();
                            dgvTurno.Columns.Clear();
                            dgvTurno.Columns.Add("Campo", "Campo");
                            dgvTurno.Columns.Add("Valor", "Valor");

                            dgvTurno.Rows.Add("ID Turno", reader.GetInt32("id_turno"));
                            dgvTurno.Rows.Add("Consultorio", reader.GetInt32("consultorio"));
                            dgvTurno.Rows.Add("Médico", reader.GetString("medico"));
                            dgvTurno.Rows.Add("Especialidad", reader.GetString("especialidad"));
                            dgvTurno.Rows.Add("Paciente", reader.GetString("paciente"));
                            dgvTurno.Rows.Add("Fecha", reader.GetDateTime("fecha").ToString("yyyy-MM-dd"));
                            dgvTurno.Rows.Add("Hora Inicio", reader.GetTimeSpan("hora_inicio"));
                            dgvTurno.Rows.Add("Hora Fin", reader.GetTimeSpan("hora_fin"));
                            dgvTurno.Rows.Add("Turno Periodo", reader.GetString("turno_periodo"));
                            dgvTurno.Rows.Add("Duración", reader.GetString("duracion"));
                            dgvTurno.Rows.Add("Estado", reader.GetString("estado"));

                            dgvTurno.Visible = true;

                            btnRatificar.FlatAppearance.BorderColor = Color.DarkBlue;
                            btnRatificar.ForeColor = Color.DarkBlue;
                            btnRatificar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Turno no encontrado, verifique el numero ingresado.");
                        }
                    }
                }
            }



        }

        private void RatificarTurno_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                dgvTurno.Rows.Clear();
                dgvTurno.Columns.Clear();
                dgvTurno.Visible = false;
                txtIdTurno.Clear();
                btnRatificar.FlatAppearance.BorderColor = Color.LightBlue;
                btnRatificar.ForeColor = Color.SteelBlue;
                btnRatificar.Enabled = false;
            }
        }

        private void RatificarTurno_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnRatificar_Click(object sender, EventArgs e)
        {

        }
    }
}
