namespace Clinica_SePrise
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnTurnos = new Button();
            picLogo = new PictureBox();
            panel1 = new Panel();
            btnAtencion = new Button();
            lblTitulo = new Label();
            btnRecepcion = new Button();
            btnGestion = new Button();
            btnSalir = new Button();
            btnVolver = new Button();
            btnAgenda = new Button();
            btnMedicos = new Button();
            btnPacientes = new Button();
            lblIngreso = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTurnos
            // 
            btnTurnos.BackColor = Color.Azure;
            btnTurnos.FlatAppearance.BorderColor = Color.LightBlue;
            btnTurnos.FlatAppearance.BorderSize = 3;
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTurnos.ForeColor = Color.SteelBlue;
            btnTurnos.Location = new Point(51, 146);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(296, 87);
            btnTurnos.TabIndex = 6;
            btnTurnos.Text = "GESTION DE TURNOS";
            btnTurnos.UseVisualStyleBackColor = false;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(-2, 168);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(279, 250);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btnAtencion);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnRecepcion);
            panel1.Controls.Add(btnGestion);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnTurnos);
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(btnAgenda);
            panel1.Controls.Add(btnMedicos);
            panel1.Controls.Add(btnPacientes);
            panel1.Location = new Point(279, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 612);
            panel1.TabIndex = 8;
            // 
            // btnAtencion
            // 
            btnAtencion.BackColor = Color.Azure;
            btnAtencion.FlatAppearance.BorderColor = Color.LightBlue;
            btnAtencion.FlatAppearance.BorderSize = 3;
            btnAtencion.FlatStyle = FlatStyle.Flat;
            btnAtencion.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtencion.ForeColor = Color.SteelBlue;
            btnAtencion.Location = new Point(381, 262);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(296, 87);
            btnAtencion.TabIndex = 15;
            btnAtencion.Text = "ATENCION DEL PACIENTE";
            btnAtencion.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(33, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 32);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "MENU PRINCIPAL";
            // 
            // btnRecepcion
            // 
            btnRecepcion.BackColor = Color.Azure;
            btnRecepcion.FlatAppearance.BorderColor = Color.LightBlue;
            btnRecepcion.FlatAppearance.BorderSize = 3;
            btnRecepcion.FlatStyle = FlatStyle.Flat;
            btnRecepcion.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecepcion.ForeColor = Color.SteelBlue;
            btnRecepcion.Location = new Point(381, 146);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(296, 87);
            btnRecepcion.TabIndex = 10;
            btnRecepcion.Text = "RECEPCION EN SALA DE ESPERA";
            btnRecepcion.UseVisualStyleBackColor = false;
            btnRecepcion.Click += btnCarnet_Click;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.Azure;
            btnGestion.FlatAppearance.BorderColor = Color.LightBlue;
            btnGestion.FlatAppearance.BorderSize = 3;
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestion.ForeColor = Color.SteelBlue;
            btnGestion.Location = new Point(51, 262);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(296, 87);
            btnGestion.TabIndex = 9;
            btnGestion.Text = "GESTION ADMINISTRATIVA";
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Azure;
            btnSalir.FlatAppearance.BorderColor = Color.LightBlue;
            btnSalir.FlatAppearance.BorderSize = 3;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.SteelBlue;
            btnSalir.Location = new Point(381, 378);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(296, 87);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Azure;
            btnVolver.FlatAppearance.BorderColor = Color.LightBlue;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.SteelBlue;
            btnVolver.Location = new Point(366, 309);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(296, 87);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Visible = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.BackColor = Color.Azure;
            btnAgenda.FlatAppearance.BorderColor = Color.LightBlue;
            btnAgenda.FlatAppearance.BorderSize = 3;
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgenda.ForeColor = Color.SteelBlue;
            btnAgenda.Location = new Point(64, 309);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(296, 87);
            btnAgenda.TabIndex = 13;
            btnAgenda.Text = "GESTIONAR AGENDA";
            btnAgenda.UseVisualStyleBackColor = false;
            btnAgenda.Visible = false;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = Color.Azure;
            btnMedicos.FlatAppearance.BorderColor = Color.LightBlue;
            btnMedicos.FlatAppearance.BorderSize = 3;
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedicos.ForeColor = Color.SteelBlue;
            btnMedicos.Location = new Point(366, 216);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(296, 87);
            btnMedicos.TabIndex = 12;
            btnMedicos.Text = "GESTIONAR PERSONAL MEDICO";
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Visible = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = Color.Azure;
            btnPacientes.FlatAppearance.BorderColor = Color.LightBlue;
            btnPacientes.FlatAppearance.BorderSize = 3;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPacientes.ForeColor = Color.SteelBlue;
            btnPacientes.Location = new Point(64, 216);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(296, 87);
            btnPacientes.TabIndex = 11;
            btnPacientes.Text = "GESTIONAR PACIENTES";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Visible = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(12, 582);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(38, 15);
            lblIngreso.TabIndex = 11;
            lblIngreso.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 14;
            label1.Text = "CLINICA SEPRISE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(169, 30);
            label2.TabIndex = 15;
            label2.Text = "Sistema General";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1010, 606);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblIngreso);
            Controls.Add(panel1);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE LA CLINICA SEPRISE";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private PictureBox picLogo;
        private Panel panel1;
        private Label lblIngreso;
        private Button btnTurnos;
        private Button btnSalir;
        private Button btnGestion;
        private Button btnRecepcion;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Button btnAgenda;
        private Button btnMedicos;
        private Button btnPacientes;
        private Button btnVolver;
        private Button btnAtencion;
    }
}
