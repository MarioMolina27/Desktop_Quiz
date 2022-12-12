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
    public partial class FormSAdimOpciones : Form
    {
        String nomSuperAdmin;
        public Usuari usuari { get; set; }
        public FormSAdimOpciones()
        {
            InitializeComponent();
        }
        public FormSAdimOpciones(Usuari u)
        {
            this.usuari = u;
            InitializeComponent();
        }
        public FormSAdimOpciones(String nomUser)
        {
            InitializeComponent();
            this.nomSuperAdmin = nomUser;
        }

        private void FormSAdimOpciones_Load(object sender, EventArgs e)
        {
            labelBenvinguda.Text = "Benvingut " + usuari.nom;
        }

        private void buttonUsuari_Click(object sender, EventArgs e)
        {
            FormUsuaris formUsuari = new FormUsuaris();
            formUsuari.ShowDialog();
        }

        private void buttonPersonatges_Click(object sender, EventArgs e)
        {
            FormPersonatges formPersonatges= new FormPersonatges(this.usuari);
            formPersonatges.ShowDialog();
        }

        private void buttonPreguntes_Click(object sender, EventArgs e)
        {
            FormPreguntas formPreguntas = new FormPreguntas(this.usuari);
            formPreguntas.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInici = new FormInicioSesion();
            formInici.ShowDialog();
        }
    }
}
