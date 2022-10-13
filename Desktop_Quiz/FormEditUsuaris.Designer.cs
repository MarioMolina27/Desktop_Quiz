namespace Desktop_Quiz
{
    partial class FormEditUsuaris
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
<<<<<<< Updated upstream
            this.components = new System.ComponentModel.Container();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUsuaris));
            this.groupBoxDadesUsuari = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBoxMostrarRepeat = new System.Windows.Forms.CheckBox();
            this.checkBoxMostrar = new System.Windows.Forms.CheckBox();
            this.textBoxRepeatContrasenya = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.groupBoxPriveligis = new System.Windows.Forms.GroupBox();
            this.checkBoxEliminar = new System.Windows.Forms.CheckBox();
            this.checkBoxEditar = new System.Windows.Forms.CheckBox();
            this.checkBoxAfegir = new System.Windows.Forms.CheckBox();
            this.labelRepeatContrasenya = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBoxDadesUsuari.SuspendLayout();
            this.groupBoxPriveligis.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadesUsuari
            // 
            this.groupBoxDadesUsuari.Controls.Add(this.button4);
            this.groupBoxDadesUsuari.Controls.Add(this.checkBoxMostrarRepeat);
            this.groupBoxDadesUsuari.Controls.Add(this.checkBoxMostrar);
            this.groupBoxDadesUsuari.Controls.Add(this.textBoxRepeatContrasenya);
            this.groupBoxDadesUsuari.Controls.Add(this.textBoxContrasenya);
            this.groupBoxDadesUsuari.Controls.Add(this.textBoxNickName);
            this.groupBoxDadesUsuari.Controls.Add(this.textBoxNom);
            this.groupBoxDadesUsuari.Controls.Add(this.groupBoxPriveligis);
            this.groupBoxDadesUsuari.Controls.Add(this.labelRepeatContrasenya);
            this.groupBoxDadesUsuari.Controls.Add(this.labelContrasenya);
            this.groupBoxDadesUsuari.Controls.Add(this.labelNickname);
            this.groupBoxDadesUsuari.Controls.Add(this.labelNom);
            this.groupBoxDadesUsuari.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDadesUsuari.Name = "groupBoxDadesUsuari";
            this.groupBoxDadesUsuari.Size = new System.Drawing.Size(435, 331);
            this.groupBoxDadesUsuari.TabIndex = 0;
            this.groupBoxDadesUsuari.TabStop = false;
            this.groupBoxDadesUsuari.Text = "Dades Usuari";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ForeColor = System.Drawing.Color.Cyan;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(372, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 47);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // checkBoxMostrarRepeat
            // 
            this.checkBoxMostrarRepeat.AutoSize = true;
            this.checkBoxMostrarRepeat.Location = new System.Drawing.Point(362, 170);
            this.checkBoxMostrarRepeat.Name = "checkBoxMostrarRepeat";
            this.checkBoxMostrarRepeat.Size = new System.Drawing.Size(61, 17);
            this.checkBoxMostrarRepeat.TabIndex = 10;
            this.checkBoxMostrarRepeat.Text = "Mostrar";
            this.checkBoxMostrarRepeat.UseVisualStyleBackColor = true;
            this.checkBoxMostrarRepeat.CheckedChanged += new System.EventHandler(this.checkBoxMostrarRepeat_CheckedChanged);
            // 
            // checkBoxMostrar
            // 
            this.checkBoxMostrar.AutoSize = true;
            this.checkBoxMostrar.Location = new System.Drawing.Point(363, 122);
            this.checkBoxMostrar.Name = "checkBoxMostrar";
            this.checkBoxMostrar.Size = new System.Drawing.Size(61, 17);
            this.checkBoxMostrar.TabIndex = 9;
            this.checkBoxMostrar.Text = "Mostrar";
            this.checkBoxMostrar.UseVisualStyleBackColor = true;
            this.checkBoxMostrar.CheckedChanged += new System.EventHandler(this.checkBoxMostrar_CheckedChanged);
            // 
            // textBoxRepeatContrasenya
            // 
            this.textBoxRepeatContrasenya.Location = new System.Drawing.Point(137, 168);
            this.textBoxRepeatContrasenya.Name = "textBoxRepeatContrasenya";
            this.textBoxRepeatContrasenya.Size = new System.Drawing.Size(219, 20);
            this.textBoxRepeatContrasenya.TabIndex = 8;
            this.textBoxRepeatContrasenya.UseSystemPasswordChar = true;
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(137, 119);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(219, 20);
            this.textBoxContrasenya.TabIndex = 7;
            this.textBoxContrasenya.UseSystemPasswordChar = true;
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(137, 72);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(219, 20);
            this.textBoxNickName.TabIndex = 6;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(137, 29);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(219, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // groupBoxPriveligis
            // 
            this.groupBoxPriveligis.Controls.Add(this.checkBoxEliminar);
            this.groupBoxPriveligis.Controls.Add(this.checkBoxEditar);
            this.groupBoxPriveligis.Controls.Add(this.checkBoxAfegir);
            this.groupBoxPriveligis.Location = new System.Drawing.Point(30, 220);
            this.groupBoxPriveligis.Name = "groupBoxPriveligis";
            this.groupBoxPriveligis.Size = new System.Drawing.Size(326, 49);
            this.groupBoxPriveligis.TabIndex = 4;
            this.groupBoxPriveligis.TabStop = false;
            this.groupBoxPriveligis.Text = "Privilegis";
            // 
            // checkBoxEliminar
            // 
            this.checkBoxEliminar.AutoSize = true;
            this.checkBoxEliminar.Location = new System.Drawing.Point(258, 19);
            this.checkBoxEliminar.Name = "checkBoxEliminar";
            this.checkBoxEliminar.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEliminar.TabIndex = 2;
            this.checkBoxEliminar.Text = "Eliminar";
            this.checkBoxEliminar.UseVisualStyleBackColor = true;
            // 
            // checkBoxEditar
            // 
            this.checkBoxEditar.AutoSize = true;
            this.checkBoxEditar.Location = new System.Drawing.Point(132, 19);
            this.checkBoxEditar.Name = "checkBoxEditar";
            this.checkBoxEditar.Size = new System.Drawing.Size(53, 17);
            this.checkBoxEditar.TabIndex = 1;
            this.checkBoxEditar.Text = "Editar";
            this.checkBoxEditar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAfegir
            // 
            this.checkBoxAfegir.AutoSize = true;
            this.checkBoxAfegir.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAfegir.Name = "checkBoxAfegir";
            this.checkBoxAfegir.Size = new System.Drawing.Size(53, 17);
            this.checkBoxAfegir.TabIndex = 0;
            this.checkBoxAfegir.Text = "Afegir";
            this.checkBoxAfegir.UseVisualStyleBackColor = true;
            // 
            // labelRepeatContrasenya
            // 
            this.labelRepeatContrasenya.AutoSize = true;
            this.labelRepeatContrasenya.Location = new System.Drawing.Point(27, 171);
            this.labelRepeatContrasenya.Name = "labelRepeatContrasenya";
            this.labelRepeatContrasenya.Size = new System.Drawing.Size(103, 13);
            this.labelRepeatContrasenya.TabIndex = 3;
            this.labelRepeatContrasenya.Text = "Repetir Contrasenya";
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Location = new System.Drawing.Point(27, 122);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(66, 13);
            this.labelContrasenya.TabIndex = 2;
            this.labelContrasenya.Text = "Contrasenya";
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(27, 75);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(57, 13);
            this.labelNickname.TabIndex = 1;
            this.labelNickname.Text = "NickName";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(27, 32);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // FormEditUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
>>>>>>> Stashed changes
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormEditUsuaris";
<<<<<<< Updated upstream
=======
            this.Load += new System.EventHandler(this.FormEditUsuaris_Load);
            this.groupBoxDadesUsuari.ResumeLayout(false);
            this.groupBoxDadesUsuari.PerformLayout();
            this.groupBoxPriveligis.ResumeLayout(false);
            this.groupBoxPriveligis.PerformLayout();
            this.ResumeLayout(false);

>>>>>>> Stashed changes
        }

        #endregion
    }
}