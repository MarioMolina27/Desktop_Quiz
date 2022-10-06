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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = textBoxNom.Text;
            String contrasenya = textBoxContrasenya.Text;

            if(nom.Equals("Super Admin") && contrasenya.Equals("1234"))
            {
                FormSAdimOpciones formSuperAdmin = new FormSAdimOpciones();
                formSuperAdmin.ShowDialog();
                this.Close();
            } else if (nom.Equals("Admin") && contrasenya.Equals("1234"))
            {
                FormAdminOpciones formAdmin = new FormAdminOpciones();
                formAdmin.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Usuari/Contrasenya incorrecte.");
            }
        }

        private void textBoxNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBoxContrasenya_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
