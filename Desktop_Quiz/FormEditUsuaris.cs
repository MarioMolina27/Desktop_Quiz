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


        private int IndexPosition = -1;
        


        public FormEditUsuaris()
        {
            InitializeComponent();
        }


        public FormEditUsuaris(int IndexPosition)
        {
           InitializeComponent();
           this.IndexPosition = IndexPosition;
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

        private void labelNickname_Click(object sender, EventArgs e)
        {

            
        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {            
           
        }

        private void groupBoxDadesUsuari_Enter(object sender, EventArgs e)
        {

        }

        private void FormEditUsuaris_Load(object sender, EventArgs e)
        {
            if (IndexPosition != -1)
            {
                textBoxNickName.Text = UsuarisRepositori.users[IndexPosition].nickname;
                textBoxNomEdit.Text = UsuarisRepositori.users[IndexPosition].nom;
                checkBoxAfegir.Checked = UsuarisRepositori.users[IndexPosition].add;
                checkBoxEditar.Checked = UsuarisRepositori.users[IndexPosition].modify;
                checkBoxEliminar.Checked = UsuarisRepositori.users[IndexPosition].delete;


            }
            
        }

        private void textBoxRepeatContrasenya_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptarEditUsers_Click(object sender, EventArgs e)
        {
            char tipus = 'A';


            if (IndexPosition == -1)
            {
                //Afegir nou usuari
                Usuari usuariAfegir = new Usuari(textBoxNickName.Text, textBoxNomEdit.Text, EncriptarContrasenyes.encriptarContrasenya(textBoxContrasenya.Text), tipus, checkBoxAfegir.Checked, checkBoxEditar.Checked, checkBoxEliminar.Checked);

                UsuarisRepositori.AddUser(usuariAfegir);
                UsuarisRepositori.SaveUsers();
                this.Close();
            }
            else
            {
                if (ValidarUser())
                {
                    //Editar usuari existen

                    Usuari usuariEdited = new Usuari(textBoxNickName.Text, textBoxNomEdit.Text, EncriptarContrasenyes.encriptarContrasenya(textBoxContrasenya.Text), tipus, checkBoxAfegir.Checked, checkBoxEditar.Checked, checkBoxEliminar.Checked);


                    UsuarisRepositori.EditUser(usuariEdited, IndexPosition);
                    UsuarisRepositori.SaveUsers();
                    this.Close();
                }
            }   
        }
    }
}
