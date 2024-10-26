using Clinica_SePrise.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_SePrise.TurnoP
{
    public partial class NuevoTurnoP : Form
    {
        public NuevoTurnoP()
        {
            InitializeComponent();
        }

        private void NuevoTurno_Load(object sender, EventArgs e)
        {
            LlenarComboBoxMedicos();
        }

        private void LlenarComboBoxMedicos()
        {
            Conexion conexion = new Conexion();
            string query = "SELECT nombre_medi FROM medico"; // Ajusta la consulta según tu base de datos

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cboMedico.DataSource = dt;
                    cboMedico.DisplayMember = "nombre_medi";
                    cboMedico.ValueMember = "nombre_medi";

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }
        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTurnosDisponibles(cboMedico.SelectedValue.ToString());
        }

        private void CargarTurnosDisponibles(string medico)
        {
            Conexion conexion = new Conexion();
            string query = "SELECT fecha, hora_inicio, hora_fin FROM turnos WHERE  estado = 'Disponible'"; // medico = @medico AND Ajusta según tu estructura

            using (var connection = conexion.GetConnection())
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@medico", medico);
                    MySqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dataGridViewTurnos.DataSource = dt;

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }
    }
}
