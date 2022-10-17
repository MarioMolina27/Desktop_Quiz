using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    public partial class FormUsuaris : Form
    {


        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            //cargamos la lista con el contenido del Json
            UsuarisRepositori.LoadUsersList();

            dataGridUsuaris1.DataSource = null;
            dataGridUsuaris1.DataSource = UsuarisRepositori.users; 

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNickSearch_TextChanged(object sender, EventArgs e)
        {

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

        //button edit
        private void buttonEditUser1_Click(object sender, EventArgs e)
        {
            if (conseguirRowIndex() != -1)
            {
                FormEditUsuaris userEdit1 = new FormEditUsuaris(conseguirRowIndex());
                userEdit1.ShowDialog();
            }

        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditUsuaris editUsuaris2 = new FormEditUsuaris();
            editUsuaris2.ShowDialog();
        }

        //funcio per saver quina fila esta seleccionada 
        private int conseguirRowIndex()
        {
            int rowIndex = -1;
            if (dataGridUsuaris1.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Has de seleccionar una filera");
            }else
            {
                rowIndex = dataGridUsuaris1.CurrentCell.RowIndex;
            }
            return rowIndex;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefreshUsers_Click(object sender, EventArgs e)
        {
            //cargamos la lista con el contenido del Json
            UsuarisRepositori.LoadUsersList();

            dataGridUsuaris1.DataSource = null;
            dataGridUsuaris1.DataSource = UsuarisRepositori.users;
        }
    }
}
