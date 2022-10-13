namespace Desktop_Quiz
{
    partial class FormEditPersonatges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPersonatges));
            this.groupBoxDadesPersonatge = new System.Windows.Forms.GroupBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelDescripcio = new System.Windows.Forms.Label();
            this.labelRutaImg = new System.Windows.Forms.Label();
            this.textBoxRutaImg = new System.Windows.Forms.TextBox();
            this.buttonBuscarRutaImg = new System.Windows.Forms.Button();
            this.textBoxDescripcioPers = new System.Windows.Forms.TextBox();
            this.textBoxNomPers = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxDadesPersonatge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDadesPersonatge
            // 
            this.groupBoxDadesPersonatge.Controls.Add(this.button1);
            this.groupBoxDadesPersonatge.Controls.Add(this.pictureBox1);
            this.groupBoxDadesPersonatge.Controls.Add(this.textBoxNomPers);
            this.groupBoxDadesPersonatge.Controls.Add(this.textBoxDescripcioPers);
            this.groupBoxDadesPersonatge.Controls.Add(this.buttonBuscarRutaImg);
            this.groupBoxDadesPersonatge.Controls.Add(this.textBoxRutaImg);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelRutaImg);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelDescripcio);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelNom);
            this.groupBoxDadesPersonatge.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDadesPersonatge.Name = "groupBoxDadesPersonatge";
            this.groupBoxDadesPersonatge.Size = new System.Drawing.Size(454, 436);
            this.groupBoxDadesPersonatge.TabIndex = 0;
            this.groupBoxDadesPersonatge.TabStop = false;
            this.groupBoxDadesPersonatge.Text = "Dades personatge";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(6, 36);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(39, 17);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelDescripcio
            // 
            this.labelDescripcio.AutoSize = true;
            this.labelDescripcio.Location = new System.Drawing.Point(6, 67);
            this.labelDescripcio.Name = "labelDescripcio";
            this.labelDescripcio.Size = new System.Drawing.Size(78, 17);
            this.labelDescripcio.TabIndex = 1;
            this.labelDescripcio.Text = "Descripció";
            // 
            // labelRutaImg
            // 
            this.labelRutaImg.AutoSize = true;
            this.labelRutaImg.Location = new System.Drawing.Point(6, 178);
            this.labelRutaImg.Name = "labelRutaImg";
            this.labelRutaImg.Size = new System.Drawing.Size(87, 17);
            this.labelRutaImg.TabIndex = 2;
            this.labelRutaImg.Text = "Ruta Imatge";
            // 
            // textBoxRutaImg
            // 
            this.textBoxRutaImg.Location = new System.Drawing.Point(99, 175);
            this.textBoxRutaImg.Name = "textBoxRutaImg";
            this.textBoxRutaImg.Size = new System.Drawing.Size(257, 25);
            this.textBoxRutaImg.TabIndex = 3;
            // 
            // buttonBuscarRutaImg
            // 
            this.buttonBuscarRutaImg.Location = new System.Drawing.Point(362, 175);
            this.buttonBuscarRutaImg.Name = "buttonBuscarRutaImg";
            this.buttonBuscarRutaImg.Size = new System.Drawing.Size(86, 23);
            this.buttonBuscarRutaImg.TabIndex = 4;
            this.buttonBuscarRutaImg.Text = " · · ·";
            this.buttonBuscarRutaImg.UseVisualStyleBackColor = true;
            this.buttonBuscarRutaImg.Click += new System.EventHandler(this.buttonBuscarRutaImg_Click);
            // 
            // textBoxDescripcioPers
            // 
            this.textBoxDescripcioPers.Location = new System.Drawing.Point(99, 64);
            this.textBoxDescripcioPers.Multiline = true;
            this.textBoxDescripcioPers.Name = "textBoxDescripcioPers";
            this.textBoxDescripcioPers.Size = new System.Drawing.Size(257, 100);
            this.textBoxDescripcioPers.TabIndex = 5;
            // 
            // textBoxNomPers
            // 
            this.textBoxNomPers.Location = new System.Drawing.Point(99, 33);
            this.textBoxNomPers.Name = "textBoxNomPers";
            this.textBoxNomPers.Size = new System.Drawing.Size(257, 25);
            this.textBoxNomPers.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 157);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(355, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 87);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormEditPersonatges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(478, 460);
            this.Controls.Add(this.groupBoxDadesPersonatge);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditPersonatges";
            this.Text = "FormEditPersonatges";
            this.groupBoxDadesPersonatge.ResumeLayout(false);
            this.groupBoxDadesPersonatge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadesPersonatge;
        private System.Windows.Forms.TextBox textBoxDescripcioPers;
        private System.Windows.Forms.Button buttonBuscarRutaImg;
        private System.Windows.Forms.TextBox textBoxRutaImg;
        private System.Windows.Forms.Label labelRutaImg;
        private System.Windows.Forms.Label labelDescripcio;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxNomPers;
    }
}