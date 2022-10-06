namespace Desktop_Quiz
{
    partial class FormEditPersonatges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPersonatges));
            this.labelBuscadorEditPersonatge = new System.Windows.Forms.Label();
            this.textBoxBuscadorEditPersonatge = new System.Windows.Forms.TextBox();
            this.dataGridViewEditPesonatge = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.buttonAfegirEditPersonatge = new System.Windows.Forms.Button();
            this.buttonEditarEditPersonatge = new System.Windows.Forms.Button();
            this.buttonEliminarEditPersonatge = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditPesonatge)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBuscadorEditPersonatge
            // 
            this.labelBuscadorEditPersonatge.AutoSize = true;
            this.labelBuscadorEditPersonatge.Location = new System.Drawing.Point(75, 90);
            this.labelBuscadorEditPersonatge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscadorEditPersonatge.Name = "labelBuscadorEditPersonatge";
            this.labelBuscadorEditPersonatge.Size = new System.Drawing.Size(83, 17);
            this.labelBuscadorEditPersonatge.TabIndex = 0;
            this.labelBuscadorEditPersonatge.Text = "Personatge";
            // 
            // textBoxBuscadorEditPersonatge
            // 
            this.textBoxBuscadorEditPersonatge.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBuscadorEditPersonatge.Location = new System.Drawing.Point(248, 82);
            this.textBoxBuscadorEditPersonatge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuscadorEditPersonatge.Name = "textBoxBuscadorEditPersonatge";
            this.textBoxBuscadorEditPersonatge.Size = new System.Drawing.Size(480, 25);
            this.textBoxBuscadorEditPersonatge.TabIndex = 1;
            this.textBoxBuscadorEditPersonatge.Text = "  Buscar...";
            this.textBoxBuscadorEditPersonatge.Enter += new System.EventHandler(this.textBoxBuscadorEditPersonatge_Enter);
            this.textBoxBuscadorEditPersonatge.Leave += new System.EventHandler(this.textBoxBuscadorEditPersonatge_Leave);
            // 
            // dataGridViewEditPesonatge
            // 
            this.dataGridViewEditPesonatge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditPesonatge.Location = new System.Drawing.Point(248, 128);
            this.dataGridViewEditPesonatge.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEditPesonatge.Name = "dataGridViewEditPesonatge";
            this.dataGridViewEditPesonatge.Size = new System.Drawing.Size(1643, 883);
            this.dataGridViewEditPesonatge.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // buttonAfegirEditPersonatge
            // 
            this.buttonAfegirEditPersonatge.Location = new System.Drawing.Point(39, 254);
            this.buttonAfegirEditPersonatge.Name = "buttonAfegirEditPersonatge";
            this.buttonAfegirEditPersonatge.Size = new System.Drawing.Size(156, 125);
            this.buttonAfegirEditPersonatge.TabIndex = 4;
            this.buttonAfegirEditPersonatge.Text = "button1";
            this.buttonAfegirEditPersonatge.UseVisualStyleBackColor = true;
            // 
            // buttonEditarEditPersonatge
            // 
            this.buttonEditarEditPersonatge.Location = new System.Drawing.Point(39, 385);
            this.buttonEditarEditPersonatge.Name = "buttonEditarEditPersonatge";
            this.buttonEditarEditPersonatge.Size = new System.Drawing.Size(75, 75);
            this.buttonEditarEditPersonatge.TabIndex = 5;
            this.buttonEditarEditPersonatge.Text = "button2";
            this.buttonEditarEditPersonatge.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarEditPersonatge
            // 
            this.buttonEliminarEditPersonatge.Location = new System.Drawing.Point(120, 385);
            this.buttonEliminarEditPersonatge.Name = "buttonEliminarEditPersonatge";
            this.buttonEliminarEditPersonatge.Size = new System.Drawing.Size(75, 75);
            this.buttonEliminarEditPersonatge.TabIndex = 6;
            this.buttonEliminarEditPersonatge.Text = "button3";
            this.buttonEliminarEditPersonatge.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1812, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormEditPersonatges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonEliminarEditPersonatge);
            this.Controls.Add(this.buttonEditarEditPersonatge);
            this.Controls.Add(this.buttonAfegirEditPersonatge);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewEditPesonatge);
            this.Controls.Add(this.textBoxBuscadorEditPersonatge);
            this.Controls.Add(this.labelBuscadorEditPersonatge);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditPersonatges";
            this.Text = "FormEditPersonatges";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditPesonatge)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuscadorEditPersonatge;
        private System.Windows.Forms.TextBox textBoxBuscadorEditPersonatge;
        private System.Windows.Forms.DataGridView dataGridViewEditPesonatge;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button buttonAfegirEditPersonatge;
        private System.Windows.Forms.Button buttonEditarEditPersonatge;
        private System.Windows.Forms.Button buttonEliminarEditPersonatge;
        private System.Windows.Forms.Button button4;
    }
}