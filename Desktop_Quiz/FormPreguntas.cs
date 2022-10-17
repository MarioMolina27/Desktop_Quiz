﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Desktop_Quiz
{
    public partial class FormPreguntas : Form
    {
        public  BindingList<Pelicula> peliculaList { get; set; }
        public  BindingList<Pelicula> CAST_DIFICIL { get; set; }
        public  BindingList<Pelicula> CAST_FACIL  { get; set; }
        public  BindingList<Pelicula> CAST_MEDIANO { get; set; }
        public  BindingList<Pelicula> CAT_DIFICIL { get; set; }
        public  BindingList<Pelicula> CAT_MEDIANO { get; set; }
        public  BindingList<Pelicula> CAT_FACIL { get; set; }
        public  BindingList<Pelicula> ENG_DIFICIL { get; set; }
        public BindingList<Pelicula> ENG_MEDIANO { get; set; }
        public  BindingList<Pelicula> ENG_FACIL { get; set; }
        public FormPreguntas()
        {
            InitializeComponent();
            JArray jarrayCastD = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_DIFICIL.json", Encoding.UTF8));
            this.CAST_DIFICIL = jarrayCastD.ToObject<BindingList<Pelicula>>();

            JArray jarrayCastF = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_FACIL.json", Encoding.UTF8));
            this.CAST_FACIL = jarrayCastF.ToObject<BindingList<Pelicula>>();

            JArray jarrayCastM = JArray.Parse(File.ReadAllText(@"..\..\JSON\CASTELLANO_MEDIANO.json", Encoding.UTF8));
            this.CAST_MEDIANO = jarrayCastM.ToObject<BindingList<Pelicula>>();

            JArray jarrayCatD = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_DIFICIL.json", Encoding.UTF8));
            this.CAT_DIFICIL = jarrayCatD.ToObject<BindingList<Pelicula>>();

            JArray jarrayCatM = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_MEDIANO.json", Encoding.UTF8));
            this.CAT_MEDIANO = jarrayCatM.ToObject<BindingList<Pelicula>>();

            JArray jarrayCatF = JArray.Parse(File.ReadAllText(@"..\..\JSON\CATALA_FACIL.json", Encoding.UTF8));
            this.CAT_FACIL = jarrayCatF.ToObject<BindingList<Pelicula>>();

            JArray jarrayEngD = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_DIFICIL.json", Encoding.UTF8));
            this.ENG_DIFICIL = jarrayEngD.ToObject<BindingList<Pelicula>>();

            JArray jarrayEngM = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_MEDIANO.json", Encoding.UTF8));
            this.ENG_MEDIANO = jarrayEngM.ToObject<BindingList<Pelicula>>();

            JArray jarrayEngF = JArray.Parse(File.ReadAllText(@"..\..\JSON\ENGLISH_FACIL.json", Encoding.UTF8));
            this.ENG_FACIL = jarrayEngF.ToObject<BindingList<Pelicula>>();

            BindingList<Pelicula> list = new BindingList<Pelicula>();
            this.peliculaList = list;

        }

        public FormPreguntas(BindingList<Pelicula> peliculaList, BindingList<Pelicula> cAST_DIFICIL, BindingList<Pelicula> cAST_FACIL, BindingList<Pelicula> cAST_MEDIANO, BindingList<Pelicula> cAT_DIFICIL, BindingList<Pelicula> cAT_MEDIANO, BindingList<Pelicula> cAT_FACIL, BindingList<Pelicula> eNG_DIFICIL, BindingList<Pelicula> eNG_MEDIANO, BindingList<Pelicula> eNG_FACIL)
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
        }

        private void FormPreguntas_Load(object sender, EventArgs e)
        {
            updateList();
            updateDataGrid();
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            FormEditPreguntes p = new FormEditPreguntes(peliculaList, CAST_DIFICIL, CAST_MEDIANO,
                                 CAST_FACIL, CAT_DIFICIL, CAT_MEDIANO,
                                 CAT_FACIL, ENG_DIFICIL, ENG_MEDIANO,
                                ENG_FACIL);
            p.ShowDialog();
            updateList();
        }
        public void updateList()
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

            updateDataGrid();
          

        }

        public void updateDataGrid()
        {
            dataGridViewPelicules.DataSource = null;
            dataGridViewPelicules.DataSource = this.peliculaList;
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

                FormEditPreguntes p2 = new FormEditPreguntes(id, pelicula, pregunta,resposta1, resposta2,resposta3, resposta_correcte, categoria, imgaudio, dificultat,
                                peliculaList,CAST_DIFICIL,CAST_MEDIANO,
                                 CAST_FACIL, CAT_DIFICIL, CAT_MEDIANO,
                                 CAT_FACIL, ENG_DIFICIL,  ENG_MEDIANO,
                                ENG_FACIL);
                eliminarElemento(id);
                p2.ShowDialog();
            }
            else
            {
                MessageBox.Show("No has elegit cap pregunta per modificar-la");
            }
            updateDataGrid();
            updateList();
        }
        private int conseguirRowIndex()
        {
            int rowIndex = dataGridViewPelicules.CurrentCell.RowIndex;
            return rowIndex;
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
                    userPosition = retornarIndice(id,this.CAT_FACIL);
                    CAT_FACIL.RemoveAt(userPosition);
                    CAT_FACIL = UpdateIDs(txtID + "_", this.CAT_FACIL);
                    break;
                case "CAT_M":
                    userPosition = retornarIndice(id,this.CAT_MEDIANO);
                    CAT_MEDIANO.RemoveAt(userPosition);
                    CAT_MEDIANO = UpdateIDs(txtID + "_", this.CAT_MEDIANO);
                    break;
                case "CAT_D":
                    userPosition = retornarIndice(id,this.CAT_DIFICIL);
                    CAT_DIFICIL.RemoveAt(userPosition);
                    CAT_DIFICIL = UpdateIDs(txtID+"_",this.CAT_DIFICIL);
                    break;
                case "CAS_F":
                    userPosition = retornarIndice(id,this.CAST_FACIL);
                    CAST_FACIL.RemoveAt(userPosition);
                    CAST_FACIL=UpdateIDs(txtID + "_", this.CAST_FACIL);
                    break;
                case "CAS_M":
                    userPosition = retornarIndice(id,this.CAST_MEDIANO);
                    CAST_MEDIANO.RemoveAt(userPosition);
                    CAST_MEDIANO=UpdateIDs(txtID + "_", this.CAST_MEDIANO);
                    break;
                case "CAS_D":
                    userPosition = retornarIndice(id,this.CAST_DIFICIL);
                    
                    CAST_DIFICIL.RemoveAt(userPosition);
                    CAST_DIFICIL = UpdateIDs(txtID + "_", this.CAST_DIFICIL);

                    break;
                case "EN_F_":
                    userPosition = retornarIndice(id,this.ENG_FACIL);
                    ENG_FACIL.RemoveAt(userPosition);
                    ENG_FACIL= UpdateIDs(txtID,this.ENG_FACIL);
                    break;
                case "EN_M_":
                    userPosition = retornarIndice(id,this.ENG_MEDIANO);
                    ENG_MEDIANO.RemoveAt(userPosition);
                    ENG_MEDIANO= UpdateIDs(txtID,this.ENG_MEDIANO);
                    break;
                case "EN_D_":
                    userPosition = retornarIndice(id,this.ENG_DIFICIL);
                    ENG_DIFICIL.RemoveAt(userPosition);
                    ENG_DIFICIL=UpdateIDs(txtID,this.ENG_DIFICIL);
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

        private void radioButtonDificultat_CheckedChanged(object sender, EventArgs e)
        {
            peliculaList = new BindingList<Pelicula>(peliculaList.OrderBy(p => p.dificultad).ToList());
          
            updateDataGrid();
        }
       
        private void radioButtonCategoria_CheckedChanged(object sender, EventArgs e)
        {
            peliculaList = new BindingList<Pelicula>(peliculaList.OrderBy(p => p.categoria).ToList());
            updateDataGrid();
        }
    }
}

