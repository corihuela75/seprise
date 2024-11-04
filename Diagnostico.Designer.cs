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
            richTextBoxHistoria = new RichTextBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            // richTextBoxHistoria
            // 
            richTextBoxHistoria.BorderStyle = BorderStyle.None;
            richTextBoxHistoria.Location = new Point(-1, -1);
            richTextBoxHistoria.Name = "richTextBoxHistoria";
            richTextBoxHistoria.Size = new Size(301, 94);
            richTextBoxHistoria.TabIndex = 51;
            richTextBoxHistoria.Text = "";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(richTextBoxHistoria);
            panel2.Location = new Point(216, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 94);
            panel2.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(216, 161);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 50;
            label1.Text = "Motivo de consulta :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(563, 161);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 53;
            label2.Text = "Motivo de consulta :";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(richTextBox1);
            panel3.Location = new Point(563, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 94);
            panel3.TabIndex = 54;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(-1, -1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(301, 94);
            richTextBox1.TabIndex = 51;
            richTextBox1.Text = "";
            // 
            // Diagnostico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegistrar);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Diagnostico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATENCION DE PACIENTES";
            Load += Diagnostico_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private RichTextBox richTextBoxHistoria;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private RichTextBox richTextBox1;
    }
}