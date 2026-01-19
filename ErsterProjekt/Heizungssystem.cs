using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ErsterProjekt
{
    internal class Heizungssystem
    {
        public string marke;
        public int maxTemperature;
        public string typ;
        public int aktuelleTemperatur;
        public bool anAusSchaltStatus;

        public Heizungssystem(string marke, string typ, int max, int maxtemperatur)
        {
            this.marke = marke;
            this.typ = typ;
            this.maxTemperature = maxtemperatur;
            this.aktuelleTemperatur = 0;
            this.anAusSchaltStatus = false;
        }

        public void Anschalten()
        {
            anAusSchaltStatus = true;
            return;
        }
        public void Ausschalten()
        {
            anAusSchaltStatus = false;
            return;
        }
        public void Hauserwaermen(int gewuenschteTemperatur)
        { 
            if (aktuelleTemperatur >= gewuenschteTemperatur)
            {
                Ausschalten();
            }
            else
            {
                Anschalten();
            }
        }
    }
}
