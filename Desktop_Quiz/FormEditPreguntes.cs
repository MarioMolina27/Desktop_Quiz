using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    public partial class FormEditPreguntes : Form
    {
        public String id, pelicula, pregunta, resposta1, resposta2, resposta3, categoria, imgaudio;
        public int resposta_correcte, dificultat;
        public bool modificar;
        public Usuari usuari;

        public BindingList<Pelicula> peliculaList { get; set; }
        public BindingList<Pelicula> CAST_DIFICIL { get; set; }
        public BindingList<Pelicula> CAST_FACIL { get; set; }
        public BindingList<Pelicula> CAST_MEDIANO { get; set; }
        public BindingList<Pelicula> CAT_DIFICIL { get; set; }
        public BindingList<Pelicula> CAT_MEDIANO { get; set; }
        public BindingList<Pelicula> CAT_FACIL { get; set; }
        public BindingList<Pelicula> ENG_DIFICIL { get; set; }
        public BindingList<Pelicula> ENG_MEDIANO { get; set; }
        public BindingList<Pelicula> ENG_FACIL { get; set; }
        
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FormEditPreguntes()
        {
            InitializeComponent();
        }

        public FormEditPreguntes(BindingList<Pelicula> peliculaList, BindingList<Pelicula> CAST_DIFICIL, BindingList<Pelicula> CAST_MEDIANO,
                                BindingList<Pelicula> CAST_FACIL, BindingList<Pelicula> CAT_DIFICIL, BindingList<Pelicula> CAT_MEDIANO,
                                BindingList<Pelicula> CAT_FACIL, BindingList<Pelicula> ENG_DIFICIL, BindingList<Pelicula> ENG_MEDIANO,
                                BindingList<Pelicula> ENG_FACIL,Usuari u)
        {
            this.peliculaList = peliculaList;
            this.CAST_DIFICIL = CAST_DIFICIL;
            this.CAST_FACIL = CAST_FACIL;
            this.CAST_MEDIANO = CAST_MEDIANO;
            this.CAT_DIFICIL = CAT_DIFICIL;
            this.CAT_MEDIANO = CAT_MEDIANO;
            this.CAT_FACIL = CAT_FACIL;
            this.ENG_DIFICIL = ENG_DIFICIL;
            this.ENG_MEDIANO = ENG_MEDIANO;
            this.ENG_FACIL = ENG_FACIL;
            this.modificar = false;
            this.usuari = u;
            InitializeComponent();
        }

        public FormEditPreguntes(String id ,String pregunta, String resposta1, String resposta2, String resposta3, int resposta_correcte, String categoria, String imgaudio, int dificultat,
                                BindingList<Pelicula> peliculaList, BindingList<Pelicula> CAST_DIFICIL, BindingList<Pelicula> CAST_MEDIANO,
                                BindingList<Pelicula> CAST_FACIL, BindingList<Pelicula> CAT_DIFICIL, BindingList<Pelicula> CAT_MEDIANO,
                                BindingList<Pelicula> CAT_FACIL, BindingList<Pelicula> ENG_DIFICIL, BindingList<Pelicula> ENG_MEDIANO,
                                BindingList<Pelicula> ENG_FACIL, Usuari u)
        {
            this.id = id;
            this.pregunta = pregunta;
            this.resposta1 = resposta1;
            this.resposta2 = resposta2;
            this.resposta3 = resposta3;
            this.resposta_correcte = resposta_correcte;
            this.categoria = categoria;
            this.imgaudio = imgaudio;
            this.dificultat = dificultat;
            this.peliculaList = peliculaList;
            this.CAST_DIFICIL = CAST_DIFICIL;
            this.CAST_FACIL = CAST_FACIL;
            this.CAST_MEDIANO = CAST_MEDIANO;
            this.CAT_DIFICIL = CAT_DIFICIL;
            this.CAT_MEDIANO = CAT_MEDIANO;
            this.CAT_FACIL = CAT_FACIL;
            this.ENG_DIFICIL = ENG_DIFICIL;
            this.ENG_MEDIANO = ENG_MEDIANO;
            this.ENG_FACIL = ENG_FACIL;
            this.modificar = true;
            this.usuari = u;
            InitializeComponent();
        }
        /**
         * Event sobre el botò de buscar una imatge
         * Aquest obrirà un open file dialog que guardarà el nom d'una imatge seleccionada per l'usuari
         */
        private void buttonImatgeAceptar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult result = file.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                textBoxImatge.Text = Path.GetFileName(file.FileName); ;
            }
        }
        /**
         * Event sobre el botò de buscar un audio
         * Aquest obrirà un open file dialog que guardarà el nom d'un audio seleccionat per l'usuari
         */
        private void buttonAudioAceptar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult result = file.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                textBoxImatge.Text = Path.GetFileName(file.FileName); ;

            }
        }
        /**
         * Event sobre el botò de guardar la pregunta introduida
         * Aquest agafarà totes les dades introduides per l'usuari i el guardarà com una nova pregunta
         */
        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            eliminarElemento();
            String pregunta = textBoxPregunta.Text;
            String resposta1 = textBoxResposta1.Text;
            String resposta2 = textBoxResposta2.Text;
            String resposta3 = textBoxResposta3.Text;
            String categoria = comboBoxCategoria.Text;
            String idioma = comboBoxIdioma.Text;
            int dificultad;
            int resposta_correcte;
            bool resposta1Correcte = radioButtonResposta1.Checked;
            bool resposta2Correcte = radioButtonResposta2.Checked;
            bool resposta3Correcte = radioButtonResposta3.Checked;
            bool dificultat1 = radioButtonDificultat1.Checked;
            bool dificultat2 = radioButtonDificultat2.Checked;
            bool dificultat3 = radioButtonDificultat3.Checked;
            String audio = textBoxAudio.Text;
            String imatge = textBoxImatge.Text;
            String imgaudio = "";

            
            
            if (string.IsNullOrEmpty(imatge) && !string.IsNullOrEmpty(audio))
            {
                imgaudio = audio;
            }
            else if (!string.IsNullOrEmpty(imatge) && string.IsNullOrEmpty(audio))
            {
                imgaudio = imatge;
            }
            else if (string.IsNullOrEmpty(imatge) && string.IsNullOrEmpty(audio))
            {
                imgaudio = "";
            }
            else
            {
                MessageBox.Show("ERROR - NO ES POT TENIR UNA IMATGE I AUDIO EN LA PREGUNTA");
            }


            if (resposta1Correcte)
            {
                resposta_correcte = 1;
            }
            else if (resposta2Correcte)
            {
                resposta_correcte = 2;
            }
            else
            {
                resposta_correcte = 3;
            }

            if (dificultat1)
            {
                dificultad = 1;
            }
            else if (dificultat2)
            {
                dificultad = 2;
            }
            else
            {
                dificultad = 3;
            }

            /*
             * Segons l'idioma i la dificultat seleccionada per l'usuari l'asignarà un id a la pregunta i després 
             * el guardarà a la llista corresponent
             */
            String id;
            String txtId = "";
                if (idioma.Equals("Català") && dificultad == 1)
                {
                txtId = "CAT_F_";
                id = newID(txtId, peliculaList);
                this.CAT_FACIL.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
                else if (idioma.Equals("Català") && dificultad == 2)
                {
                txtId = "CAT_M_";
                id = newID(txtId, peliculaList);
                this.CAT_MEDIANO.Add(new Pelicula(id ,pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));

                }
                else if (idioma.Equals("Català") && dificultad == 3)
                {
                txtId = "CAT_D_";
                id = newID(txtId, peliculaList);
                this.CAT_DIFICIL.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
                else if (idioma.Equals("Castellano") && dificultad == 1)
                {
                txtId = "CAS_F_";
                id = newID(txtId, peliculaList);
                this.CAST_FACIL.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
                else if (idioma.Equals("Castellano") && dificultad == 2)
                {
                txtId = "CAS_M_";
                id = newID(txtId, peliculaList);
                this.CAST_MEDIANO.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
                else if (idioma.Equals("Castellano") && dificultad == 3)
                {
                txtId = "CAS_D_";
                id = newID(txtId, peliculaList);
                this.CAST_DIFICIL.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
                else if (idioma.Equals("English") && dificultad == 1)
                {
                txtId = "EN_F_";
                id = newID(txtId, peliculaList);
                this.ENG_FACIL.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
                else if (idioma.Equals("English") && dificultad == 2)
                {
                txtId = "EN_M_";
                id = newID(txtId, peliculaList);
                this.ENG_MEDIANO.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
                else if (idioma.Equals("English") && dificultad == 3)
                {
                txtId = "EN_D_";
                id = newID(txtId, peliculaList);
                this.ENG_DIFICIL.Add(new Pelicula(id, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
                }
           
            this.Close();
        }
        public void eliminarElemento()
        {
            String txtID = id.Substring(0, 5);
            int userPosition;
            switch (txtID)
            {
                case "CAT_F":
                    userPosition = FormPreguntas.retornarIndice(id, this.CAT_FACIL);
                    CAT_FACIL.RemoveAt(userPosition);
                    CAT_FACIL = FormPreguntas.UpdateIDs(txtID + "_", this.CAT_FACIL);
                    break;
                case "CAT_M":
                    userPosition = FormPreguntas.retornarIndice(id, this.CAT_MEDIANO);
                    CAT_MEDIANO.RemoveAt(userPosition);
                    CAT_MEDIANO = FormPreguntas.UpdateIDs(txtID + "_", this.CAT_MEDIANO);
                    break;
                case "CAT_D":
                    userPosition = FormPreguntas.retornarIndice(id, this.CAT_DIFICIL);
                    CAT_DIFICIL.RemoveAt(userPosition);
                    CAT_DIFICIL = FormPreguntas.UpdateIDs(txtID + "_", this.CAT_DIFICIL);
                    break;
                case "CAS_F":
                    userPosition = FormPreguntas.retornarIndice(id, this.CAST_FACIL);
                    CAST_FACIL.RemoveAt(userPosition);
                    CAST_FACIL = FormPreguntas.UpdateIDs(txtID + "_", this.CAST_FACIL);
                    break;
                case "CAS_M":
                    userPosition = FormPreguntas.retornarIndice(id, this.CAST_MEDIANO);
                    CAST_MEDIANO.RemoveAt(userPosition);
                    CAST_MEDIANO = FormPreguntas.UpdateIDs(txtID + "_", this.CAST_MEDIANO);
                    break;
                case "CAS_D":
                    userPosition = FormPreguntas.retornarIndice(id, this.CAST_DIFICIL);
                    CAST_DIFICIL.RemoveAt(userPosition);
                    CAST_DIFICIL = FormPreguntas.UpdateIDs(txtID + "_", this.CAST_DIFICIL);
                    break;
                case "EN_F_":
                    userPosition = FormPreguntas.retornarIndice(id, this.ENG_FACIL);
                    ENG_FACIL.RemoveAt(userPosition);
                    ENG_FACIL = FormPreguntas.UpdateIDs(txtID, this.ENG_FACIL);
                    break;
                case "EN_M_":
                    userPosition = FormPreguntas.retornarIndice(id, this.ENG_MEDIANO);
                    ENG_MEDIANO.RemoveAt(userPosition);
                    ENG_MEDIANO = FormPreguntas.UpdateIDs(txtID, this.ENG_MEDIANO);
                    break;
                case "EN_D_":
                    userPosition = FormPreguntas.retornarIndice(id, this.ENG_DIFICIL);
                    ENG_DIFICIL.RemoveAt(userPosition);
                    ENG_DIFICIL = FormPreguntas.UpdateIDs(txtID, this.ENG_DIFICIL);
                    break;

            }
        }

        /**
         * Event que es crida quan es crida al formulari
         * Omplirà totes les caselles en cas de que l'estiguem enviant una pregunta
         */
        private void FormEditPreguntes_Load(object sender, EventArgs e)
        {
            String txtID = "";
        
            textBoxPregunta.Text = pregunta;
            textBoxResposta1.Text = resposta1;
            textBoxResposta2.Text = resposta2;
            textBoxResposta3.Text = resposta3;
            switch (categoria)
            {
                case "Acción":
                    comboBoxCategoria.SelectedIndex = 0;
                    break;
                case "Animación":
                    comboBoxCategoria.SelectedIndex = 1;
                    break;
                case "Ciencia Ficción":
                    comboBoxCategoria.SelectedIndex = 2;
                    break;
                case "Drama":
                    comboBoxCategoria.SelectedIndex = 3;
                    break;
                case "Terror":
                    comboBoxCategoria.SelectedIndex = 4;
                    break;
            }

             
            if (!String.IsNullOrEmpty(id) ){
                txtID = id.Substring(0,3);
                switch (txtID)
                {
                    case "CAT":
                        comboBoxIdioma.SelectedIndex = 0;
                        break;
                    case "CAS":
                        comboBoxIdioma.SelectedIndex = 1;
                        break;
                    case "EN_":
                        comboBoxIdioma.SelectedIndex = 2;
                        break;
                }
            }

            switch (resposta_correcte)
            {
                case 1:
                    radioButtonResposta1.Checked = true;
                    break;
                case 2:
                    radioButtonResposta2.Checked = true;
                    break;
                case 3:
                    radioButtonResposta3.Checked = true;
                    break;
            }
            switch (dificultat)
            {
                case 1:
                    radioButtonDificultat1.Checked = true;
                    break;
                case 2:
                    radioButtonDificultat2.Checked = true;
                    break;
                case 3:
                    radioButtonDificultat3.Checked = true;
                    break;
            }
        }

        /**
         * Funció que crearà un nou id que correspón a la nova ultima posició d'una pregunta en una llista
         * Primerament agafarà el numero de pregunta de l'ultima posició (treient l'identificador d'idoma i dificultat) 
         * li sumarà 1 i li tornarà a agregar l'identificador d'idioma i dificultat
         */
        public static String newID(String txtID,BindingList<Pelicula>peliculaList)
        {
            int lastObject = peliculaList.Count - 1;
            String id = peliculaList[lastObject].id;
            String b = string.Empty;
            int num = 0;
            String newId;

            for (int i = 0; i < id.Length; i++)
            {
                if (char.IsDigit(id[i]))
                {
                    b += id[i];
                }

            }

            if (b.Length > 0)
            {
                num = int.Parse(b);
            }

            num += 1;

            if (num < 10)
            {
                newId = txtID + "00" + num;
            }
            else if (num < 100)
            {
                newId = txtID + "0" + num;
            }
            else
            {
                newId = txtID + num;
            }
           return newId;
        }
    }
}
