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
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            lblTitulo = new Label();
            cboMedico = new ComboBox();
            lblNacimiento = new Label();
            dataGridViewTurnos = new DataGridView();
            btnBuscar = new Button();
            txtBuscarPaciente = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            lblDocumento = new Label();
            lblFechaNacimiento = new Label();
            lblObraSocial = new Label();
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
            panel1.Size = new Size(180, 807);
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
            btnVolver.Location = new Point(738, 591);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 48);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Azure;
            btnLimpiar.FlatAppearance.BorderColor = Color.LightBlue;
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.SteelBlue;
            btnLimpiar.Location = new Point(575, 591);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(145, 48);
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
            btnIngresar.Location = new Point(412, 591);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(145, 48);
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
            cboMedico.SelectedIndexChanged += cboMedico_SelectedIndexChanged;
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
            dataGridViewTurnos.AllowUserToResizeColumns = false;
            dataGridViewTurnos.AllowUserToResizeRows = false;
            dataGridViewTurnos.BackgroundColor = Color.White;
            dataGridViewTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTurnos.Location = new Point(217, 126);
            dataGridViewTurnos.MultiSelect = false;
            dataGridViewTurnos.Name = "dataGridViewTurnos";
            dataGridViewTurnos.ReadOnly = true;
            dataGridViewTurnos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewTurnos.ScrollBars = ScrollBars.Vertical;
            dataGridViewTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTurnos.ShowEditingIcon = false;
            dataGridViewTurnos.Size = new Size(645, 269);
            dataGridViewTurnos.TabIndex = 30;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Azure;
            btnBuscar.FlatAppearance.BorderColor = Color.LightBlue;
            btnBuscar.FlatAppearance.BorderSize = 3;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(530, 442);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(151, 32);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarPaciente.ForeColor = SystemColors.MenuHighlight;
            txtBuscarPaciente.Location = new Point(420, 446);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(98, 25);
            txtBuscarPaciente.TabIndex = 39;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(217, 449);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(191, 19);
            lblDni.TabIndex = 40;
            lblDni.Text = "INGRESE DNI DE PACIENTE :";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(320, 513);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 42;
            lblNombre.Text = "label1";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(392, 513);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(38, 15);
            lblDocumento.TabIndex = 43;
            lblDocumento.Text = "label1";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(489, 513);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(38, 15);
            lblFechaNacimiento.TabIndex = 44;
            lblFechaNacimiento.Text = "label1";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Location = new Point(627, 513);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(38, 15);
            lblObraSocial.TabIndex = 45;
            lblObraSocial.Text = "label1";
            // 
            // NuevoTurnoP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(lblObraSocial);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblDocumento);
            Controls.Add(lblNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(lblDni);
            Controls.Add(dataGridViewTurnos);
            Controls.Add(cboMedico);
            Controls.Add(lblNacimiento);
            Controls.Add(lblTitulo);
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
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnIngresar;
        private Label lblTitulo;
        private ComboBox cboMedico;
        private Label lblNacimiento;
        private DataGridView dataGridViewTurnos;
        private Button btnBuscar;
        private TextBox txtBuscarPaciente;
        private Label lblDni;
        private Label lblNombre;
        private Label lblDocumento;
        private Label lblFechaNacimiento;
        private Label lblObraSocial;
    }
}