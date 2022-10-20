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
    public partial class FormEditPersonatges : Form
    {

        String nomPers, descripcioPers, genere, rutaPers;
        double percEncerts;

        private void FormEditPersonatges_Load(object sender, EventArgs e)
        {

            textBoxNomPers.Text = nomPers;
            textBoxDescripcioPers.Text = descripcioPers;
            textBoxRutaImg.Text = rutaPers;
            comboBoxGenere.Text = genere;
            textBoxEncerts.Text = percEncerts.ToString();

        }

        private void buttonGuardarEdit_Click(object sender, EventArgs e)
        {
            String nomPers = textBoxNomPers.Text;
            String descripcioPers = textBoxDescripcioPers.Text;
            String genere = comboBoxGenere.Text;
            double percEncerts = double.Parse(textBoxEncerts.Text);
            String rutaPers = textBoxRutaImg.Text;

            this.Close();

        }

        public FormEditPersonatges()
        {
            InitializeComponent();
        }

        public FormEditPersonatges(String nomPers,String descripcioPers,String genere,double percEncerts,String rutaPers)
        {

            this.nomPers = nomPers;
            this.descripcioPers = descripcioPers;
            this.genere = genere;
            this.percEncerts = percEncerts;
            this.rutaPers = rutaPers;

            InitializeComponent();
        }

        private void buttonBuscarRutaImg_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Buscar imatges (*.png)|*.png";

            if (openFile.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRutaImg.Text = openFile.FileName;
                pictureBoxPers.ImageLocation = textBoxRutaImg.Text;
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
