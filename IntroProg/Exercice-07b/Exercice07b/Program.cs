using System;

namespace Exercice07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //PrimeNumber();
            ReverseNumber();
            //FindNumber();
        }


        public static void PrimeNumber()
        {
            int nb = 17;
            int divider = 2; //divider est intialisé a 2 parcequ'il n'est pas utile de diviser par un ou zéro pour déterminer un nombre premier.
            bool isPrime = false;

            while (divider < nb)
            {
                if ((nb % divider) == 0)
                {
                    isPrime = false;
                    Console.WriteLine($"{isPrime}: {nb} n'est pas nombre premier");
                    break;
                }
                divider++;
            }
            if (nb == divider)
            {
                isPrime = true;
                Console.WriteLine($"{isPrime}: {nb} est un nombre premier");
            }
        }

        public static void ReverseNumber()
        {
            int nb = 1234;
            int reverseNumber = 0;
            int unit;

            while (nb > 0)
            {
                unit = nb % 10;
                reverseNumber = (reverseNumber * 10) + unit;
                nb /= 10;
            }
            Console.WriteLine($"reverseNumber = {reverseNumber}");
        }

        public static void FindNumber()
        {
            const int MIN = 0;
            const int MAX = 99;
            int enteredNb = -1;

            Random random = new Random();
            int numberGenerated = random.Next(0, 99);
            Console.WriteLine(numberGenerated);
            while (enteredNb != numberGenerated)
            {
                Console.WriteLine($"Entrez un nombre entre {MIN} et {MAX} : ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out enteredNb))
                {
                    
                    if (enteredNb > numberGenerated)
                    {     
                        Console.WriteLine($"plus grand");
                    }
                    else if (enteredNb < numberGenerated)
                    {
                        Console.WriteLine($"plus petit");
                    }
                    else if (enteredNb == numberGenerated)
                    {
                        Console.WriteLine($"Félicitation vous avez réussi");
                    }
                }
            }
        }
    }
}
