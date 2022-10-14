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
namespace Desktop_Quiz
{
    public partial class FormPreguntas : Form
    {
        public static BindingList<Pelicula> peliculaList  { get; set; }
        public static BindingList<Pelicula> CAST_DIFICIL { get; set; }
        public static BindingList<Pelicula> CAST_FACIL { get; set; }
        public static BindingList<Pelicula> CAST_MEDIANO { get; set; }
        public static BindingList<Pelicula> CAT_DIFICIL { get; set; }
        public static BindingList<Pelicula> CAT_MEDIANO { get; set; }
        public static BindingList<Pelicula> CAT_FACIL { get; set; }
        public static BindingList<Pelicula> ENG_DIFICIL { get; set; }
        public static BindingList<Pelicula> ENG_MEDIANO { get; set; }
        public static BindingList<Pelicula> ENG_FACIL { get; set; }
    public FormPreguntas()
        {
            InitializeComponent();
        }

        private void FormPreguntas_Load(object sender, EventArgs e)
        {
                JArray jarrayCastD = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_DIFICIL.json", Encoding.UTF8));
                CAST_DIFICIL = jarrayCastD.ToObject<BindingList<Pelicula>>();

                JArray jarrayCastF = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_FACIL.json", Encoding.UTF8));
                 CAST_FACIL = jarrayCastF.ToObject<BindingList<Pelicula>>();

                JArray jarrayCastM = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_MEDIANO.json", Encoding.UTF8));
                CAST_MEDIANO = jarrayCastM.ToObject<BindingList<Pelicula>>();

                JArray jarrayCatD = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_DIFICIL.json", Encoding.UTF8));
                CAT_DIFICIL = jarrayCatD.ToObject<BindingList<Pelicula>>();

                JArray jarrayCatM = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_MEDIANO.json", Encoding.UTF8));
                CAT_MEDIANO = jarrayCatM.ToObject<BindingList<Pelicula>>();

                JArray jarrayCatF = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_FACIL.json", Encoding.UTF8));
                CAT_FACIL = jarrayCatF.ToObject<BindingList<Pelicula>>();

                JArray jarrayEngD = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_DIFICIL.json", Encoding.UTF8));
                ENG_DIFICIL = jarrayEngD.ToObject<BindingList<Pelicula>>();

                JArray jarrayEngM = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_MEDIANO.json", Encoding.UTF8));
                ENG_MEDIANO = jarrayEngM.ToObject<BindingList<Pelicula>>();

                JArray jarrayEngF = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_FACIL.json", Encoding.UTF8));
                ENG_FACIL =  jarrayEngF.ToObject<BindingList<Pelicula>>();

                updateList();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            FormEditPreguntes p = new FormEditPreguntes();
            p.ShowDialog();
            updateList();
        }
        public void updateList()
        {
            BindingList<Pelicula> carga = new BindingList<Pelicula>();
            
            peliculaList.Clear();
            for (int json = 0; json < 8; json++)
            {
                switch (json)
                {
                    case 0:
                        carga = CAST_DIFICIL;
                        break;
                    case 1:
                        carga = CAST_FACIL;
                        break;
                    case 2:
                        carga = CAST_MEDIANO;
                        break;
                    case 3:
                        carga = CAT_FACIL;
                        break;
                    case 4:
                        carga = CAT_MEDIANO;
                        break;
                    case 5:
                        carga = ENG_FACIL;
                        break;
                    case 6:
                        carga = ENG_MEDIANO;
                        break;
                    case 7:
                        carga = ENG_DIFICIL;
                        break;
                }
                foreach (var item in carga)
                {
                    peliculaList.Add(item);
                }
            }

            updateDataGrid();
          

        }

