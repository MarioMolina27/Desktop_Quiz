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

       /**
       * Funcion que llama a la funcion que infla la lista de usuario y carga esta lista en el dataGrid
       */
        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            //cargamos la lista con el contenido del Json
            UsuarisRepositori.LoadUsersList();

            dataGridUsuaris1.DataSource = null;
            dataGridUsuaris1.DataSource = UsuarisRepositori.users; 

        }
        /**
        * Funcion que borra lo que hay escrito en el textBoxNickSearch al entrar en él
        */
        private void textBoxNickSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "  Buscar...")
            {
                textBoxNickSearch.ForeColor = Color.Black;
                textBoxNickSearch.Text = "";
            }
        }
        /**
        * Función que vuelve a dejar la palabra "buscar..." cuando salimos del textBoxNickSearch 
        * y no hay nada escrito en él.
        */
        private void textBoxNickSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "")
            {
                textBoxNickSearch.ForeColor = Color.Gray;
                textBoxNickSearch.Text = "  Buscar...";
                autoRefresh();
            }
            
        }

        /**
        * Función que al pulsar el boton modificar usuario llama al FormEditUsuaris pasandole como
        * parametro el nickname(id) del usuario a modificarlo.
        */
        private void buttonEditUser1_Click(object sender, EventArgs e)
        {
            if (conseguirRowIndex() != -1)

            {      
                if (nicknameSelected().Equals("SuperAdmin")) //comprueba que el usuario a modificar no es el SuperAdmin
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

        /**
        * Función que nos devuelve la el nickname del usuario que se encuentra en la fila seleccionada.
        * @return nickname del usuario (id)
        */
        private String nicknameSelected()
        {
            String nickname = dataGridUsuaris1.Rows[conseguirRowIndex()].Cells[0].Value.ToString();
            return nickname;
        }

        /**
        * Función que al pulsar el boton añadir usuario llama al FormEditUsuaris pero sin pasarle como parametro ningún parametro
        * ya que estamos creando un usuario nuevo
        */
        private void button1_Click(object sender, EventArgs e)
        {   
            FormEditUsuaris editUsuaris2 = new FormEditUsuaris();
            editUsuaris2.ShowDialog();
            //volvemos a cargar la grid
            autoRefresh();
        }

        /**
        * Función que nos devuelve que fila esta seleccionada del dataGrid
        * @return número entero de la fila seleccionada
        */
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

        /**
        * Función que al pulsar el boton de volver cierra este formualario
        */
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
        * Función que nos vuelve a cargar la dataGrid con la lista estatica
        */
        private void autoRefresh()
        {
            dataGridUsuaris1.DataSource = null;
            dataGridUsuaris1.DataSource = UsuarisRepositori.users;
        }

        /**
        * Función que al pulsar el boton de eliminar usuario llama a la función DeleteUser
        * y seguidamente sobreescribe el JSON llamando a la función SaveUser.
        */
        private void buttonDeleteUsers_Click(object sender, EventArgs e)
        {
            //eliminar usuario

            if (nicknameSelected().Equals("SuperAdmin")) //comprueba si el usuario a elinar es el superadmin
            {
                MessageBox.Show("No puedes eliminar un Super Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UsuarisRepositori.DeleteUser(nicknameSelected());
                UsuarisRepositori.SaveUsers();
                autoRefresh(); //volvemos a cargar el dataGrid

            }

        }

        /**
        * Funcion que busca y muestra todos los usuario con el nickname especificado en el textBoxNickSearch
        * cuando hacemos enter sobre él
        */
        private void textBoxNickSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String nickname = textBoxNickSearch.Text;

                // creamos una nueva lista con los usuarios que cumplan el requisito de la funcion lambda
                List<Usuari> userSelect = UsuarisRepositori.users.FindAll(x => x.nickname == nickname);

                //cargamos el dataGrid con la nueva lista.
                dataGridUsuaris1.DataSource = null;
                dataGridUsuaris1.DataSource = userSelect;
            } 
        }

        private void toolStripButtonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estas seguro que quieres cerrar sesión?", "LOG OUT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                FormInicioSesion formInici = new FormInicioSesion();
                formInici.ShowDialog();
            }
        }
    }
}
