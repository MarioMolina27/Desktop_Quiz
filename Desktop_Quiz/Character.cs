using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Quiz
{
    internal class Character
    {

        private String nameChar { get; set; }
        private String descChar { get; set; }
        private String genChar { get; set; }
        private double numAnsw { get; set; }
        private String picRoute { get; set; }

        private Character (){ 
        }
        
        private Character (string nameChar, string descChar, string genChar, double numAnsw, string picRoute)
        {
            this.nameChar = nameChar;
            this.descChar = descChar;
            this.genChar = genChar;
            this.numAnsw = numAnsw;
            this.picRoute = picRoute;
        }
    }
}
