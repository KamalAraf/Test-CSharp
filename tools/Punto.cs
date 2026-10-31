using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp.tools
{
    internal class Punto
    {
        private int _x;
        private int _y;
        
        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Punto()
        {
            _x = 0;
            _y = 0;
        }

        public Punto(int posx, int posy)
        {
            _x = posx;
            _y = posy;
        }

        public void Stampa() // Stampa direttamente in console
        {
            Console.WriteLine("[" + _x + ", " + _y + "]");
        }

        public override string ToString() // Metodo Tostring
        {
            return "[" + _x + ", " + _y + "]";
        }
    }
}
