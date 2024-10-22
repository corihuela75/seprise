
namespace Clinica_SePrise.Medicos

{
    public partial class NuevoMedico : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoMedico));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblMatricula = new Label();
            lblNacimiento = new Label();
            txtNombre = new TextBox();
            txtMatricula = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblAsterisco = new Label();
            panel1 = new Panel();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            cboEspecialidad = new ComboBox();
            txtContraseña = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(328, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "REGISTRAR MEDICO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(327, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(97, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "( * ) Nombre:";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatricula.Location = new Point(314, 166);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(104, 19);
            lblMatricula.TabIndex = 3;
            lblMatricula.Text = "( * ) Matricula:";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(294, 209);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(124, 19);
            lblNacimiento.TabIndex = 5;
            lblNacimiento.Text = "( * ) Especialidad:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = SystemColors.MenuHighlight;
            txtNombre.Location = new Point(434, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(404, 25);
            txtNombre.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatricula.ForeColor = SystemColors.MenuHighlight;
            txtMatricula.Location = new Point(434, 163);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(98, 25);
            txtMatricula.TabIndex = 3;
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
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
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
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.MenuHighlight;
            txtEmail.Location = new Point(434, 292);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(404, 25);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(375, 295);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsterisco.Location = new Point(200, 592);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(192, 15);
            lblAsterisco.TabIndex = 20;
            lblAsterisco.Text = "( * ) Campos de ingreso obligatorio";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 657);
            panel1.TabIndex = 21;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = SystemColors.MenuHighlight;
            txtTelefono.Location = new Point(434, 249);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(124, 25);
            txtTelefono.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(325, 252);
            label2.Name = "label2";
            label2.Size = new Size(99, 19);
            label2.TabIndex = 25;
            label2.Text = "( * ) Teléfono:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = SystemColors.MenuHighlight;
            txtApellido.Location = new Point(434, 120);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(404, 25);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(320, 123);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 27;
            label3.Text = "( * ) Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(333, 381);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 29;
            label4.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = SystemColors.MenuHighlight;
            txtUsuario.Location = new Point(434, 335);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 25);
            txtUsuario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 338);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 23;
            label1.Text = "Usuario:";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboEspecialidad.ForeColor = SystemColors.MenuHighlight;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Medicina Interna", "Pediatría", "Ginecología", "Obstetricia", "Cardiología", "Neurología", "Psiquiatría", "Cirugía General", "Ortopedia y Traumatología", "Otorrinolaringología", "Oftalmología", "Urología", "Dermatología", "Radiología", "Anestesiología", "Patología", "Medicina Nuclear", "Medicina del Trabajo", "Medicina Preventiva", "Medicina Intensiva", "Geriatría", "Alergología e Inmunología", "Anatomía Patológica", "Cirugía Cardiovascular", "Neurocirugía", "Cirugía Pediátrica", "Cirugía Plástica y Reparadora", "Gastroenterología", "Hematología", "Nefrología", "Neumología", "Reumatología", "Endocrinología" });
            cboEspecialidad.Location = new Point(434, 209);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(404, 25);
            cboEspecialidad.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = SystemColors.MenuHighlight;
            txtContraseña.Location = new Point(434, 378);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(214, 25);
            txtContraseña.TabIndex = 8;
            // 
            // NuevoMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(txtContraseña);
            Controls.Add(cboEspecialidad);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(lblAsterisco);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtMatricula);
            Controls.Add(txtNombre);
            Controls.Add(lblNacimiento);
            Controls.Add(lblMatricula);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Name = "NuevoMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR MEDICO";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblMatricula;
        private Label lblNacimiento;
        private TextBox txtEmail;
        //private TextBox textBox2;
        //private TextBox textBox3;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private TextBox txtNombre;
        private TextBox txtMatricula;        
        private Label lblEmail;
        private Label lblAsterisco;
        private Panel panel1;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private Label label1;
        private ComboBox cboEspecialidad;
        private TextBox txtContraseña;
    }
}