using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    internal class Matrice
    {
        private int _x; // larghezza
        private int _y; // altezza
        private float[,] _matrice;

        public Matrice()
        {
            _x = 5;
            _y = 5;
            _matrice = new float[5, 5];
        }

        public Matrice(int ny, int nx) // Prima riga indica la x, seconda la y (normali matrici è al contrario)
        {
            if (nx < 0 || ny < 0)
            {
                throw new ArgumentException("[Matrice.cs - Costruttore] Errore, Uno dei due Valori della dimensione è Negativo.");
            }

            _x = nx;
            _y = ny;
            _matrice = new float[ny, nx]; // Tutti i valori iniziano a 0
        }

        public void Inserisci(int posx, int posy, float n)
        {
            if (posx > _x - 1 || posy > _y - 1)
            {
                throw new ArgumentException("[Matrice.cs - Metodo Inserisci] Errore, Ordinata o Ascissa al di fuori della dimensione Matrice.");
            }
            if (posx < 0 || posy < 0)
            {
                throw new ArgumentException("[Matrice.cs - Metodo Inserisci] Errore, Ordinata o Ascissa negativa.");
            }

            _matrice[posy, posx] = n; // Inversione a causa del formato
        }

        public void Inserisci(Punto punto, float n) // Metodo con anche il punto
        {
            if (punto.x > _x - 1 || punto.y > _y - 1)
            {
                throw new ArgumentException("[Matrice.cs - Metodo Inserisci] Errore, Punto al di fuori della dimensione Matrice.");
            }
            if (punto.x < 0 || punto.y < 0)
            {
                throw new ArgumentException("[Matrice.cs - Metodo Inserisci] Errore, Punto con Ordinata o Ascissa negativa.");
            }

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
