namespace Desktop_Quiz
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
            this.buttonIniciSesio = new System.Windows.Forms.Button();
            this.pictureBoxIconUser = new System.Windows.Forms.PictureBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.checkBoxMostraPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIniciSesio
            // 
            this.buttonIniciSesio.BackColor = System.Drawing.Color.Black;
            this.buttonIniciSesio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIniciSesio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciSesio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciSesio.Location = new System.Drawing.Point(839, 736);
            this.buttonIniciSesio.Name = "buttonIniciSesio";
            this.buttonIniciSesio.Size = new System.Drawing.Size(193, 69);
            this.buttonIniciSesio.TabIndex = 5;
            this.buttonIniciSesio.Text = "INICIA SESSIÓ\r\n";
            this.buttonIniciSesio.UseVisualStyleBackColor = false;
            this.buttonIniciSesio.Click += new System.EventHandler(this.buttonIniciSessio_Click);
            // 
            // pictureBoxIconUser
            // 
            this.pictureBoxIconUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIconUser.Image = global::Desktop_Quiz.Properties.Resources.loginImage;
            this.pictureBoxIconUser.Location = new System.Drawing.Point(821, 92);
            this.pictureBoxIconUser.Name = "pictureBoxIconUser";
            this.pictureBoxIconUser.Size = new System.Drawing.Size(239, 191);
            this.pictureBoxIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIconUser.TabIndex = 6;
            this.pictureBoxIconUser.TabStop = false;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(697, 423);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(79, 18);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "NickName";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenya.Location = new System.Drawing.Point(697, 495);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(97, 18);
            this.labelContrasenya.TabIndex = 1;
            this.labelContrasenya.Text = "Contrasenya";
            this.labelContrasenya.Click += new System.EventHandler(this.labelContrasenya_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(800, 421);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(333, 20);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            this.textBoxNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNom_KeyDown);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(800, 493);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(333, 20);
            this.textBoxContrasenya.TabIndex = 3;
            this.textBoxContrasenya.UseSystemPasswordChar = true;
            this.textBoxContrasenya.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContrasenya_KeyDown);
            // 
            // checkBoxMostraPass
            // 
            this.checkBoxMostraPass.AutoSize = true;
            this.checkBoxMostraPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostraPass.Location = new System.Drawing.Point(1139, 496);
            this.checkBoxMostraPass.Name = "checkBoxMostraPass";
            this.checkBoxMostraPass.Size = new System.Drawing.Size(123, 17);
            this.checkBoxMostraPass.TabIndex = 4;
            this.checkBoxMostraPass.Text = "Mostrar Contrasenya";
            this.checkBoxMostraPass.UseVisualStyleBackColor = true;
            this.checkBoxMostraPass.CheckedChanged += new System.EventHandler(this.checkBoxMostraPass_CheckedChanged);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.checkBoxMostraPass);
            this.Controls.Add(this.pictureBoxIconUser);
            this.Controls.Add(this.labelContrasenya);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.buttonIniciSesio);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelNom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInicioSesion";
            this.Text = "FormInicioSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIniciSesio;
        private System.Windows.Forms.PictureBox pictureBoxIconUser;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelContrasenya;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.CheckBox checkBoxMostraPass;
    }
}