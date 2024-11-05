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
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(535, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(464, 32);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "CRONOGRAMA DE LA SALA DE ESPERA";
            // 
            // lv1
            // 
            lv1.Location = new Point(31, 129);
            lv1.Name = "lv1";
            lv1.Size = new Size(360, 265);
            lv1.TabIndex = 15;
            lv1.UseCompatibleStateImageBehavior = false;
            // 
            // lv2
            // 
            lv2.Location = new Point(459, 129);
            lv2.Name = "lv2";
            lv2.Size = new Size(360, 265);
            lv2.TabIndex = 16;
            lv2.UseCompatibleStateImageBehavior = false;
            // 
            // lv4
            // 
            lv4.Location = new Point(239, 468);
            lv4.Name = "lv4";
            lv4.Size = new Size(360, 265);
            lv4.TabIndex = 18;
            lv4.UseCompatibleStateImageBehavior = false;
            // 
            // lv3
            // 
            lv3.Location = new Point(887, 129);
            lv3.Name = "lv3";
            lv3.Size = new Size(360, 265);
            lv3.TabIndex = 17;
            lv3.UseCompatibleStateImageBehavior = false;
            // 
            // lv5
            // 
            lv5.Location = new Point(671, 468);
            lv5.Name = "lv5";
            lv5.Size = new Size(360, 265);
            lv5.TabIndex = 19;
            lv5.UseCompatibleStateImageBehavior = false;
            // 
            // lblC_1
            // 
            lblC_1.AutoSize = true;
            lblC_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_1.Location = new Point(155, 105);
            lblC_1.Name = "lblC_1";
            lblC_1.Size = new Size(112, 21);
            lblC_1.TabIndex = 20;
            lblC_1.Text = "Consultorio 1";
            // 
            // lblC_2
            // 
            lblC_2.AutoSize = true;
            lblC_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_2.Location = new Point(583, 105);
            lblC_2.Name = "lblC_2";
            lblC_2.Size = new Size(112, 21);
            lblC_2.TabIndex = 20;
            lblC_2.Text = "Consultorio 2";
            // 
            // lblC_3
            // 
            lblC_3.AutoSize = true;
            lblC_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_3.Location = new Point(1011, 105);
            lblC_3.Name = "lblC_3";
            lblC_3.Size = new Size(112, 21);
            lblC_3.TabIndex = 20;
            lblC_3.Text = "Consultorio 3";
            // 
            // lblC_4
            // 
            lblC_4.AutoSize = true;
            lblC_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_4.Location = new Point(363, 444);
            lblC_4.Name = "lblC_4";
            lblC_4.Size = new Size(112, 21);
            lblC_4.TabIndex = 20;
            lblC_4.Text = "Consultorio 4";
            // 
            // lblC_5
            // 
            lblC_5.AutoSize = true;
            lblC_5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC_5.Location = new Point(795, 444);
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
            cboTurno.Location = new Point(1183, 31);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(181, 25);
            cboTurno.TabIndex = 29;
            cboTurno.SelectedIndexChanged += cboTurno_SelectedIndexChanged;
            // 
            // lvlTurno
            // 
            lvlTurno.AutoSize = true;
            lvlTurno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lvlTurno.Location = new Point(1110, 33);
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
            btnBuscar.Location = new Point(320, 31);
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
            lblDni.Location = new Point(31, 33);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 21);
            lblDni.TabIndex = 44;
            lblDni.Text = "D.N.I";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(100, 32);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(189, 23);
            txtDni.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1099, 468);
            button1.Name = "button1";
            button1.Size = new Size(148, 43);
            button1.TabIndex = 47;
            button1.Text = "A CONSULTORIO";
            button1.UseVisualStyleBackColor = false;
            // 
            // CronogramaSalaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 755);
            Controls.Add(button1);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnBuscar);
            Controls.Add(lvlTurno);
            Controls.Add(cboTurno);
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
            Name = "CronogramaSalaEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CronogramaSalaEspera";
            Load += CronogramaSalaEspera_Load;
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
        private Button button1;
    }
}