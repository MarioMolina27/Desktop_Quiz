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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxBuscadorPersonatges = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonTornarEnrere = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonatges)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPersonatges
            // 
            this.dataGridViewPersonatges.AllowUserToAddRows = false;
            this.dataGridViewPersonatges.AllowUserToDeleteRows = false;
            this.dataGridViewPersonatges.AllowUserToResizeColumns = false;
            this.dataGridViewPersonatges.AllowUserToResizeRows = false;
            this.dataGridViewPersonatges.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewPersonatges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonatges.Location = new System.Drawing.Point(246, 151);
            this.dataGridViewPersonatges.Name = "dataGridViewPersonatges";
            this.dataGridViewPersonatges.Size = new System.Drawing.Size(1646, 821);
            this.dataGridViewPersonatges.TabIndex = 0;
            // 
            // buttonNouPersonatge
            // 
            this.buttonNouPersonatge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNouPersonatge.Image = ((System.Drawing.Image)(resources.GetObject("buttonNouPersonatge.Image")));
            this.buttonNouPersonatge.Location = new System.Drawing.Point(34, 282);
            this.buttonNouPersonatge.Name = "buttonNouPersonatge";
            this.buttonNouPersonatge.Size = new System.Drawing.Size(144, 105);
            this.buttonNouPersonatge.TabIndex = 1;
            this.buttonNouPersonatge.UseVisualStyleBackColor = false;
            this.buttonNouPersonatge.Click += new System.EventHandler(this.buttonNouPersonatge_Click);
            // 
            // buttonEditarPersonatge
            // 
            this.buttonEditarPersonatge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEditarPersonatge.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarPersonatge.Image")));
            this.buttonEditarPersonatge.Location = new System.Drawing.Point(34, 393);
            this.buttonEditarPersonatge.Name = "buttonEditarPersonatge";
            this.buttonEditarPersonatge.Size = new System.Drawing.Size(69, 79);
            this.buttonEditarPersonatge.TabIndex = 2;
            this.buttonEditarPersonatge.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarPersonatge
            // 
            this.buttonEliminarPersonatge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminarPersonatge.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarPersonatge.Image")));
            this.buttonEliminarPersonatge.Location = new System.Drawing.Point(109, 393);
            this.buttonEliminarPersonatge.Name = "buttonEliminarPersonatge";
            this.buttonEliminarPersonatge.Size = new System.Drawing.Size(69, 79);
            this.buttonEliminarPersonatge.TabIndex = 3;
            this.buttonEliminarPersonatge.UseVisualStyleBackColor = false;
            // 
            // labelBuscadorPersonatge
            // 
            this.labelBuscadorPersonatge.AutoSize = true;
            this.labelBuscadorPersonatge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscadorPersonatge.Location = new System.Drawing.Point(243, 115);
            this.labelBuscadorPersonatge.Name = "labelBuscadorPersonatge";
            this.labelBuscadorPersonatge.Size = new System.Drawing.Size(83, 17);
            this.labelBuscadorPersonatge.TabIndex = 4;
            this.labelBuscadorPersonatge.Text = "Personatge";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.Location = new System.Drawing.Point(1785, 45);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(93, 87);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscadorPersonatges
            // 
            this.textBoxBuscadorPersonatges.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscadorPersonatges.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBuscadorPersonatges.Location = new System.Drawing.Point(377, 112);
            this.textBoxBuscadorPersonatges.Name = "textBoxBuscadorPersonatges";
            this.textBoxBuscadorPersonatges.Size = new System.Drawing.Size(463, 25);
            this.textBoxBuscadorPersonatges.TabIndex = 6;
            this.textBoxBuscadorPersonatges.Text = "  Buscar...";
            this.textBoxBuscadorPersonatges.Enter += new System.EventHandler(this.textBoxBuscadorPersonatges_Enter);
            this.textBoxBuscadorPersonatges.Leave += new System.EventHandler(this.textBoxBuscadorPersonatges_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTornarEnrere});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonTornarEnrere
            // 
            this.toolStripButtonTornarEnrere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTornarEnrere.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTornarEnrere.Image")));
            this.toolStripButtonTornarEnrere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTornarEnrere.Name = "toolStripButtonTornarEnrere";
            this.toolStripButtonTornarEnrere.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTornarEnrere.Text = "Tornar";
            this.toolStripButtonTornarEnrere.ToolTipText = "Tornar";
            this.toolStripButtonTornarEnrere.Click += new System.EventHandler(this.toolStripButtonTornarEnrere_Click);
            // 
            // FormPersonatges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxBuscadorPersonatges);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelBuscadorPersonatge);
            this.Controls.Add(this.buttonEliminarPersonatge);
            this.Controls.Add(this.buttonEditarPersonatge);
            this.Controls.Add(this.buttonNouPersonatge);
            this.Controls.Add(this.dataGridViewPersonatges);
            this.Name = "FormPersonatges";
            this.Text = "FormPersonatges";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonatges)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNouPersonatge;
        private System.Windows.Forms.Button buttonEditarPersonatge;
        private System.Windows.Forms.Button buttonEliminarPersonatge;
        private System.Windows.Forms.Label labelBuscadorPersonatge;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxBuscadorPersonatges;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTornarEnrere;
        private System.Windows.Forms.DataGridView dataGridViewPersonatges;
    }
}