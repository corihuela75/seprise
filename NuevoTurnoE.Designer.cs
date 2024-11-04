namespace Clinica_SePrise.TurnoE 
{
    partial class NuevoTurnoE : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoTurnoE));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            btnrRegistrar = new Button();
            lblTitulo = new Label();
            cboEspecialidad = new ComboBox();
            lblNacimiento = new Label();
            groupBox1 = new GroupBox();
            lblObraSocial = new Label();
            lblFechaNacimiento = new Label();
            lblNombre = new Label();
            lblDocumento = new Label();
            txtBuscarPaciente = new TextBox();
            lblObraSocial1 = new Label();
            btnBuscar = new Button();
            lblFechaNacimiento1 = new Label();
            lblNombre1 = new Label();
            lblDocumento1 = new Label();
            dataGridViewTurnos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
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
            // btnVolver
            // 
            btnVolver.BackColor = Color.Azure;
            btnVolver.FlatAppearance.BorderColor = Color.LightBlue;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.SteelBlue;
            btnVolver.Location = new Point(575, 592);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 47);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnrRegistrar
            // 
            btnrRegistrar.BackColor = Color.Azure;
            btnrRegistrar.FlatAppearance.BorderColor = Color.LightBlue;
            btnrRegistrar.FlatAppearance.BorderSize = 3;
            btnrRegistrar.FlatStyle = FlatStyle.Flat;
            btnrRegistrar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnrRegistrar.ForeColor = Color.SteelBlue;
            btnrRegistrar.Location = new Point(738, 592);
            btnrRegistrar.Name = "btnrRegistrar";
            btnrRegistrar.Size = new Size(145, 47);
            btnrRegistrar.TabIndex = 23;
            btnrRegistrar.Text = "REGISTRAR";
            btnrRegistrar.UseVisualStyleBackColor = false;
            btnrRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(649, 45);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "REGISTRO DE TURNO POR ESPECIALIDAD";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboEspecialidad.ForeColor = SystemColors.MenuHighlight;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Medicina Interna", "Pediatría", "Ginecología", "Obstetricia", "Cardiología", "Neurología", "Psiquiatría **", "Cirugía General", "Ortopedia y Traumatología", "Otorrinolaringología", "Oftalmología", "Urología", "Dermatología", "Radiología", "Anestesiología", "Patología", "Medicina Nuclear", "Medicina del Trabajo", "Medicina Preventiva", "Medicina Intensiva", "Geriatría", "Kinesiologia *", "Alergología e Inmunología", "Anatomía Patológica", "Cirugía Cardiovascular", "Neurocirugía", "Cirugía Pediátrica", "Cirugía Plástica y Reparadora", "Gastroenterología", "Hematología", "Nefrología", "Neumología", "Reumatología", "Endocrinología" });
            cboEspecialidad.Location = new Point(403, 76);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(404, 25);
            cboEspecialidad.TabIndex = 28;
            cboEspecialidad.SelectedIndexChanged += cboEspecialidad_SelectedIndexChanged;
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(261, 79);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(140, 19);
            lblNacimiento.TabIndex = 29;
            lblNacimiento.Text = "( * ) ESPECIALIDAD :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblObraSocial);
            groupBox1.Controls.Add(lblFechaNacimiento);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblDocumento);
            groupBox1.Controls.Add(txtBuscarPaciente);
            groupBox1.Controls.Add(lblObraSocial1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(lblFechaNacimiento1);
            groupBox1.Controls.Add(lblNombre1);
            groupBox1.Controls.Add(lblDocumento1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(215, 410);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 151);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "DNI del paciente :";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraSocial.Location = new Point(323, 106);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(0, 21);
            lblObraSocial.TabIndex = 49;
            lblObraSocial.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(323, 80);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(0, 21);
            lblFechaNacimiento.TabIndex = 48;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(323, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 21);
            lblNombre.TabIndex = 46;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(323, 54);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(0, 21);
            lblDocumento.TabIndex = 47;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarPaciente.ForeColor = Color.Black;
            txtBuscarPaciente.Location = new Point(23, 28);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(116, 25);
            txtBuscarPaciente.TabIndex = 39;
            txtBuscarPaciente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblObraSocial1
            // 
            lblObraSocial1.AutoSize = true;
            lblObraSocial1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblObraSocial1.Location = new Point(220, 106);
            lblObraSocial1.Name = "lblObraSocial1";
            lblObraSocial1.Size = new Size(97, 21);
            lblObraSocial1.TabIndex = 45;
            lblObraSocial1.Text = "Obra Social :";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Azure;
            btnBuscar.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(23, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 25);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblFechaNacimiento1
            // 
            lblFechaNacimiento1.AutoSize = true;
            lblFechaNacimiento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento1.Location = new Point(155, 80);
            lblFechaNacimiento1.Name = "lblFechaNacimiento1";
            lblFechaNacimiento1.Size = new Size(162, 21);
            lblFechaNacimiento1.TabIndex = 44;
            lblFechaNacimiento1.Text = "Fecha de Nacimiento :";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre1.Location = new Point(242, 28);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(75, 21);
            lblNombre1.TabIndex = 42;
            lblNombre1.Text = "Nombre :";
            // 
            // lblDocumento1
            // 
            lblDocumento1.AutoSize = true;
            lblDocumento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento1.Location = new Point(219, 54);
            lblDocumento1.Name = "lblDocumento1";
            lblDocumento1.Size = new Size(98, 21);
            lblDocumento1.TabIndex = 43;
            lblDocumento1.Text = "Documento :";
            // 
            // dataGridViewTurnos
            // 
            dataGridViewTurnos.AllowUserToAddRows = false;
            dataGridViewTurnos.AllowUserToDeleteRows = false;
            dataGridViewTurnos.AllowUserToResizeColumns = false;
            dataGridViewTurnos.AllowUserToResizeRows = false;
            dataGridViewTurnos.BackgroundColor = Color.White;
            dataGridViewTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnos.Location = new Point(215, 123);
            dataGridViewTurnos.MultiSelect = false;
            dataGridViewTurnos.Name = "dataGridViewTurnos";
            dataGridViewTurnos.ReadOnly = true;
            dataGridViewTurnos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTurnos.ScrollBars = ScrollBars.Vertical;
            dataGridViewTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTurnos.ShowEditingIcon = false;
            dataGridViewTurnos.Size = new Size(645, 269);
            dataGridViewTurnos.TabIndex = 47;
            dataGridViewTurnos.RowEnter += dataGridViewTurnos_RowEnter;
            // 
            // NuevoTurnoE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewTurnos);
            Controls.Add(cboEspecialidad);
            Controls.Add(lblNacimiento);
            Controls.Add(lblTitulo);
            Controls.Add(btnrRegistrar);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NuevoTurnoE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE TURNO POR ESPECIALIDAD";
            Load += NuevoTurno_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Button btnrRegistrar;
        private Label lblTitulo;
        private ComboBox cboEspecialidad;
        private Label lblNacimiento;
        private GroupBox groupBox1;
        private Label lblObraSocial;
        private Label lblFechaNacimiento;
        private Label lblNombre;
        private Label lblDocumento;
        private TextBox txtBuscarPaciente;
        private Label lblObraSocial1;
        private Button btnBuscar;
        private Label lblFechaNacimiento1;
        private Label lblNombre1;
        private Label lblDocumento1;
        private DataGridView dataGridViewTurnos;
    }
}