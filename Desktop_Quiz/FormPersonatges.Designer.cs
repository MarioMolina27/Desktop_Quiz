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
            this.buttonGuardarPersonatge = new System.Windows.Forms.Button();
            this.buttonEliminarPersonatge = new System.Windows.Forms.Button();
            this.buttonEditarPersonatge = new System.Windows.Forms.Button();
            this.buttonAfegirPersonatge = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonTornar = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewPesonatge = new System.Windows.Forms.DataGridView();
            this.textBoxBuscadorPersonatge = new System.Windows.Forms.TextBox();
            this.labelBuscadorPersonatge = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesonatge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardarPersonatge
            // 
            this.buttonGuardarPersonatge.Location = new System.Drawing.Point(1812, 27);
            this.buttonGuardarPersonatge.Name = "buttonGuardarPersonatge";
            this.buttonGuardarPersonatge.Size = new System.Drawing.Size(80, 80);
            this.buttonGuardarPersonatge.TabIndex = 15;
            this.buttonGuardarPersonatge.Text = "button4";
            this.buttonGuardarPersonatge.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarPersonatge
            // 
            this.buttonEliminarPersonatge.Location = new System.Drawing.Point(114, 380);
            this.buttonEliminarPersonatge.Name = "buttonEliminarPersonatge";
            this.buttonEliminarPersonatge.Size = new System.Drawing.Size(69, 79);
            this.buttonEliminarPersonatge.TabIndex = 14;
            this.buttonEliminarPersonatge.Text = "button3";
            this.buttonEliminarPersonatge.UseVisualStyleBackColor = true;
            // 
            // buttonEditarPersonatge
            // 
            this.buttonEditarPersonatge.Location = new System.Drawing.Point(39, 380);
            this.buttonEditarPersonatge.Name = "buttonEditarPersonatge";
            this.buttonEditarPersonatge.Size = new System.Drawing.Size(69, 79);
            this.buttonEditarPersonatge.TabIndex = 13;
            this.buttonEditarPersonatge.Text = "button2";
            this.buttonEditarPersonatge.UseVisualStyleBackColor = true;
            // 
            // buttonAfegirPersonatge
            // 
            this.buttonAfegirPersonatge.Location = new System.Drawing.Point(39, 269);
            this.buttonAfegirPersonatge.Name = "buttonAfegirPersonatge";
            this.buttonAfegirPersonatge.Size = new System.Drawing.Size(144, 105);
            this.buttonAfegirPersonatge.TabIndex = 12;
            this.buttonAfegirPersonatge.Text = "button1";
            this.buttonAfegirPersonatge.UseVisualStyleBackColor = true;
            this.buttonAfegirPersonatge.Click += new System.EventHandler(this.buttonAfegirPersonatge_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonTornar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonTornar
            // 
            this.toolStripButtonTornar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTornar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTornar.Image")));
            this.toolStripButtonTornar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTornar.Name = "toolStripButtonTornar";
            this.toolStripButtonTornar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTornar.Text = "toolStripButton1";
            this.toolStripButtonTornar.Click += new System.EventHandler(this.toolStripButtonTornar_Click);
            // 
            // dataGridViewPesonatge
            // 
            this.dataGridViewPesonatge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesonatge.Location = new System.Drawing.Point(248, 143);
            this.dataGridViewPesonatge.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPesonatge.Name = "dataGridViewPesonatge";
            this.dataGridViewPesonatge.Size = new System.Drawing.Size(1643, 883);
            this.dataGridViewPesonatge.TabIndex = 10;
            // 
            // textBoxBuscadorPersonatge
            // 
            this.textBoxBuscadorPersonatge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscadorPersonatge.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBuscadorPersonatge.Location = new System.Drawing.Point(390, 101);
            this.textBoxBuscadorPersonatge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuscadorPersonatge.Name = "textBoxBuscadorPersonatge";
            this.textBoxBuscadorPersonatge.Size = new System.Drawing.Size(838, 25);
            this.textBoxBuscadorPersonatge.TabIndex = 9;
            this.textBoxBuscadorPersonatge.Text = "  Buscar...";
            this.textBoxBuscadorPersonatge.Enter += new System.EventHandler(this.textBoxBuscadorPersonatge_Enter);
            this.textBoxBuscadorPersonatge.Leave += new System.EventHandler(this.textBoxBuscadorPersonatge_Leave);
            // 
            // labelBuscadorPersonatge
            // 
            this.labelBuscadorPersonatge.AutoSize = true;
            this.labelBuscadorPersonatge.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscadorPersonatge.Location = new System.Drawing.Point(245, 104);
            this.labelBuscadorPersonatge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscadorPersonatge.Name = "labelBuscadorPersonatge";
            this.labelBuscadorPersonatge.Size = new System.Drawing.Size(83, 17);
            this.labelBuscadorPersonatge.TabIndex = 8;
            this.labelBuscadorPersonatge.Text = "Personatge";
            // 
            // FormPersonatges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.buttonGuardarPersonatge);
            this.Controls.Add(this.buttonEliminarPersonatge);
            this.Controls.Add(this.buttonEditarPersonatge);
            this.Controls.Add(this.buttonAfegirPersonatge);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewPesonatge);
            this.Controls.Add(this.textBoxBuscadorPersonatge);
            this.Controls.Add(this.labelBuscadorPersonatge);
            this.Name = "FormPersonatges";
            this.Text = "FormPersonatges";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesonatge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardarPersonatge;
        private System.Windows.Forms.Button buttonEliminarPersonatge;
        private System.Windows.Forms.Button buttonEditarPersonatge;
        private System.Windows.Forms.Button buttonAfegirPersonatge;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTornar;
        private System.Windows.Forms.DataGridView dataGridViewPesonatge;
        private System.Windows.Forms.TextBox textBoxBuscadorPersonatge;
        private System.Windows.Forms.Label labelBuscadorPersonatge;
    }
}