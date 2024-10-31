namespace Clinica_SePrise.Turnos
{
    partial class RatificarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatificarTurno));
            lblTitulo = new Label();
            panel1 = new Panel();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            lblTipo = new Label();
            txtIdTurno = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            lblObraSocial = new Label();
            lblFechaNacimiento = new Label();
            lblNombre = new Label();
            lblDocumento = new Label();
            lblObraSocial1 = new Label();
            lblFechaNacimiento1 = new Label();
            lblNombre1 = new Label();
            lblDocumento1 = new Label();
            groupBox2 = new GroupBox();
            lblOSInfo = new Label();
            rbtObraSocial = new RadioButton();
            rbtParticular = new RadioButton();
            btnRatificar = new Button();
            btnVolver = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(303, 45);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "RATIFICAR TURNO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 657);
            panel1.TabIndex = 23;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(72, 212);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 24;
            lblName.Text = "name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(276, 108);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(78, 19);
            lblTipo.TabIndex = 24;
            lblTipo.Text = "N° TURNO";
            // 
            // txtIdTurno
            // 
            txtIdTurno.Location = new Point(371, 106);
            txtIdTurno.Name = "txtIdTurno";
            txtIdTurno.Size = new Size(316, 23);
            txtIdTurno.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Azure;
            btnSearch.FlatAppearance.BorderColor = Color.LightBlue;
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(708, 103);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 28);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(228, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 166);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Verifique los datos del paciente :";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraSocial.Location = new Point(207, 124);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(0, 21);
            lblObraSocial.TabIndex = 49;
            lblObraSocial.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(207, 92);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(0, 21);
            lblFechaNacimiento.TabIndex = 48;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(207, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 21);
            lblNombre.TabIndex = 46;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(207, 60);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(0, 21);
            lblDocumento.TabIndex = 47;
            // 
            // lblObraSocial1
            // 
            lblObraSocial1.AutoSize = true;
            lblObraSocial1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblObraSocial1.Location = new Point(104, 124);
            lblObraSocial1.Name = "lblObraSocial1";
            lblObraSocial1.Size = new Size(97, 21);
            lblObraSocial1.TabIndex = 45;
            lblObraSocial1.Text = "Obra Social :";
            // 
            // lblFechaNacimiento1
            // 
            lblFechaNacimiento1.AutoSize = true;
            lblFechaNacimiento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento1.Location = new Point(39, 92);
            lblFechaNacimiento1.Name = "lblFechaNacimiento1";
            lblFechaNacimiento1.Size = new Size(162, 21);
            lblFechaNacimiento1.TabIndex = 44;
            lblFechaNacimiento1.Text = "Fecha de Nacimiento :";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre1.Location = new Point(126, 28);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(75, 21);
            lblNombre1.TabIndex = 42;
            lblNombre1.Text = "Nombre :";
            // 
            // lblDocumento1
            // 
            lblDocumento1.AutoSize = true;
            lblDocumento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento1.Location = new Point(103, 60);
            lblDocumento1.Name = "lblDocumento1";
            lblDocumento1.Size = new Size(98, 21);
            lblDocumento1.TabIndex = 43;
            lblDocumento1.Text = "Documento :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblOSInfo);
            groupBox2.Controls.Add(rbtObraSocial);
            groupBox2.Controls.Add(rbtParticular);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(228, 353);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(645, 170);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccione la forma de pago :";
            // 
            // lblOSInfo
            // 
            lblOSInfo.AutoSize = true;
            lblOSInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblOSInfo.Location = new Point(9, 142);
            lblOSInfo.Name = "lblOSInfo";
            lblOSInfo.Size = new Size(596, 15);
            lblOSInfo.TabIndex = 2;
            lblOSInfo.Text = "Si la opción de Obra Social se muestra deshabilitada, deberá modificarla desde la opción \"Registro de Pacientes\"";
            // 
            // rbtObraSocial
            // 
            rbtObraSocial.AutoSize = true;
            rbtObraSocial.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rbtObraSocial.Location = new Point(315, 64);
            rbtObraSocial.Name = "rbtObraSocial";
            rbtObraSocial.Size = new Size(104, 24);
            rbtObraSocial.TabIndex = 1;
            rbtObraSocial.TabStop = true;
            rbtObraSocial.Text = "Obra Social";
            rbtObraSocial.UseVisualStyleBackColor = true;
            // 
            // rbtParticular
            // 
            rbtParticular.AutoSize = true;
            rbtParticular.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rbtParticular.Location = new Point(187, 64);
            rbtParticular.Name = "rbtParticular";
            rbtParticular.Size = new Size(88, 24);
            rbtParticular.TabIndex = 0;
            rbtParticular.TabStop = true;
            rbtParticular.Text = "Particular";
            rbtParticular.UseVisualStyleBackColor = true;
            // 
            // btnRatificar
            // 
            btnRatificar.BackColor = Color.Azure;
            btnRatificar.FlatAppearance.BorderColor = Color.LightBlue;
            btnRatificar.FlatAppearance.BorderSize = 3;
            btnRatificar.FlatStyle = FlatStyle.Flat;
            btnRatificar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRatificar.ForeColor = Color.SteelBlue;
            btnRatificar.Location = new Point(760, 580);
            btnRatificar.Name = "btnRatificar";
            btnRatificar.Size = new Size(145, 48);
            btnRatificar.TabIndex = 51;
            btnRatificar.Text = "RATIFICAR";
            btnRatificar.UseVisualStyleBackColor = false;
            btnRatificar.Click += btnRatificar_click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Azure;
            btnVolver.FlatAppearance.BorderColor = Color.LightBlue;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.SteelBlue;
            btnVolver.Location = new Point(597, 580);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 48);
            btnVolver.TabIndex = 52;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // RatificarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(933, 651);
            Controls.Add(btnRatificar);
            Controls.Add(btnVolver);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtIdTurno);
            Controls.Add(lblTipo);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Name = "RatificarTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RATIFICAR TURNO";
            FormClosing += RatificarTurno_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblAsterisco;
        private Label lblTipo;
        private TextBox txtIdTurno;
        private Button btnSearch;
        private Label lblName;
        private DataGridView dgbTurno2;
        private GroupBox groupBox1;
        private Label lblObraSocial;
        private Label lblFechaNacimiento;
        private Label lblNombre;
        private Label lblDocumento;
        private Label lblObraSocial1;
        private Label lblFechaNacimiento1;
        private Label lblNombre1;
        private Label lblDocumento1;
        private GroupBox groupBox2;
        private RadioButton rbtObraSocial;
        private RadioButton rbtParticular;
        private Label lblOSInfo;
        private Button btnRatificar;
        private Button btnVolver;
    }
}