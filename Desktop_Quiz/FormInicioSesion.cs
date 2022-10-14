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
            EncriptarContrasenyes ec = new EncriptarContrasenyes();

            foreach (Usuari user in usuaris)
            {
                if (nom.Equals(user.nickname) && ec.verificarContra(contrasenya, user.contrasenya))
                {
                    if (user.tipus.Equals("SA"))
                    {
                        FormSAdimOpciones formSuperAdmin = new FormSAdimOpciones(user.nom);
                        formSuperAdmin.ShowDialog();
                    } else
                    {
                        FormAdminOpciones formAdmin = new FormAdminOpciones(user.nom);
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

       
    }
}
