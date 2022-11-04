using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    public partial class FormEditUsuaris : Form
    {

        
        private String nickname = null;
        


        public FormEditUsuaris()
        {
            InitializeComponent();
        }


        public FormEditUsuaris(String nickname)
        {
           InitializeComponent();
           this.nickname = nickname;
        }

        private void checkBoxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrar.Checked == true)
            {
                textBoxContrasenya.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxContrasenya.UseSystemPasswordChar = true;
            }
        }

        private void checkBoxMostrarRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarRepeat.Checked == true)
            {
                textBoxRepeatContrasenya.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxRepeatContrasenya.UseSystemPasswordChar = true;
            }
        }
        
        public bool ValidarUser()
        {
            bool validReturn = true;
            if (textBoxNickName.Text.Equals("") || textBoxNomEdit.Text.Equals("") || textBoxContrasenya.Text.Equals("") || textBoxRepeatContrasenya.Text.Equals(""))
            {
                MessageBox.Show("No puedes dejar ningún campo en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validReturn = false; 
            }
            if (!textBoxContrasenya.Text.Equals(textBoxRepeatContrasenya.Text))
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validReturn = false;
            }
            return validReturn;
        }

        
        //funció per saber la posició del user a editar
        private int userPosition()
        {
            int UserPosition = UsuarisRepositori.users.FindIndex(x => x.nickname == nickname);
            return UserPosition;    
        }

        private void FormEditUsuaris_Load(object sender, EventArgs e)
        {
            if (nickname != null)
            {   
               

                textBoxNickName.Text = UsuarisRepositori.users[userPosition()].nickname;
                textBoxNomEdit.Text = UsuarisRepositori.users[userPosition()].nom;
                checkBoxAfegir.Checked = UsuarisRepositori.users[userPosition()].add;
                checkBoxEditar.Checked = UsuarisRepositori.users[userPosition()].modify;
                checkBoxEliminar.Checked = UsuarisRepositori.users[userPosition()].delete;


            }
            
        }

        private void textBoxRepeatContrasenya_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptarEditUsers_Click(object sender, EventArgs e)
        {
            char tipus = 'A';


            if (nickname == null)
            {
                if (ValidarUser())
                {
                    //Afegir nou usuari
                    Usuari usuariAfegir = new Usuari(textBoxNickName.Text, textBoxNomEdit.Text, EncriptarContrasenyes.encriptarContrasenya(textBoxContrasenya.Text), tipus, checkBoxAfegir.Checked, checkBoxEditar.Checked, checkBoxEliminar.Checked);

                    UsuarisRepositori.AddUser(usuariAfegir);
                    UsuarisRepositori.SaveUsers();
                    this.Close();
                }

            }
            else
            {
                if (!nickname.Equals("SuperAdmin"))
                {
                    if (ValidarUser())
                    {
                        //Editar usuari existen

                        Usuari usuariEdited = new Usuari(textBoxNickName.Text, textBoxNomEdit.Text, EncriptarContrasenyes.encriptarContrasenya(textBoxContrasenya.Text), tipus, checkBoxAfegir.Checked, checkBoxEditar.Checked, checkBoxEliminar.Checked);


                        UsuarisRepositori.EditUser(usuariEdited, userPosition());
                        UsuarisRepositori.SaveUsers();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No puedes crear/modificar un Super Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
