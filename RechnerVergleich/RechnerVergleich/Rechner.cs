using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace RechnerVergleich
{
    internal class Rechner
    {
        public String IP {  get; set; }
        public String Name { get; set; }
        public List<string> Programme { get; set; }


        public Rechner(String ip, String name)
        {
            IP = ip;
            Name = name;
            Programme = new List<string>();

        }
    }
}
