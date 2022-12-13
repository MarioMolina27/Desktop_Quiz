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
            this.groupBoxDadesPersonatge = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxGenere = new System.Windows.Forms.ComboBox();
            this.textBoxEncerts = new System.Windows.Forms.TextBox();
            this.labelEncerts = new System.Windows.Forms.Label();
            this.labelGenere = new System.Windows.Forms.Label();
            this.buttonGuardarEdit = new System.Windows.Forms.Button();
            this.pictureBoxPers = new System.Windows.Forms.PictureBox();
            this.textBoxNomPers = new System.Windows.Forms.TextBox();
            this.textBoxDescripcioPers = new System.Windows.Forms.TextBox();
            this.buttonBuscarRutaImg = new System.Windows.Forms.Button();
            this.textBoxRutaImg = new System.Windows.Forms.TextBox();
            this.labelRutaImg = new System.Windows.Forms.Label();
            this.labelDescripcio = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBoxDadesPersonatge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDadesPersonatge
            // 
            this.groupBoxDadesPersonatge.Controls.Add(this.buttonCancel);
            this.groupBoxDadesPersonatge.Controls.Add(this.comboBoxGenere);
            this.groupBoxDadesPersonatge.Controls.Add(this.textBoxEncerts);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelEncerts);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelGenere);
            this.groupBoxDadesPersonatge.Controls.Add(this.buttonGuardarEdit);
            this.groupBoxDadesPersonatge.Controls.Add(this.pictureBoxPers);
            this.groupBoxDadesPersonatge.Controls.Add(this.textBoxNomPers);
            this.groupBoxDadesPersonatge.Controls.Add(this.textBoxDescripcioPers);
            this.groupBoxDadesPersonatge.Controls.Add(this.buttonBuscarRutaImg);
            this.groupBoxDadesPersonatge.Controls.Add(this.textBoxRutaImg);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelRutaImg);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelDescripcio);
            this.groupBoxDadesPersonatge.Controls.Add(this.labelNom);
            this.groupBoxDadesPersonatge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDadesPersonatge.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDadesPersonatge.Name = "groupBoxDadesPersonatge";
            this.groupBoxDadesPersonatge.Size = new System.Drawing.Size(454, 436);
            this.groupBoxDadesPersonatge.TabIndex = 0;
            this.groupBoxDadesPersonatge.TabStop = false;
            this.groupBoxDadesPersonatge.Text = "Dades personatge";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(330, 386);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 29);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxGenere
            // 
            this.comboBoxGenere.FormattingEnabled = true;
            this.comboBoxGenere.Items.AddRange(new object[] {
            "Acció",
            "Animació",
            "Ciencia ficció",
            "Drama",
            "Terror",
            "General"});
            this.comboBoxGenere.Location = new System.Drawing.Point(99, 215);
            this.comboBoxGenere.Name = "comboBoxGenere";
            this.comboBoxGenere.Size = new System.Drawing.Size(129, 30);
            this.comboBoxGenere.TabIndex = 14;
            // 
            // textBoxEncerts
            // 
            this.textBoxEncerts.Location = new System.Drawing.Point(321, 215);
            this.textBoxEncerts.Name = "textBoxEncerts";
            this.textBoxEncerts.Size = new System.Drawing.Size(112, 29);
            this.textBoxEncerts.TabIndex = 13;
            // 
            // labelEncerts
            // 
            this.labelEncerts.AutoSize = true;
            this.labelEncerts.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncerts.Location = new System.Drawing.Point(255, 218);
            this.labelEncerts.Name = "labelEncerts";
            this.labelEncerts.Size = new System.Drawing.Size(82, 22);
            this.labelEncerts.TabIndex = 12;
            this.labelEncerts.Text = "Encerts";
            // 
            // labelGenere
            // 
            this.labelGenere.AutoSize = true;
            this.labelGenere.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenere.Location = new System.Drawing.Point(6, 218);
            this.labelGenere.Name = "labelGenere";
            this.labelGenere.Size = new System.Drawing.Size(78, 22);
            this.labelGenere.TabIndex = 10;
            this.labelGenere.Text = "Gènere";
            // 
            // buttonGuardarEdit
            // 
            this.buttonGuardarEdit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGuardarEdit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarEdit.Location = new System.Drawing.Point(303, 311);
            this.buttonGuardarEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardarEdit.Name = "buttonGuardarEdit";
            this.buttonGuardarEdit.Size = new System.Drawing.Size(130, 50);
            this.buttonGuardarEdit.TabIndex = 9;
            this.buttonGuardarEdit.Text = "Aceptar";
            this.buttonGuardarEdit.UseVisualStyleBackColor = false;
            this.buttonGuardarEdit.Click += new System.EventHandler(this.buttonGuardarEdit_Click);
            // 
            // pictureBoxPers
            // 
            this.pictureBoxPers.Location = new System.Drawing.Point(60, 258);
            this.pictureBoxPers.Name = "pictureBoxPers";
            this.pictureBoxPers.Size = new System.Drawing.Size(168, 157);
            this.pictureBoxPers.TabIndex = 8;
            this.pictureBoxPers.TabStop = false;
            // 
            // textBoxNomPers
            // 
            this.textBoxNomPers.Location = new System.Drawing.Point(99, 33);
            this.textBoxNomPers.Name = "textBoxNomPers";
            this.textBoxNomPers.Size = new System.Drawing.Size(257, 29);
            this.textBoxNomPers.TabIndex = 7;
            // 
            // textBoxDescripcioPers
            // 
            this.textBoxDescripcioPers.Location = new System.Drawing.Point(99, 64);
            this.textBoxDescripcioPers.Multiline = true;
            this.textBoxDescripcioPers.Name = "textBoxDescripcioPers";
            this.textBoxDescripcioPers.Size = new System.Drawing.Size(257, 100);
            this.textBoxDescripcioPers.TabIndex = 5;
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
            // textBoxRutaImg
            // 
            this.textBoxRutaImg.Location = new System.Drawing.Point(99, 175);
            this.textBoxRutaImg.Name = "textBoxRutaImg";
            this.textBoxRutaImg.Size = new System.Drawing.Size(257, 29);
            this.textBoxRutaImg.TabIndex = 3;
            this.textBoxRutaImg.TextChanged += new System.EventHandler(this.textBoxRutaImg_TextChanged);
            // 
            // labelRutaImg
            // 
            this.labelRutaImg.AutoSize = true;
            this.labelRutaImg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutaImg.Location = new System.Drawing.Point(6, 178);
            this.labelRutaImg.Name = "labelRutaImg";
            this.labelRutaImg.Size = new System.Drawing.Size(119, 22);
            this.labelRutaImg.TabIndex = 2;
            this.labelRutaImg.Text = "Ruta Imatge";
            // 
            // labelDescripcio
            // 
            this.labelDescripcio.AutoSize = true;
            this.labelDescripcio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcio.Location = new System.Drawing.Point(6, 67);
            this.labelDescripcio.Name = "labelDescripcio";
            this.labelDescripcio.Size = new System.Drawing.Size(110, 22);
            this.labelDescripcio.TabIndex = 1;
            this.labelDescripcio.Text = "Descripció";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(6, 36);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(52, 22);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // FormEditPersonatges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(478, 460);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxDadesPersonatge);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditPersonatges";
            this.Text = "FilmZ";
            this.Load += new System.EventHandler(this.FormEditPersonatges_Load);
            this.groupBoxDadesPersonatge.ResumeLayout(false);
            this.groupBoxDadesPersonatge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPers)).EndInit();
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
        private System.Windows.Forms.Button buttonGuardarEdit;
        private System.Windows.Forms.PictureBox pictureBoxPers;
        private System.Windows.Forms.TextBox textBoxNomPers;
        private System.Windows.Forms.ComboBox comboBoxGenere;
        private System.Windows.Forms.TextBox textBoxEncerts;
        private System.Windows.Forms.Label labelEncerts;
        private System.Windows.Forms.Label labelGenere;
        private System.Windows.Forms.Button buttonCancel;
    }
}