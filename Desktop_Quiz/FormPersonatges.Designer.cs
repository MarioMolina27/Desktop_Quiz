namespace Desktop_Quiz
{
    partial class FormPersonatges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonatges));
            this.dataGridViewPersonatges = new System.Windows.Forms.DataGridView();
            this.buttonNouPersonatge = new System.Windows.Forms.Button();
            this.buttonEditarPersonatge = new System.Windows.Forms.Button();
            this.buttonEliminarPersonatge = new System.Windows.Forms.Button();
            this.labelBuscadorPersonatge = new System.Windows.Forms.Label();
            this.textBoxBuscadorPersonatges = new System.Windows.Forms.TextBox();
            this.toolStripButtonTornarEnrere = new System.Windows.Forms.ToolStripButton();
            this.groupBoxIdioma = new System.Windows.Forms.GroupBox();
            this.radioButtonAngles = new System.Windows.Forms.RadioButton();
            this.radioButtonCastella = new System.Windows.Forms.RadioButton();
            this.radioButtonCatala = new System.Windows.Forms.RadioButton();
            this.toolStripBackOption = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonatges)).BeginInit();
            this.groupBoxIdioma.SuspendLayout();
            this.toolStripBackOption.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPersonatges
            // 
            this.dataGridViewPersonatges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonatges.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewPersonatges.ColumnHeadersHeight = 29;
            this.dataGridViewPersonatges.Location = new System.Drawing.Point(455, 186);
            this.dataGridViewPersonatges.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPersonatges.MultiSelect = false;
            this.dataGridViewPersonatges.Name = "dataGridViewPersonatges";
            this.dataGridViewPersonatges.RowHeadersWidth = 51;
            this.dataGridViewPersonatges.Size = new System.Drawing.Size(1963, 1028);
            this.dataGridViewPersonatges.TabIndex = 0;
            // 
            // buttonNouPersonatge
            // 
            this.buttonNouPersonatge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNouPersonatge.Image = ((System.Drawing.Image)(resources.GetObject("buttonNouPersonatge.Image")));
            this.buttonNouPersonatge.Location = new System.Drawing.Point(21, 28);
            this.buttonNouPersonatge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNouPersonatge.Name = "buttonNouPersonatge";
            this.buttonNouPersonatge.Size = new System.Drawing.Size(192, 129);
            this.buttonNouPersonatge.TabIndex = 1;
            this.buttonNouPersonatge.UseVisualStyleBackColor = false;
            this.buttonNouPersonatge.Click += new System.EventHandler(this.buttonNouPersonatge_Click);
            // 
            // buttonEditarPersonatge
            // 
            this.buttonEditarPersonatge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEditarPersonatge.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarPersonatge.Image")));
            this.buttonEditarPersonatge.Location = new System.Drawing.Point(21, 165);
            this.buttonEditarPersonatge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditarPersonatge.Name = "buttonEditarPersonatge";
            this.buttonEditarPersonatge.Size = new System.Drawing.Size(92, 97);
            this.buttonEditarPersonatge.TabIndex = 2;
            this.buttonEditarPersonatge.UseVisualStyleBackColor = false;
            this.buttonEditarPersonatge.Click += new System.EventHandler(this.buttonEditarPersonatge_Click);
            // 
            // buttonEliminarPersonatge
            // 
            this.buttonEliminarPersonatge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminarPersonatge.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarPersonatge.Image")));
            this.buttonEliminarPersonatge.Location = new System.Drawing.Point(121, 165);
            this.buttonEliminarPersonatge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminarPersonatge.Name = "buttonEliminarPersonatge";
            this.buttonEliminarPersonatge.Size = new System.Drawing.Size(92, 97);
            this.buttonEliminarPersonatge.TabIndex = 3;
            this.buttonEliminarPersonatge.UseVisualStyleBackColor = false;
            this.buttonEliminarPersonatge.Click += new System.EventHandler(this.buttonEliminarPersonatge_Click_1);
            // 
            // labelBuscadorPersonatge
            // 
            this.labelBuscadorPersonatge.AutoSize = true;
            this.labelBuscadorPersonatge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscadorPersonatge.Location = new System.Drawing.Point(451, 142);
            this.labelBuscadorPersonatge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscadorPersonatge.Name = "labelBuscadorPersonatge";
            this.labelBuscadorPersonatge.Size = new System.Drawing.Size(117, 22);
            this.labelBuscadorPersonatge.TabIndex = 4;
            this.labelBuscadorPersonatge.Text = "Personatge";
            // 
            // textBoxBuscadorPersonatges
            // 
            this.textBoxBuscadorPersonatges.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscadorPersonatges.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBuscadorPersonatges.Location = new System.Drawing.Point(620, 138);
            this.textBoxBuscadorPersonatges.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuscadorPersonatges.Name = "textBoxBuscadorPersonatges";
            this.textBoxBuscadorPersonatges.Size = new System.Drawing.Size(616, 29);
            this.textBoxBuscadorPersonatges.TabIndex = 6;
            this.textBoxBuscadorPersonatges.Text = "  Buscar...";
            this.textBoxBuscadorPersonatges.Enter += new System.EventHandler(this.textBoxBuscadorPersonatges_Enter);
            this.textBoxBuscadorPersonatges.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscadorPersonatges_KeyDown);
            this.textBoxBuscadorPersonatges.Leave += new System.EventHandler(this.textBoxBuscadorPersonatges_Leave);
            // 
            // toolStripButtonTornarEnrere
            // 
            this.toolStripButtonTornarEnrere.Name = "toolStripButtonTornarEnrere";
            this.toolStripButtonTornarEnrere.Size = new System.Drawing.Size(23, 23);
            // 
            // groupBoxIdioma
            // 
            this.groupBoxIdioma.Controls.Add(this.radioButtonAngles);
            this.groupBoxIdioma.Controls.Add(this.radioButtonCastella);
            this.groupBoxIdioma.Controls.Add(this.radioButtonCatala);
            this.groupBoxIdioma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIdioma.Location = new System.Drawing.Point(35, 60);
            this.groupBoxIdioma.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxIdioma.Name = "groupBoxIdioma";
            this.groupBoxIdioma.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxIdioma.Size = new System.Drawing.Size(233, 154);
            this.groupBoxIdioma.TabIndex = 8;
            this.groupBoxIdioma.TabStop = false;
            this.groupBoxIdioma.Text = "Idioma";
            // 
            // radioButtonAngles
            // 
            this.radioButtonAngles.AutoSize = true;
            this.radioButtonAngles.Location = new System.Drawing.Point(51, 102);
            this.radioButtonAngles.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAngles.Name = "radioButtonAngles";
            this.radioButtonAngles.Size = new System.Drawing.Size(101, 26);
            this.radioButtonAngles.TabIndex = 2;
            this.radioButtonAngles.Text = "English";
            this.radioButtonAngles.UseVisualStyleBackColor = true;
            this.radioButtonAngles.CheckedChanged += new System.EventHandler(this.radioButtonAngles_CheckedChanged);
            // 
            // radioButtonCastella
            // 
            this.radioButtonCastella.AutoSize = true;
            this.radioButtonCastella.Location = new System.Drawing.Point(51, 73);
            this.radioButtonCastella.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCastella.Name = "radioButtonCastella";
            this.radioButtonCastella.Size = new System.Drawing.Size(129, 26);
            this.radioButtonCastella.TabIndex = 1;
            this.radioButtonCastella.Text = "Castellano";
            this.radioButtonCastella.UseVisualStyleBackColor = true;
            this.radioButtonCastella.CheckedChanged += new System.EventHandler(this.radioButtonCastella_CheckedChanged);
            // 
            // radioButtonCatala
            // 
            this.radioButtonCatala.AutoSize = true;
            this.radioButtonCatala.Checked = true;
            this.radioButtonCatala.Location = new System.Drawing.Point(51, 43);
            this.radioButtonCatala.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCatala.Name = "radioButtonCatala";
            this.radioButtonCatala.Size = new System.Drawing.Size(89, 26);
            this.radioButtonCatala.TabIndex = 0;
            this.radioButtonCatala.TabStop = true;
            this.radioButtonCatala.Text = "Català";
            this.radioButtonCatala.UseVisualStyleBackColor = true;
            this.radioButtonCatala.CheckedChanged += new System.EventHandler(this.radioButtonCatala_CheckedChanged);
            // 
            // toolStripBackOption
            // 
            this.toolStripBackOption.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripBackOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripBackOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack});
            this.toolStripBackOption.Location = new System.Drawing.Point(0, 0);
            this.toolStripBackOption.Name = "toolStripBackOption";
            this.toolStripBackOption.Size = new System.Drawing.Size(2404, 27);
            this.toolStripBackOption.TabIndex = 11;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBoxIdioma);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 186);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(305, 570);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNouPersonatge);
            this.groupBox2.Controls.Add(this.buttonEditarPersonatge);
            this.groupBox2.Controls.Add(this.buttonEliminarPersonatge);
            this.groupBox2.Location = new System.Drawing.Point(36, 239);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(233, 278);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // FormPersonatges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(2404, 1281);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripBackOption);
            this.Controls.Add(this.textBoxBuscadorPersonatges);
            this.Controls.Add(this.labelBuscadorPersonatge);
            this.Controls.Add(this.dataGridViewPersonatges);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPersonatges";
            this.Text = "FilmZ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPersonatges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonatges)).EndInit();
            this.groupBoxIdioma.ResumeLayout(false);
            this.groupBoxIdioma.PerformLayout();
            this.toolStripBackOption.ResumeLayout(false);
            this.toolStripBackOption.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonatges;
        private System.Windows.Forms.Button buttonNouPersonatge;
        private System.Windows.Forms.Button buttonEditarPersonatge;
        private System.Windows.Forms.Button buttonEliminarPersonatge;
        private System.Windows.Forms.Label labelBuscadorPersonatge;
        private System.Windows.Forms.TextBox textBoxBuscadorPersonatges;
        private System.Windows.Forms.ToolStripButton toolStripButtonTornarEnrere;
        private System.Windows.Forms.GroupBox groupBoxIdioma;
        private System.Windows.Forms.RadioButton radioButtonAngles;
        private System.Windows.Forms.RadioButton radioButtonCastella;
        private System.Windows.Forms.RadioButton radioButtonCatala;
        private System.Windows.Forms.ToolStrip toolStripBackOption;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}