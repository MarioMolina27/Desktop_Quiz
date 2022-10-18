﻿namespace Desktop_Quiz
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxPreguntes = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBoxOpcionsFilOr = new System.Windows.Forms.GroupBox();
            this.groupBoxModificacions = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.groupBoxOrdenacio = new System.Windows.Forms.GroupBox();
            this.radioButtonDificultat = new System.Windows.Forms.RadioButton();
            this.radioButtonCategoria = new System.Windows.Forms.RadioButton();
            this.labelOrdenacio = new System.Windows.Forms.Label();
            this.dataGridViewPelicules = new System.Windows.Forms.DataGridView();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTitul = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBoxPreguntes.SuspendLayout();
            this.groupBoxOpcionsFilOr.SuspendLayout();
            this.groupBoxModificacions.SuspendLayout();
            this.groupBoxOrdenacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelicules)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1904, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // groupBoxPreguntes
            // 
            this.groupBoxPreguntes.Controls.Add(this.buttonAceptar);
            this.groupBoxPreguntes.Controls.Add(this.groupBoxOpcionsFilOr);
            this.groupBoxPreguntes.Controls.Add(this.dataGridViewPelicules);
            this.groupBoxPreguntes.Controls.Add(this.textBoxTitulo);
            this.groupBoxPreguntes.Controls.Add(this.labelTitul);
            this.groupBoxPreguntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPreguntes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPreguntes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxPreguntes.Location = new System.Drawing.Point(0, 31);
            this.groupBoxPreguntes.Name = "groupBoxPreguntes";
            this.groupBoxPreguntes.Size = new System.Drawing.Size(1904, 1010);
            this.groupBoxPreguntes.TabIndex = 2;
            this.groupBoxPreguntes.TabStop = false;
            this.groupBoxPreguntes.Text = "Preguntes";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAceptar.Location = new System.Drawing.Point(744, 88);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(111, 32);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // groupBoxOpcionsFilOr
            // 
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBoxModificacions);
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBoxOrdenacio);
            this.groupBoxOpcionsFilOr.Controls.Add(this.labelOrdenacio);
            this.groupBoxOpcionsFilOr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxOpcionsFilOr.Location = new System.Drawing.Point(36, 136);
            this.groupBoxOpcionsFilOr.Name = "groupBoxOpcionsFilOr";
            this.groupBoxOpcionsFilOr.Size = new System.Drawing.Size(241, 835);
            this.groupBoxOpcionsFilOr.TabIndex = 4;
            this.groupBoxOpcionsFilOr.TabStop = false;
            this.groupBoxOpcionsFilOr.Text = "Opcions";
            // 
            // groupBoxModificacions
            // 
            this.groupBoxModificacions.Controls.Add(this.buttonEliminar);
            this.groupBoxModificacions.Controls.Add(this.buttonAfegir);
            this.groupBoxModificacions.Controls.Add(this.buttonModificar);
            this.groupBoxModificacions.Location = new System.Drawing.Point(21, 319);
            this.groupBoxModificacions.Name = "groupBoxModificacions";
            this.groupBoxModificacions.Size = new System.Drawing.Size(200, 243);
            this.groupBoxModificacions.TabIndex = 2;
            this.groupBoxModificacions.TabStop = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(100, 139);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(69, 79);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAfegir.Image = ((System.Drawing.Image)(resources.GetObject("buttonAfegir.Image")));
            this.buttonAfegir.Location = new System.Drawing.Point(25, 28);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(144, 105);
            this.buttonAfegir.TabIndex = 6;
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
            this.buttonModificar.Location = new System.Drawing.Point(25, 139);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(69, 79);
            this.buttonModificar.TabIndex = 7;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // groupBoxOrdenacio
            // 
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonDificultat);
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonCategoria);
            this.groupBoxOrdenacio.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBoxOrdenacio.Location = new System.Drawing.Point(59, 121);
            this.groupBoxOrdenacio.Name = "groupBoxOrdenacio";
            this.groupBoxOrdenacio.Size = new System.Drawing.Size(162, 113);
            this.groupBoxOrdenacio.TabIndex = 1;
            this.groupBoxOrdenacio.TabStop = false;
            // 
            // radioButtonDificultat
            // 
            this.radioButtonDificultat.AutoSize = true;
            this.radioButtonDificultat.Location = new System.Drawing.Point(31, 66);
            this.radioButtonDificultat.Name = "radioButtonDificultat";
            this.radioButtonDificultat.Size = new System.Drawing.Size(86, 24);
            this.radioButtonDificultat.TabIndex = 1;
            this.radioButtonDificultat.TabStop = true;
            this.radioButtonDificultat.Text = "Dificultad";
            this.radioButtonDificultat.UseVisualStyleBackColor = true;
            this.radioButtonDificultat.CheckedChanged += new System.EventHandler(this.radioButtonDificultat_CheckedChanged);
            // 
            // radioButtonCategoria
            // 
            this.radioButtonCategoria.AutoSize = true;
            this.radioButtonCategoria.Location = new System.Drawing.Point(31, 31);
            this.radioButtonCategoria.Name = "radioButtonCategoria";
            this.radioButtonCategoria.Size = new System.Drawing.Size(86, 24);
            this.radioButtonCategoria.TabIndex = 0;
            this.radioButtonCategoria.TabStop = true;
            this.radioButtonCategoria.Text = "Categoría";
            this.radioButtonCategoria.UseVisualStyleBackColor = true;
            this.radioButtonCategoria.CheckedChanged += new System.EventHandler(this.radioButtonCategoria_CheckedChanged);
            // 
            // labelOrdenacio
            // 
            this.labelOrdenacio.AutoSize = true;
            this.labelOrdenacio.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenacio.Location = new System.Drawing.Point(43, 79);
            this.labelOrdenacio.Name = "labelOrdenacio";
            this.labelOrdenacio.Size = new System.Drawing.Size(87, 20);
            this.labelOrdenacio.TabIndex = 0;
            this.labelOrdenacio.Text = "Ordenar per:";
            // 
            // dataGridViewPelicules
            // 
            this.dataGridViewPelicules.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewPelicules.AllowUserToOrderColumns = true;
            this.dataGridViewPelicules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPelicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelicules.Location = new System.Drawing.Point(332, 136);
            this.dataGridViewPelicules.Name = "dataGridViewPelicules";
            this.dataGridViewPelicules.RowHeadersWidth = 62;
            this.dataGridViewPelicules.Size = new System.Drawing.Size(1472, 835);
            this.dataGridViewPelicules.TabIndex = 3;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(332, 92);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(394, 26);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // labelTitul
            // 
            this.labelTitul.AutoSize = true;
            this.labelTitul.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitul.Location = new System.Drawing.Point(267, 95);
            this.labelTitul.Name = "labelTitul";
            this.labelTitul.Size = new System.Drawing.Size(42, 19);
            this.labelTitul.TabIndex = 0;
            this.labelTitul.Text = "Títul";
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBoxPreguntes);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FormPreguntas";
            this.Text = "FormPreguntas";
            this.Load += new System.EventHandler(this.FormPreguntas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxPreguntes.ResumeLayout(false);
            this.groupBoxPreguntes.PerformLayout();
            this.groupBoxOpcionsFilOr.ResumeLayout(false);
            this.groupBoxOpcionsFilOr.PerformLayout();
            this.groupBoxModificacions.ResumeLayout(false);
            this.groupBoxOrdenacio.ResumeLayout(false);
            this.groupBoxOrdenacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPelicules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBoxPreguntes;
        private System.Windows.Forms.DataGridView dataGridViewPelicules;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTitul;
        private System.Windows.Forms.GroupBox groupBoxOpcionsFilOr;
        private System.Windows.Forms.GroupBox groupBoxOrdenacio;
        private System.Windows.Forms.RadioButton radioButtonDificultat;
        private System.Windows.Forms.RadioButton radioButtonCategoria;
        private System.Windows.Forms.Label labelOrdenacio;
        private System.Windows.Forms.GroupBox groupBoxModificacions;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonAceptar;
    }
}