namespace Clinica_SePrise.Atencion

{
    partial class AtencionPaciente : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtencionPaciente));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            btnRegistrar = new Button();
            lblTitulo = new Label();
            lblNombre1 = new Label();
            lblDocumento1 = new Label();
            lblFechaNacimiento1 = new Label();
            lblObraSocial1 = new Label();
            btnBuscar = new Button();
            txtBuscarPaciente = new TextBox();
            groupBox1 = new GroupBox();
            lblObraSocial = new Label();
            lblFechaNacimiento = new Label();
            lblNombre = new Label();
            lblDocumento = new Label();
            cboPacientes = new ComboBox();
            lblNacimiento = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            richTextBoxHistoria = new RichTextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
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
            btnVolver.Location = new Point(556, 580);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 48);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Azure;
            btnRegistrar.FlatAppearance.BorderColor = Color.LightBlue;
            btnRegistrar.FlatAppearance.BorderSize = 3;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.SteelBlue;
            btnRegistrar.Location = new Point(719, 580);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 48);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "REGISTRAR DIAGNOSTICO";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(475, 45);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "CONSULTA HISTORIA CLINICA";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre1.Location = new Point(134, 28);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(75, 21);
            lblNombre1.TabIndex = 42;
            lblNombre1.Text = "Nombre :";
            // 
            // lblDocumento1
            // 
            lblDocumento1.AutoSize = true;
            lblDocumento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento1.Location = new Point(111, 54);
            lblDocumento1.Name = "lblDocumento1";
            lblDocumento1.Size = new Size(98, 21);
            lblDocumento1.TabIndex = 43;
            lblDocumento1.Text = "Documento :";
            // 
            // lblFechaNacimiento1
            // 
            lblFechaNacimiento1.AutoSize = true;
            lblFechaNacimiento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento1.Location = new Point(47, 80);
            lblFechaNacimiento1.Name = "lblFechaNacimiento1";
            lblFechaNacimiento1.Size = new Size(162, 21);
            lblFechaNacimiento1.TabIndex = 44;
            lblFechaNacimiento1.Text = "Fecha de Nacimiento :";
            // 
            // lblObraSocial1
            // 
            lblObraSocial1.AutoSize = true;
            lblObraSocial1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblObraSocial1.Location = new Point(112, 106);
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
            btnBuscar.Location = new Point(118, 58);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 25);
            btnBuscar.TabIndex = 41;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarPaciente.ForeColor = Color.Black;
            txtBuscarPaciente.Location = new Point(21, 58);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(91, 25);
            txtBuscarPaciente.TabIndex = 39;
            txtBuscarPaciente.TextAlign = HorizontalAlignment.Center;
            txtBuscarPaciente.KeyPress += txtBuscarPaciente_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblObraSocial);
            groupBox1.Controls.Add(lblFechaNacimiento);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblDocumento);
            groupBox1.Controls.Add(lblObraSocial1);
            groupBox1.Controls.Add(lblFechaNacimiento1);
            groupBox1.Controls.Add(lblNombre1);
            groupBox1.Controls.Add(lblDocumento1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(218, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 151);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del paciente :";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraSocial.Location = new Point(215, 106);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(0, 21);
            lblObraSocial.TabIndex = 49;
            lblObraSocial.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(215, 80);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(0, 21);
            lblFechaNacimiento.TabIndex = 48;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(215, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 21);
            lblNombre.TabIndex = 46;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(215, 54);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(0, 21);
            lblDocumento.TabIndex = 47;
            // 
            // cboPacientes
            // 
            cboPacientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPacientes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboPacientes.ForeColor = SystemColors.MenuHighlight;
            cboPacientes.FormattingEnabled = true;
            cboPacientes.Location = new Point(262, 58);
            cboPacientes.Name = "cboPacientes";
            cboPacientes.Size = new Size(363, 25);
            cboPacientes.TabIndex = 47;
            cboPacientes.SelectedIndexChanged += cboPacientes_SelectedIndexChanged;
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(262, 36);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(165, 19);
            lblNacimiento.TabIndex = 48;
            lblNacimiento.Text = "BUSCAR POR NOMBRE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(194, 19);
            label1.TabIndex = 49;
            label1.Text = "BUSCAR POR DOCUMENTO:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(cboPacientes);
            groupBox2.Controls.Add(txtBuscarPaciente);
            groupBox2.Controls.Add(lblNacimiento);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(218, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(645, 109);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Paciente :";
            // 
            // richTextBoxHistoria
            // 
            richTextBoxHistoria.BorderStyle = BorderStyle.None;
            richTextBoxHistoria.Location = new Point(3, 4);
            richTextBoxHistoria.Name = "richTextBoxHistoria";
            richTextBoxHistoria.Size = new Size(639, 212);
            richTextBoxHistoria.TabIndex = 51;
            richTextBoxHistoria.Text = "";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(richTextBoxHistoria);
            panel2.Location = new Point(218, 345);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 219);
            panel2.TabIndex = 52;
            // 
            // AtencionPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegistrar);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AtencionPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATENCION DE PACIENTES";
            Load += NuevoTurno_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Button btnRegistrar;
        private Label lblTitulo;
        private Label lblNombre1;
        private Label lblDocumento1;
        private Label lblFechaNacimiento1;
        private Label lblObraSocial1;
        private Button btnBuscar;
        private TextBox txtBuscarPaciente;
        private GroupBox groupBox1;
        private Label lblObraSocial;
        private Label lblFechaNacimiento;
        private Label lblNombre;
        private Label lblDocumento;
        private ComboBox cboPacientes;
        private Label lblNacimiento;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox richTextBoxHistoria;
        private Panel panel2;
    }
}