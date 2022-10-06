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
    public partial class FormEditPersonatges : Form
    {
        public FormEditPersonatges()
        {
            InitializeComponent();
        }

        private void buttonBuscarRutaImatgePersonatge_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            abrirImagen.InitialDirectory = Application.StartupPath; 
            abrirImagen.Filter = "Imagenes PNG (*.png)|*.png";

            if (abrirImagen.ShowDialog().Equals(DialogResult.OK))
            {
                textBoxRutaImatgeEditPersonatge.Text = abrirImagen.FileName;
            }

        }
    }
}
