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
                autoRefresh();
            }
            
        }

        //button edit
        private void buttonEditUser1_Click(object sender, EventArgs e)
        {
           

            if (conseguirRowIndex() != -1)

            {
                if (nicknameSelected().Equals("SuperAdmin"))
                {
                    MessageBox.Show("No puedes crear/modificar un Super Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    FormEditUsuaris userEdit1 = new FormEditUsuaris(nicknameSelected());
                    userEdit1.ShowDialog();

                    //volvemos a cargar la grid
                    autoRefresh();
                }
                
            }

        }

        //gaurdem el nickname de la fila seleccionada 
        private String nicknameSelected()
        {
            String nickname = dataGridUsuaris1.Rows[conseguirRowIndex()].Cells[0].Value.ToString();
            return nickname;
        }

        //button afegir

        private void button1_Click(object sender, EventArgs e)
        {   
            
            
            FormEditUsuaris editUsuaris2 = new FormEditUsuaris();
            editUsuaris2.ShowDialog();
            //volvemos a cargar la grid
            autoRefresh();
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

        private void autoRefresh()
        {
            dataGridUsuaris1.DataSource = null;
            dataGridUsuaris1.DataSource = UsuarisRepositori.users;
        }

        private void buttonDeleteUsers_Click(object sender, EventArgs e)
        {
            //eliminar usuario

            if (nicknameSelected().Equals("SuperAdmin"))
            {
                MessageBox.Show("No puedes eliminar un Super Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UsuarisRepositori.DeleteUser(nicknameSelected());
                UsuarisRepositori.SaveUsers();
                autoRefresh();

            }

        }

        //metode per buscar un usuari concret
        private void textBoxNickSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String nickname = textBoxNickSearch.Text;
                List<Usuari> userSelect = UsuarisRepositori.users.FindAll(x => x.nickname == nickname);

                //carreguem la nova llista
                dataGridUsuaris1.DataSource = null;
                dataGridUsuaris1.DataSource = userSelect;
            }
           
            
            
        }
    }
}
