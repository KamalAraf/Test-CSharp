using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    public class Essere
    {
        Funzioni funzioni = new Funzioni();

        private string _nome;
        private float _vita;
        private float _danno;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public float vita
        {
            get { return _vita; }
            set { _vita = value; }
        }
        public float danno
        {
            get { return _danno; }
            set { _danno = value; }
        }

        public Essere()
        {
            _nome = "Essere";
            _vita = 1000;
            _danno = 100;
        }
        public Essere(string nm, float hp, float dmg)
        {
            if (nm.Length < 1)
            {
                Console.WriteLine("[Essere.cs - Costruttore] Errore, il Nome deve essere presente");
            }
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
            _nome = nm;
            _vita = hp;
            _danno = dmg;
        }
        public void Attacca(ref Essere nemico)
        {
            nemico.vita = nemico.vita - _danno;

            if (nemico.vita <= 0)
            {
                Console.WriteLine("Ucciso " + nemico.nome + ".");
                nemico = null;
            }
        }
    }
}
