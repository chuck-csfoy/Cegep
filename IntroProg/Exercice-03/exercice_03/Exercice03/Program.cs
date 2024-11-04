using System;

namespace Exercice03
{
    public class Program
    {
        public const float PI = 3.14159265359f;
        public const float REBATE_RATE = 0.10f;
        public const float TPS_RATE = 0.05f;
        public const float TVQ_RATE = 0.09975f;

        public static void Main(string[] args)
        {
            CirclePerimeter();
            NumbersAverage();
            ApplyRebate();
            SwapNumbers();
            ComputePriceWithTaxes();
        }

        public static void CirclePerimeter()
        {
            float radius = 5.5f;

            float circlePerimeter = 2 * PI * radius;
            Console.Out.WriteLine("circlePerimeter = " + circlePerimeter);
        }

        public static void NumbersAverage()
        {
            int number1 = 75;
            int number2 = 88;
            int number3 = 53;

            int nbAvg = ((number1 + number2 + number3) / 3);
            Console.Out.WriteLine("average = " + nbAvg);
        }

        public static void ApplyRebate()
        {
            float priceCad = 75.0f;

            float applyRebate = (priceCad - (priceCad * REBATE_RATE));
            Console.Out.WriteLine("amountWintRebate = " + applyRebate);
        }

        public static void SwapNumbers()
        {
            int number1 = 1;
            int number2 = 2;
            int temp;

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.Out.WriteLine($"La valeur échangé de number1 est : {number1}\nLa valeur échangé de number2 est : {number2}\n");
        }

        public static void ComputePriceWithTaxes()
        {
            float price = 100.0f;

            float computePriceWithTaxes = (price + (price * TPS_RATE) + (price * TVQ_RATE));
            Console.Out.WriteLine("amountWintTaxes = " + computePriceWithTaxes);
        }
    }
}