        public void updateDataGrid()
        {
            dataGridViewPelicules.DataSource = null;
            dataGridViewPelicules.DataSource = peliculaList;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int rowIndex = conseguirRowIndex();
            if (rowIndex != -1)
            {
                DataGridViewRow filaSeleccionada = dataGridViewPelicules.Rows[rowIndex];
                String id = filaSeleccionada.Cells[0].Value.ToString();
                String pelicula = filaSeleccionada.Cells[1].Value.ToString();
                String pregunta = filaSeleccionada.Cells[2].Value.ToString();
                String resposta1 = filaSeleccionada.Cells[3].Value.ToString();
                String resposta2 = filaSeleccionada.Cells[4].Value.ToString();
                String resposta3 = filaSeleccionada.Cells[5].Value.ToString();
                int resposta_correcte = Int32.Parse(filaSeleccionada.Cells[6].Value.ToString());
                String categoria = filaSeleccionada.Cells[7].Value.ToString();
                //REVISAR CUANDO SE TENGAN EJEMPLOS PRACTICOS
                String imgaudio = filaSeleccionada.Cells[8].Value?.ToString();
                
                int dificultat = Int32.Parse(filaSeleccionada.Cells[9].Value.ToString());

                FormEditPreguntes p2 = new FormEditPreguntes(id,pelicula,pregunta,resposta1,resposta2,resposta3,resposta_correcte,categoria,imgaudio,dificultat);
                p2.ShowDialog();

            }
            else
            {
                MessageBox.Show("No has elegit cap pregunta per modificar-la");
            }
        }
        private int conseguirRowIndex()
        {
            int rowIndex = dataGridViewPelicules.CurrentCell.RowIndex;
            return rowIndex;
        }

        private void radioButtonCategoria_CheckedChanged(object sender, EventArgs e)
        {
 
            dataGridViewPelicules.Sort(dataGridViewPelicules.Columns[7], ListSortDirection.Ascending);
        }

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

            }
            else
            {
                MessageBox.Show("No has elegit cap pregunta per eliminar-la");
            }
        }
        private void eliminarElemento(String id)
        {
            String txtID = obtenerTxtID(id);
            int userPosition;
            switch (txtID)
            {
                case "CAT_F":
                    userPosition = retornarIndice(id,CAT_FACIL);
                    CAT_FACIL.RemoveAt(userPosition);
                    CAT_FACIL = UpdateIDs(txtID + "_", CAT_FACIL);
                    break;
                case "CAT_M":
                    userPosition = retornarIndice(id,CAT_MEDIANO);
                    CAT_MEDIANO.RemoveAt(userPosition);
                    CAT_MEDIANO = UpdateIDs(txtID + "_", CAT_MEDIANO);
                    break;
                case "CAT_D":
                    userPosition = retornarIndice(id,CAT_DIFICIL);
                    CAT_DIFICIL.RemoveAt(userPosition);
                    CAT_DIFICIL = UpdateIDs(txtID+"_", CAT_DIFICIL);
                    break;
                case "CAS_F":
                    userPosition = retornarIndice(id,CAST_FACIL);
                    CAST_FACIL.RemoveAt(userPosition);
                    CAST_FACIL=UpdateIDs(txtID + "_", CAST_FACIL);
                    break;
                case "CAS_M":
                    userPosition = retornarIndice(id,CAST_MEDIANO);
                    CAST_MEDIANO.RemoveAt(userPosition);
                    CAST_MEDIANO=UpdateIDs(txtID + "_", CAST_MEDIANO);
                    break;
                case "CAS_D":
                    userPosition = retornarIndice(id,CAST_DIFICIL);
                    
                    CAST_DIFICIL.RemoveAt(userPosition);
                    CAST_DIFICIL = UpdateIDs(txtID + "_", CAST_DIFICIL);

                    break;
                case "EN_F_":
                    userPosition = retornarIndice(id,ENG_FACIL);
                    ENG_FACIL.RemoveAt(userPosition);
                    ENG_FACIL= UpdateIDs(txtID,ENG_FACIL);
                    break;
                case "EN_M_":
                    userPosition = retornarIndice(id,ENG_MEDIANO);
                    ENG_MEDIANO.RemoveAt(userPosition);
                    ENG_MEDIANO= UpdateIDs(txtID,ENG_MEDIANO);
                    break;
                case "EN_D_":
                    userPosition = retornarIndice(id,ENG_DIFICIL);
                    ENG_DIFICIL.RemoveAt(userPosition);
                    ENG_DIFICIL=UpdateIDs(txtID,ENG_DIFICIL);
                    break;

            }
            updateList();
            updateDataGrid();
        }

        public static string obtenerTxtID(String id)
        {
            String txtID;
            txtID = id.Substring(0, 5);
            return txtID;
        }
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
        
    }
}

