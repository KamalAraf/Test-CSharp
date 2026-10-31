using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp.Test
{
    public class ETurni : Essere
    {
        private bool _turno;
        
        public bool turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        public ETurni(string nome, float vita, float danno) : base(nome, vita, danno)
        {
            _turno = false;
        }
        public ETurni(string nome, float vita, float danno, bool turno) : base(nome, vita, danno)
        {
            _turno = turno;
        }
        public override void Stampa()
        {
            Console.WriteLine("Nome: " + nome + ", Vita: " + vita + ", Danno:" + danno + ".");
        }
        public override string ToString()
        {
            return "Nome: " + nome + ", Vita: " + vita + ", Danno:" + danno + ".";
        }
    }
}
