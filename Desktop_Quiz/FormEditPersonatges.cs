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
    public partial class FormEditPersonatges : Form
    {
        public FormEditPersonatges()
        {
            InitializeComponent();
        }

        private void textBoxBuscadorEditPersonatge_Enter(object sender, EventArgs e)
        {
            if (textBoxBuscadorEditPersonatge.Text.Equals("  Buscar..."))
            {
                textBoxBuscadorEditPersonatge.Text = "";
                textBoxBuscadorEditPersonatge.ForeColor = Color.Black;
            }
        }

        private void textBoxBuscadorEditPersonatge_Leave(object sender, EventArgs e)
        {
            if (textBoxBuscadorEditPersonatge.Text.Equals(""))
            {
                textBoxBuscadorEditPersonatge.Text = "  Buscar...";
                textBoxBuscadorEditPersonatge.ForeColor= Color.Gray;
            }
        }
    }
}
