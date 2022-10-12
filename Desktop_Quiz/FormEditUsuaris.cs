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
        public FormEditUsuaris()
        {
            InitializeComponent();
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
        
        public bool  ValidarUser()
        {
            if (textBoxNickName.Equals(null) || textBoxNom.Equals(null) || textBoxContrasenya.Equals(null) || textBoxRepeatContrasenya.Equals(null))
            {
                MessageBox.Show("No puedes dejar ningún campo en blanco");
                return false;
            } else
            {
                return true;
            }
        }

        private void labelNickname_Click(object sender, EventArgs e)
        {

            
        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=pyw-2Z95RE8&ab_channel=Inform%C3%A1ticayProgramaci%C3%B3n
            if (ValidarUser())
            {

            } else
            {

            }
           
        }
    }
}
