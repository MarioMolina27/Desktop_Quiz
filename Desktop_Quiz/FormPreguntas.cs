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
        public static BindingList<Pelicula> peliculaList = new BindingList<Pelicula>();
        public static BindingList<Pelicula> CAST_DIFICIL = new BindingList<Pelicula>();
        public static BindingList<Pelicula> CAST_FACIL =  new BindingList<Pelicula>();
        public static BindingList<Pelicula> CAST_MEDIANO = new BindingList<Pelicula>();
        public static BindingList<Pelicula> CAT_DIFICL = new BindingList<Pelicula>();
        public static BindingList<Pelicula> CAT_MEDIANO = new BindingList<Pelicula>();
        public static BindingList<Pelicula> CAT_FACIL = new  BindingList<Pelicula>();
        public static BindingList<Pelicula> ENG_DIFICIL=new BindingList<Pelicula>();
        public static BindingList<Pelicula> ENG_MEDIANO=new BindingList<Pelicula>();
        public static BindingList<Pelicula> ENG_FACIL=new BindingList<Pelicula>();
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
                CAT_DIFICL = jarrayCatD.ToObject<BindingList<Pelicula>>();

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
                String imgaudio = "";
                if (!string.IsNullOrEmpty(filaSeleccionada.Cells[8].Value.ToString())) {
                    imgaudio = filaSeleccionada.Cells[8].Value.ToString();
                }
                int dificultat = Int32.Parse(filaSeleccionada.Cells[9].Value.ToString());

                FormEditPreguntes p2 = new FormEditPreguntes(id,pelicula,pregunta,resposta1,resposta2,resposta3,resposta_correcte,categoria,imgaudio,dificultat);
                p2.ShowDialog();

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
    }
    }

