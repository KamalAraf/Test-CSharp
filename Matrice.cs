using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    internal class Matrice
    {
        private int _x;
        private int _y;
        private float[,] _matrice;

        public Matrice()
        {
            _x = 5;
            _y = 5;
            _matrice = new float[5, 5];
        }

        public Matrice(int ny, int nx) // Prima riga indica la x, seconda la y (normali matrici è al contrario)
        {
            _x = nx;
            _y = ny;
            _matrice = new float[ny, nx]; // Tutti i valori iniziano a 0
        }

        public void Inserisci(int posx, int posy, float n)
        {
            _matrice[posy, posx] = n; // Inversione a causa del formato
        }

        public void Inserisci(Punto punto, float n) // Metodo con anche il punto
        {
            _matrice[punto.x, punto.y] = n;
        }

        public void Stampa() // Stampa diretto in console
        {
            for (int posy = 0; posy < 5; posy++)
            {
                for (int posx = 0; posx < 5; posx++)
                {
                    Console.Write(_matrice[posy, posx]);
                    if (posx != 4)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }

        public override string ToString() // Metodo tostring
        {
            string risultato = "";

            for (int posy = 0; posy < 5; posy++)
            {
                for (int posx = 0; posx < 5; posx++)
                {
                    risultato += _matrice[posy, posx];
                    if (posx != 4)
                    {
                        risultato += ", ";
                    }
                }
                risultato += Environment.NewLine;
            }

            return risultato;
        }
    }
}
