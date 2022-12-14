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
            this.groupBoxDadesUsuari = new System.Windows.Forms.GroupBox();
            this.groupBoxPassw = new System.Windows.Forms.GroupBox();
            this.checkModifyPassw = new System.Windows.Forms.CheckBox();
            this.checkBoxMostrarRepeat = new System.Windows.Forms.CheckBox();
            this.checkBoxMostrar = new System.Windows.Forms.CheckBox();
            this.textBoxRepeatContrasenya = new System.Windows.Forms.TextBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.labelRepeatContrasenya = new System.Windows.Forms.Label();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.buttonCancelarEdit = new System.Windows.Forms.Button();
            this.buttonAceptarEditUsers = new System.Windows.Forms.Button();
            this.textBoxNomEdit = new System.Windows.Forms.TextBox();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.groupBoxPriveligis = new System.Windows.Forms.GroupBox();
            this.checkBoxEliminar = new System.Windows.Forms.CheckBox();
            this.checkBoxEditar = new System.Windows.Forms.CheckBox();
            this.checkBoxAfegir = new System.Windows.Forms.CheckBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBoxDadesUsuari.SuspendLayout();
            this.groupBoxPassw.SuspendLayout();
            this.groupBoxPriveligis.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadesUsuari
            // 
            this.groupBoxDadesUsuari.Controls.Add(this.groupBoxPassw);
            this.groupBoxDadesUsuari.Controls.Add(this.buttonCancelarEdit);
            this.groupBoxDadesUsuari.Controls.Add(this.buttonAceptarEditUsers);
            this.groupBoxDadesUsuari.Controls.Add(this.textBoxNomEdit);
            this.groupBoxDadesUsuari.Controls.Add(this.textBoxNickName);
            this.groupBoxDadesUsuari.Controls.Add(this.groupBoxPriveligis);
            this.groupBoxDadesUsuari.Controls.Add(this.labelNickname);
            this.groupBoxDadesUsuari.Controls.Add(this.labelNom);
            this.groupBoxDadesUsuari.Location = new System.Drawing.Point(20, 18);
            this.groupBoxDadesUsuari.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDadesUsuari.Name = "groupBoxDadesUsuari";
            this.groupBoxDadesUsuari.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDadesUsuari.Size = new System.Drawing.Size(663, 494);
            this.groupBoxDadesUsuari.TabIndex = 0;
            this.groupBoxDadesUsuari.TabStop = false;
            this.groupBoxDadesUsuari.Text = "Dades Usuari";
            // 
            // groupBoxPassw
            // 
            this.groupBoxPassw.Controls.Add(this.checkModifyPassw);
            this.groupBoxPassw.Controls.Add(this.checkBoxMostrarRepeat);
            this.groupBoxPassw.Controls.Add(this.checkBoxMostrar);
            this.groupBoxPassw.Controls.Add(this.textBoxRepeatContrasenya);
            this.groupBoxPassw.Controls.Add(this.textBoxContrasenya);
            this.groupBoxPassw.Controls.Add(this.labelRepeatContrasenya);
            this.groupBoxPassw.Controls.Add(this.labelContrasenya);
            this.groupBoxPassw.Location = new System.Drawing.Point(29, 138);
            this.groupBoxPassw.Name = "groupBoxPassw";
            this.groupBoxPassw.Size = new System.Drawing.Size(614, 176);
            this.groupBoxPassw.TabIndex = 13;
            this.groupBoxPassw.TabStop = false;
            this.groupBoxPassw.Text = "Modificar Contrasenyes";
            // 
            // checkModifyPassw
            // 
            this.checkModifyPassw.AutoSize = true;
            this.checkModifyPassw.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkModifyPassw.Location = new System.Drawing.Point(14, 128);
            this.checkModifyPassw.Margin = new System.Windows.Forms.Padding(4);
            this.checkModifyPassw.Name = "checkModifyPassw";
            this.checkModifyPassw.Size = new System.Drawing.Size(192, 22);
            this.checkModifyPassw.TabIndex = 11;
            this.checkModifyPassw.Text = "Modificar contrasenyes";
            this.checkModifyPassw.UseVisualStyleBackColor = true;
            this.checkModifyPassw.CheckedChanged += new System.EventHandler(this.checkModifyPassw_CheckedChanged);
            // 
            // checkBoxMostrarRepeat
            // 
            this.checkBoxMostrarRepeat.AutoSize = true;
            this.checkBoxMostrarRepeat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrarRepeat.Location = new System.Drawing.Point(514, 77);
            this.checkBoxMostrarRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMostrarRepeat.Name = "checkBoxMostrarRepeat";
            this.checkBoxMostrarRepeat.Size = new System.Drawing.Size(82, 22);
            this.checkBoxMostrarRepeat.TabIndex = 10;
            this.checkBoxMostrarRepeat.Text = "Mostrar";
            this.checkBoxMostrarRepeat.UseVisualStyleBackColor = true;
            this.checkBoxMostrarRepeat.CheckedChanged += new System.EventHandler(this.checkBoxMostrarRepeat_CheckedChanged);
            // 
            // checkBoxMostrar
            // 
            this.checkBoxMostrar.AutoSize = true;
            this.checkBoxMostrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMostrar.Location = new System.Drawing.Point(515, 24);
            this.checkBoxMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMostrar.Name = "checkBoxMostrar";
            this.checkBoxMostrar.Size = new System.Drawing.Size(82, 22);
            this.checkBoxMostrar.TabIndex = 9;
            this.checkBoxMostrar.Text = "Mostrar";
            this.checkBoxMostrar.UseVisualStyleBackColor = true;
            this.checkBoxMostrar.CheckedChanged += new System.EventHandler(this.checkBoxMostrar_CheckedChanged);
            // 
            // textBoxRepeatContrasenya
            // 
            this.textBoxRepeatContrasenya.Enabled = false;
            this.textBoxRepeatContrasenya.Location = new System.Drawing.Point(177, 75);
            this.textBoxRepeatContrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRepeatContrasenya.Name = "textBoxRepeatContrasenya";
            this.textBoxRepeatContrasenya.Size = new System.Drawing.Size(326, 25);
            this.textBoxRepeatContrasenya.TabIndex = 8;
            this.textBoxRepeatContrasenya.UseSystemPasswordChar = true;
            this.textBoxRepeatContrasenya.TextChanged += new System.EventHandler(this.textBoxRepeatContrasenya_TextChanged);
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Enabled = false;
            this.textBoxContrasenya.Location = new System.Drawing.Point(177, 20);
            this.textBoxContrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.Size = new System.Drawing.Size(326, 25);
            this.textBoxContrasenya.TabIndex = 7;
            this.textBoxContrasenya.UseSystemPasswordChar = true;
            // 
            // labelRepeatContrasenya
            // 
            this.labelRepeatContrasenya.AutoSize = true;
            this.labelRepeatContrasenya.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatContrasenya.Location = new System.Drawing.Point(11, 79);
            this.labelRepeatContrasenya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepeatContrasenya.Name = "labelRepeatContrasenya";
            this.labelRepeatContrasenya.Size = new System.Drawing.Size(154, 18);
            this.labelRepeatContrasenya.TabIndex = 3;
            this.labelRepeatContrasenya.Text = "Repetir Contrasenya";
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenya.Location = new System.Drawing.Point(11, 24);
            this.labelContrasenya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(97, 18);
            this.labelContrasenya.TabIndex = 2;
            this.labelContrasenya.Text = "Contrasenya";
            // 
            // buttonCancelarEdit
            // 
            this.buttonCancelarEdit.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelarEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarEdit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarEdit.Location = new System.Drawing.Point(374, 432);
            this.buttonCancelarEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelarEdit.Name = "buttonCancelarEdit";
            this.buttonCancelarEdit.Size = new System.Drawing.Size(130, 50);
            this.buttonCancelarEdit.TabIndex = 12;
            this.buttonCancelarEdit.Text = "Cancelar";
            this.buttonCancelarEdit.UseVisualStyleBackColor = false;
            this.buttonCancelarEdit.Click += new System.EventHandler(this.buttonCancelarEdit_Click);
            // 
            // buttonAceptarEditUsers
            // 
            this.buttonAceptarEditUsers.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAceptarEditUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAceptarEditUsers.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptarEditUsers.Location = new System.Drawing.Point(512, 432);
            this.buttonAceptarEditUsers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptarEditUsers.Name = "buttonAceptarEditUsers";
            this.buttonAceptarEditUsers.Size = new System.Drawing.Size(130, 50);
            this.buttonAceptarEditUsers.TabIndex = 11;
            this.buttonAceptarEditUsers.Text = "Aceptar";
            this.buttonAceptarEditUsers.UseVisualStyleBackColor = false;
            this.buttonAceptarEditUsers.Click += new System.EventHandler(this.buttonAceptarEditUsers_Click);
            // 
            // textBoxNomEdit
            // 
            this.textBoxNomEdit.Location = new System.Drawing.Point(207, 88);
            this.textBoxNomEdit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomEdit.Name = "textBoxNomEdit";
            this.textBoxNomEdit.Size = new System.Drawing.Size(326, 25);
            this.textBoxNomEdit.TabIndex = 6;
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(206, 40);
            this.textBoxNickName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(326, 25);
            this.textBoxNickName.TabIndex = 5;
            // 
            // groupBoxPriveligis
            // 
            this.groupBoxPriveligis.Controls.Add(this.checkBoxEliminar);
            this.groupBoxPriveligis.Controls.Add(this.checkBoxEditar);
            this.groupBoxPriveligis.Controls.Add(this.checkBoxAfegir);
            this.groupBoxPriveligis.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPriveligis.Location = new System.Drawing.Point(30, 342);
            this.groupBoxPriveligis.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPriveligis.Name = "groupBoxPriveligis";
            this.groupBoxPriveligis.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPriveligis.Size = new System.Drawing.Size(489, 63);
            this.groupBoxPriveligis.TabIndex = 4;
            this.groupBoxPriveligis.TabStop = false;
            this.groupBoxPriveligis.Text = "Privilegis";
            // 
            // checkBoxEliminar
            // 
            this.checkBoxEliminar.AutoSize = true;
            this.checkBoxEliminar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEliminar.Location = new System.Drawing.Point(387, 26);
            this.checkBoxEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEliminar.Name = "checkBoxEliminar";
            this.checkBoxEliminar.Size = new System.Drawing.Size(84, 22);
            this.checkBoxEliminar.TabIndex = 2;
            this.checkBoxEliminar.Text = "Eliminar";
            this.checkBoxEliminar.UseVisualStyleBackColor = true;
            // 
            // checkBoxEditar
            // 
            this.checkBoxEditar.AutoSize = true;
            this.checkBoxEditar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEditar.Location = new System.Drawing.Point(203, 26);
            this.checkBoxEditar.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEditar.Name = "checkBoxEditar";
            this.checkBoxEditar.Size = new System.Drawing.Size(69, 22);
            this.checkBoxEditar.TabIndex = 1;
            this.checkBoxEditar.Text = "Editar";
            this.checkBoxEditar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAfegir
            // 
            this.checkBoxAfegir.AutoSize = true;
            this.checkBoxAfegir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAfegir.Location = new System.Drawing.Point(23, 26);
            this.checkBoxAfegir.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAfegir.Name = "checkBoxAfegir";
            this.checkBoxAfegir.Size = new System.Drawing.Size(69, 22);
            this.checkBoxAfegir.TabIndex = 0;
            this.checkBoxAfegir.Text = "Afegir";
            this.checkBoxAfegir.UseVisualStyleBackColor = true;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNickname.Location = new System.Drawing.Point(40, 44);
            this.labelNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(79, 18);
            this.labelNickname.TabIndex = 1;
            this.labelNickname.Text = "NickName";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(42, 91);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(40, 18);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // FormEditUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(696, 523);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxDadesUsuari);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditUsuaris";
            this.Text = "FilmZ";
            this.Load += new System.EventHandler(this.FormEditUsuaris_Load);
            this.groupBoxDadesUsuari.ResumeLayout(false);
            this.groupBoxDadesUsuari.PerformLayout();
            this.groupBoxPassw.ResumeLayout(false);
            this.groupBoxPassw.PerformLayout();
            this.groupBoxPriveligis.ResumeLayout(false);
            this.groupBoxPriveligis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadesUsuari;
        private System.Windows.Forms.TextBox textBoxRepeatContrasenya;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.TextBox textBoxNomEdit;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.GroupBox groupBoxPriveligis;
        private System.Windows.Forms.Label labelRepeatContrasenya;
        private System.Windows.Forms.Label labelContrasenya;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.CheckBox checkBoxEliminar;
        private System.Windows.Forms.CheckBox checkBoxEditar;
        private System.Windows.Forms.CheckBox checkBoxAfegir;
        private System.Windows.Forms.CheckBox checkBoxMostrarRepeat;
        private System.Windows.Forms.CheckBox checkBoxMostrar;
        private System.Windows.Forms.Button buttonAceptarEditUsers;
        private System.Windows.Forms.Button buttonCancelarEdit;
        private System.Windows.Forms.GroupBox groupBoxPassw;
        private System.Windows.Forms.CheckBox checkModifyPassw;
    }
}