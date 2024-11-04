namespace Clinica_SePrise.Diagnosticar


{
    partial class Diagnostico : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnostico));
            panel1 = new Panel();
            lblIngreso = new Label();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            btnRegistrar = new Button();
            lblTitulo = new Label();
            lblNombre1 = new Label();
            lblDocumento1 = new Label();
            lblFechaNacimiento1 = new Label();
            lblObraSocial1 = new Label();
            groupBox1 = new GroupBox();
            lblObraSocial = new Label();
            lblFechaNacimiento = new Label();
            lblNombre = new Label();
            lblDocumento = new Label();
            panel2 = new Panel();
            richConsulta = new RichTextBox();
            panel4 = new Panel();
            panel8 = new Panel();
            richNotas = new RichTextBox();
            lblNotas = new Label();
            panel7 = new Panel();
            richTratamiento = new RichTextBox();
            lblTratamiento = new Label();
            panel6 = new Panel();
            richDiagnostico = new RichTextBox();
            lblDiagnostico = new Label();
            panel5 = new Panel();
            richExamen = new RichTextBox();
            lblHistorial = new Label();
            lblExamen = new Label();
            panel3 = new Panel();
            richHistoria = new RichTextBox();
            lblConsulta = new Label();
            lblAsterisco = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblIngreso);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 857);
            panel1.TabIndex = 22;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(10, 190);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(38, 15);
            lblIngreso.TabIndex = 57;
            lblIngreso.Text = "label3";
            lblIngreso.TextAlign = ContentAlignment.MiddleLeft;
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
            btnVolver.Location = new Point(557, 792);
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
            btnRegistrar.Location = new Point(720, 792);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 48);
            btnRegistrar.TabIndex = 23;
            btnRegistrar.Text = "REGISTRAR DIAGNOSTICO";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(571, 45);
            lblTitulo.TabIndex = 27;
            lblTitulo.Text = "REGISTRAR ATENCION DE PACIENTE";
            // 
            // lblNombre1
            // 
            lblNombre1.AutoSize = true;
            lblNombre1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre1.Location = new Point(58, 19);
            lblNombre1.Name = "lblNombre1";
            lblNombre1.Size = new Size(75, 21);
            lblNombre1.TabIndex = 42;
            lblNombre1.Text = "Nombre :";
            // 
            // lblDocumento1
            // 
            lblDocumento1.AutoSize = true;
            lblDocumento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocumento1.Location = new Point(35, 40);
            lblDocumento1.Name = "lblDocumento1";
            lblDocumento1.Size = new Size(98, 21);
            lblDocumento1.TabIndex = 43;
            lblDocumento1.Text = "Documento :";
            // 
            // lblFechaNacimiento1
            // 
            lblFechaNacimiento1.AutoSize = true;
            lblFechaNacimiento1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento1.Location = new Point(323, 19);
            lblFechaNacimiento1.Name = "lblFechaNacimiento1";
            lblFechaNacimiento1.Size = new Size(162, 21);
            lblFechaNacimiento1.TabIndex = 44;
            lblFechaNacimiento1.Text = "Fecha de Nacimiento :";
            // 
            // lblObraSocial1
            // 
            lblObraSocial1.AutoSize = true;
            lblObraSocial1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblObraSocial1.Location = new Point(388, 40);
            lblObraSocial1.Name = "lblObraSocial1";
            lblObraSocial1.Size = new Size(97, 21);
            lblObraSocial1.TabIndex = 45;
            lblObraSocial1.Text = "Obra Social :";
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
            groupBox1.Location = new Point(216, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 77);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del paciente :";
            // 
            // lblObraSocial
            // 
            lblObraSocial.AutoSize = true;
            lblObraSocial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblObraSocial.Location = new Point(491, 40);
            lblObraSocial.Name = "lblObraSocial";
            lblObraSocial.Size = new Size(0, 21);
            lblObraSocial.TabIndex = 49;
            lblObraSocial.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(491, 19);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(0, 21);
            lblFechaNacimiento.TabIndex = 48;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(139, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 21);
            lblNombre.TabIndex = 46;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(139, 40);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(0, 21);
            lblDocumento.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(richConsulta);
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 100);
            panel2.TabIndex = 52;
            // 
            // richConsulta
            // 
            richConsulta.BorderStyle = BorderStyle.None;
            richConsulta.Location = new Point(0, 0);
            richConsulta.Name = "richConsulta";
            richConsulta.Size = new Size(630, 100);
            richConsulta.TabIndex = 51;
            richConsulta.Text = "";
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(lblNotas);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(lblTratamiento);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(lblDiagnostico);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(lblHistorial);
            panel4.Controls.Add(lblExamen);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(lblConsulta);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(217, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 600);
            panel4.TabIndex = 55;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(richNotas);
            panel8.Location = new Point(0, 790);
            panel8.Name = "panel8";
            panel8.Size = new Size(630, 100);
            panel8.TabIndex = 62;
            // 
            // richNotas
            // 
            richNotas.BorderStyle = BorderStyle.None;
            richNotas.Location = new Point(0, 0);
            richNotas.Name = "richNotas";
            richNotas.Size = new Size(630, 100);
            richNotas.TabIndex = 51;
            richNotas.Text = "";
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNotas.Location = new Point(0, 765);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(141, 21);
            lblNotas.TabIndex = 61;
            lblNotas.Text = "Notas Adicionales :";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(richTratamiento);
            panel7.Location = new Point(0, 640);
            panel7.Name = "panel7";
            panel7.Size = new Size(630, 100);
            panel7.TabIndex = 60;
            // 
            // richTratamiento
            // 
            richTratamiento.BorderStyle = BorderStyle.None;
            richTratamiento.Location = new Point(0, 0);
            richTratamiento.Name = "richTratamiento";
            richTratamiento.Size = new Size(630, 100);
            richTratamiento.TabIndex = 51;
            richTratamiento.Text = "";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTratamiento.Location = new Point(0, 615);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new Size(166, 21);
            lblTratamiento.TabIndex = 59;
            lblTratamiento.Text = "Plan de Tratamiento * :";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(richDiagnostico);
            panel6.Location = new Point(0, 490);
            panel6.Name = "panel6";
            panel6.Size = new Size(630, 100);
            panel6.TabIndex = 58;
            // 
            // richDiagnostico
            // 
            richDiagnostico.BorderStyle = BorderStyle.None;
            richDiagnostico.Location = new Point(0, 0);
            richDiagnostico.Name = "richDiagnostico";
            richDiagnostico.Size = new Size(630, 100);
            richDiagnostico.TabIndex = 51;
            richDiagnostico.Text = "";
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiagnostico.Location = new Point(0, 465);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(110, 21);
            lblDiagnostico.TabIndex = 57;
            lblDiagnostico.Text = "Diagnóstico * :";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(richExamen);
            panel5.Location = new Point(0, 340);
            panel5.Name = "panel5";
            panel5.Size = new Size(630, 100);
            panel5.TabIndex = 56;
            // 
            // richExamen
            // 
            richExamen.BorderStyle = BorderStyle.None;
            richExamen.Location = new Point(0, 0);
            richExamen.Name = "richExamen";
            richExamen.Size = new Size(630, 100);
            richExamen.TabIndex = 51;
            richExamen.Text = "";
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(0, 165);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(125, 21);
            lblHistorial.TabIndex = 53;
            lblHistorial.Text = "Historia Médica :";
            // 
            // lblExamen
            // 
            lblExamen.AutoSize = true;
            lblExamen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExamen.Location = new Point(0, 315);
            lblExamen.Name = "lblExamen";
            lblExamen.Size = new Size(125, 21);
            lblExamen.TabIndex = 55;
            lblExamen.Text = "Exámen Físico * :";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(richHistoria);
            panel3.Location = new Point(0, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 100);
            panel3.TabIndex = 54;
            // 
            // richHistoria
            // 
            richHistoria.BorderStyle = BorderStyle.None;
            richHistoria.Location = new Point(0, 0);
            richHistoria.Name = "richHistoria";
            richHistoria.Size = new Size(630, 100);
            richHistoria.TabIndex = 51;
            richHistoria.Text = "";
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConsulta.Location = new Point(0, 15);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(160, 21);
            lblConsulta.TabIndex = 50;
            lblConsulta.Text = "Motivo de consulta * :";
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsterisco.Location = new Point(216, 154);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(192, 15);
            lblAsterisco.TabIndex = 56;
            lblAsterisco.Text = "( * ) Campos de ingreso obligatorio";
            // 
            // Diagnostico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 861);
            Controls.Add(lblAsterisco);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegistrar);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Diagnostico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATENCION DE PACIENTES";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Label lblObraSocial;
        private Label lblFechaNacimiento;
        private Label lblNombre;
        private Label lblDocumento;
        private Panel panel2;
        private Panel panel4;
        private RichTextBox richConsulta;
        private Label lblConsulta;
        private Label lblHistorial;
        private Panel panel3;
        private RichTextBox richHistoria;
        private Panel panel5;
        private RichTextBox richExamen;
        private Label lblExamen;
        private Panel panel6;
        private RichTextBox richDiagnostico;
        private Label lblDiagnostico;
        private Panel panel7;
        private RichTextBox richTratamiento;
        private Label lblTratamiento;
        private Panel panel8;
        private RichTextBox richNotas;
        private Label lblNotas;
        private Label lblAsterisco;
        private Label lblIngreso;
    }
}