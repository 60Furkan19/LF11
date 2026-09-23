using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernen
{
    public class Motor
    {

        private int Drehzahl;
        public int Oelstand;
        public int Laufleistung;

        public Motor(int drehzahl, int oelstand, int laufleistung)
        {
            this.Drehzahl = drehzahl;
            this.Oelstand = oelstand;
            this.Laufleistung = laufleistung;
        }

        public void setDrehzahl(int drehz) {
            if (drehz <0)
                return;
            else
            {
                Drehzahl = drehz;
            }
        }
        public int getDrehzahl() {  return Drehzahl; }
            
    }
}
