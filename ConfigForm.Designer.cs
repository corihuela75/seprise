using Clinica_SePrise.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;
using System.Drawing;

namespace Clinica_SePrise
 {
    partial class ConfigForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            pictureBox1 = new PictureBox();
            txtServer = new TextBox();
            lblServer = new Label();
            lblDatabase = new Label();
            txtDatabase = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            txtPassword = new TextBox();
            lblPasword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtServer
            // 
            txtServer.ForeColor = SystemColors.MenuHighlight;
            txtServer.Location = new Point(466, 122);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(163, 23);
            txtServer.TabIndex = 1;
            txtServer.Text = "Admin";
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(362, 125);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(46, 15);
            lblServer.TabIndex = 2;
            lblServer.Text = "SERVER";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Location = new Point(362, 167);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(62, 15);
            lblDatabase.TabIndex = 3;
            lblDatabase.Text = "DATABASE";
            // 
            // txtDatabase
            // 
            txtDatabase.ForeColor = SystemColors.MenuHighlight;
            txtDatabase.Location = new Point(466, 164);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(163, 23);
            txtDatabase.TabIndex = 2;
            txtDatabase.Text = "1234";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Azure;
            btnGuardar.FlatAppearance.BorderColor = Color.LightBlue;
            btnGuardar.FlatAppearance.BorderSize = 3;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.SteelBlue;
            btnGuardar.Location = new Point(394, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(217, 52);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 32);
            label1.Name = "label1";
            label1.Size = new Size(397, 28);
            label1.TabIndex = 13;
            label1.Text = "DATOS DE ACCESO A LA BASE DE DATOS";
            // 
            // txtUser
            // 
            txtUser.ForeColor = SystemColors.MenuHighlight;
            txtUser.Location = new Point(466, 206);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(163, 23);
            txtUser.TabIndex = 3;
            txtUser.Text = "1234";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(362, 209);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(34, 15);
            lblUser.TabIndex = 14;
            lblUser.Text = "USER";
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.MenuHighlight;
            txtPassword.Location = new Point(466, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(163, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "1234";
            // 
            // lblPasword
            // 
            lblPasword.AutoSize = true;
            lblPasword.Location = new Point(362, 251);
            lblPasword.Name = "lblPasword";
            lblPasword.Size = new Size(62, 15);
            lblPasword.TabIndex = 16;
            lblPasword.Text = "PASWORD";
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 383);
            Controls.Add(txtPassword);
            Controls.Add(lblPasword);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtDatabase);
            Controls.Add(lblDatabase);
            Controls.Add(lblServer);
            Controls.Add(txtServer);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ConfigForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONFIGURACION DEL SISTEMA DE LA CLINICA SEPRISE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtServer;
        private Label lblServer;
        private Label lblDatabase;
        private TextBox txtDatabase;
        private Button btnGuardar;
        private Label label1;
        private TextBox txtUser;
        private Label lblUser;
        private TextBox txtPassword;
        private Label lblPasword;
    }
}