using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        Character char1 = new Character("richard");
        char1.introduction();

        Assasin char2 = new Assasin("Altair", "hidden blade");
        char2.introduction(false);

        Assasin char3 = new Assasin("connor", "hidden blade", new skill("axe"));
        char3.introduction(true);

    }

    public class Character
    {
        public string name;
        private int health;

        public Character(string name)
        {
            this.name = name;
            this.health = 100;
        }


        public int getHealth()
        {
            return this.health;
        }

        public void introduction()
        {
            Console.WriteLine("\nCharacter" +
                              "\nName   : " + this.name +
                              "\nhealth : "+ this.health);
            principle();
        }

        public virtual void principle()
        {
            Console.WriteLine("My principle is netral");
        }
    }

    public class skill
    {
        public string nameSkill;
        public skill(string nameSkill)
        {
            this.nameSkill = nameSkill;
        }
    }

    public class Assasin : Character
    {
        private string weapon;
        private skill skill;
        public Assasin(string name, string weapon, skill skill = null) : base(name)
        {
            this.weapon = weapon;
            this.skill = skill;
        }

        public void introduction(bool showWeapon)
        {
            if (showWeapon)
            {
                Console.Write("\nAssassin" +
                              "\nName   : " + this.name +
                              "\nHealth : " + getHealth() +
                              "\nWeapon : " + this.weapon);
                if (skill != null)
                {
                    Console.WriteLine("\nSKill  : " + this.skill.nameSkill);
                }
                else
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nAssassin" +
                              "\nName   : " + this.name +
                              "\nHealth : " + getHealth());
            }

            principle();
        }

        public override void principle()
        {
            Console.WriteLine("My principle is freedom");
        }

    }
}