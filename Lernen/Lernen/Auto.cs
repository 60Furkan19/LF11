using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernen
{
    internal class Auto
    
    {
        public bool e_auto {  get; set; }
        public string marke { get; set; }
        public string modell { get; set; }
        public Motor Julian { get; set; }

        public Auto(Motor m, string marke, bool e, string mo) 
        {
            this.marke = marke;
            this.e_auto = e;
            this.Julian = m;
            this.modell = mo;
        }
    }
}
