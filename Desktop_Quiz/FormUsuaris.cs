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
    public partial class FormUsuaris : Form
    {
<<<<<<< Updated upstream
=======

        BindingList<Usuari> usuaris;


>>>>>>> Stashed changes
        public FormUsuaris()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            JArray arrayUsers = JArray.Parse(File.ReadAllText(@"..\..\JSON\USUARIS.json"));
            usuaris = arrayUsers.ToObject<BindingList<Usuari>>();

            dataGridUsuaris1.DataSource = null;
            dataGridUsuaris1.DataSource = usuaris;
        }

        private void textBoxNickSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "  Buscar...")
            {
                textBoxNickSearch.ForeColor = Color.Black;
                textBoxNickSearch.Text = "";
            }
        }

        private void textBoxNickSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "")
            {
                textBoxNickSearch.ForeColor = Color.Gray;
                textBoxNickSearch.Text = "  Buscar...";
            }
            
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            FormEditUsuaris editUsuaris1 = new FormEditUsuaris();
            editUsuaris1.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int rowIndex = conseguirRowIndex();
            if (rowIndex != -1)
            {
                DataGridViewRow filaSeleccionada = dataGridUsuaris1.Rows[rowIndex];
                String nickname = filaSeleccionada.Cells[0].Value.ToString();
                String nom = filaSeleccionada.Cells[1].Value.ToString();
                String contrasenya = filaSeleccionada.Cells[2].Value.ToString();
                String tipus = filaSeleccionada.Cells[3].Value.ToString();
                String priveligis = filaSeleccionada.Cells[4].Value.ToString();
                if (tipus.Equals("SA")) {
                    MessageBox.Show("No es pot modificar un SUPER ADMIN!");
                } else
                {
                    FormEditUsuaris editUsuaris1 = new FormEditUsuaris(nickname, nom, contrasenya, priveligis);
                    editUsuaris1.ShowDialog();
                }   
            } else
            {
                MessageBox.Show("No has elegit ningun Usuari per modificar-lo");
            }      
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int rowIndex = conseguirRowIndex();
            if (rowIndex != -1)
            {
                DataGridViewRow filaSeleccionada = dataGridUsuaris1.Rows[rowIndex];
                String tipus = filaSeleccionada.Cells[3].Value.ToString();
                if (tipus.Equals("SA"))
                {
                    MessageBox.Show("No es pot eliminar un SUPER ADMIN!");
                } else
                {
                    //Eliminar
                }
            } else
            {
                MessageBox.Show("No has elegit ningun Usuari per eliminar-lo");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int conseguirRowIndex ()
        {
            int rowIndex = dataGridUsuaris1.CurrentCell.RowIndex;
            return rowIndex;
        }
>>>>>>> Stashed changes
    }
}
