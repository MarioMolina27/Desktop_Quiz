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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonGuardar = new System.Windows.Forms.Button();
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
            this.groupBoxPelicules.SuspendLayout();
            this.groupBoxDificultat.SuspendLayout();
            this.groupBoxRespostaCorrecte.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPelicules
            // 
            this.groupBoxPelicules.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxPelicules.Controls.Add(this.buttonCancelar);
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
            this.groupBoxPelicules.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPelicules.Name = "groupBoxPelicules";
            this.groupBoxPelicules.Size = new System.Drawing.Size(1313, 726);
            this.groupBoxPelicules.TabIndex = 1;
            this.groupBoxPelicules.TabStop = false;
            this.groupBoxPelicules.Text = "Dades Pel·lícules";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.ImageKey = "(ninguno)";
            this.buttonCancelar.ImageList = this.imageList1;
            this.buttonCancelar.Location = new System.Drawing.Point(913, 618);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(175, 70);
            this.buttonCancelar.TabIndex = 29;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ImageKey = "(ninguno)";
            this.buttonGuardar.ImageList = this.imageList1;
            this.buttonGuardar.Location = new System.Drawing.Point(1104, 618);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(175, 70);
            this.buttonGuardar.TabIndex = 28;
            this.buttonGuardar.Text = "Aceptar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click_1);
            // 
            // buttonAudioAceptar
            // 
            this.buttonAudioAceptar.Location = new System.Drawing.Point(834, 547);
            this.buttonAudioAceptar.Name = "buttonAudioAceptar";
            this.buttonAudioAceptar.Size = new System.Drawing.Size(105, 26);
            this.buttonAudioAceptar.TabIndex = 26;
            this.buttonAudioAceptar.Text = "....";
            this.buttonAudioAceptar.UseVisualStyleBackColor = true;
            this.buttonAudioAceptar.Click += new System.EventHandler(this.buttonAudioAceptar_Click);
            // 
            // buttonImatgeAceptar
            // 
            this.buttonImatgeAceptar.Location = new System.Drawing.Point(834, 485);
            this.buttonImatgeAceptar.Name = "buttonImatgeAceptar";
            this.buttonImatgeAceptar.Size = new System.Drawing.Size(105, 26);
            this.buttonImatgeAceptar.TabIndex = 25;
            this.buttonImatgeAceptar.Text = "....";
            this.buttonImatgeAceptar.UseVisualStyleBackColor = true;
            this.buttonImatgeAceptar.Click += new System.EventHandler(this.buttonImatgeAceptar_Click);
            // 
            // groupBoxDificultat
            // 
            this.groupBoxDificultat.Controls.Add(this.radioButtonDificultat3);
            this.groupBoxDificultat.Controls.Add(this.radioButtonDificultat2);
            this.groupBoxDificultat.Controls.Add(this.radioButtonDificultat1);
            this.groupBoxDificultat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDificultat.Location = new System.Drawing.Point(869, 331);
            this.groupBoxDificultat.Name = "groupBoxDificultat";
            this.groupBoxDificultat.Size = new System.Drawing.Size(410, 76);
            this.groupBoxDificultat.TabIndex = 24;
            this.groupBoxDificultat.TabStop = false;
            this.groupBoxDificultat.Text = "Dificultat";
            // 
            // radioButtonDificultat3
            // 
            this.radioButtonDificultat3.AutoSize = true;
            this.radioButtonDificultat3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDificultat3.Location = new System.Drawing.Point(328, 32);
            this.radioButtonDificultat3.Name = "radioButtonDificultat3";
            this.radioButtonDificultat3.Size = new System.Drawing.Size(42, 26);
            this.radioButtonDificultat3.TabIndex = 23;
            this.radioButtonDificultat3.TabStop = true;
            this.radioButtonDificultat3.Text = "3";
            this.radioButtonDificultat3.UseVisualStyleBackColor = true;
            // 
            // radioButtonDificultat2
            // 
            this.radioButtonDificultat2.AutoSize = true;
            this.radioButtonDificultat2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDificultat2.Location = new System.Drawing.Point(177, 32);
            this.radioButtonDificultat2.Name = "radioButtonDificultat2";
            this.radioButtonDificultat2.Size = new System.Drawing.Size(42, 26);
            this.radioButtonDificultat2.TabIndex = 23;
            this.radioButtonDificultat2.TabStop = true;
            this.radioButtonDificultat2.Text = "2";
            this.radioButtonDificultat2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDificultat1
            // 
            this.radioButtonDificultat1.AutoSize = true;
            this.radioButtonDificultat1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDificultat1.Location = new System.Drawing.Point(27, 32);
            this.radioButtonDificultat1.Name = "radioButtonDificultat1";
            this.radioButtonDificultat1.Size = new System.Drawing.Size(42, 26);
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
            this.groupBoxRespostaCorrecte.Location = new System.Drawing.Point(869, 141);
            this.groupBoxRespostaCorrecte.Name = "groupBoxRespostaCorrecte";
            this.groupBoxRespostaCorrecte.Size = new System.Drawing.Size(410, 76);
            this.groupBoxRespostaCorrecte.TabIndex = 21;
            this.groupBoxRespostaCorrecte.TabStop = false;
            this.groupBoxRespostaCorrecte.Text = "Resposta Correcte";
            // 
            // radioButtonResposta3
            // 
            this.radioButtonResposta3.AutoSize = true;
            this.radioButtonResposta3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta3.Location = new System.Drawing.Point(328, 32);
            this.radioButtonResposta3.Name = "radioButtonResposta3";
            this.radioButtonResposta3.Size = new System.Drawing.Size(42, 26);
            this.radioButtonResposta3.TabIndex = 23;
            this.radioButtonResposta3.TabStop = true;
            this.radioButtonResposta3.Text = "3";
            this.radioButtonResposta3.UseVisualStyleBackColor = true;
            // 
            // radioButtonResposta2
            // 
            this.radioButtonResposta2.AutoSize = true;
            this.radioButtonResposta2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta2.Location = new System.Drawing.Point(177, 32);
            this.radioButtonResposta2.Name = "radioButtonResposta2";
            this.radioButtonResposta2.Size = new System.Drawing.Size(42, 26);
            this.radioButtonResposta2.TabIndex = 23;
            this.radioButtonResposta2.TabStop = true;
            this.radioButtonResposta2.Text = "2";
            this.radioButtonResposta2.UseVisualStyleBackColor = true;
            // 
            // radioButtonResposta1
            // 
            this.radioButtonResposta1.AutoSize = true;
            this.radioButtonResposta1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonResposta1.Location = new System.Drawing.Point(27, 32);
            this.radioButtonResposta1.Name = "radioButtonResposta1";
            this.radioButtonResposta1.Size = new System.Drawing.Size(42, 26);
            this.radioButtonResposta1.TabIndex = 22;
            this.radioButtonResposta1.TabStop = true;
            this.radioButtonResposta1.Text = "1";
            this.radioButtonResposta1.UseVisualStyleBackColor = true;
            // 
            // textBoxAudio
            // 
            this.textBoxAudio.Location = new System.Drawing.Point(178, 545);
            this.textBoxAudio.Name = "textBoxAudio";
            this.textBoxAudio.ReadOnly = true;
            this.textBoxAudio.Size = new System.Drawing.Size(624, 29);
            this.textBoxAudio.TabIndex = 20;
            // 
            // textBoxImatge
            // 
            this.textBoxImatge.Location = new System.Drawing.Point(178, 487);
            this.textBoxImatge.Name = "textBoxImatge";
            this.textBoxImatge.ReadOnly = true;
            this.textBoxImatge.Size = new System.Drawing.Size(624, 29);
            this.textBoxImatge.TabIndex = 19;
            // 
            // textBoxResposta3
            // 
            this.textBoxResposta3.Location = new System.Drawing.Point(178, 242);
            this.textBoxResposta3.Name = "textBoxResposta3";
            this.textBoxResposta3.Size = new System.Drawing.Size(624, 29);
            this.textBoxResposta3.TabIndex = 18;
            // 
            // textBoxResposta2
            // 
            this.textBoxResposta2.Location = new System.Drawing.Point(178, 194);
            this.textBoxResposta2.Name = "textBoxResposta2";
            this.textBoxResposta2.Size = new System.Drawing.Size(624, 29);
            this.textBoxResposta2.TabIndex = 17;
            // 
            // textBoxResposta1
            // 
            this.textBoxResposta1.Location = new System.Drawing.Point(178, 141);
            this.textBoxResposta1.Name = "textBoxResposta1";
            this.textBoxResposta1.Size = new System.Drawing.Size(624, 29);
            this.textBoxResposta1.TabIndex = 16;
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(178, 55);
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(624, 29);
            this.textBoxPregunta.TabIndex = 15;
            // 
            // labelAudio
            // 
            this.labelAudio.AutoSize = true;
            this.labelAudio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAudio.Location = new System.Drawing.Point(64, 551);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.Size = new System.Drawing.Size(64, 22);
            this.labelAudio.TabIndex = 13;
            this.labelAudio.Text = "Audio";
            // 
            // labelImatge
            // 
            this.labelImatge.AutoSize = true;
            this.labelImatge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImatge.Location = new System.Drawing.Point(64, 485);
            this.labelImatge.Name = "labelImatge";
            this.labelImatge.Size = new System.Drawing.Size(72, 22);
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
            this.comboBoxIdioma.Location = new System.Drawing.Point(178, 396);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(230, 30);
            this.comboBoxIdioma.TabIndex = 11;
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdioma.Location = new System.Drawing.Point(64, 399);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(72, 22);
            this.labelIdioma.TabIndex = 10;
            this.labelIdioma.Text = "Idioma";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Acción",
            "Animación",
            "Ciencia Ficción",
            "Drama",
            "Terror"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(178, 331);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(230, 30);
            this.comboBoxCategoria.TabIndex = 9;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.Location = new System.Drawing.Point(66, 334);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(100, 22);
            this.labelCategoria.TabIndex = 8;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelResposta3
            // 
            this.labelResposta3.AutoSize = true;
            this.labelResposta3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta3.Location = new System.Drawing.Point(64, 249);
            this.labelResposta3.Name = "labelResposta3";
            this.labelResposta3.Size = new System.Drawing.Size(113, 22);
            this.labelResposta3.TabIndex = 7;
            this.labelResposta3.Text = "Resposta 3";
            // 
            // labelResposta2
            // 
            this.labelResposta2.AutoSize = true;
            this.labelResposta2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta2.Location = new System.Drawing.Point(64, 194);
            this.labelResposta2.Name = "labelResposta2";
            this.labelResposta2.Size = new System.Drawing.Size(113, 22);
            this.labelResposta2.TabIndex = 6;
            this.labelResposta2.Text = "Resposta 2";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPregunta.Location = new System.Drawing.Point(64, 55);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(95, 22);
            this.labelPregunta.TabIndex = 5;
            this.labelPregunta.Text = "Pregunta";
            // 
            // labelResposta1
            // 
            this.labelResposta1.AutoSize = true;
            this.labelResposta1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResposta1.Location = new System.Drawing.Point(64, 141);
            this.labelResposta1.Name = "labelResposta1";
            this.labelResposta1.Size = new System.Drawing.Size(113, 22);
            this.labelResposta1.TabIndex = 4;
            this.labelResposta1.Text = "Resposta 1";
            // 
            // FormEditPreguntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1339, 751);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxPelicules);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormEditPreguntes";
            this.Text = "FilmZ";
            this.Load += new System.EventHandler(this.FormEditPreguntes_Load);
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
        private System.Windows.Forms.Button buttonCancelar;
    }
}