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
        public char tipus { get; set; }
        public bool add { get; set; }
        public bool modify { get; set; }
        public bool delete { get; set; }


        public Usuari() { }

        public Usuari(string nickname, string nom, string contrasenya, char tipus, bool add, bool modify, bool delete)
        {
            this.nickname = nickname;
            this.nom = nom;
            this.contrasenya = contrasenya;
            this.tipus = tipus;
            this.add = add;
            this.modify = modify;
            this.delete = delete;
        }
    }
}
