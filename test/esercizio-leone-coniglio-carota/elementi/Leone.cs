using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_CSharp.test.esercizio_leone_coniglio_carota.elementi;

namespace Test_CSharp.test.esercizio_leone_coniglio_carota
{
    internal class Leone : Base
    {
        public Leone(int posx, int posy, string name, float health, float energy) : base(posx, posy, name, health, energy)
        {

        }
        public override void Muovi(Direzione direzione)
        {
            if (direzione == Direzione.destra)
            {
                base.posx++;
                base.energy -= 20;
            } else
            if (direzione == Direzione.sinistra)
            {
                base.posx--;
                base.energy -= 20;
            } else
            if (direzione == Direzione.sopra)
            {
                    base.posy++;
                base.energy -= 20;
            } else
            if (direzione == Direzione.sotto)
            {
                base.posy--;
                base.energy -= 20;
            } else if (direzione == Direzione.fermo)
            {

            } else
            {
                Console.WriteLine("[test/esercizio-leone-coniglio-carota/Leone.cs - Muovi()] Errore, la direzione non è corretta");
                throw new ArgumentException("[test/esercizio-leone-coniglio-carota/Leone.cs - Muovi()] Errore, la direzione non è corretta");
            }
        }

        public override void Mangia()
        {
            base.energy += 40;
        }
    }
}
