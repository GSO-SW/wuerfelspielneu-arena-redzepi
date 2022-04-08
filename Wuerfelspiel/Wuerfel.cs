using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        int anzahlSeiten;

        public int Wuerfeln()
        {
            Random rndZufallZahl = new Random ();
            return rndZufallZahl.Next(1,anzahlSeiten);
            
        }

        public Wuerfel (int AnzahlSeiten)
        {
            this.anzahlSeiten = AnzahlSeiten;
        }
    }
}
