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
        public Motor Julian { get; set; }

        public Auto(Motor m, string ma, bool e) 
        {
            this.marke = ma;
            this.e_auto = e;
            this.Julian = m;
        }
    }
}
