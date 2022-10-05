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
            this.labelBuscadorEditPersonatge = new System.Windows.Forms.Label();
            this.textBoxBuscadorEditPersonatge = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuscadorEditPersonatge
            // 
            this.labelBuscadorEditPersonatge.AutoSize = true;
            this.labelBuscadorEditPersonatge.Location = new System.Drawing.Point(16, 34);
            this.labelBuscadorEditPersonatge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuscadorEditPersonatge.Name = "labelBuscadorEditPersonatge";
            this.labelBuscadorEditPersonatge.Size = new System.Drawing.Size(83, 17);
            this.labelBuscadorEditPersonatge.TabIndex = 0;
            this.labelBuscadorEditPersonatge.Text = "Personatge";
            // 
            // textBoxBuscadorEditPersonatge
            // 
            this.textBoxBuscadorEditPersonatge.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBuscadorEditPersonatge.Location = new System.Drawing.Point(124, 34);
            this.textBoxBuscadorEditPersonatge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBuscadorEditPersonatge.Name = "textBoxBuscadorEditPersonatge";
            this.textBoxBuscadorEditPersonatge.Size = new System.Drawing.Size(480, 25);
            this.textBoxBuscadorEditPersonatge.TabIndex = 1;
            this.textBoxBuscadorEditPersonatge.Text = "  Buscar...";
            this.textBoxBuscadorEditPersonatge.Enter += new System.EventHandler(this.textBoxBuscadorEditPersonatge_Enter);
            this.textBoxBuscadorEditPersonatge.Leave += new System.EventHandler(this.textBoxBuscadorEditPersonatge_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 110);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormEditPersonatges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxBuscadorEditPersonatge);
            this.Controls.Add(this.labelBuscadorEditPersonatge);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditPersonatges";
            this.Text = "FormEditPersonatges";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuscadorEditPersonatge;
        private System.Windows.Forms.TextBox textBoxBuscadorEditPersonatge;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}