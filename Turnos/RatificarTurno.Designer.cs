namespace Clinica_SePrise.Turnos
{
    partial class RatificarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatificarTurno));
            lblTitulo = new Label();
            panel1 = new Panel();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            lblTipo = new Label();
            txtIdTurno = new TextBox();
            btnSearch = new Button();
            dgvTurno = new DataGridView();
            btnRatificar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurno).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(200, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(303, 45);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "RATIFICAR TURNO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 657);
            panel1.TabIndex = 23;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(72, 212);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 24;
            lblName.Text = "name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(200, 92);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(78, 19);
            lblTipo.TabIndex = 24;
            lblTipo.Text = "N° TURNO";
            // 
            // txtIdTurno
            // 
            txtIdTurno.Location = new Point(295, 90);
            txtIdTurno.Name = "txtIdTurno";
            txtIdTurno.Size = new Size(316, 23);
            txtIdTurno.TabIndex = 26;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Azure;
            btnSearch.FlatAppearance.BorderColor = Color.LightBlue;
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.SteelBlue;
            btnSearch.Location = new Point(632, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 28);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTurno
            // 
            dgvTurno.AllowUserToAddRows = false;
            dgvTurno.AllowUserToDeleteRows = false;
            dgvTurno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dgvTurno.BackgroundColor = SystemColors.HighlightText;
            dgvTurno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurno.Location = new Point(200, 136);
            dgvTurno.Name = "dgvTurno";
            dgvTurno.RowTemplate.Height = 25;
            dgvTurno.Size = new Size(707, 451);
            dgvTurno.TabIndex = 27;
            dgvTurno.Visible = false;
            // 
            // btnRatificar
            // 
            btnRatificar.BackColor = Color.Azure;
            btnRatificar.Enabled = false;
            btnRatificar.FlatAppearance.BorderColor = Color.LightBlue;
            btnRatificar.FlatAppearance.BorderSize = 3;
            btnRatificar.FlatStyle = FlatStyle.Flat;
            btnRatificar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRatificar.ForeColor = Color.SteelBlue;
            btnRatificar.Location = new Point(776, 87);
            btnRatificar.Name = "btnRatificar";
            btnRatificar.Size = new Size(110, 28);
            btnRatificar.TabIndex = 29;
            btnRatificar.Text = "RATIFICAR";
            btnRatificar.UseVisualStyleBackColor = false;
            btnRatificar.Click += btnRatificar_Click;
            // 
            // RatificarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(933, 651);
            Controls.Add(btnRatificar);
            Controls.Add(btnSearch);
            Controls.Add(dgvTurno);
            Controls.Add(txtIdTurno);
            Controls.Add(lblTipo);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Name = "RatificarTurno";
            Text = "RatificarTurno";
            FormClosing += RatificarTurno_FormClosing;
            Load += RatificarTurno_Load;
            VisibleChanged += RatificarTurno_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblAsterisco;
        private Label lblTipo;
        private TextBox txtIdTurno;
        private Button btnSearch;
        private DataGridView dgvTurno;
        private Label lblName;
        private DataGridView dgbTurno2;
        private Button btnRatificar;
    }
}