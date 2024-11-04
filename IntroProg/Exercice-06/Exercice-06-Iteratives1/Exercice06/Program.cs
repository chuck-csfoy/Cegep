using System;

namespace Exercice06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //PrintNumbers();                   // Question 1
            //ComputeSum();                     // Question 2
            //ComputeProductOfEvenNumbers();    // Question 3
            //ComputeSumOfDigits();             // Question 4
            GreatestCommonDivisor();          // Question 5 [Bonus]
        }

        public static void PrintNumbers()
        {
            int numberMin = 3;
            int numberMax = 9;
            int i = numberMin;
            for (i = numberMin; i <= numberMax; i++)
            {
                Console.WriteLine($"printNumbersRange : {i}");
            }
        }

        public static void ComputeSum()
        {
            int limitNumber = 5;
            int i = 1;
            int sum = 0;
            while (i <= limitNumber)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"numberSum = {sum}");
        }
        //Exemple de Solution de PierreP. avec boule for()
        //public static void ComputeSum()
        //{
        //    int limitNumber = 5;
        //    int sum = 0;
        //    for (int i = 1; i <= limitNumber; i++)
        //    {
        //        sum = sum + i;
        //    }
        //    Console.WriteLine($"numberSum = + {sum}");
        //}

        public static void ComputeProductOfEvenNumbers()
        {
            int limitNumber = 10;
            int i = 2;
            int product = 1;
            while (i <= limitNumber)
            {
                product *= i;
                i += 2;
            }
            Console.WriteLine($"ProductOfEvenNumbers = {product}");
        }
        //public static void ComputeProductOfEvenNumbers()
        //{
        //    int limitNumber = 10;
        //    int product = 1;
        //    for (int i = 2; i <= limitNumber; i+=2)
        //    {
        //        product *= i;
        //    }
        //    Console.WriteLine($"ProductOfEvenNumbers = {product}");
        //}

        public static void ComputeSumOfDigits()
        {
            // Entrées ***ATTENTION : Noubliez pas d<incure un cas a trois chiffres exemple 123: 6 = (1+2+3) l'algo doit fonctionner dans tous les cas.***
            int number = 48;
            int sumOfDigits = 0;
            int temp;
            
            while(number > 0)
            {
                temp = number % 10;
                sumOfDigits += temp;
                number /= 10;
            }
            Console.WriteLine($"sumOfDigits = {sumOfDigits}");
        }

        public static void GreatestCommonDivisor()
        {
            //***ATTENTION : ERROR TABLEAU Var ligne 5 b = 72***
            //PGCD(a, b) = PGCD(b, a % b) tant que b != 0
            int a = 128;
            int b = 72;
            int pgcd;
            do {
                pgcd = a % b;
                a = b;
                b = pgcd;
            } while ((a % b) > 0);
            Console.WriteLine($"pgcd = {pgcd}");
        }
    }
}
