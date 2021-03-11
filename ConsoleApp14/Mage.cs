using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Mage:Hero
    {
        public Mage():base()
        {
        }

        public Mage(Hero x):base(x)
        {
            this.mana = 40;
            this.manaa = 40;
        }

        public Mage(String name):base(name)
        {
            this.name = name;
        }



        public void Attack(Hero victim)
        {
            if (!(this.heal > 0 && victim.heal > 0))
            {
                Console.WriteLine("Cannot attack, not both heroes are alive");
                return;
            }
            if (this.mana >= 30)
            {
                int damage =(((this.dmg / 2 + 1) + ((this.dmg) + 1) / 2) * 2);
                Console.WriteLine(this.name + " is attacking " + victim.name + " with damage " + damage);
                victim.heal -= damage;
                this.mana -= 30;
            }

            else
            {
                int damage = (((this.dmg / 2 + 1) + (this.dmg) + 1) / 2);
                Console.WriteLine(this.name + " is attacking " + victim.name + " with damage " + damage);
                victim.heal -= damage;
            }

            if (victim.heal <= 0)
            {
                victim.heal = 0;
                Console.WriteLine(victim.name + " has been killed");
                this.exp += 100;
                victim.exp += 50;
            }
            this.mana += 10;
        }

        public void Fight(Hero victim)
        {
            base.Fight(victim);
        }

        public void Health(Mage victim)
        {
            base.Health(victim);
        }

        public void Lvlup(Mage victim)
        {
            base.Lvlup(victim);
            victim.manaa += 10;
            victim.mana += 10;
        }
    }
}
