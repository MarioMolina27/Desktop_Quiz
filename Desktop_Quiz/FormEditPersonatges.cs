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

        

        public FormEditPersonatges()
        {
            InitializeComponent();
        }

        public FormEditPersonatges(String nomPers,String descripcioPers,String genere,int percEncerts,String rutaPers)
        {

            this.nomPers = nomPers;
            this.descripcioPers = descripcioPers;
            this.genere = genere;
            this.percEncerts = percEncerts;
            this.rutaPers = rutaPers;
            
            InitializeComponent();

        }

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

        private void textBoxRutaImg_TextChanged(object sender, EventArgs e) {

            if (!textBoxRutaImg.Equals(""))
            {

                pictureBoxPers.ImageLocation = textBoxRutaImg.Text;

            }

        }



    }
}
