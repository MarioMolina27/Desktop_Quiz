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
    }
}
