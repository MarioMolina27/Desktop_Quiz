using System;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    /**
     * public partial class FormAdminOpciones : Form
     */
    public partial class FormAdminOpciones : Form
    {
        String nomAdmin;
        public Usuari usuari { get; set; }

        /**
         * Constructor default
         */
        public FormAdminOpciones()
        {
            InitializeComponent();
        }
        /**
         * Constructor amb usuari passat des del Form Inici Sessió
         */
        public FormAdminOpciones(Usuari u)
        {
            this.usuari = u;
            InitializeComponent();
        }
        /**
         * Constructor amb nom usuari passat des del Form Inici Sessió
         */
        public FormAdminOpciones(String nomUser)
        {
            InitializeComponent();
            this.nomAdmin = nomUser;
        }

        /**
         * Obrim el formulari
         * Posem el nom de l'usuari per donar-li la benvinguda
         */
        private void FormAdminOpciones_Load(object sender, EventArgs e)
        {
            labelNom.Text = nomAdmin;
            labelBenvinguda.Text = "Benvingut " + usuari.nom;
        }

        /**
         * Acció --> Botó Personatges
         * Obrim un Form de Personatges pasant-li per parametre l'usuari que som
         */
        private void buttonPersonatges_Click(object sender, EventArgs e)
        {
            FormPersonatges formPersonatge = new FormPersonatges(this.usuari);
            formPersonatge.ShowDialog();
        }

        /**
         * Acció --> Botó Preguntes
         * Obrim un Form de Preguntes pasant-li per parametre l'usuari que som
         */
        private void buttonPreguntes_Click(object sender, EventArgs e)
        {
            FormPreguntas formPreguntes = new FormPreguntas(this.usuari);
            formPreguntes.ShowDialog();
        }

        /**
         * Acció --> Botó BACK (ToolStrip)
         * Tanca el formulari i t'obre l'anterior
         */
        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicioSesion formInici = new FormInicioSesion();
            formInici.ShowDialog();
        }

        /**
         * Acció --> Botó LOGOUT (ToolStrip)
         * Tanca la sessió i torna al Form Inici Sessió
         */
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
