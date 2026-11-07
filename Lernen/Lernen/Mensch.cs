using System;

namespace Lernen

{ 
    public class Mensch
    {
        public string name;
        public int alter;
        public int größe;
        public string geburtstag;
        public int gewicht;

        public Uhr armbanduhr{get; set;}
    
        public Mensch(string pname)
        {
            this.name=pname;
            Console.WriteLine (this.name + " erstellt!");
        }
        public void essen(int menge)
        {
            this.gewicht = this.gewicht + menge;
        }
        public void abnehmen(int menge)
        {
            this.gewicht = this.gewicht - menge;
        }

    }

}