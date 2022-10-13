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
        public static List<Pelicula> peliculaList = new List<Pelicula>();
        public static List<Pelicula> CAST_DIFICIL = new List<Pelicula>();
        public static List<Pelicula> CAST_FACIL =  new List<Pelicula>();
        public static List<Pelicula> CAST_MEDIANO = new List<Pelicula>();
        public static List<Pelicula> CAT_DIFICL = new List<Pelicula>();
        public static List<Pelicula> CAT_MEDIANO = new List<Pelicula>();
        public static List<Pelicula> CAT_FACIL = new List<Pelicula>();
        public static List<Pelicula> ENG_DIFICIL=new List<Pelicula>();
        public static List<Pelicula> ENG_MEDIANO=new List<Pelicula>();
        public static List<Pelicula> ENG_FACIL=new List<Pelicula>();
        public FormPreguntas()
        {
            InitializeComponent();
        }

        private void FormPreguntas_Load(object sender, EventArgs e)
        {
                JArray jarrayCastD = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_DIFICIL.json", Encoding.UTF8));
                CAST_DIFICIL = jarrayCastD.ToObject<List<Pelicula>>();

                JArray jarrayCastF = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_FACIL.json", Encoding.UTF8));
                 CAST_FACIL = jarrayCastF.ToObject<List<Pelicula>>();

                JArray jarrayCastM = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_MEDIANO.json", Encoding.UTF8));
                CAST_MEDIANO = jarrayCastM.ToObject<List<Pelicula>>();

                JArray jarrayCatD = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_DIFICIL.json", Encoding.UTF8));
                CAT_DIFICL = jarrayCatD.ToObject<List<Pelicula>>();

                JArray jarrayCatM = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_MEDIANO.json", Encoding.UTF8));
                CAT_MEDIANO = jarrayCatM.ToObject<List<Pelicula>>();

                JArray jarrayCatF = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_FACIL.json", Encoding.UTF8));
                CAT_FACIL = jarrayCatF.ToObject<List<Pelicula>>();

                JArray jarrayEngD = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_DIFICIL.json", Encoding.UTF8));
                ENG_DIFICIL = jarrayEngD.ToObject<List<Pelicula>>();

                JArray jarrayEngM = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_MEDIANO.json", Encoding.UTF8));
                ENG_MEDIANO = jarrayEngM.ToObject<List<Pelicula>>();

                JArray jarrayEngF = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_FACIL.json", Encoding.UTF8));
                ENG_FACIL =  jarrayEngF.ToObject<List<Pelicula>>();

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
            List<Pelicula> carga = new List<Pelicula>();
            
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
    }
    }

