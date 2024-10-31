namespace Clinica_SePrise
{
    partial class Calendario
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
            lblMedfico = new Label();
            dataGridView1 = new DataGridView();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            cboGenero = new ComboBox();
            comboBox1 = new ComboBox();
            btnSearch = new Button();
            dataGridView2 = new DataGridView();
            lblClear = new Button();
            comboBox2 = new ComboBox();
            lblTurno = new Label();
            lblDate = new Label();
            lblTMañana = new Label();
            lblTTarde = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // lblMedfico
            // 
            lblMedfico.AutoSize = true;
            lblMedfico.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedfico.Location = new Point(12, 26);
            lblMedfico.Name = "lblMedfico";
            lblMedfico.Size = new Size(54, 19);
            lblMedfico.TabIndex = 1;
            lblMedfico.Text = "Medico";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(292, 661);
            dataGridView1.TabIndex = 4;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(414, 26);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(121, 25);
            dtpDate.TabIndex = 34;
            dtpDate.Value = new DateTime(2024, 10, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 35;
            label1.Text = "Especialidad";
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboGenero.ForeColor = SystemColors.MenuHighlight;
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cboGenero.Location = new Point(100, 23);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(170, 25);
            cboGenero.TabIndex = 36;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = SystemColors.MenuHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            comboBox1.Location = new Point(100, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 25);
            comboBox1.TabIndex = 37;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Azure;
            btnSearch.FlatAppearance.BorderColor = Color.LightBlue;
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(612, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 47);
            btnSearch.TabIndex = 38;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnIngresar_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(381, 127);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(292, 661);
            dataGridView2.TabIndex = 39;
            // 
            // lblClear
            // 
            lblClear.BackColor = Color.Azure;
            lblClear.FlatAppearance.BorderColor = Color.LightBlue;
            lblClear.FlatAppearance.BorderSize = 3;
            lblClear.FlatStyle = FlatStyle.Flat;
            lblClear.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClear.ForeColor = Color.SteelBlue;
            lblClear.Location = new Point(612, 68);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(126, 47);
            lblClear.TabIndex = 40;
            lblClear.Text = "LIMPIAR";
            lblClear.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.ForeColor = SystemColors.MenuHighlight;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            comboBox2.Location = new Point(385, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 25);
            comboBox2.TabIndex = 41;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurno.Location = new Point(297, 71);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(45, 19);
            lblTurno.TabIndex = 42;
            lblTurno.Text = "Turno";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(297, 29);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 19);
            lblDate.TabIndex = 43;
            lblDate.Text = "Fecha";
            lblDate.UseMnemonic = false;
            // 
            // lblTMañana
            // 
            lblTMañana.AutoSize = true;
            lblTMañana.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTMañana.Location = new Point(140, 106);
            lblTMañana.Name = "lblTMañana";
            lblTMañana.Size = new Size(99, 19);
            lblTMañana.TabIndex = 44;
            lblTMañana.Text = "Turno Mañana";
            // 
            // lblTTarde
            // 
            lblTTarde.AutoSize = true;
            lblTTarde.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTTarde.Location = new Point(478, 105);
            lblTTarde.Name = "lblTTarde";
            lblTTarde.Size = new Size(81, 19);
            lblTTarde.TabIndex = 45;
            lblTTarde.Text = "Turno Tarde";
            // 
            // Calendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 796);
            Controls.Add(lblTTarde);
            Controls.Add(lblTMañana);
            Controls.Add(lblDate);
            Controls.Add(lblTurno);
            Controls.Add(comboBox2);
            Controls.Add(lblClear);
            Controls.Add(dataGridView2);
            Controls.Add(btnSearch);
            Controls.Add(comboBox1);
            Controls.Add(cboGenero);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(dataGridView1);
            Controls.Add(lblMedfico);
            Name = "Calendario";
            Text = "Calendario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMedfico;
        private DataGridView dataGridView1;
        private DateTimePicker dtpDate;
        private Label label1;
        private ComboBox cboGenero;
        private ComboBox comboBox1;
        private Button btnSearch;
        private DataGridView dataGridView2;
        private Button lblClear;
        private ComboBox comboBox2;
        private Label lblTurno;
        private Label lblDate;
        private Label lblTMañana;
        private Label lblTTarde;
    }
}