using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz
{
    public class Personatge
    {

        public String nomPers { get; set; }
        public String descripcioPers { get; set; }
        public String genere { get; set; }
        public double percEncerts { get; set; }
        public String rutaPers { get; set; }

        
        public Personatge()
        {

        }
        public Personatge (String nomPers, String descripcioPers,  String genere, double percEncerts,  String rutaPers) 
        {

            this.nomPers = nomPers;
            this.descripcioPers = descripcioPers;
            this.genere = genere;
            this.percEncerts = percEncerts;
            this.rutaPers = rutaPers;

        }
        

    }
}
