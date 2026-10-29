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

        public Matrice(int ny, int nx) // prima riga indica la x, seconda la y (normali matrici è al contrario)
        {
            _x = nx;
            _y = ny;
            _matrice = new float[ny, nx];
        }

        public void Inserisci(int posx, int posy, float n)
        {
            _matrice[posy, posx] = n; // inversione a causa del formato
        }

        public void Stampa()
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
    }
}
