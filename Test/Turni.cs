using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_CSharp.tools;

namespace Test_CSharp.Test
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

        public void Inizia()
        {
            int co0 = -1; // contatore numero di elementi di Eturni nell'oggetto 0
            int co1 = -1; // contatore numero di elementi di Eturni nell'oggetto 1
            int i0 = 0; // indice dell'array oggetti 0
            int i1 = 0; // indice dell'array oggetti 1
            bool morto0 = false; // bool necessario per controlli
            bool morto1 = false; // bool necessario per controlli

            for (int i = 0; i < _oggetti0.Length; i++)
            {
                co0++;
            }
            for (int i = 0; i < _oggetti1.Length; i++)
            {
                co1++;
            }

            if (_inizio == 0)
            {
                while (co0 != 0 || co1 != 0)
                {
                    morto1 = _oggetti0[i0].Attacca(_oggetti1[i1]);

                    if (morto1 == true)
                    {
                        if(i1 == co1)
                        {
                            break;
                        }

                        i1++;
                        morto1 = false;

                    } else
                    {
                        morto0 = _oggetti1[i1].Attacca(_oggetti0[i0]);

                        if (morto0 == true)
                        {
                            if (i0 == co0)
                            {
                                break;
                            }

                            i0++;
                            morto0 = false;
                        }
                    }
                }
            }
        }

        public virtual void Stampa()
        {
            string risultato0 = "[";
            string risultato1 = "[";

            for (int i = 0; i < _oggetti0.Length; i++)
            {
                risultato0 += _oggetti0[i].nome;
                if (i != _oggetti0.Length - 1)
                {
                    risultato0 += ", ";
                }
            }

            for (int i = 0; i < _oggetti1.Length; i++)
            {
                risultato1 += _oggetti1[i].nome;
                if (i != _oggetti1.Length - 1)
                {
                    risultato1 += ", ";
                }
            }

            risultato0 += "]";
            risultato1 += "]";

            if (inizio == 0)
            {
                Console.WriteLine(risultato0 + " (inizio)");
                Console.WriteLine(risultato1);
            } else
            {

                Console.WriteLine(risultato0);
                Console.WriteLine(risultato1 + " (inizio)");
            }
        }

        public override string ToString()
        {
            string risultato0 = "[";
            string risultato1 = "[";

            for (int i = 0; i < _oggetti0.Length; i++)
            {
                risultato0 += _oggetti0[i].nome;
                if (i != _oggetti0.Length - 1)
                {
                    risultato0 += ", ";
                }
            }

            for (int i = 0; i < _oggetti1.Length; i++)
            {
                risultato1 += _oggetti1[i].nome;
                if (i != _oggetti1.Length - 1)
                {
                    risultato1 += ", ";
                }
            }

            risultato0 += "]";
            risultato1 += "]";

            if (inizio == 0)
            {
                return risultato0 + " (inizio)" + Environment.NewLine + risultato1;
            }
            else
            {
                return risultato0 + Environment.NewLine + risultato1 + " (inizio)";
            }
        }
    }
}
