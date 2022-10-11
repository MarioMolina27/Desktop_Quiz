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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2856, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBoxPreguntes
            // 
            this.groupBoxPreguntes.Controls.Add(this.groupBoxOpcionsFilOr);
            this.groupBoxPreguntes.Controls.Add(this.dataGridViewPelicules);
            this.groupBoxPreguntes.Controls.Add(this.buttonAcceptarTitul);
            this.groupBoxPreguntes.Controls.Add(this.textBoxTitulo);
            this.groupBoxPreguntes.Controls.Add(this.labelTitul);
            this.groupBoxPreguntes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPreguntes.Location = new System.Drawing.Point(0, 33);
            this.groupBoxPreguntes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPreguntes.Name = "groupBoxPreguntes";
            this.groupBoxPreguntes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPreguntes.Size = new System.Drawing.Size(2856, 1557);
            this.groupBoxPreguntes.TabIndex = 2;
            this.groupBoxPreguntes.TabStop = false;
            this.groupBoxPreguntes.Text = "Preguntes";
            // 
            // groupBoxOpcionsFilOr
            // 
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBox1);
            this.groupBoxOpcionsFilOr.Controls.Add(this.groupBoxOrdenacio);
            this.groupBoxOpcionsFilOr.Controls.Add(this.labelOrdenacio);
            this.groupBoxOpcionsFilOr.Location = new System.Drawing.Point(54, 209);
            this.groupBoxOpcionsFilOr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOpcionsFilOr.Name = "groupBoxOpcionsFilOr";
            this.groupBoxOpcionsFilOr.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOpcionsFilOr.Size = new System.Drawing.Size(362, 1285);
            this.groupBoxOpcionsFilOr.TabIndex = 4;
            this.groupBoxOpcionsFilOr.TabStop = false;
            this.groupBoxOpcionsFilOr.Text = "Opcions";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonEditar);
            this.groupBox1.Controls.Add(this.buttonAfegir);
            this.groupBox1.Location = new System.Drawing.Point(32, 491);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(156, 165);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(110, 100);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(38, 165);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(110, 100);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.Location = new System.Drawing.Point(38, 55);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(228, 100);
            this.buttonAfegir.TabIndex = 0;
            this.buttonAfegir.Text = "Afegir";
            this.buttonAfegir.UseVisualStyleBackColor = true;
            // 
            // groupBoxOrdenacio
            // 
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonDificultat);
            this.groupBoxOrdenacio.Controls.Add(this.radioButtonCategoria);
            this.groupBoxOrdenacio.Location = new System.Drawing.Point(88, 186);
            this.groupBoxOrdenacio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOrdenacio.Name = "groupBoxOrdenacio";
            this.groupBoxOrdenacio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxOrdenacio.Size = new System.Drawing.Size(214, 154);
            this.groupBoxOrdenacio.TabIndex = 1;
            this.groupBoxOrdenacio.TabStop = false;
            // 
            // radioButtonDificultat
            // 
            this.radioButtonDificultat.AutoSize = true;
            this.radioButtonDificultat.Location = new System.Drawing.Point(46, 102);
            this.radioButtonDificultat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonDificultat.Name = "radioButtonDificultat";
            this.radioButtonDificultat.Size = new System.Drawing.Size(100, 24);
            this.radioButtonDificultat.TabIndex = 1;
            this.radioButtonDificultat.TabStop = true;
            this.radioButtonDificultat.Text = "Dificultad";
            this.radioButtonDificultat.UseVisualStyleBackColor = true;
            // 
            // radioButtonCategoria
            // 
            this.radioButtonCategoria.AutoSize = true;
            this.radioButtonCategoria.Location = new System.Drawing.Point(46, 48);
            this.radioButtonCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCategoria.Name = "radioButtonCategoria";
            this.radioButtonCategoria.Size = new System.Drawing.Size(103, 24);
            this.radioButtonCategoria.TabIndex = 0;
            this.radioButtonCategoria.TabStop = true;
            this.radioButtonCategoria.Text = "Categoría";
            this.radioButtonCategoria.UseVisualStyleBackColor = true;
            // 
            // labelOrdenacio
            // 
            this.labelOrdenacio.AutoSize = true;
            this.labelOrdenacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenacio.Location = new System.Drawing.Point(64, 122);
            this.labelOrdenacio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrdenacio.Name = "labelOrdenacio";
            this.labelOrdenacio.Size = new System.Drawing.Size(116, 20);
            this.labelOrdenacio.TabIndex = 0;
            this.labelOrdenacio.Text = "Ordenar per:";
            // 
            // dataGridViewPelicules
            // 
            this.dataGridViewPelicules.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewPelicules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPelicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPelicules.Location = new System.Drawing.Point(498, 209);
            this.dataGridViewPelicules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPelicules.Name = "dataGridViewPelicules";
            this.dataGridViewPelicules.RowHeadersWidth = 62;
            this.dataGridViewPelicules.Size = new System.Drawing.Size(2208, 1285);
            this.dataGridViewPelicules.TabIndex = 3;
            // 
            // buttonAcceptarTitul
            // 
            this.buttonAcceptarTitul.Location = new System.Drawing.Point(1124, 138);
            this.buttonAcceptarTitul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAcceptarTitul.Name = "buttonAcceptarTitul";
            this.buttonAcceptarTitul.Size = new System.Drawing.Size(112, 35);
            this.buttonAcceptarTitul.TabIndex = 2;
            this.buttonAcceptarTitul.Text = "Aceptar";
            this.buttonAcceptarTitul.UseVisualStyleBackColor = true;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(498, 142);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(589, 26);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // labelTitul
            // 
            this.labelTitul.AutoSize = true;
            this.labelTitul.Location = new System.Drawing.Point(400, 146);
            this.labelTitul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitul.Name = "labelTitul";
            this.labelTitul.Size = new System.Drawing.Size(38, 20);
            this.labelTitul.TabIndex = 0;
            this.labelTitul.Text = "Títul";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2856, 1590);
            this.Controls.Add(this.groupBoxPreguntes);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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