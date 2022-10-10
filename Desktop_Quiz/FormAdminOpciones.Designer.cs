namespace Desktop_Quiz
{
    partial class FormAdminOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminOpciones));
            this.buttonPreguntes = new System.Windows.Forms.Button();
            this.buttonPersonatges = new System.Windows.Forms.Button();
            this.labelNomSAdmin = new System.Windows.Forms.Label();
            this.labelBenvinguda = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.toolStripBackOption = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.toolStripBackOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPreguntes
            // 
            this.buttonPreguntes.BackColor = System.Drawing.Color.Black;
            this.buttonPreguntes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPreguntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreguntes.ForeColor = System.Drawing.Color.White;
            this.buttonPreguntes.Location = new System.Drawing.Point(1096, 667);
            this.buttonPreguntes.Name = "buttonPreguntes";
            this.buttonPreguntes.Size = new System.Drawing.Size(193, 69);
            this.buttonPreguntes.TabIndex = 15;
            this.buttonPreguntes.Text = "Preguntes";
            this.buttonPreguntes.UseVisualStyleBackColor = false;
            this.buttonPreguntes.Click += new System.EventHandler(this.buttonPreguntes_Click);
            // 
            // buttonPersonatges
            // 
            this.buttonPersonatges.BackColor = System.Drawing.Color.Black;
            this.buttonPersonatges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPersonatges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonatges.ForeColor = System.Drawing.Color.White;
            this.buttonPersonatges.Location = new System.Drawing.Point(618, 667);
            this.buttonPersonatges.Name = "buttonPersonatges";
            this.buttonPersonatges.Size = new System.Drawing.Size(193, 69);
            this.buttonPersonatges.TabIndex = 14;
            this.buttonPersonatges.Text = "Personatges";
            this.buttonPersonatges.UseVisualStyleBackColor = false;
            this.buttonPersonatges.Click += new System.EventHandler(this.buttonPersonatges_Click);
            // 
            // labelNomSAdmin
            // 
            this.labelNomSAdmin.AutoSize = true;
            this.labelNomSAdmin.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomSAdmin.Location = new System.Drawing.Point(922, 563);
            this.labelNomSAdmin.Name = "labelNomSAdmin";
            this.labelNomSAdmin.Size = new System.Drawing.Size(91, 30);
            this.labelNomSAdmin.TabIndex = 13;
            this.labelNomSAdmin.Text = "ADMIN";
            this.labelNomSAdmin.TextChanged += new System.EventHandler(this.labelNomSAdmin_TextChanged);
            // 
            // labelBenvinguda
            // 
            this.labelBenvinguda.AutoSize = true;
            this.labelBenvinguda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenvinguda.Location = new System.Drawing.Point(902, 525);
            this.labelBenvinguda.Name = "labelBenvinguda";
            this.labelBenvinguda.Size = new System.Drawing.Size(127, 24);
            this.labelBenvinguda.TabIndex = 11;
            this.labelBenvinguda.Text = "BENVINGUT";
            // 
            // toolStripBackOption
            // 
            this.toolStripBackOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack});
            this.toolStripBackOption.Location = new System.Drawing.Point(0, 0);
            this.toolStripBackOption.Name = "toolStripBackOption";
            this.toolStripBackOption.Size = new System.Drawing.Size(1904, 25);
            this.toolStripBackOption.TabIndex = 16;
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBack.Text = "BACK";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // FormAdminOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.toolStripBackOption);
            this.Controls.Add(this.buttonPreguntes);
            this.Controls.Add(this.buttonPersonatges);
            this.Controls.Add(this.labelNomSAdmin);
            this.Controls.Add(this.labelBenvinguda);
            this.Controls.Add(this.pictureBoxIcon);
            this.Name = "FormAdminOpciones";
            this.Text = "FormAdminOpciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.toolStripBackOption.ResumeLayout(false);
            this.toolStripBackOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreguntes;
        private System.Windows.Forms.Button buttonPersonatges;
        private System.Windows.Forms.Label labelNomSAdmin;
        private System.Windows.Forms.Label labelBenvinguda;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.ToolStrip toolStripBackOption;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
    }
}