using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRoulette
{
    class TestInteger
    {

        public int GetStack(int stackBanque)
        {
            var StackChoisi = 0;
            bool choix = false;
            while (choix == false)
            {
                Console.WriteLine("- Choisir le stack: ");
                Console.WriteLine("---------------------------------------");
                string stackSaisi = Console.ReadLine();

                if (int.TryParse(stackSaisi, out StackChoisi))
                {
                    choix = true;
                    if (StackChoisi >= 0 && StackChoisi <= stackBanque)
                    {
                        Console.WriteLine("Vous avez " + StackChoisi + " dans le stack =^.^=");
                        Console.WriteLine("---------------------------------------");
                        //return StackChoisi;
                    }

                    else
                    {
                        Console.WriteLine("Erreur! le nombre de saisi doit être entre 0 et 1000 svp =^.^= ");
                        choix = false;
                    }


                }
                else
                {
                   // choix = false;
                    Console.WriteLine("Erreur! le nombre de saisi doit être un chiffre entier!:!:!:!");

                }
                
            }
            return StackChoisi;

        }

        //********************************************************************************************************

        public int GetNumber()
        {
            int NbrChoisi = 0;
            bool choix = false;
            while (choix == false)
            {
                Console.WriteLine("- Choisir Un nombre : ");
                Console.WriteLine("---------------------------------------");
                string nbrSaisi = Console.ReadLine();

                if (int.TryParse(nbrSaisi, out NbrChoisi))
                {
                    choix = true;
                    if (NbrChoisi >= 0 && NbrChoisi <= 36)
                    {
                        Console.WriteLine("Vous avez choisi le numéro " + NbrChoisi + " Bonne chance =^.^=");
                        return NbrChoisi;
                    }

                    else
                    {
                        Console.WriteLine("Erreur! le nombre  doit être entre 0 et 36 svp =^.^= ");
                        choix = false;
                    }


                }
                else
                {
                    choix = false;
                    Console.WriteLine("Erreur! le nombre de saisi doit être un chiffre entier!:!:!:!");

                }
            }
            return NbrChoisi;
        }

        //*****************************************************************************

        public int GetMise(int stack, int number)
        {
            int NbrMise = 0;
            bool choix1 = false;
            while (choix1 == false)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("- Choisir Une mise pour le chiffre "+number);
                Console.WriteLine("---------------------------------------");
                string nbrSaisi = Console.ReadLine();

                if (int.TryParse(nbrSaisi, out NbrMise))
                {
                    choix1 = true;
                    if ( NbrMise <= stack)
                    {
                        Console.WriteLine("Vous avez misé sur le numéro "+number+" un stack de " + NbrMise + " Bonne chance =^.^=");
                        //Console.WriteLine("Dans le stack il vous reste: "+(GetStack() - GetMise()));
                        
                        return NbrMise;
                    }

                    else
                    {                        
                        Console.WriteLine(" (°v°) Erreur! la mise doit être inferieure ou égale à "+stack);
                        choix1 = false;
                    }


                }
                else
                {
                    choix1 = false;
                    Console.WriteLine("Erreur! le nombre de saisi doit être un chiffre entier!:!:!:!");

                }
            }
            return NbrMise;
        }
        //***********************************************
        /*static string Rejouer(int stack2, int number)
        {
            int? g;
            Console.WriteLine("Voulez-vous une nouvelle partie ? o / n ?");
            string nbrSaisi = Console.ReadLine();
            if (nbrSaisi == "o")
            {
                Console.WriteLine("Vous avez en stack  : "+stack2);
                

            }
               

            return;
        }
        */


    }
}
