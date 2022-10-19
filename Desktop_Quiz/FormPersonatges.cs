using System;
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
    public partial class FormPersonatges : Form
    {
        public FormPersonatges()
        {
            InitializeComponent();
        }

        private void toolStripButtonTornarEnrere_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBuscadorPersonatges_Enter(object sender, EventArgs e)
        {
            if (textBoxBuscadorPersonatges.Text.Equals("  Buscar..."))
            {
                textBoxBuscadorPersonatges.Text = "";
                textBoxBuscadorPersonatges.ForeColor = Color.Black;
            }
        }

        private void textBoxBuscadorPersonatges_Leave(object sender, EventArgs e)
        {
            if (textBoxBuscadorPersonatges.Text.Equals(""))
            {
                textBoxBuscadorPersonatges.Text = "  Buscar...";
                textBoxBuscadorPersonatges.ForeColor = Color.Gray;
            }
        }

        private void buttonEliminarPersonatge_Click(object sender, EventArgs e)
        {

        }

        private void buttonNouPersonatge_Click(object sender, EventArgs e)
        {
            new FormEditPersonatges().ShowDialog();
        }

        private void textBoxBuscadorPersonatges_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
