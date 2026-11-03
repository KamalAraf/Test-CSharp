using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_CSharp.test.esercizio_leone_coniglio_carota;

namespace Test_CSharp.test.esercizio_leone_coniglio_carota.elementi
{
    public class Base
    {
        public enum Direzione
        {
            sopra,
            destra,
            sotto,
            sinistra
        }

        private int _posx;
        private int _posy;

        private string _name;
        private float _health;
        private float _energy;

        public int posx
        {
            get { return _posx; }
            set { _posx = value; }
        }
        public int posy
        {
            get { return _posy; }
            set { _posy = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float health
        {
            get { return _health; }
            set { _health = value; }
        }
        public float energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public Base()
        {
            _posx = 0;
            _posy = 0;

            _name = "nome";
            _health = 100;
            _energy = 100;
        }
        public Base(int posx, int posy, string name, float health, float energy)
        {
            if (posx < 0 || posy < 0)
            {
                Console.WriteLine("[test/esercizio-leone-coniglio-carota/Base.cs - Costruttore] Errore, la posizione nell'asse x o y è negativa");
            }

            if (name.Length < 1)
            {
                Console.WriteLine("[test/esercizio-leone-coniglio-carota/Base.cs - Costruttore] Errore, il nome deve essere lungo almeno 1 carattere");
                throw new ArgumentException("[test/esercizio-leone-coniglio-carota/Base.cs - Costruttore] Errore, il nome deve essere lungo almeno 1 carattere");
            }
            if (health <= 0)
            {
                Console.WriteLine("[test/esercizio-leone-coniglio-carota/Base.cs - Costruttore] Errore, la vita non può essere minore o uguale a 0");
                throw new ArgumentException("[test/esercizio-leone-coniglio-carota/Base.cs - Costruttore] Errore, la vita non può essere minore o uguale a 0");
            }
            if (energy <= 0)
            {
                Console.WriteLine("[test/esercizio-leone-coniglio-carota/Base.cs - Costruttore] Errore, l'energia non può essere minore o uguale a 0");
                throw new ArgumentException("[test/esercizio-leone-coniglio-carota/Base.cs - Costruttore] Errore, l'energia non può essere minore o uguale a 0");
            }

            _posx = posx;
            _posy = posy;

            _name = name;
            _health = health;
            _energy = energy;
        }

        public virtual void Muovi(Direzione direzione)
        {
            if (direzione == Direzione.destra)
            {
                _posx++;
                _energy -= 10;
            }
            if (direzione == Direzione.sinistra)
            {
                _posx--;
                _energy -= 10;
            }
            if (direzione == Direzione.sopra)
            {
                _posy++;
                _energy -= 10;
            }
            if (direzione == Direzione.sotto)
            {
                _posy--;
                _energy -= 10;
            }

            Console.WriteLine("[test/esercizio-leone-coniglio-carota/Base.cs - Muovi()] Errore, la direzione non è corretta");
            throw new ArgumentException("[test/esercizio-leone-coniglio-carota/Base.cs - Muovi()] Errore, la direzione non è corretta");
        }
    }
}
