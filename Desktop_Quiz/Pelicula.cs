using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz
{
    public class Pelicula
    {
        public String id { get; set; }
        public String película { get; set; }
        public String pregunta { get; set; }
        public String resposta1 { get; set; }
        public String resposta2 { get; set; }
        public String resposta3 { get; set; }
        public int resposta_correcte { get; set; }
        public String categoria { get; set; }
        public String imgaudio { get; set; }
        public int dificultad { get; set; }

        public Pelicula() { }
        public Pelicula(string id, string película,string pregunta, string resposta1, string resposta2, string resposta3, int resposta_correcte, string categoria, string imgaudio, int dificultat)
        {
            this.id = id;
            this.película = película;
            this.pregunta = pregunta;
            this.resposta1 = resposta1;
            this.resposta2 = resposta2;
            this.resposta3 = resposta3;
            this.resposta_correcte = resposta_correcte;
            this.categoria = categoria;
            this.imgaudio = imgaudio;
            this.dificultad = dificultat;
        }
    }
}
