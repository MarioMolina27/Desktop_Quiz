﻿namespace Desktop_Quiz
{
    partial class FormInicioSesion
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.groupBoxDades = new System.Windows.Forms.GroupBox();
            this.checkBoxMostraPass = new System.Windows.Forms.CheckBox();
            this.buttonIniciSesio = new System.Windows.Forms.Button();
            this.pictureBoxIconUser = new System.Windows.Forms.PictureBox();
            this.groupBoxDades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(261, 172);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(75, 17);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "NickName";
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenya.Location = new System.Drawing.Point(261, 289);
            this.labelContrasenya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(91, 17);
            this.labelContrasenya.TabIndex = 1;
            this.labelContrasenya.Text = "Contrasenya";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(513, 162);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(498, 26);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            this.textBoxNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNom_KeyDown);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(513, 277);
            this.textBoxContrasenya.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(498, 26);
            this.textBoxContrasenya.TabIndex = 3;
            this.textBoxContrasenya.UseSystemPasswordChar = true;
            this.textBoxContrasenya.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContrasenya_KeyDown);
            // 
            // groupBoxDades
            // 
            this.groupBoxDades.Controls.Add(this.checkBoxMostraPass);
            this.groupBoxDades.Controls.Add(this.textBoxContrasenya);
            this.groupBoxDades.Controls.Add(this.textBoxNom);
            this.groupBoxDades.Controls.Add(this.labelContrasenya);
            this.groupBoxDades.Controls.Add(this.labelNom);
            this.groupBoxDades.Location = new System.Drawing.Point(765, 538);
            this.groupBoxDades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDades.Name = "groupBoxDades";
            this.groupBoxDades.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDades.Size = new System.Drawing.Size(1268, 518);
            this.groupBoxDades.TabIndex = 0;
            this.groupBoxDades.TabStop = false;
            // 
            // checkBoxMostraPass
            // 
            this.checkBoxMostraPass.AutoSize = true;
            this.checkBoxMostraPass.Location = new System.Drawing.Point(1023, 280);
            this.checkBoxMostraPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMostraPass.Name = "checkBoxMostraPass";
            this.checkBoxMostraPass.Size = new System.Drawing.Size(176, 24);
            this.checkBoxMostraPass.TabIndex = 4;
            this.checkBoxMostraPass.Text = "Mostrar Contrasenya";
            this.checkBoxMostraPass.UseVisualStyleBackColor = true;
            this.checkBoxMostraPass.CheckedChanged += new System.EventHandler(this.checkBoxMostraPass_CheckedChanged);
            // 
            // buttonIniciSesio
            // 
            this.buttonIniciSesio.BackColor = System.Drawing.Color.Black;
            this.buttonIniciSesio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIniciSesio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciSesio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciSesio.Location = new System.Drawing.Point(1258, 1132);
            this.buttonIniciSesio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIniciSesio.Name = "buttonIniciSesio";
            this.buttonIniciSesio.Size = new System.Drawing.Size(290, 106);
            this.buttonIniciSesio.TabIndex = 5;
            this.buttonIniciSesio.Text = "INICIA SESSIÓ\r\n";
            this.buttonIniciSesio.UseVisualStyleBackColor = false;
            this.buttonIniciSesio.Click += new System.EventHandler(this.buttonIniciSessio_Click);
            // 
            // pictureBoxIconUser
            // 
            this.pictureBoxIconUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIconUser.Image = global::Desktop_Quiz.Properties.Resources.loginImage;
            this.pictureBoxIconUser.Location = new System.Drawing.Point(1232, 142);
            this.pictureBoxIconUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxIconUser.Name = "pictureBoxIconUser";
            this.pictureBoxIconUser.Size = new System.Drawing.Size(358, 294);
            this.pictureBoxIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIconUser.TabIndex = 6;
            this.pictureBoxIconUser.TabStop = false;
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pictureBoxIconUser);
            this.Controls.Add(this.buttonIniciSesio);
            this.Controls.Add(this.groupBoxDades);
            this.Name = "FormInicioSesion";
            this.Text = "FormInicioSesion";
            this.groupBoxDades.ResumeLayout(false);
            this.groupBoxDades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelContrasenya;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.GroupBox groupBoxDades;
        private System.Windows.Forms.Button buttonIniciSesio;
        private System.Windows.Forms.CheckBox checkBoxMostraPass;
        private System.Windows.Forms.PictureBox pictureBoxIconUser;
    }
}