﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    public partial class FormUsuaris : Form
    {
        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNickSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNickSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "  Buscar...")
            {
                textBoxNickSearch.ForeColor = Color.Black;
                textBoxNickSearch.Text = "";
            }
        }

        private void textBoxNickSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "")
            {
                textBoxNickSearch.ForeColor = Color.Gray;
                textBoxNickSearch.Text = "  Buscar...";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuaris_Load(object sender, EventArgs e)
        {

        }
    }
}
