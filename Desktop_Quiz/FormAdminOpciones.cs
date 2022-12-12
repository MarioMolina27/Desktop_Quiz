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
        String nomAdmin;
        public Usuari usuari { get; set; }
        public FormAdminOpciones()
        {
            InitializeComponent();
        }
        public FormAdminOpciones(Usuari u)
        {
            this.usuari = u;
            InitializeComponent();
        }
        public FormAdminOpciones(String nomUser)
        {
            InitializeComponent();
            this.nomAdmin = nomUser;
        }

        private void FormAdminOpciones_Load(object sender, EventArgs e)
        {
            labelNom.Text = nomAdmin;
            labelBenvinguda.Text = "Benvingut " + usuari.nom;
        }

        private void buttonPersonatges_Click(object sender, EventArgs e)
        {
            FormPersonatges formPersonatge = new FormPersonatges(this.usuari);
            formPersonatge.ShowDialog();
        }

        private void buttonPreguntes_Click(object sender, EventArgs e)
        {
            FormPreguntas formPreguntes = new FormPreguntas(this.usuari);
            formPreguntes.ShowDialog();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInici = new FormInicioSesion();
            formInici.ShowDialog();
        }

        private void toolStripButtonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas seguro que quieres cerrar sesión?", "LOG OUT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                this.Close();
                FormInicioSesion formInici = new FormInicioSesion();
                formInici.ShowDialog();
            }
        }
    }
}
