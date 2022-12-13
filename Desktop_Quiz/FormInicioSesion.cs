using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    /**
     * public partial class MainWindow : Form
     */

    public partial class FormInicioSesion : Form
    {
        //Declarem una variable global on hi posarem la llista d'usuaris que haurem carregat gràcies al JSON USUARIS
        List<Usuari> usuaris;

        /**
         * Obrim el formulari
         */

        public FormInicioSesion()
        {
            InitializeComponent();
        }

        /**
         * Acció --> Botó Inici Sessió.
         * Un cop es faci aquesta acció, es llegirà el JSON d'usuaris i es guardarà tot a la llista <usuaris>.
         * Es recorrerà la llista buscant que el camp NOM i camp CONTRASENYA coincideixin amb algun nom_usuari i contrasenya_usuari de la lista Usuaris
         * CAS CORRECTE --> S'obrirà FORM (Admin o SuperAdmin), depenent del tipus d'Usuari que sigui.
         * CAS INCORRECTE --> Missatge ERROR
         */
        private void buttonIniciSessio_Click(object sender, EventArgs e)
        {
            String nom = textBoxNom.Text;
            String contrasenya = textBoxContrasenya.Text;
            Boolean logInCorrect = false;

            JArray jarrayUsuaris = JArray.Parse(File.ReadAllText(@"../../JSON/USUARIS.json", Encoding.UTF8));
            usuaris = jarrayUsuaris.ToObject<List<Usuari>>();
            int usuari = 0;
            do
            {
                if (nom.Equals(usuaris[usuari].nickname.ToString()) && EncriptarContrasenyes.verificarContra(contrasenya, usuaris[usuari].contrasenya.ToString()))
                {
                    if (usuaris[usuari].tipus == 'S')
                    {
                        FormSAdimOpciones formSuperAdmin = new FormSAdimOpciones(usuaris[usuari]);
                        formSuperAdmin.ShowDialog();
                    } else
                    {
                        FormAdminOpciones formAdmin = new FormAdminOpciones(usuaris[usuari]);
                        formAdmin.ShowDialog();
                    }
                    this.Close();
                    logInCorrect = true;
                }
                usuari++;
            }
            while (logInCorrect == false && usuari < usuaris.Count());

            if (logInCorrect == false)
            {
                MessageBox.Show("Usuari/Contrasenya incorrecte.");
            }
        }

        /**
         * Permet fer ús de la tecla Enter des del camp Nom, al utilitzar-la cridarem la funció Inici Sessió
         */
        private void textBoxNom_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                buttonIniciSessio_Click(sender, e);
            }
        }

        /**
         * Permet fer ús de la tecla Enter des del camp Contrasenya, al utilitzar-la cridarem la funció Inici Sessió
         */
        private void textBoxContrasenya_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonIniciSessio_Click(sender, e);
            }
        }

        /**
         * Al fer click sobre la CheckBox d'ensenyar contrasenya, te la farà visible o invisible
         */
        private void checkBoxMostraPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostraPass.Checked == true)
            {
                textBoxContrasenya.UseSystemPasswordChar = false;
            } else
            {
                textBoxContrasenya.UseSystemPasswordChar = true;
            }
        }
    }
}
