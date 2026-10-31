using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp.turni.entities
{
    public abstract class Entity : IEntity
    {
        private string _name;
        private float _health;
        private float _damage;

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
        public float damage
        {
            get { return damage; }
            set { _damage = value; }
        }

        public Entity()
        {
            _name = "Entity";
            _health = 100;
            _damage = 10;
        }
        public Entity(string name, float health, float damage)
        {
            if (name.Length < 1)
            {
                Console.WriteLine("[turni.Entity.cs - Costruttore] Errore, il parametro Name deve essere lungo almeno Un Carattere");
                throw new ArgumentException("[turni.Entity.cs - Costruttore] Errore, il parametro Name deve essere lungo almeno Un Carattere");
            }
            if (health <= 0)
            {
                Console.WriteLine("[turni.Entity.cs - Costruttore] Errore, il parametro Health deve essere Maggiore di 0");
                throw new ArgumentException("[turni.Entity.cs - Costruttore] Errore, il parametro Health deve essere Maggiore di 0");
            }
            if (damage <= 0)
            {
                Console.WriteLine("[turni.Entity.cs - Costruttore] Errore, il parametro Damage deve essere Maggiore di 0");
                throw new ArgumentException("[turni.Entity.cs - Costruttore] Errore, il parametro Damage deve essere Maggiore di 0");
            }

            _name = name;
            _health = health;
            _damage = damage;
        }

        public abstract bool Attacca();
        public abstract bool EsisteNemico();
        public virtual void Stampa()
        {
            Console.WriteLine("Name: " + _name + "; Health: " + _health + "; Damage: " + _damage + ".");
        }
    }
}
