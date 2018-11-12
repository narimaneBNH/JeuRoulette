using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            //string rejouer = "o";
            // Random valeur = new Random();
            //int aleatoire = valeur.Next(0, 36);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("*** Bienvenue au jeu de la ROULETTE ***");
            Console.WriteLine("---------------------------------------");

            int stackBanque = 1000;
            //Console.WriteLine(aleatoire);

            TestInteger joueur = new TestInteger();
            var stack =  joueur.GetStack(stackBanque);

            
            while (stackBanque != 0 && stack != 0)
            {
                //je joue =^.^=
                Random valeur = new Random();
                int aleatoire = valeur.Next(0, 36);

                var number = joueur.GetNumber();
                var mise =  joueur.GetMise(stack, number);
                var stack2 = stack - mise;


                if (number == aleatoire)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Félicitation! Vous avez gagné! ... Votre stack augmente de " + mise * 36);
                    Console.WriteLine("Votre stack est actuellement = " + (stack + (mise * 36)));
                    Console.WriteLine("---------------------------------------");
                }
                else if (aleatoire == number && number == 0)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Félicitation! Vous avez gagné! ... Votre stack augmente de " + mise * 50);
                    Console.WriteLine("Votre stack est actuellement = " + (stack + (mise * 50)));
                    Console.WriteLine("---------------------------------------");
                }
                else if (aleatoire % 2 == 0 && number %2 ==0)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Félicitation! Vous avez deviné que le chiffre mister '"+aleatoire+"' est pair! ... Votre stack ugmente de " + mise * 20);
                    Console.WriteLine("Votre stack est actuellement = " + (stack + (mise * 20)));
                    Console.WriteLine("---------------------------------------");
                }
                else if (aleatoire % 2 != 0 && number % 2 != 0)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Félicitation! Vous avez deviné que le chiffre mister '" + aleatoire + "' est impair! ... Votre stack augmente de " + mise * 20);
                    Console.WriteLine("Votre stack est actuellement = " + (stack + (mise * 20)));
                    Console.WriteLine("---------------------------------------");
                }
                else
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("PERDU!!! La roulette a choisi le chiffre : "+aleatoire+ " \nIl vous reste : " + (stack = stack - mise) + " dans votre stack! (°v°)");
                    Console.WriteLine("---------------------------------------");
                /* if (stack == 0)
                 {
                     Console.WriteLine("Merci de passer à la Banque pour pouvoir rejouer! ^_^");
                     Console.WriteLine("---------------------------------------");
                 }*/

                Console.ReadKey();
            }

        }

    }
}
