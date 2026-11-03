using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Test_CSharp.test.esercizio_leone_coniglio_carota.elementi;

namespace Test_CSharp.test.esercizio_leone_coniglio_carota
{
    public enum Direzione
    {
        sopra,
        destra,
        sotto,
        sinistra,
        fermo
    }
    public enum Elemento
    {
        coniglio,
        leone
    }
    internal class Main
    {
        private Base[,] _campo;
        private Base[] _lista;
        private int _contatore;

        public Base[,] campo
        {
            get { return _campo; }
            set { _campo = value; }
        }
        public Base[] lista
        {
            get { return _lista; }
            set { _lista = value; }
        }
        public int contatore
        {
            get { return _contatore; }
            set { _contatore = value; }
        }

        public static Base Crea(Elemento tipo, int posx, int posy, string name, float health, float energy)
        {
            return tipo switch
            {
                Elemento.coniglio => new Coniglio(posx, posy, name, health, energy),
                Elemento.leone => new Leone(posx, posy, name, health, energy),
                _ => throw new ArgumentException("[test/esercizio-leone-coniglio-carota/Main.cs] Errore, il tipo di oggetto non esiste")
            };
        }
    }
}
