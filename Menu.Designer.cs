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
            btnEspera = new Button();
            btnAdministrativa = new Button();
            btnFour = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnOne = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            lblIngreso = new Label();
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
            btnTurnos.Location = new Point(33, 229);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(296, 87);
            btnTurnos.TabIndex = 2;
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
            panel1.Controls.Add(btnEspera);
            panel1.Controls.Add(btnAdministrativa);
            panel1.Controls.Add(btnTurnos);
            panel1.Controls.Add(btnFour);
            panel1.Controls.Add(btnTwo);
            panel1.Controls.Add(btnThree);
            panel1.Controls.Add(btnOne);
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
            btnAtencion.Location = new Point(33, 481);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(296, 87);
            btnAtencion.TabIndex = 4;
            btnAtencion.Text = "ATENCION DEL PACIENTE";
            btnAtencion.UseVisualStyleBackColor = false;
            btnAtencion.Click += btnAtencion_Click;
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
            // btnEspera
            // 
            btnEspera.BackColor = Color.Azure;
            btnEspera.FlatAppearance.BorderColor = Color.LightBlue;
            btnEspera.FlatAppearance.BorderSize = 3;
            btnEspera.FlatStyle = FlatStyle.Flat;
            btnEspera.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEspera.ForeColor = Color.SteelBlue;
            btnEspera.Location = new Point(33, 355);
            btnEspera.Name = "btnEspera";
            btnEspera.Size = new Size(296, 87);
            btnEspera.TabIndex = 3;
            btnEspera.Text = "RECEPCION EN SALA DE ESPERA";
            btnEspera.UseVisualStyleBackColor = false;
            btnEspera.Click += btnSalaEspera_Click;
            // 
            // btnAdministrativa
            // 
            btnAdministrativa.BackColor = Color.Azure;
            btnAdministrativa.FlatAppearance.BorderColor = Color.LightBlue;
            btnAdministrativa.FlatAppearance.BorderSize = 3;
            btnAdministrativa.FlatStyle = FlatStyle.Flat;
            btnAdministrativa.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdministrativa.ForeColor = Color.SteelBlue;
            btnAdministrativa.Location = new Point(33, 103);
            btnAdministrativa.Name = "btnAdministrativa";
            btnAdministrativa.Size = new Size(296, 87);
            btnAdministrativa.TabIndex = 1;
            btnAdministrativa.Text = "GESTION ADMINISTRATIVA";
            btnAdministrativa.UseVisualStyleBackColor = false;
            btnAdministrativa.Click += btnAdministrativa_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.Azure;
            btnFour.FlatAppearance.BorderColor = Color.LightBlue;
            btnFour.FlatAppearance.BorderSize = 3;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFour.ForeColor = Color.SteelBlue;
            btnFour.Location = new Point(410, 441);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(250, 75);
            btnFour.TabIndex = 8;
            btnFour.Text = "Opcion 4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnOpFour_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.Azure;
            btnTwo.FlatAppearance.BorderColor = Color.LightBlue;
            btnTwo.FlatAppearance.BorderSize = 3;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTwo.ForeColor = Color.SteelBlue;
            btnTwo.Location = new Point(410, 241);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(250, 75);
            btnTwo.TabIndex = 6;
            btnTwo.Text = "Opcion 2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnOpTwo_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.Azure;
            btnThree.FlatAppearance.BorderColor = Color.LightBlue;
            btnThree.FlatAppearance.BorderSize = 3;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThree.ForeColor = Color.SteelBlue;
            btnThree.Location = new Point(410, 341);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(250, 75);
            btnThree.TabIndex = 7;
            btnThree.Text = "Opcion 3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnOpThree_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.Azure;
            btnOne.FlatAppearance.BorderColor = Color.LightBlue;
            btnOne.FlatAppearance.BorderSize = 3;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOne.ForeColor = Color.SteelBlue;
            btnOne.Location = new Point(410, 141);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(250, 75);
            btnOne.TabIndex = 5;
            btnOne.Text = "Opcion 1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOpOne_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkRed;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 0);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(42, 513);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 50);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 14;
            label1.Text = "CLINICA SEPRISE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 50);
            label2.Name = "label2";
            label2.Size = new Size(169, 30);
            label2.TabIndex = 15;
            label2.Text = "Sistema General";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(119, 123);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(38, 15);
            lblIngreso.TabIndex = 16;
            lblIngreso.Text = "label3";
            lblIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1010, 606);
            Controls.Add(lblIngreso);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE LA CLINICA SEPRISE";
            FormClosing += Menu_FormClosing;
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
        private Button btnTurnos;
        private Button btnSalir;
        private Button btnAdministrativa;
        private Button btnEspera;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Button btnTwo;
        private Button btnThree;
        private Button btnOne;
        private Button btnFour;
        private Button btnAtencion;
        private Label lblIngreso;
    }
}
