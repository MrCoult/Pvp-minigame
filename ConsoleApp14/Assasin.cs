using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Assasin:Hero
    {
       
        public Assasin():base()
        {
        }

        public Assasin(Hero x) : base(x)
        {
        }

        public Assasin(String name) : base(name)
        {
            this.name = name;
        }

        public void Attack(Hero victim)
        {
            base.Attack(victim);
        }

        public void Fight(Hero victim)
        {
            base.Fight(victim);
        }

        public void Health(Assasin victim)
        {
            base.Health(victim);
        }

        public void Lvlup(Assasin victim)
        {
            base.Lvlup(victim);
            victim.dmg += 10;
        }

    }
}
