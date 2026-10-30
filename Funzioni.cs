using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    internal class Funzioni
    {
        public Funzioni() { }
        private ArgumentException GestisciErroreRandom(string tipo)
        {
            Console.WriteLine("[Random.cs - Metodo GeneraNumero] Errore, Tipo non valido: " + tipo + ".");
            throw new ArgumentException("[Random.cs - Metodo GeneraNumero] Errore, Tipo non valido: " + tipo + ".");
        }
        public double GeneraNumero(string tipo, int start, int end)
        {
            System.Random rnd = new System.Random();

            return tipo switch
            {
                "int" => rnd.Next(start, end),
                "decimal" => Math.Round(rnd.NextDouble() * (end - start) + start, 2),
                "float" => Math.Round(rnd.NextSingle() * (end - start) + start, 4),
                "double" => Math.Round(rnd.NextDouble() * (end - start) + start, 8),
                _ => throw GestisciErroreRandom(tipo)
            };
        }

        public bool EsisteOggetto(object oggetto)
        {
            return oggetto is not null;
        }
    }
}
