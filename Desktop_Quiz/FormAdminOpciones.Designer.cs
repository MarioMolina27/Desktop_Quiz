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
            this.labelBenvinguda = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.toolStripBackOption = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogOut = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxIconUser = new System.Windows.Forms.PictureBox();
            this.labelNom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.toolStripBackOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPreguntes
            // 
            this.buttonPreguntes.BackColor = System.Drawing.Color.Black;
            this.buttonPreguntes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPreguntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreguntes.ForeColor = System.Drawing.Color.White;
            this.buttonPreguntes.Location = new System.Drawing.Point(1082, 550);
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
            this.buttonPersonatges.Location = new System.Drawing.Point(604, 550);
            this.buttonPersonatges.Name = "buttonPersonatges";
            this.buttonPersonatges.Size = new System.Drawing.Size(193, 69);
            this.buttonPersonatges.TabIndex = 14;
            this.buttonPersonatges.Text = "Personatges";
            this.buttonPersonatges.UseVisualStyleBackColor = false;
            this.buttonPersonatges.Click += new System.EventHandler(this.buttonPersonatges_Click);
            // 
            // labelBenvinguda
            // 
            this.labelBenvinguda.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenvinguda.Location = new System.Drawing.Point(821, 400);
            this.labelBenvinguda.Name = "labelBenvinguda";
            this.labelBenvinguda.Size = new System.Drawing.Size(239, 24);
            this.labelBenvinguda.TabIndex = 11;
            this.labelBenvinguda.Text = "BENVINGUT";
            this.labelBenvinguda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxIcon.TabIndex = 17;
            this.pictureBoxIcon.TabStop = false;
            // 
            // toolStripBackOption
            // 
            this.toolStripBackOption.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripBackOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripButtonLogOut});
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
            // toolStripButtonLogOut
            // 
            this.toolStripButtonLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogOut.Image")));
            this.toolStripButtonLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogOut.Name = "toolStripButtonLogOut";
            this.toolStripButtonLogOut.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLogOut.Text = "LOG OUT";
            this.toolStripButtonLogOut.Click += new System.EventHandler(this.toolStripButtonLogOut_Click);
            // 
            // pictureBoxIconUser
            // 
            this.pictureBoxIconUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxIconUser.Image = global::Desktop_Quiz.Properties.Resources.loginImage;
            this.pictureBoxIconUser.Location = new System.Drawing.Point(821, 150);
            this.pictureBoxIconUser.Name = "pictureBoxIconUser";
            this.pictureBoxIconUser.Size = new System.Drawing.Size(239, 191);
            this.pictureBoxIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIconUser.TabIndex = 18;
            this.pictureBoxIconUser.TabStop = false;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(864, 427);
            this.labelNom.Name = "labelNom";
            this.labelNom.Padding = new System.Windows.Forms.Padding(75, 0, 75, 0);
            this.labelNom.Size = new System.Drawing.Size(150, 19);
            this.labelNom.TabIndex = 19;
            this.labelNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdminOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.pictureBoxIconUser);
            this.Controls.Add(this.toolStripBackOption);
            this.Controls.Add(this.buttonPreguntes);
            this.Controls.Add(this.buttonPersonatges);
            this.Controls.Add(this.labelBenvinguda);
            this.Controls.Add(this.pictureBoxIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminOpciones";
            this.Text = "FilmZ";
            this.Load += new System.EventHandler(this.FormAdminOpciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.toolStripBackOption.ResumeLayout(false);
            this.toolStripBackOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreguntes;
        private System.Windows.Forms.Button buttonPersonatges;
        private System.Windows.Forms.Label labelBenvinguda;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.ToolStrip toolStripBackOption;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.PictureBox pictureBoxIconUser;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogOut;
    }
}