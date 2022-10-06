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

        private void textBoxBuscadorPersonatge_Enter(object sender, EventArgs e)
        {
        
                if (textBoxBuscadorPersonatge.Text.Equals("  Buscar..."))
                {
                    textBoxBuscadorPersonatge.Text = "";
                    textBoxBuscadorPersonatge.ForeColor = Color.Black;
                }
            
        }

        private void textBoxBuscadorPersonatge_Leave(object sender, EventArgs e)
        {

                if (textBoxBuscadorPersonatge.Text.Equals(""))
                {
                    textBoxBuscadorPersonatge.Text = "  Buscar...";
                    textBoxBuscadorPersonatge.ForeColor = Color.Gray;
                }
        }

        private void buttonAfegirPersonatge_Click(object sender, EventArgs e)
        {
            FormEditPersonatges afegirPersonatges = new FormEditPersonatges();
            afegirPersonatges.ShowDialog();
        }

        private void toolStripButtonTornar_Click(object sender, EventArgs e)
        {
            FormSAdimOpciones supAdOpcions = new FormSAdimOpciones();
            supAdOpcions.ShowDialog();
            this.Close();
        }
    }
}
