namespace Clinica_SePrise.TurnoP
{
    partial class NuevoTurnoP : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoTurnoP));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblAsterisco = new Label();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            lblTitulo = new Label();
            cboMedico = new ComboBox();
            lblNacimiento = new Label();
            dataGridViewTurnos = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            hora_inicio = new DataGridViewTextBoxColumn();
            hora_fin = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 657);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsterisco.Location = new Point(200, 592);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(192, 15);
            lblAsterisco.TabIndex = 26;
            lblAsterisco.Text = "( * ) Campos de ingreso obligatorio";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Azure;
            btnVolver.FlatAppearance.BorderColor = Color.LightBlue;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.SteelBlue;
            btnVolver.Location = new Point(738, 592);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 47);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Azure;
            btnLimpiar.FlatAppearance.BorderColor = Color.LightBlue;
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.SteelBlue;
            btnLimpiar.Location = new Point(575, 592);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 47);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Azure;
            btnIngresar.FlatAppearance.BorderColor = Color.LightBlue;
            btnIngresar.FlatAppearance.BorderSize = 3;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.SteelBlue;
            btnIngresar.Location = new Point(412, 592);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(145, 47);
            btnIngresar.TabIndex = 23;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(642, 45);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "REGISTRO DE TURNO POR PROFESIONAL";
            // 
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboMedico.ForeColor = SystemColors.MenuHighlight;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(403, 76);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(404, 25);
            cboMedico.TabIndex = 28;
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(261, 79);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(139, 19);
            lblNacimiento.TabIndex = 29;
            lblNacimiento.Text = "( * ) PROFESIONAL :";
            // 
            // dataGridViewTurnos
            // 
            dataGridViewTurnos.AllowUserToAddRows = false;
            dataGridViewTurnos.AllowUserToDeleteRows = false;
            dataGridViewTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnos.Columns.AddRange(new DataGridViewColumn[] { Fecha, hora_inicio, hora_fin });
            dataGridViewTurnos.Location = new Point(200, 131);
            dataGridViewTurnos.Name = "dataGridViewTurnos";
            dataGridViewTurnos.ReadOnly = true;
            dataGridViewTurnos.Size = new Size(683, 438);
            dataGridViewTurnos.TabIndex = 30;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // hora_inicio
            // 
            hora_inicio.HeaderText = "Hora de inicio";
            hora_inicio.Name = "hora_inicio";
            hora_inicio.ReadOnly = true;
            // 
            // hora_fin
            // 
            hora_fin.HeaderText = "Hora de fin";
            hora_fin.Name = "hora_fin";
            hora_fin.ReadOnly = true;
            // 
            // NuevoTurnoP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(dataGridViewTurnos);
            Controls.Add(cboMedico);
            Controls.Add(lblNacimiento);
            Controls.Add(lblTitulo);
            Controls.Add(lblAsterisco);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NuevoTurnoP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE TURNO POR PROFESIONAL";
            Load += NuevoTurno_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblAsterisco;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnIngresar;
        private Label lblTitulo;
        private ComboBox cboMedico;
        private Label lblNacimiento;
        private DataGridView dataGridViewTurnos;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn hora_inicio;
        private DataGridViewTextBoxColumn hora_fin;
    }
}