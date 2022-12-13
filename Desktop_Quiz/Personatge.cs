using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz
{
    public class Personatge
    {

        /**
         * public Personatge()
         * Aqui declarem els atributs de la classe Personatge()
         */
        public String nomPers { get; set; }
        public String descripcioPers { get; set; }
        public String genere { get; set; }
        public int percEncerts { get; set; }
        public String rutaPers { get; set; }

        /**
         * A continuació creem un constructor vuit
         */
        public Personatge()
        {

        }
        /**
         * A continuació creem un constructor amb els atributs creats amb antelació
         */
        public Personatge (String nomPers, String descripcioPers,  String genere, int percEncerts,  String rutaPers) 
        {

            this.nomPers = nomPers;
            this.descripcioPers = descripcioPers;
            this.genere = genere;
            this.percEncerts = percEncerts;
            this.rutaPers = rutaPers;

        }
        
    }
}
