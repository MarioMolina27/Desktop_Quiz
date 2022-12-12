namespace Desktop_Quiz
{
    partial class FormPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreguntas));
            this.groupBoxPreguntes = new System.Windows.Forms.GroupBox();
            this.groupBoxOpcionsFilOr = new System.Windows.Forms.GroupBox();
            this.groupBoxIdiomes = new System.Windows.Forms.GroupBox();
            this.radioButtonIdiomesTots = new System.Windows.Forms.RadioButton();
            this.radioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.radioButtonCastellano = new System.Windows.Forms.RadioButton();
            this.radioButtonCatala = new System.Windows.Forms.RadioButton();
            this.groupBoxModificacions = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.groupBoxOrdenacio = new System.Windows.Forms.GroupBox();
            this.radioButtonDificultat = new System.Windows.Forms.RadioButton();
            this.radioButtonCategoria = new System.Windows.Forms.RadioButton();
            this.dataGridViewPelicules = new System.Windows.Forms.DataGridView();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTitul = new System.Windows.Forms.Label();
            this.toolStripBackOption = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.groupBoxPreguntes.SuspendLayout();
            this.groupBoxOpcionsFilOr.SuspendLayout();
            this.groupBoxIdiomes.SuspendLayout();
            this.groupBoxModificacions.SuspendLayout();
            this.groupBoxOrdenacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelicules)).BeginInit();
            this.toolStripBackOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPreguntes
            // 
            this.groupBoxPreguntes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxPreguntes.Controls.Add(this.groupBoxOpcionsFilOr);
            this.groupBoxPreguntes.Controls.Add(this.dataGridViewPelicules);
            this.groupBoxPreguntes.Controls.Add(this.textBoxTitulo);
            this.groupBoxPreguntes.Controls.Add(this.labelTitul);
            this.groupBoxPreguntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPreguntes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPreguntes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxPreguntes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPreguntes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPreguntes.Name = "groupBoxPreguntes";
            this.groupBoxPreguntes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPreguntes.Size = new System.Drawing.Size(1924, 1055);
            this.groupBoxPreguntes.TabIndex = 2;
            this.groupBoxPreguntes.TabStop = false;
            this.groupBoxPreguntes.Text = "Preguntes";
            // 
            // groupBoxOpcionsFilOr
            // 
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBoxIdiomes);
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBoxModificacions);
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBoxOrdenacio);
            this.groupBoxOpcionsFilOr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxOpcionsFilOr.Location = new System.Drawing.Point(48, 167);
            this.groupBoxOpcionsFilOr.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOpcionsFilOr.Name = "groupBoxOpcionsFilOr";
            this.groupBoxOpcionsFilOr.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOpcionsFilOr.Size = new System.Drawing.Size(321, 757);
            this.groupBoxOpcionsFilOr.TabIndex = 4;
            this.groupBoxOpcionsFilOr.TabStop = false;
            this.groupBoxOpcionsFilOr.Text = "Opcions";
            // 
            // groupBoxIdiomes
            // 
            this.groupBoxIdiomes.Controls.Add(this.radioButtonIdiomesTots);
            this.groupBoxIdiomes.Controls.Add(this.radioButtonEnglish);
            this.groupBoxIdiomes.Controls.Add(this.radioButtonCastellano);
            this.groupBoxIdiomes.Controls.Add(this.radioButtonCatala);
            this.groupBoxIdiomes.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBoxIdiomes.Location = new System.Drawing.Point(28, 240);
            this.groupBoxIdiomes.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIdiomes.Name = "groupBoxIdiomes";
            this.groupBoxIdiomes.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIdiomes.Size = new System.Drawing.Size(267, 190);
            this.groupBoxIdiomes.TabIndex = 3;
            this.groupBoxIdiomes.TabStop = false;
            this.groupBoxIdiomes.Text = "Idiomes";
            // 
            // radioButtonIdiomesTots
            // 
            this.radioButtonIdiomesTots.AutoSize = true;
            this.radioButtonIdiomesTots.Checked = true;
            this.radioButtonIdiomesTots.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioButtonIdiomesTots.Location = new System.Drawing.Point(41, 140);
            this.radioButtonIdiomesTots.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonIdiomesTots.Name = "radioButtonIdiomesTots";
            this.radioButtonIdiomesTots.Size = new System.Drawing.Size(65, 28);
            this.radioButtonIdiomesTots.TabIndex = 3;
            this.radioButtonIdiomesTots.TabStop = true;
            this.radioButtonIdiomesTots.Text = "Tots";
            this.radioButtonIdiomesTots.UseVisualStyleBackColor = true;
            this.radioButtonIdiomesTots.CheckedChanged += new System.EventHandler(this.radioButtonIdiomesTots_CheckedChanged);
            // 
            // radioButtonEnglish
            // 
            this.radioButtonEnglish.AutoSize = true;
            this.radioButtonEnglish.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radioButtonEnglish.Location = new System.Drawing.Point(41, 103);
            this.radioButtonEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEnglish.Name = "radioButtonEnglish";
            this.radioButtonEnglish.Size = new System.Drawing.Size(91, 28);
            this.radioButtonEnglish.TabIndex = 2;
            this.radioButtonEnglish.TabStop = true;
            this.radioButtonEnglish.Text = "English";
            this.radioButtonEnglish.UseVisualStyleBackColor = true;
            this.radioButtonEnglish.CheckedChanged += new System.EventHandler(this.radioButtonEnglish_CheckedChanged);
            // 
            // radioButtonCastellano
            // 
            this.radioButtonCastellano.AutoSize = true;
            this.radioButtonCastellano.Location = new System.Drawing.Point(41, 68);
            this.radioButtonCastellano.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCastellano.Name = "radioButtonCastellano";
            this.radioButtonCastellano.Size = new System.Drawing.Size(114, 28);
            this.radioButtonCastellano.TabIndex = 1;
            this.radioButtonCastellano.TabStop = true;
            this.radioButtonCastellano.Text = "Castellano";
            this.radioButtonCastellano.UseVisualStyleBackColor = true;
            this.radioButtonCastellano.CheckedChanged += new System.EventHandler(this.radioButtonCastellano_CheckedChanged);
            // 
            // radioButtonCatala
            // 
            this.radioButtonCatala.AutoSize = true;
            this.radioButtonCatala.Location = new System.Drawing.Point(41, 32);
            this.radioButtonCatala.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCatala.Name = "radioButtonCatala";
            this.radioButtonCatala.Size = new System.Drawing.Size(80, 28);
            this.radioButtonCatala.TabIndex = 0;
            this.radioButtonCatala.TabStop = true;
            this.radioButtonCatala.Text = "Català";
            this.radioButtonCatala.UseVisualStyleBackColor = true;
            this.radioButtonCatala.CheckedChanged += new System.EventHandler(this.radioButtonCatala_CheckedChanged);
            // 
            // groupBoxModificacions
            // 
            this.groupBoxModificacions.Controls.Add(this.buttonEliminar);
            this.groupBoxModificacions.Controls.Add(this.buttonAfegir);
            this.groupBoxModificacions.Controls.Add(this.buttonModificar);
            this.groupBoxModificacions.Location = new System.Drawing.Point(28, 437);
            this.groupBoxModificacions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxModificacions.Name = "groupBoxModificacions";
            this.groupBoxModificacions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxModificacions.Size = new System.Drawing.Size(267, 299);
            this.groupBoxModificacions.TabIndex = 2;
            this.groupBoxModificacions.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(133, 171);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(92, 97);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAfegir.Image = ((System.Drawing.Image)(resources.GetObject("buttonAfegir.Image")));
            this.buttonAfegir.Location = new System.Drawing.Point(33, 34);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(192, 129);
            this.buttonAfegir.TabIndex = 6;
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
            this.buttonModificar.Location = new System.Drawing.Point(33, 171);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(92, 97);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // groupBoxOrdenacio
            // 
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonDificultat);
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonCategoria);
            this.groupBoxOrdenacio.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBoxOrdenacio.Location = new System.Drawing.Point(28, 63);
            this.groupBoxOrdenacio.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOrdenacio.Name = "groupBoxOrdenacio";
            this.groupBoxOrdenacio.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOrdenacio.Size = new System.Drawing.Size(267, 139);
            this.groupBoxOrdenacio.TabIndex = 1;
            this.groupBoxOrdenacio.TabStop = false;
            this.groupBoxOrdenacio.Text = "Ordenar per: ";
            // 
            // radioButtonDificultat
            // 
            this.radioButtonDificultat.AutoSize = true;
            this.radioButtonDificultat.Location = new System.Drawing.Point(41, 81);
            this.radioButtonDificultat.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDificultat.Name = "radioButtonDificultat";
            this.radioButtonDificultat.Size = new System.Drawing.Size(101, 28);
            this.radioButtonDificultat.TabIndex = 1;
            this.radioButtonDificultat.TabStop = true;
            this.radioButtonDificultat.Text = "Dificultat";
            this.radioButtonDificultat.UseVisualStyleBackColor = true;
            this.radioButtonDificultat.CheckedChanged += new System.EventHandler(this.radioButtonDificultat_CheckedChanged);
            // 
            // radioButtonCategoria
            // 
            this.radioButtonCategoria.AutoSize = true;
            this.radioButtonCategoria.Location = new System.Drawing.Point(41, 38);
            this.radioButtonCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCategoria.Name = "radioButtonCategoria";
            this.radioButtonCategoria.Size = new System.Drawing.Size(106, 28);
            this.radioButtonCategoria.TabIndex = 0;
            this.radioButtonCategoria.TabStop = true;
            this.radioButtonCategoria.Text = "Categoria";
            this.radioButtonCategoria.UseVisualStyleBackColor = true;
            this.radioButtonCategoria.CheckedChanged += new System.EventHandler(this.radioButtonCategoria_CheckedChanged);
            // 
            // dataGridViewPelicules
            // 
            this.dataGridViewPelicules.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewPelicules.AllowUserToOrderColumns = true;
            this.dataGridViewPelicules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPelicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelicules.Location = new System.Drawing.Point(443, 167);
            this.dataGridViewPelicules.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPelicules.Name = "dataGridViewPelicules";
            this.dataGridViewPelicules.RowHeadersWidth = 62;
            this.dataGridViewPelicules.Size = new System.Drawing.Size(1963, 1028);
            this.dataGridViewPelicules.TabIndex = 3;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(544, 112);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(524, 30);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.Enter += new System.EventHandler(this.textBoxTitulo_Enter);
            this.textBoxTitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitulo_KeyDown);
            this.textBoxTitulo.Leave += new System.EventHandler(this.textBoxTitulo_Leave);
            // 
            // labelTitul
            // 
            this.labelTitul.AutoSize = true;
            this.labelTitul.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitul.Location = new System.Drawing.Point(437, 117);
            this.labelTitul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitul.Name = "labelTitul";
            this.labelTitul.Size = new System.Drawing.Size(66, 24);
            this.labelTitul.TabIndex = 0;
            this.labelTitul.Text = "Filtrar";
            // 
            // toolStripBackOption
            // 
            this.toolStripBackOption.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripBackOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBackOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack});
            this.toolStripBackOption.Location = new System.Drawing.Point(0, 0);
            this.toolStripBackOption.Name = "toolStripBackOption";
            this.toolStripBackOption.Size = new System.Drawing.Size(1924, 27);
            this.toolStripBackOption.TabIndex = 12;
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonBack.Text = "BACK";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripBackOption);
            this.Controls.Add(this.groupBoxPreguntes);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPreguntas";
            this.Text = "FilmZ";
            this.Load += new System.EventHandler(this.FormPreguntas_Load);
            this.groupBoxPreguntes.ResumeLayout(false);
            this.groupBoxPreguntes.PerformLayout();
            this.groupBoxOpcionsFilOr.ResumeLayout(false);
            this.groupBoxIdiomes.ResumeLayout(false);
            this.groupBoxIdiomes.PerformLayout();
            this.groupBoxModificacions.ResumeLayout(false);
            this.groupBoxOrdenacio.ResumeLayout(false);
            this.groupBoxOrdenacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelicules)).EndInit();
            this.toolStripBackOption.ResumeLayout(false);
            this.toolStripBackOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPreguntes;
        private System.Windows.Forms.DataGridView dataGridViewPelicules;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTitul;
        private System.Windows.Forms.GroupBox groupBoxOpcionsFilOr;
        private System.Windows.Forms.GroupBox groupBoxOrdenacio;
        private System.Windows.Forms.RadioButton radioButtonDificultat;
        private System.Windows.Forms.RadioButton radioButtonCategoria;
        private System.Windows.Forms.GroupBox groupBoxModificacions;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.GroupBox groupBoxIdiomes;
        private System.Windows.Forms.RadioButton radioButtonEnglish;
        private System.Windows.Forms.RadioButton radioButtonCastellano;
        private System.Windows.Forms.RadioButton radioButtonCatala;
        private System.Windows.Forms.RadioButton radioButtonIdiomesTots;
        private System.Windows.Forms.ToolStrip toolStripBackOption;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
    }
}