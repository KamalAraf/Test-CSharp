using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    public class Essere
    {
        private float _vita;
        private float _danno;

        public float vita { get; set; }
        public float danno { get; set; }

        public Essere()
        {
            _vita = 1000;
            _danno = 100;
        }
        public Essere(float hp, float dmg)
        {
            if (hp < 0)
            {
                Console.WriteLine("[Essere.cs - Costruttore] Errore, la Saluta non può essere Negativa.");
                throw new ArgumentException("[Essere.cs - Costruttore] Errore, la Saluta non può essere Negativa.");
            }
            if (dmg < 0)
            {
                Console.WriteLine("[Essere.cs - Costruttore] Errore, il Danno non può essere Negativo.");
                throw new ArgumentException("[Essere.cs - Costruttore] Errore, il Danno non può essere Negativo.");
            }
            _vita = hp;
            _danno = dmg;
        }
        public void Attacca(Essere nemico)
        {
            nemico.vita -= _danno;
        }
    }
}
