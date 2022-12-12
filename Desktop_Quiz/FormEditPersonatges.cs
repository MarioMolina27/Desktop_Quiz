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
    public partial class FormEditPersonatges : Form
    {
        /**
         * public FormEditPersonatges()
         * Creem variables per carregar cada un dels atributs de la clase Personatge
         */

        String nomPers, descripcioPers, genere, rutaPers;
        double percEncerts;

        /**
         * Carreguem el formulari amb les dades del personatge en cas que el vulguem editar,
         * i en cas de que en creem un de nou aquests camps estaràn vuits
         */

        private void FormEditPersonatges_Load(object sender, EventArgs e)
        {

            textBoxNomPers.Text = nomPers;
            textBoxDescripcioPers.Text = descripcioPers;
            textBoxRutaImg.Text = rutaPers;
            comboBoxGenere.Text = genere;
            textBoxEncerts.Text = percEncerts.ToString();
              
        }

        /**
         * D'aquesta forma carreguem el formulari vuit
         */

        public FormEditPersonatges()
        {
            InitializeComponent();
        }

        /**
         * D'aquesta forma rebem les dades del personatge i carreguem el formulari ple
         */

        public FormEditPersonatges(String nomPers,String descripcioPers,String genere,double percEncerts,String rutaPers)
        {

            this.nomPers = nomPers;
            this.descripcioPers = descripcioPers;
            this.genere = genere;
            this.percEncerts = percEncerts;
            this.rutaPers = rutaPers;
            
            InitializeComponent();

        }

        /**
         * El botó que permet guardar els canvis o el nou personatge, sempre que no hi hagi cap camp vuit.
         */

        private void buttonGuardarEdit_Click(object sender, EventArgs e)
        {
            Personatge p = new Personatge();

            p.nomPers = textBoxNomPers.Text;
            p.descripcioPers = textBoxDescripcioPers.Text;
            p.genere = comboBoxGenere.Text;
            p.percEncerts = double.Parse(textBoxEncerts.Text);
            p.rutaPers = textBoxRutaImg.Text;

            if (textBoxNomPers.Text.Equals("") | textBoxDescripcioPers.Text.Equals("") | comboBoxGenere.Text.Equals("")) {

                MessageBox.Show("No pot haver-hi cap camp en blanc", "Error");
                this.Close();

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
         * Amb la següent funció permetem que l'usuari esculli la imatge del personatge que en questió.
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
         * Amb la següent funció mostrem el la ruta de la imatge seleccionada
         */

        private void textBoxRutaImg_TextChanged(object sender, EventArgs e) {

            if (!textBoxRutaImg.Equals(""))
            {

                pictureBoxPers.ImageLocation = textBoxRutaImg.Text;

            }

        }



    }
}
