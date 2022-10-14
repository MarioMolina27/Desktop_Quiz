using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    public partial class FormUsuaris : Form
    {

        List<Usuari> usuaris;


        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void textBoxNickSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "  Buscar...")
            {
                textBoxNickSearch.ForeColor = Color.Black;
                textBoxNickSearch.Text = "";
            }
        }

        private void textBoxNickSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxNickSearch.Text == "")
            {
                textBoxNickSearch.ForeColor = Color.Gray;
                textBoxNickSearch.Text = "  Buscar...";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormEditUsuaris editUsuaris1 = new FormEditUsuaris();
            editUsuaris1.ShowDialog();
        }

        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            JArray arrayUsers = JArray.Parse(File.ReadAllText(@"..\..\JSON\USUARIS.json"));
            usuaris = arrayUsers.ToObject<List<Usuari>>();
            


            
            dataGridUsuaris1.DataSource = null;
            dataGridUsuaris1.DataSource = usuaris;   


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditUsuaris editUsuaris1 = new FormEditUsuaris();
            editUsuaris1.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
