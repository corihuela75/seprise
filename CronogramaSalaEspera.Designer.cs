namespace Clinica_SePrise
{
    partial class CronogramaSalaEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CronogramaSalaEspera));
            lblTitulo = new Label();
            lv1 = new ListView();
            lv2 = new ListView();
            lv4 = new ListView();
            lv3 = new ListView();
            lv5 = new ListView();
            lblC_1 = new Label();
            lblC_2 = new Label();
            lblC_3 = new Label();
            lblC_4 = new Label();
            lblC_5 = new Label();
            cboTurno = new ComboBox();
            lvlTurno = new Label();
            btnBuscar = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            btnAConsultorio = new Button();
            btnVolver = new Button();
            lblFechaHoy = new Label();
            picLogo = new PictureBox();
            panel1 = new Panel();
            lblIngreso = new Label();
            btnCierre = new Button();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(434, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(516, 37);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "CRONOGRAMA DE LA SALA DE ESPERA";
            // 
            // lv1
            // 
            lv1.Location = new Point(27, 156);
            lv1.Name = "lv1";
            lv1.Size = new Size(439, 265);
            lv1.TabIndex = 15;
            lv1.UseCompatibleStateImageBehavior = false;
            // 
            // lv2
            // 
            lv2.Location = new Point(479, 156);
            lv2.Name = "lv2";
            lv2.Size = new Size(439, 265);
            lv2.TabIndex = 16;
            lv2.UseCompatibleStateImageBehavior = false;
            // 
            // lv4
            // 
            lv4.Location = new Point(479, 468);
            lv4.Name = "lv4";
            lv4.Size = new Size(439, 265);
            lv4.TabIndex = 18;
            lv4.UseCompatibleStateImageBehavior = false;
            // 
            // lv3
            // 
            lv3.Location = new Point(27, 468);
            lv3.Name = "lv3";
            lv3.Size = new Size(439, 265);
            lv3.TabIndex = 17;
            lv3.UseCompatibleStateImageBehavior = false;
            // 
            // lv5
            // 
            lv5.Location = new Point(931, 468);
            lv5.Name = "lv5";
            lv5.Size = new Size(439, 265);
            lv5.TabIndex = 19;
            lv5.UseCompatibleStateImageBehavior = false;
            // 
            // lblC_1
            // 
            lblC_1.AutoSize = true;
            lblC_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_1.Location = new Point(178, 132);
            lblC_1.Name = "lblC_1";
            lblC_1.Size = new Size(112, 21);
            lblC_1.TabIndex = 20;
            lblC_1.Text = "Consultorio 1";
            // 
            // lblC_2
            // 
            lblC_2.AutoSize = true;
            lblC_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_2.Location = new Point(630, 132);
            lblC_2.Name = "lblC_2";
            lblC_2.Size = new Size(112, 21);
            lblC_2.TabIndex = 20;
            lblC_2.Text = "Consultorio 2";
            // 
            // lblC_3
            // 
            lblC_3.AutoSize = true;
            lblC_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_3.Location = new Point(178, 444);
            lblC_3.Name = "lblC_3";
            lblC_3.Size = new Size(112, 21);
            lblC_3.TabIndex = 20;
            lblC_3.Text = "Consultorio 3";
            // 
            // lblC_4
            // 
            lblC_4.AutoSize = true;
            lblC_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_4.Location = new Point(630, 444);
            lblC_4.Name = "lblC_4";
            lblC_4.Size = new Size(112, 21);
            lblC_4.TabIndex = 20;
            lblC_4.Text = "Consultorio 4";
            // 
            // lblC_5
            // 
            lblC_5.AutoSize = true;
            lblC_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_5.Location = new Point(1082, 444);
            lblC_5.Name = "lblC_5";
            lblC_5.Size = new Size(112, 21);
            lblC_5.TabIndex = 20;
            lblC_5.Text = "Consultorio 5";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboTurno.ForeColor = SystemColors.MenuHighlight;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "mañana", "tarde" });
            cboTurno.Location = new Point(1099, 32);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(202, 25);
            cboTurno.TabIndex = 29;
            cboTurno.SelectedIndexChanged += cboTurno_SelectedIndexChanged;
            // 
            // lvlTurno
            // 
            lvlTurno.AutoSize = true;
            lvlTurno.BackColor = Color.White;
            lvlTurno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lvlTurno.Location = new Point(1036, 34);
            lvlTurno.Name = "lvlTurno";
            lvlTurno.Size = new Size(54, 21);
            lvlTurno.TabIndex = 30;
            lvlTurno.Text = "Turno";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Azure;
            btnBuscar.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1208, 86);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 25);
            btnBuscar.TabIndex = 43;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(1043, 88);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 21);
            lblDni.TabIndex = 44;
            lblDni.Text = "D.N.I";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(1099, 87);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(94, 23);
            txtDni.TabIndex = 46;
            // 
            // btnAConsultorio
            // 
            btnAConsultorio.BackColor = Color.Azure;
            btnAConsultorio.FlatAppearance.BorderColor = Color.LightBlue;
            btnAConsultorio.FlatAppearance.BorderSize = 3;
            btnAConsultorio.FlatStyle = FlatStyle.Flat;
            btnAConsultorio.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAConsultorio.ForeColor = Color.Black;
            btnAConsultorio.Location = new Point(1042, 164);
            btnAConsultorio.Name = "btnAConsultorio";
            btnAConsultorio.Size = new Size(221, 50);
            btnAConsultorio.TabIndex = 47;
            btnAConsultorio.Text = "LLAMAR AL CONSULTORIO";
            btnAConsultorio.UseVisualStyleBackColor = false;
            btnAConsultorio.Click += btnAConsultorio_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Azure;
            btnVolver.FlatAppearance.BorderColor = Color.LightBlue;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.Black;
            btnVolver.Location = new Point(1042, 296);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(222, 50);
            btnVolver.TabIndex = 48;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.AutoSize = true;
            lblFechaHoy.BackColor = Color.White;
            lblFechaHoy.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaHoy.Location = new Point(563, 62);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(50, 28);
            lblFechaHoy.TabIndex = 49;
            lblFechaHoy.Text = "Hoy";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(1, 1);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(147, 123);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 50;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblIngreso);
            panel1.Controls.Add(cboTurno);
            panel1.Controls.Add(lvlTurno);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(lblDni);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1386, 125);
            panel1.TabIndex = 51;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(165, 77);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(38, 15);
            lblIngreso.TabIndex = 35;
            lblIngreso.Text = "label3";
            lblIngreso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCierre
            // 
            btnCierre.BackColor = Color.Red;
            btnCierre.FlatAppearance.BorderColor = Color.LightBlue;
            btnCierre.FlatAppearance.BorderSize = 3;
            btnCierre.FlatStyle = FlatStyle.Flat;
            btnCierre.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCierre.ForeColor = Color.White;
            btnCierre.Location = new Point(1042, 362);
            btnCierre.Name = "btnCierre";
            btnCierre.Size = new Size(222, 50);
            btnCierre.TabIndex = 52;
            btnCierre.Text = "CIERRE DEL DIA";
            btnCierre.UseVisualStyleBackColor = false;
            btnCierre.Click += btnCierre_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Azure;
            btnFinalizar.FlatAppearance.BorderColor = Color.LightBlue;
            btnFinalizar.FlatAppearance.BorderSize = 3;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalizar.ForeColor = Color.Black;
            btnFinalizar.Location = new Point(1042, 230);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(221, 50);
            btnFinalizar.TabIndex = 53;
            btnFinalizar.Text = "FINALIZAR ATENCION";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // CronogramaSalaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 755);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCierre);
            Controls.Add(picLogo);
            Controls.Add(lblFechaHoy);
            Controls.Add(btnVolver);
            Controls.Add(btnAConsultorio);
            Controls.Add(lblC_5);
            Controls.Add(lblC_4);
            Controls.Add(lblC_3);
            Controls.Add(lblC_2);
            Controls.Add(lblC_1);
            Controls.Add(lv5);
            Controls.Add(lv4);
            Controls.Add(lv3);
            Controls.Add(lv2);
            Controls.Add(lv1);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Name = "CronogramaSalaEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SALA DE ESPERA";
            Load += CronogramaSalaEspera_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ListView lv1;
        private ListView lv2;
        private ListView lv4;
        private ListView lv3;
        private ListView lv5;
        private Label lblC_1;
        private Label lblC_2;
        private Label lblC_3;
        private Label lblC_4;
        private Label lblC_5;
        private ComboBox cboTurno;
        private Label lvlTurno;
        private Button btnBuscar;
        private Label lblDni;
        private TextBox txtDni;
        private Button btnAConsultorio;
        private Button btnVolver;
        private Label lblFechaHoy;
        private PictureBox picLogo;
        private Panel panel1;
        private Button btnCierre;
        private Label lblIngreso;
        private Button btnFinalizar;
    }
}