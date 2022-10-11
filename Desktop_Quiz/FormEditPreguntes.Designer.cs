namespace Desktop_Quiz
{
    partial class FormEditPreguntes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPreguntes));
            this.groupBoxPelicules = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAudioAceptar = new System.Windows.Forms.Button();
            this.buttonImatgeAceptar = new System.Windows.Forms.Button();
            this.groupBoxDificultat = new System.Windows.Forms.GroupBox();
            this.radioButtonDificultat3 = new System.Windows.Forms.RadioButton();
            this.radioButtonDificultat2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDificultat1 = new System.Windows.Forms.RadioButton();
            this.groupBoxRespostaCorrecte = new System.Windows.Forms.GroupBox();
            this.radioButtonResposta3 = new System.Windows.Forms.RadioButton();
            this.radioButtonResposta2 = new System.Windows.Forms.RadioButton();
            this.radioButtonResposta1 = new System.Windows.Forms.RadioButton();
            this.textBoxAudio = new System.Windows.Forms.TextBox();
            this.textBoxImatge = new System.Windows.Forms.TextBox();
            this.textBoxResposta3 = new System.Windows.Forms.TextBox();
            this.textBoxResposta2 = new System.Windows.Forms.TextBox();
            this.textBoxResposta1 = new System.Windows.Forms.TextBox();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelAudio = new System.Windows.Forms.Label();
            this.labelImatge = new System.Windows.Forms.Label();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelResposta3 = new System.Windows.Forms.Label();
            this.labelResposta2 = new System.Windows.Forms.Label();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.labelResposta1 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.groupBoxPelicules.SuspendLayout();
            this.groupBoxDificultat.SuspendLayout();
            this.groupBoxRespostaCorrecte.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPelicules
            // 
            this.groupBoxPelicules.Controls.Add(this.buttonGuardar);
            this.groupBoxPelicules.Controls.Add(this.buttonAudioAceptar);
            this.groupBoxPelicules.Controls.Add(this.buttonImatgeAceptar);
            this.groupBoxPelicules.Controls.Add(this.groupBoxDificultat);
            this.groupBoxPelicules.Controls.Add(this.groupBoxRespostaCorrecte);
            this.groupBoxPelicules.Controls.Add(this.textBoxAudio);
            this.groupBoxPelicules.Controls.Add(this.textBoxImatge);
            this.groupBoxPelicules.Controls.Add(this.textBoxResposta3);
            this.groupBoxPelicules.Controls.Add(this.textBoxResposta2);
            this.groupBoxPelicules.Controls.Add(this.textBoxResposta1);
            this.groupBoxPelicules.Controls.Add(this.textBoxPregunta);
            this.groupBoxPelicules.Controls.Add(this.textBoxNom);
            this.groupBoxPelicules.Controls.Add(this.labelAudio);
            this.groupBoxPelicules.Controls.Add(this.labelImatge);
            this.groupBoxPelicules.Controls.Add(this.comboBoxIdioma);
            this.groupBoxPelicules.Controls.Add(this.labelIdioma);
            this.groupBoxPelicules.Controls.Add(this.comboBoxCategoria);
            this.groupBoxPelicules.Controls.Add(this.labelCategoria);
            this.groupBoxPelicules.Controls.Add(this.labelResposta3);
            this.groupBoxPelicules.Controls.Add(this.labelResposta2);
            this.groupBoxPelicules.Controls.Add(this.labelPregunta);
            this.groupBoxPelicules.Controls.Add(this.labelResposta1);
            this.groupBoxPelicules.Controls.Add(this.labelNom);
            this.groupBoxPelicules.Location = new System.Drawing.Point(8, 8);
            this.groupBoxPelicules.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPelicules.Name = "groupBoxPelicules";
            this.groupBoxPelicules.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPelicules.Size = new System.Drawing.Size(935, 573);
            this.groupBoxPelicules.TabIndex = 1;
            this.groupBoxPelicules.TabStop = false;
            this.groupBoxPelicules.Text = "Dades Pel·lícules";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ImageIndex = 0;
            this.buttonGuardar.ImageList = this.imageList1;
            this.buttonGuardar.Location = new System.Drawing.Point(850, 493);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(69, 67);
            this.buttonGuardar.TabIndex = 28;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            // 
            // buttonAudioAceptar
            // 
            this.buttonAudioAceptar.Location = new System.Drawing.Point(563, 439);
            this.buttonAudioAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAudioAceptar.Name = "buttonAudioAceptar";
            this.buttonAudioAceptar.Size = new System.Drawing.Size(70, 19);
            this.buttonAudioAceptar.TabIndex = 26;
            this.buttonAudioAceptar.Text = "....";
            this.buttonAudioAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonImatgeAceptar
            // 
            this.buttonImatgeAceptar.Location = new System.Drawing.Point(563, 394);
            this.buttonImatgeAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImatgeAceptar.Name = "buttonImatgeAceptar";
            this.buttonImatgeAceptar.Size = new System.Drawing.Size(70, 19);
            this.buttonImatgeAceptar.TabIndex = 25;
            this.buttonImatgeAceptar.Text = "....";
            this.buttonImatgeAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBoxDificultat
            // 
            this.groupBoxDificultat.Controls.Add(this.radioButtonDificultat3);
            this.groupBoxDificultat.Controls.Add(this.radioButtonDificultat2);
            this.groupBoxDificultat.Controls.Add(this.radioButtonDificultat1);
            this.groupBoxDificultat.Location = new System.Drawing.Point(586, 283);
            this.groupBoxDificultat.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDificultat.Name = "groupBoxDificultat";
            this.groupBoxDificultat.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDificultat.Size = new System.Drawing.Size(273, 55);
            this.groupBoxDificultat.TabIndex = 24;
            this.groupBoxDificultat.TabStop = false;
            this.groupBoxDificultat.Text = "Dificultat";
            // 
            // radioButtonDificultat3
            // 
            this.radioButtonDificultat3.AutoSize = true;
            this.radioButtonDificultat3.Location = new System.Drawing.Point(219, 23);
            this.radioButtonDificultat3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDificultat3.Name = "radioButtonDificultat3";
            this.radioButtonDificultat3.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDificultat3.TabIndex = 23;
            this.radioButtonDificultat3.TabStop = true;
            this.radioButtonDificultat3.Text = "3";
            this.radioButtonDificultat3.UseVisualStyleBackColor = true;
            // 
            // radioButtonDificultat2
            // 
            this.radioButtonDificultat2.AutoSize = true;
            this.radioButtonDificultat2.Location = new System.Drawing.Point(118, 23);
            this.radioButtonDificultat2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDificultat2.Name = "radioButtonDificultat2";
            this.radioButtonDificultat2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDificultat2.TabIndex = 23;
            this.radioButtonDificultat2.TabStop = true;
            this.radioButtonDificultat2.Text = "2";
            this.radioButtonDificultat2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDificultat1
            // 
            this.radioButtonDificultat1.AutoSize = true;
            this.radioButtonDificultat1.Location = new System.Drawing.Point(18, 23);
            this.radioButtonDificultat1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDificultat1.Name = "radioButtonDificultat1";
            this.radioButtonDificultat1.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDificultat1.TabIndex = 22;
            this.radioButtonDificultat1.TabStop = true;
            this.radioButtonDificultat1.Text = "1";
            this.radioButtonDificultat1.UseVisualStyleBackColor = true;
            // 
            // groupBoxRespostaCorrecte
            // 
            this.groupBoxRespostaCorrecte.Controls.Add(this.radioButtonResposta3);
            this.groupBoxRespostaCorrecte.Controls.Add(this.radioButtonResposta2);
            this.groupBoxRespostaCorrecte.Controls.Add(this.radioButtonResposta1);
            this.groupBoxRespostaCorrecte.Location = new System.Drawing.Point(586, 146);
            this.groupBoxRespostaCorrecte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRespostaCorrecte.Name = "groupBoxRespostaCorrecte";
            this.groupBoxRespostaCorrecte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRespostaCorrecte.Size = new System.Drawing.Size(273, 55);
            this.groupBoxRespostaCorrecte.TabIndex = 21;
            this.groupBoxRespostaCorrecte.TabStop = false;
            this.groupBoxRespostaCorrecte.Text = "Resposta Correcte";
            // 
            // radioButtonResposta3
            // 
            this.radioButtonResposta3.AutoSize = true;
            this.radioButtonResposta3.Location = new System.Drawing.Point(219, 23);
            this.radioButtonResposta3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonResposta3.Name = "radioButtonResposta3";
            this.radioButtonResposta3.Size = new System.Drawing.Size(31, 17);
            this.radioButtonResposta3.TabIndex = 23;
            this.radioButtonResposta3.TabStop = true;
            this.radioButtonResposta3.Text = "3";
            this.radioButtonResposta3.UseVisualStyleBackColor = true;
            // 
            // radioButtonResposta2
            // 
            this.radioButtonResposta2.AutoSize = true;
            this.radioButtonResposta2.Location = new System.Drawing.Point(118, 23);
            this.radioButtonResposta2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonResposta2.Name = "radioButtonResposta2";
            this.radioButtonResposta2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonResposta2.TabIndex = 23;
            this.radioButtonResposta2.TabStop = true;
            this.radioButtonResposta2.Text = "2";
            this.radioButtonResposta2.UseVisualStyleBackColor = true;
            // 
            // radioButtonResposta1
            // 
            this.radioButtonResposta1.AutoSize = true;
            this.radioButtonResposta1.Location = new System.Drawing.Point(18, 23);
            this.radioButtonResposta1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonResposta1.Name = "radioButtonResposta1";
            this.radioButtonResposta1.Size = new System.Drawing.Size(31, 17);
            this.radioButtonResposta1.TabIndex = 22;
            this.radioButtonResposta1.TabStop = true;
            this.radioButtonResposta1.Text = "1";
            this.radioButtonResposta1.UseVisualStyleBackColor = true;
            // 
            // textBoxAudio
            // 
            this.textBoxAudio.Location = new System.Drawing.Point(125, 438);
            this.textBoxAudio.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAudio.Name = "textBoxAudio";
            this.textBoxAudio.Size = new System.Drawing.Size(417, 20);
            this.textBoxAudio.TabIndex = 20;
            // 
            // textBoxImatge
            // 
            this.textBoxImatge.Location = new System.Drawing.Point(125, 396);
            this.textBoxImatge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxImatge.Name = "textBoxImatge";
            this.textBoxImatge.Size = new System.Drawing.Size(417, 20);
            this.textBoxImatge.TabIndex = 19;
            // 
            // textBoxResposta3
            // 
            this.textBoxResposta3.Location = new System.Drawing.Point(125, 219);
            this.textBoxResposta3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResposta3.Name = "textBoxResposta3";
            this.textBoxResposta3.Size = new System.Drawing.Size(417, 20);
            this.textBoxResposta3.TabIndex = 18;
            // 
            // textBoxResposta2
            // 
            this.textBoxResposta2.Location = new System.Drawing.Point(125, 184);
            this.textBoxResposta2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResposta2.Name = "textBoxResposta2";
            this.textBoxResposta2.Size = new System.Drawing.Size(417, 20);
            this.textBoxResposta2.TabIndex = 17;
            // 
            // textBoxResposta1
            // 
            this.textBoxResposta1.Location = new System.Drawing.Point(125, 146);
            this.textBoxResposta1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResposta1.Name = "textBoxResposta1";
            this.textBoxResposta1.Size = new System.Drawing.Size(417, 20);
            this.textBoxResposta1.TabIndex = 16;
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(125, 84);
            this.textBoxPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(417, 20);
            this.textBoxPregunta.TabIndex = 15;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(125, 27);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(417, 20);
            this.textBoxNom.TabIndex = 14;
            // 
            // labelAudio
            // 
            this.labelAudio.AutoSize = true;
            this.labelAudio.Location = new System.Drawing.Point(56, 442);
            this.labelAudio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.Size = new System.Drawing.Size(34, 13);
            this.labelAudio.TabIndex = 13;
            this.labelAudio.Text = "Audio";
            // 
            // labelImatge
            // 
            this.labelImatge.AutoSize = true;
            this.labelImatge.Location = new System.Drawing.Point(50, 396);
            this.labelImatge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImatge.Name = "labelImatge";
            this.labelImatge.Size = new System.Drawing.Size(39, 13);
            this.labelImatge.TabIndex = 12;
            this.labelImatge.Text = "Imatge";
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Català",
            "Castellano",
            "English"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(125, 330);
            this.comboBoxIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(155, 21);
            this.comboBoxIdioma.TabIndex = 11;
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(51, 332);
            this.labelIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(38, 13);
            this.labelIdioma.TabIndex = 10;
            this.labelIdioma.Text = "Idioma";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(125, 283);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(155, 21);
            this.comboBoxCategoria.TabIndex = 9;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(37, 283);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelResposta3
            // 
            this.labelResposta3.AutoSize = true;
            this.labelResposta3.Location = new System.Drawing.Point(29, 219);
            this.labelResposta3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResposta3.Name = "labelResposta3";
            this.labelResposta3.Size = new System.Drawing.Size(61, 13);
            this.labelResposta3.TabIndex = 7;
            this.labelResposta3.Text = "Resposta 3";
            // 
            // labelResposta2
            // 
            this.labelResposta2.AutoSize = true;
            this.labelResposta2.Location = new System.Drawing.Point(29, 184);
            this.labelResposta2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResposta2.Name = "labelResposta2";
            this.labelResposta2.Size = new System.Drawing.Size(61, 13);
            this.labelResposta2.TabIndex = 6;
            this.labelResposta2.Text = "Resposta 2";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Location = new System.Drawing.Point(40, 84);
            this.labelPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(50, 13);
            this.labelPregunta.TabIndex = 5;
            this.labelPregunta.Text = "Pregunta";
            // 
            // labelResposta1
            // 
            this.labelResposta1.AutoSize = true;
            this.labelResposta1.Location = new System.Drawing.Point(29, 146);
            this.labelResposta1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResposta1.Name = "labelResposta1";
            this.labelResposta1.Size = new System.Drawing.Size(61, 13);
            this.labelResposta1.TabIndex = 4;
            this.labelResposta1.Text = "Resposta 1";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(61, 31);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // FormEditPreguntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 593);
            this.Controls.Add(this.groupBoxPelicules);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditPreguntes";
            this.Text = "FormEditPreguntes";
            this.groupBoxPelicules.ResumeLayout(false);
            this.groupBoxPelicules.PerformLayout();
            this.groupBoxDificultat.ResumeLayout(false);
            this.groupBoxDificultat.PerformLayout();
            this.groupBoxRespostaCorrecte.ResumeLayout(false);
            this.groupBoxRespostaCorrecte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPelicules;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label labelResposta1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button buttonAudioAceptar;
        private System.Windows.Forms.Button buttonImatgeAceptar;
        private System.Windows.Forms.GroupBox groupBoxDificultat;
        private System.Windows.Forms.RadioButton radioButtonDificultat3;
        private System.Windows.Forms.RadioButton radioButtonDificultat2;
        private System.Windows.Forms.RadioButton radioButtonDificultat1;
        private System.Windows.Forms.GroupBox groupBoxRespostaCorrecte;
        private System.Windows.Forms.RadioButton radioButtonResposta3;
        private System.Windows.Forms.RadioButton radioButtonResposta2;
        private System.Windows.Forms.RadioButton radioButtonResposta1;
        private System.Windows.Forms.TextBox textBoxAudio;
        private System.Windows.Forms.TextBox textBoxImatge;
        private System.Windows.Forms.TextBox textBoxResposta3;
        private System.Windows.Forms.TextBox textBoxResposta2;
        private System.Windows.Forms.TextBox textBoxResposta1;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelAudio;
        private System.Windows.Forms.Label labelImatge;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelResposta3;
        private System.Windows.Forms.Label labelResposta2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ImageList imageList1;
    }
}