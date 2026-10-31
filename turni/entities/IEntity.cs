using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp.turni.entities
{
    public interface IEntity
    {
        public bool Attacca();
        public bool EsisteNemico();
        public void Stampa();
    }
}
