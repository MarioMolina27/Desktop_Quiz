﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Quiz
{
    public partial class FormEditPreguntes : Form
    {
        public FormEditPreguntes()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String nom = textBoxNom.Text;
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
            String imgaudio="";
            
            if (string.IsNullOrEmpty(imatge)&& !string.IsNullOrEmpty(audio))
            {
                imgaudio = audio;
            }
            else if (!string.IsNullOrEmpty(imatge) && string.IsNullOrEmpty(audio))
            {
                    imgaudio = imatge;
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

            String id;
            String txtId="";

            if (idioma.Equals("Català") && dificultad==1)
            {
                txtId = "CAT_F_";
                id = newID(txtId);
                FormPreguntas.CAT_FACIL.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
            else if (idioma.Equals("Català") && dificultad == 2)
            {
                txtId = "CAT_M_";
                
                id = newID(txtId);
                FormPreguntas.CAT_MEDIANO.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));

            }
            else if (idioma.Equals("Català") && dificultad == 3)
            {
                txtId = "CAT_D_";
                id = newID(txtId);
                FormPreguntas.CAT_DIFICL.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
            else if (idioma.Equals("Castellano") && dificultad == 1)
            {
                txtId = "CAST_F_";
                
                id = newID(txtId);
                FormPreguntas.CAST_FACIL.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
            else if (idioma.Equals("Castellano") && dificultad == 2)
            {
                txtId = "CAST_M_";
                id = newID(txtId);
                FormPreguntas.CAST_MEDIANO.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
            else if (idioma.Equals("Castellano") && dificultad == 3)
            {
                txtId = "CAST_D_";
                id = newID(txtId);
                FormPreguntas.CAST_DIFICIL.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
            else if (idioma.Equals("English") && dificultad == 1)
            {
                txtId = "EN_F_";
                id = newID(txtId);
                FormPreguntas.ENG_FACIL.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
            else if (idioma.Equals("English") && dificultad == 2)
            {
                txtId = "EN_M_";
                id = newID(txtId);
                FormPreguntas.ENG_MEDIANO.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
            else if (idioma.Equals("English") && dificultad == 3)
            {
                txtId = "EN_D_";
                id = newID(txtId);
                FormPreguntas.ENG_DIFICIL.Add(new Pelicula(id, nom, pregunta, resposta1, resposta2, resposta3, resposta_correcte, categoria, imatge, dificultad));
            }
          
            this.Close();
        }

        public static String newID(String txtID)
        {
            int lastObject = FormPreguntas.peliculaList.Count - 1;
            String id = FormPreguntas.peliculaList[lastObject].id;
            String b = string.Empty;
            int num = 0;
            String newId;

            for (int i = 0; i < id.Length; i++)
            {
                if (Char.IsDigit(id[i]))
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
