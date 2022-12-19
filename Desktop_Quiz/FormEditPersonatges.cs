using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    /**
    * public partial class MainWindow : Form
    */
    public partial class FormEditPersonatges : Form
    {

        /**
         * public FormPersonatges()
         * declarem unes variables generals per tal de llegir i escrirure les dades dels documents Json.
         */

        String nomPers, descripcioPers, genere, rutaPers;
        int percEncerts;

        private void FormEditPersonatges_Load(object sender, EventArgs e)
        {

            textBoxNomPers.Text = nomPers;
            textBoxDescripcioPers.Text = descripcioPers;
            textBoxRutaImg.Text = rutaPers;
            comboBoxGenere.Text = genere;
            textBoxEncerts.Text = percEncerts.ToString();
           
              
        }

        /**
         * Obrim el formulari vuit
         */

        public FormEditPersonatges()
        {
            InitializeComponent();
        }

        /**
         * Obrim el formulari amb les dades del personatge
         */

        public FormEditPersonatges(String nomPers,String descripcioPers,String genere,int percEncerts,String rutaPers)
        {

            this.nomPers = nomPers;
            this.descripcioPers = descripcioPers;
            this.genere = genere;
            this.percEncerts = percEncerts;
            this.rutaPers = rutaPers;
            
            InitializeComponent();

        }

        /**
         * Botó per tancar el formulari sense introduïr dades
         */

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            Personatge p = new Personatge();



            if (textBoxNomPers.Text.Equals("") | textBoxDescripcioPers.Text.Equals("") | comboBoxGenere.Text.Equals("") | textBoxRutaImg.Equals(""))
            {
                MessageBox.Show("No s'ha afegit cap personatge");
            }
            else {

                p.nomPers = textBoxNomPers.Text;
                p.descripcioPers = textBoxDescripcioPers.Text;
                p.genere = comboBoxGenere.Text;
                p.percEncerts = int.Parse(textBoxEncerts.Text);
                p.rutaPers = textBoxRutaImg.Text;

                PersRepo.personatges.Add(p);

            }

            this.Close();
        }

        /**
         * Botó per tancar el formulari i guardar les dades introduïdes
         */

        private void buttonGuardarEdit_Click(object sender, EventArgs e)
        {
            Personatge p = new Personatge();

            p.nomPers = textBoxNomPers.Text;
            p.descripcioPers = textBoxDescripcioPers.Text;
            p.genere = comboBoxGenere.Text;
            p.percEncerts = int.Parse(textBoxEncerts.Text);
            p.rutaPers = textBoxRutaImg.Text;

            if (textBoxNomPers.Text.Equals("") | textBoxDescripcioPers.Text.Equals("") | comboBoxGenere.Text.Equals("")) {

                MessageBox.Show("No pot haver-hi cap camp en blanc", "Error");

            } else {
            
                if (p.rutaPers.Equals(""))
                {

                    p.rutaPers = "Pendent de ruta";

                }

                PersRepo.personatges.Add(p);

                this.Close();
            }

        }

        /**
         * Botó per trobar l'imatge del personatge
         */

        /**
         */

        private void buttonBuscarRutaImg_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Buscar imatges (*.png)|*.png";

            if (openFile.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRutaImg.Text = Path.GetFileName(openFile.FileName); ;
                pictureBoxPers.ImageLocation = openFile.FileName ;
            }

        }

        /**
         * Edit text per mostrar el nom de la imatge
         */

        private void textBoxRutaImg_TextChanged(object sender, EventArgs e) {

            if (!textBoxRutaImg.Equals(""))
            {

                pictureBoxPers.ImageLocation = textBoxRutaImg.Text;

            }

        }



    }
}
