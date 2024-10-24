
namespace Clinica_SePrise.Pacientes
{
    public partial class NuevoPaciente : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPaciente));
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            lblTipo = new Label();
            lblNacimiento = new Label();
            cboGenero = new ComboBox();
            txtNombre = new TextBox();
            txtDocu = new TextBox();
            txtNacimiento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cboEstado = new ComboBox();
            lblApto = new Label();
            lblAsterisco = new Label();
            panel1 = new Panel();
            txtEdad = new TextBox();
            label1 = new Label();
            txtTelefono = new TextBox();
            label2 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtObra = new TextBox();
            label4 = new Label();
            txtHistoria = new TextBox();
            label5 = new Label();
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
            lblTitulo.Size = new Size(351, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "REGISTRAR PACIENTE";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(249, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(183, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "( * ) NOMBRE COMPLETO :";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(366, 114);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(66, 19);
            lblDni.TabIndex = 3;
            lblDni.Text = "( * ) DNI:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(332, 318);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(100, 19);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "( * ) GENERO :";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(231, 250);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(201, 19);
            lblNacimiento.TabIndex = 5;
            lblNacimiento.Text = "( * ) FECHA DE NACIMIENTO :";
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboGenero.ForeColor = SystemColors.MenuHighlight;
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cboGenero.Location = new Point(434, 315);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 25);
            cboGenero.TabIndex = 8;
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
            // txtDocu
            // 
            txtDocu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocu.ForeColor = SystemColors.MenuHighlight;
            txtDocu.Location = new Point(434, 111);
            txtDocu.Name = "txtDocu";
            txtDocu.Size = new Size(98, 25);
            txtDocu.TabIndex = 2;
            // 
            // txtNacimiento
            // 
            txtNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNacimiento.ForeColor = SystemColors.MenuHighlight;
            txtNacimiento.Location = new Point(434, 247);
            txtNacimiento.Name = "txtNacimiento";
            txtNacimiento.Size = new Size(124, 25);
            txtNacimiento.TabIndex = 6;
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
            btnIngresar.TabIndex = 12;
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
            btnLimpiar.TabIndex = 13;
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
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.MenuHighlight;
            txtEmail.Location = new Point(434, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(404, 25);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(346, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(86, 19);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "( * ) EMAIL :";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboEstado.ForeColor = SystemColors.MenuHighlight;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Soltero", "Casado", "Divorciado", "Viudo", "Otro" });
            cboEstado.Location = new Point(434, 349);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 25);
            cboEstado.TabIndex = 9;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblApto.Location = new Point(325, 352);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(107, 19);
            lblApto.TabIndex = 18;
            lblApto.Text = "ESTADO CIVIL :";
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
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.ForeColor = SystemColors.MenuHighlight;
            txtEdad.Location = new Point(434, 281);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(98, 25);
            txtEdad.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(378, 284);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 23;
            label1.Text = "EDAD :";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = SystemColors.MenuHighlight;
            txtTelefono.Location = new Point(434, 179);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(124, 25);
            txtTelefono.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(318, 182);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 25;
            label2.Text = "( * ) TELEFONO :";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = SystemColors.MenuHighlight;
            txtDireccion.Location = new Point(434, 145);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(404, 25);
            txtDireccion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(313, 148);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 27;
            label3.Text = "( * ) DIRECCION :";
            // 
            // txtObra
            // 
            txtObra.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtObra.ForeColor = SystemColors.MenuHighlight;
            txtObra.Location = new Point(434, 383);
            txtObra.Name = "txtObra";
            txtObra.Size = new Size(404, 25);
            txtObra.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(323, 386);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 29;
            label4.Text = "OBRA SOCIAL :";
            // 
            // txtHistoria
            // 
            txtHistoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtHistoria.ForeColor = SystemColors.MenuHighlight;
            txtHistoria.Location = new Point(435, 415);
            txtHistoria.Multiline = true;
            txtHistoria.Name = "txtHistoria";
            txtHistoria.Size = new Size(404, 160);
            txtHistoria.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(293, 418);
            label5.Name = "label5";
            label5.Size = new Size(139, 19);
            label5.TabIndex = 31;
            label5.Text = "HISTORIA CLINICA :";
            // 
            // NuevoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(txtHistoria);
            Controls.Add(label5);
            Controls.Add(txtObra);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtEdad);
            Controls.Add(label1);
            Controls.Add(lblAsterisco);
            Controls.Add(cboEstado);
            Controls.Add(lblApto);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtNacimiento);
            Controls.Add(txtDocu);
            Controls.Add(txtNombre);
            Controls.Add(cboGenero);
            Controls.Add(lblNacimiento);
            Controls.Add(lblTipo);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Name = "NuevoPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR PACIENTE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pictureBox1;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblDni;
        private Label lblTipo;
        private Label lblNacimiento;
        private ComboBox cboEstado;
        private TextBox txtEmail;
        //private TextBox textBox2;
        //private TextBox textBox3;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private TextBox txtNombre;
        private TextBox txtDocu;        
        private TextBox txtNacimiento;
        private ComboBox cboGenero;
        private Label lblEmail;
        private Label lblApto;
        private Label lblAsterisco;
        private Panel panel1;
        private TextBox txtEdad;
        private Label label1;
        private TextBox txtTelefono;
        private Label label2;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtObra;
        private Label label4;
        private TextBox txtHistoria;
        private Label label5;
    }
}