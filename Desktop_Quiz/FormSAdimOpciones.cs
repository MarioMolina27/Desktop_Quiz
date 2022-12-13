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
    /**
     * public partial class FormSAdminOpciones : Form
     */
    public partial class FormSAdimOpciones : Form
    {
        String nomSuperAdmin;
        public Usuari usuari { get; set; }

        /**
        * Constructor default
        */
        public FormSAdimOpciones()
        {
            InitializeComponent();
        }

        /**
         * Constructor amb usuari passat des del Form Inici Sessió
         */
        public FormSAdimOpciones(Usuari u)
        {
            this.usuari = u;
            InitializeComponent();
        }

        /**
         * Constructor amb nom usuari passat des del Form Inici Sessió
         */
        public FormSAdimOpciones(String nomUser)
        {
            InitializeComponent();
            this.nomSuperAdmin = nomUser;
        }

        /**
         * Obrim el formulari
         * Posem el nom de l'usuari per donar-li la benvinguda
         */
        private void FormSAdimOpciones_Load(object sender, EventArgs e)
        {
            labelBenvinguda.Text = "Benvingut " + usuari.nom;
        }

        /**
         * Acció --> Botó Usuaris
         * Obrim un Form d'Usuaris
         */
        private void buttonUsuari_Click(object sender, EventArgs e)
        {
            FormUsuaris formUsuari = new FormUsuaris();
            formUsuari.ShowDialog();
        }

        /**
         * Acció --> Botó Personatges
         * Obrim un Form de Personatges pasant-li per parametre l'usuari que som
         */
        private void buttonPersonatges_Click(object sender, EventArgs e)
        {
            FormPersonatges formPersonatges= new FormPersonatges(this.usuari);
            formPersonatges.ShowDialog();
        }

        /**
         * Acció --> Botó Preguntes
         * Obrim un Form de Preguntes pasant-li per parametre l'usuari que som
         */
        private void buttonPreguntes_Click(object sender, EventArgs e)
        {
            FormPreguntas formPreguntas = new FormPreguntas(this.usuari);
            formPreguntas.ShowDialog();
        }

        /**
         * Acció --> Botó BACK (ToolStrip)
         * Tanca el formulari i t'obre l'anterior
         */
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInici = new FormInicioSesion();
            formInici.ShowDialog();
        }

        /**
         * Acció --> Botó LOGOUT (ToolStrip)
         * Tanca la sessió i torna al Form Inici Sessió
         */
        private void toolStripButtonLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas seguro que quieres cerrar sesión?", "LOG OUT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FormInicioSesion formInici = new FormInicioSesion();
                formInici.ShowDialog();
            }
        }
    }
}
