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
    public partial class FormAdminOpciones : Form
    {
        public FormAdminOpciones()
        {
            InitializeComponent();
        }

        private void buttonPersonatges_Click(object sender, EventArgs e)
        {
            FormPersonatges formPersonatge = new FormPersonatges();
            formPersonatge.ShowDialog();
        }

        private void buttonPreguntes_Click(object sender, EventArgs e)
        {
            FormPreguntas formPreguntes = new FormPreguntas();
            formPreguntes.ShowDialog();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInici = new FormInicioSesion();
            formInici.ShowDialog();
        }

        private void labelNomSAdmin_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
