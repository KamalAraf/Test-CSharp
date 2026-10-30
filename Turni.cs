using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    internal class Turni
    {
        private ETurni[] _oggetti0;
        private ETurni[] _oggetti1;
        private int _inizio;

        Funzioni funzioni = new Funzioni();

        public ETurni[] oggetti0
        {
            get { return _oggetti0; }
            set { _oggetti0 = value; }
        }
        
        public ETurni[] oggetti1
        {
            get { return _oggetti1; }
            set { _oggetti1 = value; }
        }

        public int inizio
        {
            get { return _inizio; }
            set { _inizio = value; }
        }

        public Turni()
        {
        }

        public Turni(ETurni[] A, ETurni[] B)
        {
            if (A.Length < 1 || B.Length < 1)
            {
                Console.WriteLine("[Turni.cs - Costruttore] Errore, i parametri devono contenere Almeno 1 elemento");
                throw new ArgumentException("[Turni.cs - Costruttore] Errore, i parametri devono contenere Almeno 1 elemento");
            }
            _oggetti0 = A;
            _oggetti1 = B;

            _inizio = (int) funzioni.GeneraNumero("int", 0, 1);
        }
    }
}
