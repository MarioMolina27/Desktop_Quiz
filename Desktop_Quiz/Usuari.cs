using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz
{
    public class Usuari
    {
        public String nickname { get; set; }
        public String nom { get; set; }
        public String contrasenya { get; set; }
        public String tipus { get; set; }
        public String privilegis { get; set; }

        public Usuari() { }

        public Usuari(string nickname, string nom, string contrasenya, string tipus, string privilegis)
        {
            this.nickname = nickname;
            this.nom = nom;
            this.contrasenya = contrasenya;
            this.tipus = tipus;
            this.privilegis = privilegis;
        }
    }
}
