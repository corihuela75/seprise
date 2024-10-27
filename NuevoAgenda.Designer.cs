
namespace Clinica_SePrise.Turnos
{
    public partial class NuevoAgenda: Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoAgenda));
            lblTitulo = new Label();
            lblTipo = new Label();
            lblNacimiento = new Label();
            cboConsultorio = new ComboBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            cboMedico = new ComboBox();
            lblApto = new Label();
            lblAsterisco = new Label();
            cboTurno = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(337, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "REGISTRAR AGENDA";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(210, 255);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(216, 19);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "( * ) CONSULTORIO ASIGNADO:";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(337, 108);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(89, 19);
            lblNacimiento.TabIndex = 5;
            lblNacimiento.Text = "( * ) FECHA :";
            // 
            // cboConsultorio
            // 
            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboConsultorio.ForeColor = SystemColors.MenuHighlight;
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboConsultorio.Location = new Point(436, 254);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(36, 25);
            cboConsultorio.TabIndex = 8;
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
            // cboMedico
            // 
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboMedico.ForeColor = SystemColors.MenuHighlight;
            cboMedico.FormattingEnabled = true;
            cboMedico.Location = new Point(436, 154);
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(404, 25);
            cboMedico.TabIndex = 9;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblApto.Location = new Point(327, 157);
            lblApto.Name = "lblApto";
            lblApto.Size = new Size(99, 19);
            lblApto.TabIndex = 18;
            lblApto.Text = "( * ) MEDICO :";
            // 
            // lblAsterisco
            // 
            lblAsterisco.AutoSize = true;
            lblAsterisco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsterisco.Location = new Point(234, 306);
            lblAsterisco.Name = "lblAsterisco";
            lblAsterisco.Size = new Size(192, 15);
            lblAsterisco.TabIndex = 20;
            lblAsterisco.Text = "( * ) Campos de ingreso obligatorio";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboTurno.ForeColor = SystemColors.MenuHighlight;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "mañana", "tarde" });
            cboTurno.Location = new Point(436, 204);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 25);
            cboTurno.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(332, 206);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 31;
            label5.Text = "( * ) TURNO :";
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 657);
            panel1.TabIndex = 21;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(436, 104);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(121, 25);
            dtpFecha.TabIndex = 32;
            dtpFecha.Value = new DateTime(2024, 10, 23, 22, 30, 28, 0);
            // 
            // NuevoAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(895, 651);
            Controls.Add(dtpFecha);
            Controls.Add(cboTurno);
            Controls.Add(label5);
            Controls.Add(lblAsterisco);
            Controls.Add(cboMedico);
            Controls.Add(lblApto);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(cboConsultorio);
            Controls.Add(lblNacimiento);
            Controls.Add(lblTipo);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Name = "NuevoAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR TURNOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblTipo;
        private Label lblNacimiento;
        private ComboBox cboMedico;
        //private TextBox textBox2;
        //private TextBox textBox3;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private ComboBox cboConsultorio;
        private Label lblApto;
        private Label lblAsterisco;
        private ComboBox cboTurno;
        private Label label5;
        private PictureBox pictureBox1;
        private Panel panel1;
        private DateTimePicker dtpFecha;
    }
}