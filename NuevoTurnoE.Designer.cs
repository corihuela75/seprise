﻿namespace Clinica_SePrise.TurnoE 
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
            lblAsterisco = new Label();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            lblTitulo = new Label();
            cboEspecialidad = new ComboBox();
            lblNacimiento = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsterisco.Location = new Point(200, 592);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(192, 15);
            lblAsterisco.TabIndex = 26;
            lblAsterisco.Text = "( * ) Campos de ingreso obligatorio";
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
            btnVolver.TabIndex = 25;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
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
            btnIngresar.Location = new Point(412, 592);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(145, 47);
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
            // NuevoTurnoE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(cboEspecialidad);
            Controls.Add(lblNacimiento);
            Controls.Add(lblTitulo);
            Controls.Add(lblAsterisco);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NuevoTurnoE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE TURNO POR ESPECIALIDAD";
            Load += NuevoTurno_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblAsterisco;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnIngresar;
        private Label lblTitulo;
        private ComboBox cboEspecialidad;
        private Label lblNacimiento;
    }
}