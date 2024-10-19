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
            btnAltaSocio = new Button();
            picLogo = new PictureBox();
            panel1 = new Panel();
            btnTodos = new Button();
            btnCuotaVencer = new Button();
            lblTitulo = new Label();
            btnCuotaHoy = new Button();
            btnCuotaVencida = new Button();
            btnCarnet = new Button();
            btnReporSocios = new Button();
            btnSalir = new Button();
            lblIngreso = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.BackColor = Color.Azure;
            btnAltaSocio.FlatAppearance.BorderColor = Color.LightBlue;
            btnAltaSocio.FlatAppearance.BorderSize = 3;
            btnAltaSocio.FlatStyle = FlatStyle.Flat;
            btnAltaSocio.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaSocio.ForeColor = Color.SteelBlue;
            btnAltaSocio.Location = new Point(86, 216);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(217, 52);
            btnAltaSocio.TabIndex = 6;
            btnAltaSocio.Text = "ALTA CLIENTE";
            btnAltaSocio.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(-2, 148);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(279, 250);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(btnTodos);
            panel1.Controls.Add(btnCuotaVencer);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(btnCuotaHoy);
            panel1.Controls.Add(btnCuotaVencida);
            panel1.Controls.Add(btnCarnet);
            panel1.Controls.Add(btnReporSocios);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnAltaSocio);
            panel1.Location = new Point(279, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 612);
            panel1.TabIndex = 8;
            // 
            // btnTodos
            // 
            btnTodos.BackColor = Color.Azure;
            btnTodos.FlatAppearance.BorderColor = Color.LightBlue;
            btnTodos.FlatAppearance.BorderSize = 3;
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTodos.ForeColor = Color.SteelBlue;
            btnTodos.Location = new Point(378, 480);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(217, 52);
            btnTodos.TabIndex = 14;
            btnTodos.Text = "TODOS LOS CLIENTES";
            btnTodos.UseVisualStyleBackColor = false;
            btnTodos.Visible = false;
            // 
            // btnCuotaVencer
            // 
            btnCuotaVencer.BackColor = Color.Azure;
            btnCuotaVencer.FlatAppearance.BorderColor = Color.LightBlue;
            btnCuotaVencer.FlatAppearance.BorderSize = 3;
            btnCuotaVencer.FlatStyle = FlatStyle.Flat;
            btnCuotaVencer.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuotaVencer.ForeColor = Color.SteelBlue;
            btnCuotaVencer.Location = new Point(139, 480);
            btnCuotaVencer.Name = "btnCuotaVencer";
            btnCuotaVencer.Size = new Size(217, 52);
            btnCuotaVencer.TabIndex = 13;
            btnCuotaVencer.Text = "SOCIOS: CUOTA A VENCER";
            btnCuotaVencer.UseVisualStyleBackColor = false;
            btnCuotaVencer.Visible = false;
            btnCuotaVencer.Click += btnCuotaVencer_Click;
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
            // btnCuotaHoy
            // 
            btnCuotaHoy.BackColor = Color.Azure;
            btnCuotaHoy.FlatAppearance.BorderColor = Color.LightBlue;
            btnCuotaHoy.FlatAppearance.BorderSize = 3;
            btnCuotaHoy.FlatStyle = FlatStyle.Flat;
            btnCuotaHoy.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuotaHoy.ForeColor = Color.SteelBlue;
            btnCuotaHoy.Location = new Point(378, 422);
            btnCuotaHoy.Name = "btnCuotaHoy";
            btnCuotaHoy.Size = new Size(217, 52);
            btnCuotaHoy.TabIndex = 12;
            btnCuotaHoy.Text = "SOCIOS: VENCE HOY";
            btnCuotaHoy.UseVisualStyleBackColor = false;
            btnCuotaHoy.Visible = false;
            btnCuotaHoy.Click += btnCuotaHoy_Click;
            // 
            // btnCuotaVencida
            // 
            btnCuotaVencida.BackColor = Color.Azure;
            btnCuotaVencida.FlatAppearance.BorderColor = Color.LightBlue;
            btnCuotaVencida.FlatAppearance.BorderSize = 3;
            btnCuotaVencida.FlatStyle = FlatStyle.Flat;
            btnCuotaVencida.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuotaVencida.ForeColor = Color.SteelBlue;
            btnCuotaVencida.Location = new Point(139, 422);
            btnCuotaVencida.Name = "btnCuotaVencida";
            btnCuotaVencida.Size = new Size(217, 52);
            btnCuotaVencida.TabIndex = 11;
            btnCuotaVencida.Text = "SOCIOS: CUOTA VENCIDA";
            btnCuotaVencida.UseVisualStyleBackColor = false;
            btnCuotaVencida.Visible = false;
            btnCuotaVencida.Click += btnCuotaVencida_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.Azure;
            btnCarnet.FlatAppearance.BorderColor = Color.LightBlue;
            btnCarnet.FlatAppearance.BorderSize = 3;
            btnCarnet.FlatStyle = FlatStyle.Flat;
            btnCarnet.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarnet.ForeColor = Color.SteelBlue;
            btnCarnet.Location = new Point(436, 216);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(217, 52);
            btnCarnet.TabIndex = 10;
            btnCarnet.Text = "EMITIR CARNET";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // btnReporSocios
            // 
            btnReporSocios.BackColor = Color.Azure;
            btnReporSocios.FlatAppearance.BorderColor = Color.LightBlue;
            btnReporSocios.FlatAppearance.BorderSize = 3;
            btnReporSocios.FlatStyle = FlatStyle.Flat;
            btnReporSocios.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporSocios.ForeColor = Color.SteelBlue;
            btnReporSocios.Location = new Point(86, 312);
            btnReporSocios.Name = "btnReporSocios";
            btnReporSocios.Size = new Size(217, 52);
            btnReporSocios.TabIndex = 9;
            btnReporSocios.Text = "REPORTE DE CLIENTES";
            btnReporSocios.UseVisualStyleBackColor = false;
            btnReporSocios.Click += btnReporSocios_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Azure;
            btnSalir.FlatAppearance.BorderColor = Color.LightBlue;
            btnSalir.FlatAppearance.BorderSize = 3;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.SteelBlue;
            btnSalir.Location = new Point(436, 312);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(217, 52);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(12, 582);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(38, 15);
            lblIngreso.TabIndex = 11;
            lblIngreso.Text = "label1";
            lblIngreso.Click += lblIngreso_Click;
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
        private Button btnAltaSocio;
        private Button btnSalir;
        private Button btnReporSocios;
        private Button btnCarnet;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Button btnCuotaVencer;
        private Button btnCuotaHoy;
        private Button btnCuotaVencida;
        private Button btnTodos;
    }
}
