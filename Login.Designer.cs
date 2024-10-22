using Clinica_SePrise.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;
using System.Drawing;

namespace Clinica_SePrise
 {
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblPass = new Label();
            txtPass = new TextBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = SystemColors.MenuHighlight;
            txtUsuario.Location = new Point(493, 90);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(163, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Admin";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(389, 93);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "USUARIO";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(389, 141);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(83, 15);
            lblPass.TabIndex = 3;
            lblPass.Text = "CONTRASEÑA";
            // 
            // txtPass
            // 
            txtPass.ForeColor = SystemColors.MenuHighlight;
            txtPass.Location = new Point(493, 138);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(163, 23);
            txtPass.TabIndex = 4;
            txtPass.Text = "1234";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Azure;
            btnIngresar.FlatAppearance.BorderColor = Color.LightBlue;
            btnIngresar.FlatAppearance.BorderSize = 3;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.SteelBlue;
            btnIngresar.Location = new Point(447, 210);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(217, 52);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(758, 293);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACCESO  AL SISTEMA DE LA CLINICA SEPRISE";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtPass;
        private Button btnIngresar;
    }
}