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

        //variable global donde guardaremos el nickname del usuario que estamos modificando
        //si estamos crando un usuario este campo estará vacio
        private String nickname = null;


        /**
        * Constructor default del formulario
        */
        public FormEditUsuaris()
        {
            InitializeComponent();
        }


        /**
        * Constructor modifcado
        * @nickname id del usuario que queremos modificar
        */
        public FormEditUsuaris(String nickname)
        {
           InitializeComponent();
           this.nickname = nickname;
        }

        /**
        * Funcion que muestra la contraseña o la esconde
        */
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
        /**
        * Funcion que muestra la contraseña o la esconde
        */
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

        /**
        * Valida si todos los campos han sido rellenados antes de guardar el usuario
        * @return devuelve un booleano si la validacion se cumple o no
        */
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

        /**
        * Funcion para saber la posición del user a editar
        * @return posición del user que queremos editar.
        */
        private int userPosition()
        {
            int UserPosition = UsuarisRepositori.users.FindIndex(x => x.nickname == nickname);
            return UserPosition;    
        }

        /**
        * Carga los textBow y checkBox con los campos del usuario a editar.
        * Si es un nuevo usuario los campos estarán vacios
        */
        private void FormEditUsuaris_Load(object sender, EventArgs e)
        {
            if (nickname != null)
            {
                int editPosition = userPosition();
                textBoxNickName.Text = UsuarisRepositori.users[editPosition].nickname;
                textBoxNomEdit.Text = UsuarisRepositori.users[editPosition].nom;
                checkBoxAfegir.Checked = UsuarisRepositori.users[editPosition].add;
                checkBoxEditar.Checked = UsuarisRepositori.users[editPosition].modify;
                checkBoxEliminar.Checked = UsuarisRepositori.users[editPosition].delete;
            }
            
        }

        private void textBoxRepeatContrasenya_TextChanged(object sender, EventArgs e)
        {

        }
        /**
        * Funcion que añade o edita y guarda un usuario hacienod previamente la validación
        */
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
                    if (ValidarUser())
                    {
                        //Editar usuari existen

                        Usuari usuariEdited = new Usuari(textBoxNickName.Text, textBoxNomEdit.Text, EncriptarContrasenyes.encriptarContrasenya(textBoxContrasenya.Text), tipus, checkBoxAfegir.Checked, checkBoxEditar.Checked, checkBoxEliminar.Checked);

                        UsuarisRepositori.EditUser(usuariEdited, userPosition());
                        UsuarisRepositori.SaveUsers();
                        this.Close();
                    }
            }
        }
    }
}
