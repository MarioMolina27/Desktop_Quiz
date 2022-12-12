using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{

    /**
    * public partial class MainWindow : Form
    */

    public partial class FormPersonatges : Form
    {

        /**
         * public FormPersonatges()
         * declarem una variable general per saber l'idoma en que estem treballan i poder saber el Json que s'ha de carregar.
         * A més d'una que ens servirà per poder saber quin usuari ha entrat
         */

        int idioma = 0;

        public Usuari usuari { get; set; }

        /**
         * Obrim el formulari
         */

        public FormPersonatges()
        {
            InitializeComponent();
        }
        public FormPersonatges(Usuari usuari)
        {
            this.usuari = usuari;
            InitializeComponent();
        }

        /**
         * Un cop s'ha cridat al formulari carreguem la llista a la DataGrid que hem agafat del Json.
         * I mostrem els botons respectius als privilegis de l'usuari.
         */

        private void FormPersonatges_Load(object sender, EventArgs e)
        {

            PersRepo.LoadPersListCat();

            dataGridViewPersonatges.DataSource = null;
            dataGridViewPersonatges.DataSource = PersRepo.personatges;
            if (usuari.add)
            {
                buttonNouPersonatge.Visible = true;
            }
            else if (!usuari.add)
            {
                buttonNouPersonatge.Visible = false;
            }

            if (usuari.delete)
            {
                buttonEliminarPersonatge.Visible = true;
            }
            else if (!usuari.delete)
            {
                buttonEliminarPersonatge.Visible = false;
            }

            if (usuari.modify)
            {
                buttonEditarPersonatge.Visible = true;
            }
            else if (!usuari.modify)
            {
                buttonEditarPersonatge.Visible = false;
            }
        }

        /**
         * Configurem el buscador per tal de que mostri un text personalitzat cada cop que entrem i sortim.
         */

        private void textBoxBuscadorPersonatges_Enter(object sender, EventArgs e)
        {
            if (textBoxBuscadorPersonatges.Text.Equals("  Buscar..."))
            {
                textBoxBuscadorPersonatges.Text = "";
                textBoxBuscadorPersonatges.ForeColor = Color.Black;
            }
        }

        private void textBoxBuscadorPersonatges_Leave(object sender, EventArgs e)
        {
            if (textBoxBuscadorPersonatges.Text.Equals(""))
            {
                textBoxBuscadorPersonatges.Text = "  Buscar...";
                textBoxBuscadorPersonatges.ForeColor = Color.Gray;
            }
        }

        /**
         * Aquesta funció serveix per actualitzar el que es mosstra a la dataGrid cada cop que es modifiqui alguna cosa a la llista
         */

        private void updateDataGridPers() {

            dataGridViewPersonatges.DataSource = null;
            dataGridViewPersonatges.DataSource = PersRepo.personatges;

            guardarJsonPers();

        }

        /**
         * Aquesta funció ens obra una nova pestanya per afegir un nou personatge
         */

        private void buttonNouPersonatge_Click(object sender, EventArgs e)
        {

            Form pers = new FormEditPersonatges();
            pers.ShowDialog();

            updateDataGridPers();

        }

        /**
         * Aquesta funció ens obra una nova pestanya per editar un personatge existent
         */

        private void buttonEditarPersonatge_Click(object sender, EventArgs e)
        {

            int rowIndex = persRowIndex();

            if (rowIndex != -1) {

                DataGridViewRow filaSeleccionada = dataGridViewPersonatges.Rows[rowIndex];

                String nomPers = filaSeleccionada.Cells[0].Value.ToString();
                String descripcioPers = filaSeleccionada.Cells[1].Value.ToString();
                String genere = filaSeleccionada.Cells[2].Value.ToString();
                double percEncerts = double.Parse(filaSeleccionada.Cells[3].Value.ToString());
                String rutaPers = filaSeleccionada.Cells[4].Value.ToString();


                FormEditPersonatges formEdit = new FormEditPersonatges(nomPers, descripcioPers, genere, percEncerts, rutaPers);
                PersRepo.personatges.RemoveAt(rowIndex);
                formEdit.ShowDialog();
                
                updateDataGridPers();

            }
            
        }

        /**
         * Aquesta funció ens obra una nova pestanya per eliminar el personatge seleccionat
         */

        private void buttonEliminarPersonatge_Click_1(object sender, EventArgs e)
        {

            int rowIndex = persRowIndex();
            int delete = 0;

            if (rowIndex != -1)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPersonatges.Rows[rowIndex];
                String nom = filaSeleccionada.Cells[0].Value.ToString();


                if (!String.IsNullOrEmpty(nom))
                {
                    delete = trobarPers(nom, PersRepo.personatges);
                    PersRepo.personatges.RemoveAt(delete);
                    updateDataGridPers();
                }

            }
            else
            {
                MessageBox.Show("No has escollit cap personatge per eliminar","Error");
            }

        }

        /**
         * Les següents funcions ens serveixen per saber amb quin personatge estem tractant 
         */

        private int persRowIndex() {

            int rowIndex = dataGridViewPersonatges.CurrentCell.RowIndex;

            return rowIndex; 
        }


        private int trobarPers(String nom, List<Personatge> list) {
            int pos = 0;

            for (int i = 0; i < list.Count(); i++)
            {

                if (nom.Equals(list[i].nomPers.ToString()))
                {
                    pos = i;
                }

            }

            return pos;
        }

        /**
         * Les següents funcions serveixen per anar cambiant l'idioma de la llista que es mostra a la DataGrid
         */

        private void radioButtonCatala_CheckedChanged(object sender, EventArgs e)
        {
            
            PersRepo.LoadPersListCat();
            
            dataGridViewPersonatges.DataSource = null;
            dataGridViewPersonatges.DataSource = PersRepo.personatges;

            idioma = 0;
            
        }

        private void radioButtonCastella_CheckedChanged(object sender, EventArgs e)
        {

            PersRepo.LoadPersListCast();

            dataGridViewPersonatges.DataSource = null;
            dataGridViewPersonatges.DataSource = PersRepo.personatges;

            idioma = 1;

        }

        private void radioButtonAngles_CheckedChanged(object sender, EventArgs e)
        {
            PersRepo.LoadPersListAng();

            dataGridViewPersonatges.DataSource = null;
            dataGridViewPersonatges.DataSource = PersRepo.personatges;

            idioma = 2;

        }

        /**
         * De la següent forma el buscador troba el personatge perl seu nom quan li donem a la tecla Enter 
         */

        private void textBoxBuscadorPersonatges_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                String nom = textBoxBuscadorPersonatges.Text;

                if (!nom.Equals("")) {
                    List<Personatge> persList = PersRepo.personatges.FindAll(x => x.nomPers == nom);

                    if (persList.Count > 0)
                    {
                        dataGridViewPersonatges.DataSource = null;
                        dataGridViewPersonatges.DataSource = persList;
                    }
                    else
                    {
                        MessageBox.Show("No hi ha cap personatge amb aquest nom", "Error");
                    }
                }
                else
                {
                    updateDataGridPers();
                }

            }
        }

        /**
         * Fent servir la variable idioma guardem el Json modificat segons l'idioma que s'estigui fent servir en aquell moment
         */

        private void guardarJsonPers ()
        {

            switch (idioma)
            {
                case 0:

                    PersRepo.SavePersCat();

                    break;

                case 1:

                    PersRepo.SavePersCast();

                    break;
                case 2:

                    PersRepo.SavePersAng();

                    break;

            }

        }

        /**
         * I de la següent forma tanquem el formulari per anar al formulari anterior
         */

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
