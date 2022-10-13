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
    public partial class FormEditUsuaris : Form
    {
        String nickname, nom, contrasenya, privilegis;
        public FormEditUsuaris()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======
        public FormEditUsuaris(String nickname, String nom, String contrasenya, String priveligis)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.nom = nom;
            this.contrasenya = contrasenya;
            this.privilegis = priveligis;
        }

        private void FormEditUsuaris_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = nom;
            textBoxNickName.Text = nickname;
            textBoxContrasenya.Text = contrasenya;
            switch(privilegis)
            {
                case "Add":
                    checkBoxAfegir.Checked = true;
                    break;
                case "Add/Modify":
                    checkBoxAfegir.Checked = true;
                    checkBoxEliminar.Checked = true;
                    break;
                case "Add/Modify/Delete":
                    checkBoxAfegir.Checked = true;
                    checkBoxEditar.Checked = true;
                    checkBoxEliminar.Checked = true;
                    break;
                default:
                    MessageBox.Show("ERROR AT PRIVILEGIES!");
                    break;
            }      
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
>>>>>>> Stashed changes
    }
}
