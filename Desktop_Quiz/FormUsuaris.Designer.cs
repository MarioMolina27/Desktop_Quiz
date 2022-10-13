namespace Desktop_Quiz
{
    partial class FormUsuaris
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
            this.components = new System.ComponentModel.Container();
<<<<<<< Updated upstream
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuaris));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridUsuaris1 = new System.Windows.Forms.DataGridView();
            this.labelSearchNickname = new System.Windows.Forms.Label();
            this.textBoxNickSearch = new System.Windows.Forms.TextBox();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuaris1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridUsuaris1
            // 
            this.dataGridUsuaris1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuaris1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridUsuaris1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuaris1.Location = new System.Drawing.Point(246, 153);
            this.dataGridUsuaris1.Name = "dataGridUsuaris1";
            this.dataGridUsuaris1.Size = new System.Drawing.Size(1614, 827);
            this.dataGridUsuaris1.TabIndex = 2;
            // 
            // labelSearchNickname
            // 
            this.labelSearchNickname.AutoSize = true;
            this.labelSearchNickname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchNickname.Location = new System.Drawing.Point(237, 104);
            this.labelSearchNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchNickname.Name = "labelSearchNickname";
            this.labelSearchNickname.Size = new System.Drawing.Size(91, 19);
            this.labelSearchNickname.TabIndex = 0;
            this.labelSearchNickname.Text = "Nickname:";
            // 
            // textBoxNickSearch
            // 
            this.textBoxNickSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNickSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNickSearch.Location = new System.Drawing.Point(333, 102);
            this.textBoxNickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNickSearch.Name = "textBoxNickSearch";
            this.textBoxNickSearch.Size = new System.Drawing.Size(358, 25);
            this.textBoxNickSearch.TabIndex = 1;
            this.textBoxNickSearch.Text = "  Buscar...";
            this.textBoxNickSearch.Enter += new System.EventHandler(this.textBoxNickSearch_Enter);
            this.textBoxNickSearch.Leave += new System.EventHandler(this.textBoxNickSearch_Leave);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAfegir.Image = ((System.Drawing.Image)(resources.GetObject("buttonAfegir.Image")));
            this.buttonAfegir.Location = new System.Drawing.Point(44, 173);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(144, 105);
            this.buttonAfegir.TabIndex = 3;
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
            this.buttonModificar.Location = new System.Drawing.Point(44, 284);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(69, 79);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(119, 284);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(69, 79);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.ForeColor = System.Drawing.Color.Cyan;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1767, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 87);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 25);
            this.toolStrip1.TabIndex = 7;
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
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.labelSearchNickname);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.textBoxNickSearch);
            this.Controls.Add(this.dataGridUsuaris1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUsuaris";
>>>>>>> Stashed changes
            this.Text = "FormUsuaris";
        }

        #endregion
<<<<<<< Updated upstream
=======

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridUsuaris1;
        private System.Windows.Forms.Label labelSearchNickname;
        private System.Windows.Forms.TextBox textBoxNickSearch;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
>>>>>>> Stashed changes
    }
}