
namespace Clinica_SePrise.Medicos
{
    public partial class ListadoMedicos : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoMedicos));
            lblTitulo = new Label();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            dgvListadoMedicos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoMedicos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(270, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(355, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "LISTADO DE MEDICOS";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Azure;
            btnVolver.FlatAppearance.BorderColor = Color.LightBlue;
            btnVolver.FlatAppearance.BorderSize = 3;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.SteelBlue;
            btnVolver.Location = new Point(720, 592);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 47);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dgvListadoMedicos
            // 
            dgvListadoMedicos.BackgroundColor = Color.White;
            dgvListadoMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoMedicos.Location = new Point(21, 128);
            dgvListadoMedicos.Name = "dgvListadoMedicos";
            dgvListadoMedicos.RowTemplate.Height = 25;
            dgvListadoMedicos.Size = new Size(844, 441);
            dgvListadoMedicos.TabIndex = 15;
            // 
            // ListadoMedicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 651);
            Controls.Add(dgvListadoMedicos);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Name = "ListadoMedicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LISTADO DE MEDICOS";
            Load += ListadoMedicos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Button btnVolver;
        private PictureBox pictureBox1;
        private DataGridView dgvListadoMedicos;
    }
}