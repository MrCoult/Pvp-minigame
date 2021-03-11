using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Hero
    {
        public String name;
        public int heal = 50;
        public int dmg = 5;
        public int lvl = 1;
        public int exp = 0;
        public int explvl = 40;
        public int mana = 0;
        public int viata = 50;
        public int manaa = 0;
        public Hero()
        {
            this.name = "neidentificat";
        }

        public Hero(String name)
        {
            this.name = name;
        }
        public Hero(Hero x)
        {
            this.name = x.name;
            this.heal = x.heal;
            this.dmg = x.dmg;
            this.lvl = x.lvl;
            this.exp = x.exp;
            this.explvl = x.explvl;
            this.mana = x.mana;
            this.viata = x.viata;
            this.manaa = x.manaa;
        }
        public override string ToString()
        {
            return this.name + " are viata " + this.heal + ", damageul " + this.dmg + " si levelul " + this.lvl;
        }

        public void Attack(Hero victim)
        {
            if (!(this.heal > 0 && victim.heal > 0))
            {
                Console.WriteLine("Cannot attack, not both heroes are alive");
                return;
            }

            int damage =((this.dmg / 2 + 1) + (this.dmg + 1) / 2);
            Console.WriteLine(this.name + " is attacking " + victim.name + " with damage " + damage);
            victim.heal -= damage;
            if (victim.heal <= 0)
            {
                victim.heal = 0;
                Console.WriteLine(victim.name + " has been killed");
                this.exp += 100;
                victim.exp += 50;
            }
        }

        public void Fight(Hero victim)
        {
            while (this.heal > 0 && victim.heal > 0)
            {
                    this.Attack(victim);
                if (victim.heal > 0)
                    victim.Attack(this);
            }
        }

        public void Health(Hero victim)
        {
            if (victim.heal != viata || victim.mana != manaa)
            {
                victim.heal = viata;
                victim.mana = manaa;
                Console.WriteLine(victim.name + " has heald");
            }
        }

        public void Lvlup(Hero victim)
        {
            while (victim.explvl <= victim.exp)
            {
                victim.lvl += 1;
                victim.exp = victim.exp - victim.explvl;
                victim.explvl += 20;
                victim.heal += 50;
                viata += 50;
                victim.dmg += 5;
                victim.manaa += 0;
            }
        }
    }
}

