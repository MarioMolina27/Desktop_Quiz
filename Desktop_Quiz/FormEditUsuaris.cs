﻿using System;
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
            if (textBoxNickName.Text.Equals("") || textBoxNomEdit.Text.Equals(""))
            {
                MessageBox.Show("No puedes dejar ningún campo en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private bool passwordCheck()
        {
            bool validReturn = true;
            
                if (!textBoxContrasenya.Text.Equals(textBoxRepeatContrasenya.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validReturn = false;
                }
            return validReturn;
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
            else 
            {
                checkModifyPassw.Checked = true;
                checkModifyPassw.Enabled = false;
            }
            
        }

        private void textBoxRepeatContrasenya_TextChanged(object sender, EventArgs e)
        {

        }
        /**
        * Funcion que añade o edita y guarda un usuario haciendo previamente la validación
        */
        private void buttonAceptarEditUsers_Click(object sender, EventArgs e)
        {
            char tipus = 'A';

            if (nickname == null)
            {
                checkModifyPassw.Checked.Equals(true);

                if (ValidarUser() && passwordCheck())
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
                if (ValidarUser() && passwordCheck())
                {
                    bool modifyPassword = false;

                    if (checkModifyPassw.Checked)
                    {
                       modifyPassword = true;
                    }

                    Usuari usuariEdited = new Usuari(textBoxNickName.Text, textBoxNomEdit.Text, EncriptarContrasenyes.encriptarContrasenya(textBoxContrasenya.Text), tipus, checkBoxAfegir.Checked, checkBoxEditar.Checked, checkBoxEliminar.Checked);
                    UsuarisRepositori.EditUser(usuariEdited, userPosition(), modifyPassword);
                    UsuarisRepositori.SaveUsers();
                    this.Close();
                }
            }
        }

        /**
        * Función que cierra el formulario
        */
        private void buttonCancelarEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
        * Función que permite escribir para editar la contraseña
        */
        private void checkModifyPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModifyPassw.Checked)
            {
                textBoxContrasenya.Enabled = true;
                textBoxRepeatContrasenya.Enabled = true;
            }
            else
            {
                textBoxContrasenya.Enabled = false;
                textBoxRepeatContrasenya.Enabled = false;
                textBoxContrasenya.Text = "";
                textBoxRepeatContrasenya.Text = "";
            }
            
        }
    }
}
