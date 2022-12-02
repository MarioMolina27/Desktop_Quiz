using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Desktop_Quiz
{
    public partial class FormPreguntas : Form
    {
        public  BindingList<Pelicula> peliculaList { get; set; }
        public  BindingList<Pelicula> CASTELLANO { get; set; }
        public  BindingList<Pelicula> CATALA { get; set; }
        public  BindingList<Pelicula> ENGLISH { get; set; }
        public  BindingList<Pelicula> CAST_DIFICIL { get; set; }
        public  BindingList<Pelicula> CAST_FACIL  { get; set; }
        public  BindingList<Pelicula> CAST_MEDIANO { get; set; }
        public  BindingList<Pelicula> CAT_DIFICIL { get; set; }
        public  BindingList<Pelicula> CAT_MEDIANO { get; set; }
        public  BindingList<Pelicula> CAT_FACIL { get; set; }
        public  BindingList<Pelicula> ENG_DIFICIL { get; set; }
        public BindingList<Pelicula> ENG_MEDIANO { get; set; }
        public  BindingList<Pelicula> ENG_FACIL { get; set; }

        private const String RUTAJSON_CAT_F = @"..\..\JSON\CATALA_FACIL.json";
        private const String RUTAJSON_CAT_M = @"..\..\JSON\CATALA_MEDIANO.json";
        private const String RUTAJSON_CAT_D = @"..\..\JSON\CATALA_DIFICIL.json";
        private const String RUTAJSON_CAST_F = @"..\..\JSON\CASTELLANO_FACIL.json";
        private const String RUTAJSON_CAST_M = @"..\..\JSON\CASTELLANO_MEDIANO.json";
        private const String RUTAJSON_CAST_D = @"..\..\JSON\CASTELLANO_DIFICIL.json";
        private const String RUTAJSON_ENG_F = @"..\..\JSON\ENGLISH_FACIL.json";
        private const String RUTAJSON_ENG_M = @"..\..\JSON\ENGLISH_MEDIANO.json";
        private const String RUTAJSON_ENG_D = @"..\..\JSON\ENGLISH_DIFICIL.json";


        public Usuari usuari { get; set; }

        public FormPreguntas(Usuari u)
        {
            InitializeComponent();
            JArray jarrayCastD = JArray.Parse(File.ReadAllText(RUTAJSON_CAST_D, Encoding.UTF8));
            this.CAST_DIFICIL = jarrayCastD.ToObject<BindingList<Pelicula>>();

            JArray jarrayCastF = JArray.Parse(File.ReadAllText(RUTAJSON_CAST_F, Encoding.UTF8));
            this.CAST_FACIL = jarrayCastF.ToObject<BindingList<Pelicula>>();

            JArray jarrayCastM = JArray.Parse(File.ReadAllText(RUTAJSON_CAST_M, Encoding.UTF8));
            this.CAST_MEDIANO = jarrayCastM.ToObject<BindingList<Pelicula>>();

            JArray jarrayCatD = JArray.Parse(File.ReadAllText(RUTAJSON_CAT_D, Encoding.UTF8));
            this.CAT_DIFICIL = jarrayCatD.ToObject<BindingList<Pelicula>>();

            JArray jarrayCatM = JArray.Parse(File.ReadAllText(RUTAJSON_CAT_M, Encoding.UTF8));
            this.CAT_MEDIANO = jarrayCatM.ToObject<BindingList<Pelicula>>();

            JArray jarrayCatF = JArray.Parse(File.ReadAllText(RUTAJSON_CAT_F, Encoding.UTF8));
            this.CAT_FACIL = jarrayCatF.ToObject<BindingList<Pelicula>>();

            JArray jarrayEngD = JArray.Parse(File.ReadAllText(RUTAJSON_ENG_D, Encoding.UTF8));
            this.ENG_DIFICIL = jarrayEngD.ToObject<BindingList<Pelicula>>();

            JArray jarrayEngM = JArray.Parse(File.ReadAllText(RUTAJSON_ENG_M, Encoding.UTF8));
            this.ENG_MEDIANO = jarrayEngM.ToObject<BindingList<Pelicula>>();

            JArray jarrayEngF = JArray.Parse(File.ReadAllText(RUTAJSON_ENG_F, Encoding.UTF8));
            this.ENG_FACIL = jarrayEngF.ToObject<BindingList<Pelicula>>();

            this.peliculaList = new BindingList<Pelicula>();
            this.CASTELLANO = new BindingList<Pelicula>();
            this.CATALA = new BindingList<Pelicula>();
            this.ENGLISH = new BindingList<Pelicula>();
            this.usuari = u;
        }

        public FormPreguntas(BindingList<Pelicula> peliculaList, BindingList<Pelicula> cAST_DIFICIL, BindingList<Pelicula> cAST_FACIL, BindingList<Pelicula> cAST_MEDIANO, BindingList<Pelicula> cAT_DIFICIL, BindingList<Pelicula> cAT_MEDIANO, BindingList<Pelicula> cAT_FACIL, BindingList<Pelicula> eNG_DIFICIL, BindingList<Pelicula> eNG_MEDIANO, BindingList<Pelicula> eNG_FACIL,Usuari u)
        {
            this.peliculaList = peliculaList;
            this.CAST_DIFICIL = cAST_DIFICIL;
            this.CAST_FACIL = cAST_FACIL;
            this.CAST_MEDIANO = cAST_MEDIANO;
            this.CAT_DIFICIL = cAT_DIFICIL;
            this.CAT_MEDIANO = cAT_MEDIANO;
            this.CAT_FACIL = cAT_FACIL;
            this.ENG_DIFICIL = eNG_DIFICIL;
            this.ENG_MEDIANO = eNG_MEDIANO;
            this.ENG_FACIL = eNG_FACIL;
            this.usuari = u;
        }
        /**
         * Event Load
         * Mostrarà o no mostrarà les diferents funcions depenent dels permisos de l'usuari 
         * actual (editar, modificar , eliminar)
         */
        private void FormPreguntas_Load(object sender, EventArgs e)
        {
            updateListAllLanguages();
            updateDataGrid();
            if (usuari.add)
            {
                buttonAfegir.Visible = true;
            }
            else if (!usuari.add)
            {
                buttonAfegir.Visible = false;
            }

            if (usuari.delete)
            {
                buttonEliminar.Visible = true;
            }
            else if (!usuari.delete)
            {
                buttonEliminar.Visible = false;
            }

            if (usuari.modify)
            {
                buttonModificar.Visible = true;
            }
            else if (!usuari.modify)
            {
                buttonModificar.Visible = false;
            }
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            FormEditPreguntes p = new FormEditPreguntes(peliculaList, CAST_DIFICIL, CAST_MEDIANO,
                                 CAST_FACIL, CAT_DIFICIL, CAT_MEDIANO,
                                 CAT_FACIL, ENG_DIFICIL, ENG_MEDIANO,
                                ENG_FACIL,this.usuari);
            p.ShowDialog();
            updateListAllLanguages();
            guardarJSON();
        }

        /**
         * Funció que ajunta totes les llistes de preguntes en una sola per mostrar-la per pantalla
         */
        public void updateListAllLanguages()
        {
            BindingList<Pelicula> carga = new BindingList<Pelicula>();
            
            this.peliculaList.Clear();
            for (int json = 0; json < 8; json++)
            {
                switch (json)
                {
                    case 0:
                        carga = this.CAST_DIFICIL;
                        break;
                    case 1:
                        carga = this.CAST_FACIL;
                        break;
                    case 2:
                        carga = this.CAST_MEDIANO;
                        break;
                    case 3:
                        carga = this.CAT_FACIL;
                        break;
                    case 4:
                        carga = this.CAT_MEDIANO;
                        break;
                    case 5:
                        carga = this.ENG_FACIL;
                        break;
                    case 6:
                        carga = this.ENG_MEDIANO;
                        break;
                    case 7:
                        carga = this.ENG_DIFICIL;
                        break;
                }
                foreach (var item in carga)
                {
                    this.peliculaList.Add(item);
                }
            }
            ordenarList();
            updateListCAS();
            updateListCAT();
            updateListENG();
            updateDataGrid();
          
        }
        /**
         * Funció que junta totes les llistes que continguin preguntes en Castellà
         */
        public void updateListCAS() 
        {
            this.CASTELLANO.Clear();
            BindingList<Pelicula> carga = new BindingList<Pelicula>();
            for (int json = 0; json < 3; json++)
            {
                switch (json)
                {
                    case 0:
                        carga = this.CAST_DIFICIL;
                        break;
                    case 1:
                        carga = this.CAST_FACIL;
                        break;
                    case 2:
                        carga = this.CAST_MEDIANO;
                        break;
                }
                foreach (var item in carga)
                {
                    this.CASTELLANO.Add(item);
                }
            }
        }
        /**
       * Funció que junta totes les llistes que continguin preguntes en Català
       */
        public void updateListCAT()
        {
            this.CATALA.Clear(); ;
            BindingList<Pelicula> carga = new BindingList<Pelicula>();
            for (int json = 0; json < 3; json++)
            {
                switch (json)
                {
                    case 0:
                        carga = this.CAT_DIFICIL;
                        break;
                    case 1:
                        carga = this.CAT_FACIL;
                        break;
                    case 2:
                        carga = this.CAT_MEDIANO;
                        break;
                }
                foreach (var item in carga)
                {
                    this.CATALA.Add(item);
                }
            }
        }
        /**
       * Funció que junta totes les llistes que continguin preguntes en Anglès
       */
        public void updateListENG()
        {
            this.ENGLISH.Clear();
            BindingList<Pelicula> carga = new BindingList<Pelicula>();
            for (int json = 0; json < 3; json++)
            {
                switch (json)
                {
                    case 0:
                        carga = this.ENG_DIFICIL;
                        break;
                    case 1:
                        carga = this.ENG_FACIL;
                        break;
                    case 2:
                        carga = this.ENG_MEDIANO;
                        break;
                }
                foreach (var item in carga)
                {
                    this.ENGLISH.Add(item);
                }
            }
        }

        public void updateDataGrid()
        {
            dataGridViewPelicules.DataSource = null;
            dataGridViewPelicules.DataSource = this.peliculaList;
        }
        public void ordenarList()
        {
            peliculaList = new BindingList<Pelicula>(peliculaList.OrderBy(p => p.id).ToList());
        }
        /**
         * Event a sobre del botò de modificar que agafa totes les dades de la pregunta seleccionada del dataGrid
         * i les envia a la pantalla de creació i modificació de preguntes.
         * Eliminarà la pregunta seleccionada i després en el formulari de modificació es guardarà la pregunta modificada
         */
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int rowIndex = conseguirRowIndex();
            if (rowIndex != -1)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPelicules.Rows[rowIndex];
                String id = filaSeleccionada.Cells[0].Value.ToString();
                String pregunta = filaSeleccionada.Cells[1].Value.ToString();
                String resposta1 = filaSeleccionada.Cells[2].Value.ToString();
                String resposta2 = filaSeleccionada.Cells[3].Value.ToString();
                String resposta3 = filaSeleccionada.Cells[4].Value.ToString();
                int resposta_correcte = Int32.Parse(filaSeleccionada.Cells[5].Value.ToString());
                String categoria = filaSeleccionada.Cells[6].Value.ToString();
                String imgaudio = filaSeleccionada.Cells[7].Value?.ToString();
                
                int dificultat = Int32.Parse(filaSeleccionada.Cells[8].Value.ToString());

                FormEditPreguntes p2 = new FormEditPreguntes(id, pregunta,resposta1, resposta2,resposta3, resposta_correcte, categoria, imgaudio, dificultat,
                                peliculaList,CAST_DIFICIL,CAST_MEDIANO,
                                 CAST_FACIL, CAT_DIFICIL, CAT_MEDIANO,
                                 CAT_FACIL, ENG_DIFICIL,  ENG_MEDIANO,
                                ENG_FACIL,this.usuari);
                eliminarElemento(id);
                p2.ShowDialog();
                updateDataGrid();
                updateListAllLanguages();
                guardarJSON();
            }
            else
            {
                MessageBox.Show("No has elegit cap pregunta per modificar-la");
            }
        }
        /**
         * Funció que agafa l'index de la fila seleccionada del dataGrid
         */
        private int conseguirRowIndex()
        {
            int rowIndex = dataGridViewPelicules.CurrentCell.RowIndex;
            return rowIndex;
        }
        /**
         * Event sobre el botò d'eliminar que amb un index d'una fila seleccionada agafa l'id de la pregunta i l'elimina de totes les llistes 
         * i guarda les noves llistes en jsons
         */
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int rowIndex = conseguirRowIndex();
            if (rowIndex != -1)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPelicules.Rows[rowIndex];
                String id = filaSeleccionada.Cells[0].Value.ToString();        
               
                if (!String.IsNullOrEmpty(id))
                {
                    eliminarElemento(id);
                }
                guardarJSON();
            }
            else
            {
                MessageBox.Show("No has elegit cap pregunta per eliminar-la");
            }
        }
        /**
         * Funció que busca a totes les llistes l'id que nosaltres l'indiquem i el borrà on estigui
         */
        private void eliminarElemento(String id)
        {
           
                String txtID = obtenerTxtID(id);
                int userPosition;
                switch (txtID)
                {
                    case "CAT_F":
                        userPosition = retornarIndice(id, this.CAT_FACIL);
                        CAT_FACIL.RemoveAt(userPosition);
                         CAT_FACIL = UpdateIDs(txtID + "_", this.CAT_FACIL); 
                        break;
                    case "CAT_M":
                        userPosition = retornarIndice(id, this.CAT_MEDIANO);
                        CAT_MEDIANO.RemoveAt(userPosition);
                         CAT_MEDIANO = UpdateIDs(txtID + "_", this.CAT_MEDIANO); 
                        break;
                    case "CAT_D":
                        userPosition = retornarIndice(id, this.CAT_DIFICIL);
                        CAT_DIFICIL.RemoveAt(userPosition);
                         CAT_DIFICIL = UpdateIDs(txtID + "_", this.CAT_DIFICIL); 
                        break;
                    case "CAS_F":
                        userPosition = retornarIndice(id, this.CAST_FACIL);
                        CAST_FACIL.RemoveAt(userPosition);
                         CAST_FACIL = UpdateIDs(txtID + "_", this.CAST_FACIL); 
                        break;
                    case "CAS_M":
                        userPosition = retornarIndice(id, this.CAST_MEDIANO);
                        CAST_MEDIANO.RemoveAt(userPosition);
                        CAST_MEDIANO = UpdateIDs(txtID + "_", this.CAST_MEDIANO); 
                        break;
                    case "CAS_D":
                        userPosition = retornarIndice(id, this.CAST_DIFICIL);
                        CAST_DIFICIL.RemoveAt(userPosition);
                         CAST_DIFICIL = UpdateIDs(txtID + "_", this.CAST_DIFICIL); 
                        break;
                    case "EN_F_":
                        userPosition = retornarIndice(id, this.ENG_FACIL);
                        ENG_FACIL.RemoveAt(userPosition);
                         ENG_FACIL = UpdateIDs(txtID, this.ENG_FACIL); 
                        break;
                    case "EN_M_":
                        userPosition = retornarIndice(id, this.ENG_MEDIANO);
                        ENG_MEDIANO.RemoveAt(userPosition);
                         ENG_MEDIANO = UpdateIDs(txtID, this.ENG_MEDIANO); 
                        break;
                    case "EN_D_":
                        userPosition = retornarIndice(id, this.ENG_DIFICIL);
                        ENG_DIFICIL.RemoveAt(userPosition);
                        ENG_DIFICIL = UpdateIDs(txtID, this.ENG_DIFICIL); 
                        break;

                }
            updateListAllLanguages();
            updateDataGrid();
        }
        /**
         * Funció que retorna la primera part del id (la qual indica el seu idioma i dificultat)
         */
        public static string obtenerTxtID(String id)
        {
            String txtID;
            txtID = id.Substring(0, 5);
            return txtID;
        }
        /**
         * Funció que busca un id en una llista i retorna el seu index en aquesta llista
         */
        public static int retornarIndice(String id,BindingList<Pelicula>lista)
        {
            int userPosition = -1;
            for (int i = 0; i < lista.Count(); i++)
            {
                if (id.Equals(lista[i].id))
                {
                    userPosition = i;
                }
            }
            return userPosition;
        }
        /**
         * Funció que asigna un nou id a totes les preguntes d'una llista
         */
        private static BindingList<Pelicula> UpdateIDs(String txtID,BindingList<Pelicula> lista)
        {
            int num = 1;
            for (int i = 0; i < lista.Count; i++)
            {
                
                if (num < 10)
                {
                    lista[i].id =txtID + "00" + num;
                }
                else if (num < 100)
                {
                    lista[i].id = txtID + "0" + num;
                }
                else
                {
                    lista[i].id = txtID + num;
                }
                num++;
            }
            return lista;
        }

        private void radioButtonDificultat_CheckedChanged(object sender, EventArgs e)
        {
            ordenar();
        }
       
        private void radioButtonCategoria_CheckedChanged(object sender, EventArgs e)
        {
            ordenar();
        }

        private void radioButtonIdiomesTots_CheckedChanged(object sender, EventArgs e)
        {
            updateListAllLanguages();
        }

        private void radioButtonCatala_CheckedChanged(object sender, EventArgs e)
        {
            ordenar();
        }

        private void radioButtonCastellano_CheckedChanged(object sender, EventArgs e)
        {
            ordenar();

        }

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            ordenar();
        }
        /**
         * Funció que ordenarà la llista segons l'idioma seleccionat per mostrar i les condicions d'ordenació seleccionades
         */
        public void ordenar()
        {
            if (radioButtonCatala.Checked)
            {
                if (radioButtonDificultat.Checked)
                {
                    CATALA = new BindingList<Pelicula>(CATALA.OrderBy(p => p.dificultad).ToList());
                    dataGridViewPelicules.DataSource = null;
                    dataGridViewPelicules.DataSource = this.CATALA;
                }
                else if (radioButtonCategoria.Checked)
                {
                    CATALA = new BindingList<Pelicula>(CATALA.OrderBy(p => p.categoria).ToList());
                    dataGridViewPelicules.DataSource = null;
                    dataGridViewPelicules.DataSource = this.CATALA;
                }
            }

            else if (radioButtonCastellano.Checked)
            {
                if (radioButtonDificultat.Checked)
                {
                    CASTELLANO = new BindingList<Pelicula>(CASTELLANO.OrderBy(p => p.dificultad).ToList());
                    dataGridViewPelicules.DataSource = null;
                    dataGridViewPelicules.DataSource = this.CASTELLANO;
                }
                else if (radioButtonCategoria.Checked)
                {
                    CASTELLANO = new BindingList<Pelicula>(CASTELLANO.OrderBy(p => p.categoria).ToList());
                    dataGridViewPelicules.DataSource = null;
                    dataGridViewPelicules.DataSource = this.CASTELLANO;
                }
            }
            else if (radioButtonEnglish.Checked)
            {
                if (radioButtonDificultat.Checked)
                {
                    ENGLISH = new BindingList<Pelicula>(ENGLISH.OrderBy(p => p.dificultad).ToList());
                    dataGridViewPelicules.DataSource = null;
                    dataGridViewPelicules.DataSource = this.ENGLISH;
                }
                else if (radioButtonCategoria.Checked)
                {
                    ENGLISH = new BindingList<Pelicula>(ENGLISH.OrderBy(p => p.categoria).ToList());
                    dataGridViewPelicules.DataSource = null;
                    dataGridViewPelicules.DataSource = this.ENGLISH;
                }
            }
            else
            {
                peliculaList = new BindingList<Pelicula>(peliculaList.OrderBy(p => p.dificultad).ToList());
                updateDataGrid();
            }
        }

        private void textBoxTitulo_Leave(object sender, EventArgs e)
        {
            if (textBoxTitulo.Text.Equals(""))
            {
                textBoxTitulo.Text = "  Buscar...";
                textBoxTitulo.ForeColor = Color.Gray;
            }
        }

        private void textBoxTitulo_Enter(object sender, EventArgs e)
        {
            if (textBoxTitulo.Text.Equals("  Buscar..."))
            {
                textBoxTitulo.Text = "";
                textBoxTitulo.ForeColor = Color.Black;
            }
        }
        /**
         * Funció que guardarà totes les llistes del programa en jsons
         */
        private void guardarJSON()
        {
            String jsonCAT_F = JsonConvert.SerializeObject(this.CAT_FACIL, Formatting.Indented);
            String jsonCAT_M = JsonConvert.SerializeObject(this.CAT_MEDIANO, Formatting.Indented);
            String jsonCAT_D = JsonConvert.SerializeObject(this.CAT_DIFICIL, Formatting.Indented);

            File.WriteAllText(RUTAJSON_CAT_F, jsonCAT_F);
            File.WriteAllText(RUTAJSON_CAT_M, jsonCAT_M);
            File.WriteAllText(RUTAJSON_CAT_D, jsonCAT_D);

            String jsonCAST_F = JsonConvert.SerializeObject(this.CAST_FACIL, Formatting.Indented);
            String jsonCAST_M = JsonConvert.SerializeObject(this.CAST_MEDIANO, Formatting.Indented);
            String jsonCAST_D = JsonConvert.SerializeObject(this.CAST_DIFICIL, Formatting.Indented);

            File.WriteAllText(RUTAJSON_CAST_F, jsonCAST_F);
            File.WriteAllText(RUTAJSON_CAST_M, jsonCAST_M);
            File.WriteAllText(RUTAJSON_CAST_D, jsonCAST_D);

            String jsonENG_F = JsonConvert.SerializeObject(this.ENG_FACIL, Formatting.Indented);
            String jsonENG_M = JsonConvert.SerializeObject(this.ENG_MEDIANO, Formatting.Indented);
            String jsonENG_D = JsonConvert.SerializeObject(this.ENG_DIFICIL, Formatting.Indented);

            File.WriteAllText(RUTAJSON_ENG_F, jsonENG_F);
            File.WriteAllText(RUTAJSON_ENG_M, jsonENG_M);
            File.WriteAllText(RUTAJSON_ENG_D, jsonENG_D);
        }
        /**
         * Event a sobre de la tecla Enter que buscarà un titol d'una pelicula a totes les llistes i mostrarà 
         * totes les preguntes que tinguin coincidència
         */
        private void textBoxTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Pelicula> llistaFiltre = new List<Pelicula>();
                String titulo = textBoxTitulo.Text;

                foreach (Pelicula p in peliculaList)
                {
                    if (p.pregunta.Contains(titulo))
                    {
                        llistaFiltre.Add(p);
                    }

                }
                if (llistaFiltre.Count > 0)
                {
                    dataGridViewPelicules.DataSource = null;
                    dataGridViewPelicules.DataSource = llistaFiltre;
                }
                else
                {
                    MessageBox.Show("No s'han trobat resultats");
                    updateDataGrid();
                }
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

