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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxPreguntes = new System.Windows.Forms.GroupBox();
            this.groupBoxOpcionsFilOr = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.groupBoxOrdenacio = new System.Windows.Forms.GroupBox();
            this.radioButtonDificultat = new System.Windows.Forms.RadioButton();
            this.radioButtonCategoria = new System.Windows.Forms.RadioButton();
            this.labelOrdenacio = new System.Windows.Forms.Label();
            this.dataGridViewPelicules = new System.Windows.Forms.DataGridView();
            this.buttonAcceptarTitul = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTitul = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBoxPreguntes.SuspendLayout();
            this.groupBoxOpcionsFilOr.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBoxPreguntes.Controls.Add(this.groupBoxOpcionsFilOr);
            this.groupBoxPreguntes.Controls.Add(this.dataGridViewPelicules);
            this.groupBoxPreguntes.Controls.Add(this.buttonAcceptarTitul);
            this.groupBoxPreguntes.Controls.Add(this.textBoxTitulo);
            this.groupBoxPreguntes.Controls.Add(this.labelTitul);
            this.groupBoxPreguntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPreguntes.Location = new System.Drawing.Point(0, 31);
            this.groupBoxPreguntes.Name = "groupBoxPreguntes";
            this.groupBoxPreguntes.Size = new System.Drawing.Size(1904, 1010);
            this.groupBoxPreguntes.TabIndex = 2;
            this.groupBoxPreguntes.TabStop = false;
            this.groupBoxPreguntes.Text = "Preguntes";
            // 
            // groupBoxOpcionsFilOr
            // 
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBox1);
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBoxOrdenacio);
            this.groupBoxOpcionsFilOr.Controls.Add(this.labelOrdenacio);
            this.groupBoxOpcionsFilOr.Location = new System.Drawing.Point(36, 136);
            this.groupBoxOpcionsFilOr.Name = "groupBoxOpcionsFilOr";
            this.groupBoxOpcionsFilOr.Size = new System.Drawing.Size(241, 835);
            this.groupBoxOpcionsFilOr.TabIndex = 4;
            this.groupBoxOpcionsFilOr.TabStop = false;
            this.groupBoxOpcionsFilOr.Text = "Opcions";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonEditar);
            this.groupBox1.Controls.Add(this.buttonAfegir);
            this.groupBox1.Location = new System.Drawing.Point(21, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(104, 107);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(73, 65);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(25, 107);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(73, 65);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Location = new System.Drawing.Point(25, 36);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(152, 65);
            this.buttonAfegir.TabIndex = 0;
            this.buttonAfegir.Text = "Afegir";
            this.buttonAfegir.UseVisualStyleBackColor = true;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // groupBoxOrdenacio
            // 
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonDificultat);
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonCategoria);
            this.groupBoxOrdenacio.Location = new System.Drawing.Point(59, 121);
            this.groupBoxOrdenacio.Name = "groupBoxOrdenacio";
            this.groupBoxOrdenacio.Size = new System.Drawing.Size(143, 100);
            this.groupBoxOrdenacio.TabIndex = 1;
            this.groupBoxOrdenacio.TabStop = false;
            // 
            // radioButtonDificultat
            // 
            this.radioButtonDificultat.AutoSize = true;
            this.radioButtonDificultat.Location = new System.Drawing.Point(31, 66);
            this.radioButtonDificultat.Name = "radioButtonDificultat";
            this.radioButtonDificultat.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDificultat.TabIndex = 1;
            this.radioButtonDificultat.TabStop = true;
            this.radioButtonDificultat.Text = "Dificultad";
            this.radioButtonDificultat.UseVisualStyleBackColor = true;
            // 
            // radioButtonCategoria
            // 
            this.radioButtonCategoria.AutoSize = true;
            this.radioButtonCategoria.Location = new System.Drawing.Point(31, 31);
            this.radioButtonCategoria.Name = "radioButtonCategoria";
            this.radioButtonCategoria.Size = new System.Drawing.Size(72, 17);
            this.radioButtonCategoria.TabIndex = 0;
            this.radioButtonCategoria.TabStop = true;
            this.radioButtonCategoria.Text = "Categoría";
            this.radioButtonCategoria.UseVisualStyleBackColor = true;
            // 
            // labelOrdenacio
            // 
            this.labelOrdenacio.AutoSize = true;
            this.labelOrdenacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenacio.Location = new System.Drawing.Point(43, 79);
            this.labelOrdenacio.Name = "labelOrdenacio";
            this.labelOrdenacio.Size = new System.Drawing.Size(78, 13);
            this.labelOrdenacio.TabIndex = 0;
            this.labelOrdenacio.Text = "Ordenar per:";
            // 
            // dataGridViewPelicules
            // 
            this.dataGridViewPelicules.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewPelicules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPelicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelicules.Location = new System.Drawing.Point(332, 136);
            this.dataGridViewPelicules.Name = "dataGridViewPelicules";
            this.dataGridViewPelicules.RowHeadersWidth = 62;
            this.dataGridViewPelicules.Size = new System.Drawing.Size(1472, 835);
            this.dataGridViewPelicules.TabIndex = 3;
            // 
            // buttonAcceptarTitul
            // 
            this.buttonAcceptarTitul.Location = new System.Drawing.Point(749, 90);
            this.buttonAcceptarTitul.Name = "buttonAcceptarTitul";
            this.buttonAcceptarTitul.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptarTitul.TabIndex = 2;
            this.buttonAcceptarTitul.Text = "Aceptar";
            this.buttonAcceptarTitul.UseVisualStyleBackColor = true;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(332, 92);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(394, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // labelTitul
            // 
            this.labelTitul.AutoSize = true;
            this.labelTitul.Location = new System.Drawing.Point(267, 95);
            this.labelTitul.Name = "labelTitul";
            this.labelTitul.Size = new System.Drawing.Size(29, 13);
            this.labelTitul.TabIndex = 0;
            this.labelTitul.Text = "Títul";
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBoxPreguntes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormPreguntas";
            this.Text = "FormPreguntas";
            this.Load += new System.EventHandler(this.FormPreguntas_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxPreguntes.ResumeLayout(false);
            this.groupBoxPreguntes.PerformLayout();
            this.groupBoxOpcionsFilOr.ResumeLayout(false);
            this.groupBoxOpcionsFilOr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonAcceptarTitul;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTitul;
        private System.Windows.Forms.GroupBox groupBoxOpcionsFilOr;
        private System.Windows.Forms.GroupBox groupBoxOrdenacio;
        private System.Windows.Forms.RadioButton radioButtonDificultat;
        private System.Windows.Forms.RadioButton radioButtonCategoria;
        private System.Windows.Forms.Label labelOrdenacio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}