using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Quiz
{
    public partial class FormInicioSesion : Form
    {
        List<Usuari> usuaris;
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void buttonIniciSessio_Click(object sender, EventArgs e)
        {
            String nom = textBoxNom.Text;
            String contrasenya = textBoxContrasenya.Text;
            Boolean logInCorrect = false;

            JArray jarrayUsuaris = JArray.Parse(File.ReadAllText(@"../../JSON/USUARIS.json", Encoding.UTF8));
            usuaris = jarrayUsuaris.ToObject<List<Usuari>>();

            foreach (Usuari user in usuaris)
            {
                if (nom.Equals(user.nickname) && EncriptarContrasenyes.verificarContra(contrasenya, user.contrasenya))
                {
                    if (user.tipus == 'S')
                    {
                        FormSAdimOpciones formSuperAdmin = new FormSAdimOpciones(user);
                        formSuperAdmin.ShowDialog();
                    } else
                    {
                        FormAdminOpciones formAdmin = new FormAdminOpciones(user);
                        formAdmin.ShowDialog();
                    }
                    this.Close();
                    logInCorrect = true;
                }
                
            }
            if (logInCorrect == false)
            {
                MessageBox.Show("Usuari/Contrasenya incorrecte.");
            }
        }

        private void textBoxNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonIniciSessio_Click(sender, e);
            }
        }

        private void textBoxContrasenya_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonIniciSessio_Click(sender, e);
            }
        }

        private void checkBoxMostraPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostraPass.Checked == true)
            {
                textBoxContrasenya.UseSystemPasswordChar = false;
            } else
            {
                textBoxContrasenya.UseSystemPasswordChar = true;
            }
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
