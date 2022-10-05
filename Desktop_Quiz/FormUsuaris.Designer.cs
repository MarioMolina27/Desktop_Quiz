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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSearchNickname = new System.Windows.Forms.Label();
            this.textBoxNickSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1614, 827);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelSearchNickname
            // 
            this.labelSearchNickname.AutoSize = true;
            this.labelSearchNickname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchNickname.Location = new System.Drawing.Point(243, 104);
            this.labelSearchNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchNickname.Name = "labelSearchNickname";
            this.labelSearchNickname.Size = new System.Drawing.Size(82, 18);
            this.labelSearchNickname.TabIndex = 0;
            this.labelSearchNickname.Text = "Nickname:";
            this.labelSearchNickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNickSearch
            // 
            this.textBoxNickSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNickSearch.Location = new System.Drawing.Point(333, 102);
            this.textBoxNickSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNickSearch.Name = "textBoxNickSearch";
            this.textBoxNickSearch.Size = new System.Drawing.Size(358, 25);
            this.textBoxNickSearch.TabIndex = 1;
            this.textBoxNickSearch.Text = "  Buscar...";
            this.textBoxNickSearch.TextChanged += new System.EventHandler(this.textBoxNickSearch_TextChanged);
            this.textBoxNickSearch.Enter += new System.EventHandler(this.textBoxNickSearch_Enter);
            this.textBoxNickSearch.Leave += new System.EventHandler(this.textBoxNickSearch_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 79);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(29, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FormUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSearchNickname);
            this.Controls.Add(this.textBoxNickSearch);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUsuaris";
            this.Text = "FormUsuaris";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSearchNickname;
        private System.Windows.Forms.TextBox textBoxNickSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}