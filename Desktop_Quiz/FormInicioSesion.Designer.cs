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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.groupBoxDades = new System.Windows.Forms.GroupBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.buttonIniciSesio = new System.Windows.Forms.Button();
            this.groupBoxDades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(174, 112);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(39, 17);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenya.Location = new System.Drawing.Point(174, 188);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(91, 17);
            this.labelContrasenya.TabIndex = 1;
            this.labelContrasenya.Text = "Contrasenya";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(342, 105);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(333, 20);
            this.textBoxNom.TabIndex = 2;
            this.textBoxNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNom_KeyDown);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(342, 180);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(333, 20);
            this.textBoxContrasenya.TabIndex = 3;
            this.textBoxContrasenya.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxContrasenya_KeyDown);
            // 
            // groupBoxDades
            // 
            this.groupBoxDades.Controls.Add(this.textBoxContrasenya);
            this.groupBoxDades.Controls.Add(this.textBoxNom);
            this.groupBoxDades.Controls.Add(this.labelContrasenya);
            this.groupBoxDades.Controls.Add(this.labelNom);
            this.groupBoxDades.Location = new System.Drawing.Point(510, 350);
            this.groupBoxDades.Name = "groupBoxDades";
            this.groupBoxDades.Size = new System.Drawing.Size(845, 337);
            this.groupBoxDades.TabIndex = 0;
            this.groupBoxDades.TabStop = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxIcon.Image = global::Desktop_Quiz.Properties.Resources.loginImage;
            this.pictureBoxIcon.Location = new System.Drawing.Point(815, 128);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(235, 183);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 1;
            this.pictureBoxIcon.TabStop = false;
            // 
            // buttonIniciSesio
            // 
            this.buttonIniciSesio.BackColor = System.Drawing.Color.Black;
            this.buttonIniciSesio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIniciSesio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciSesio.ForeColor = System.Drawing.Color.White;
            this.buttonIniciSesio.Location = new System.Drawing.Point(839, 736);
            this.buttonIniciSesio.Name = "buttonIniciSesio";
            this.buttonIniciSesio.Size = new System.Drawing.Size(193, 69);
            this.buttonIniciSesio.TabIndex = 5;
            this.buttonIniciSesio.Text = "INICIA SESSIÓ\r\n";
            this.buttonIniciSesio.UseVisualStyleBackColor = false;
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonIniciSesio);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.groupBoxDades);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInicioSesion";
            this.Text = "FormInicioSesion";
            this.groupBoxDades.ResumeLayout(false);
            this.groupBoxDades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelContrasenya;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.GroupBox groupBoxDades;
        private System.Windows.Forms.Button buttonIniciSesio;
    }
}