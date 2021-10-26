using System;

namespace Epicfight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = pickhero();
            string villan = pickvillan();
            int heroHP = GenerateHP(hero);
            int villanHp = GenerateHP(villan);

            Console.WriteLine($"{hero} will fight {villan}.");
            string heroweapon = pickweapon();
            string villanweapon = pickweapon();
            Console.WriteLine($"{hero} picked {heroweapon}. {villan} picked {villanweapon}.");

            while(heroHP > 0 && villanHp > 0)
            {
                heroHP = heroHP - Hit(villan, hero, villanweapon);
                villanHp = villanHp - Hit(hero, villan, heroweapon);
            }
            if (heroHP > 0)
            {
                Console.WriteLine($"Dark side wins");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }

        }

        private static int Hit(string charone, string chartwo, string someweapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, someweapon.Length / 2);

            Console.WriteLine($"{charone} hit {strike}");
            if(strike == someweapon.Length / 2)
            {
                Console.WriteLine($"Awesome! {charone} made a critical strike!");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"{chartwo} Dodged an attack!");
            }
            
            
            return strike;
        }

        private static int GenerateHP(string somename)
        {
            Random rnd = new Random();
            return rnd.Next(2, somename.Length + 10);
        }


        private static string pickweapon()
        {
            string[] weapon = { "plastic fork", "Banana", "frying pan", "purse" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, weapon.Length);

            return weapon[randomindex];
        }


        private static string pickhero()
        {
            string[] superHeroes = { "Superman", "Batman", "Spiderman", "Spongebob" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomindex];
        }

        private static string pickvillan()
        {
            string[] Villans = { "Joker", "Patrick", "Plankton", "Darth Vader" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, Villans.Length);

            return Villans[randomindex];
        }

    }
}   

