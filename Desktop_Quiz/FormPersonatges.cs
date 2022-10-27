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
    public partial class FormPersonatges : Form
    {

        int idioma = 0;

        public FormPersonatges()
        {
            InitializeComponent();
        }
        private void FormPersonatges_Load(object sender, EventArgs e)
        {
            PersRepo.LoadPersListCat();

            dataGridViewPersonatges.DataSource = null;
            dataGridViewPersonatges.DataSource = PersRepo.personatges;
        }

        private void toolStripButtonTornarEnrere_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void updateDataGridPers() {

            dataGridViewPersonatges.DataSource = null;
            dataGridViewPersonatges.DataSource = PersRepo.personatges;

            guardarJsonPers();

        }

        

        private void buttonNouPersonatge_Click(object sender, EventArgs e)
        {

            Form pers = new FormEditPersonatges();
            pers.ShowDialog();

            updateDataGridPers();

        }

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

        private int persRowIndex() {

            int rowIndex = dataGridViewPersonatges.CurrentCell.RowIndex;

            return rowIndex; }

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

        private  void radioButtonCatala_CheckedChanged(object sender, EventArgs e)
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

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
