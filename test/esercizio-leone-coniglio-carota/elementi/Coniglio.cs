using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_CSharp.test.esercizio_leone_coniglio_carota.elementi;

namespace Test_CSharp.test.esercizio_leone_coniglio_carota
{
    internal class Coniglio : Base
    {
        public Coniglio(int posx, int posy, string name, float health, float energy) : base(posx, posy, name, health, energy)
        {

        }
        public override void Muovi(Direzione direzione)
        {
            if (direzione == Direzione.destra)
            {
                base.posx++;
                base.energy -= 5;
            } else
            if (direzione == Direzione.sinistra)
            {
                base.posx--;
                base.energy -= 5;
            } else
            if (direzione == Direzione.sopra)
            {
                base.posy++;
                base.energy -= 5;
            } else
            if (direzione == Direzione.sotto)
            {
                base.posy--;
                base.energy -= 5;
            } else if (direzione == Direzione.fermo)
            {
                Console.WriteLine("[test/esercizio-leone-coniglio-carota/Coniglio.cs - Muovi()] Errore, la direzione non è corretta");
                throw new ArgumentException("[test/esercizio-leone-coniglio-carota/Coniglio.cs - Muovi()] Errore, la direzione non è corretta");
            }
        }

        public override void Mangia()
        {
            base.energy += 20;
        }
    }
}
