using System;

namespace Exercice05
{
    public class Program
    {
        //Constantes pour le numéro 1.3
        public const float HIGH_COMMISSION_MINIMAL_SALES = 10_000.00f;
        public const float HIGH_COMMISSION_RATE = 0.10f;
        public const float LOW_COMMISSION_RATE = 0.085f;

        //Constantes pour le numéro 1.4
        public const int EXAM_1_VALUE = 60;
        public const int EXAM_2_VALUE = 40;
        public const int MINIMAL_GRADE = 60;

        //Constantes pour le numéro 1.5
        public const float COST_PER_COURSE_RESIDENT = 150.00f;
        public const float COST_PER_COURSE_NON_RESIDENT = 320.00f;

        //Constantes pour le numéro 1.6
        public const float COST_ACCESS = 4.00f;
        public const float COST_SKATING = 4.00f;
        public const float COST_SKIING = 6.00f;
        public const float CHILD_REBATE_RATE = 0.50f;
        public const int CHILD_REBATE_MAX_AGE = 12;

        public static void Main(string[] args)
        {
            FindSmallerNumber2Values();
            FindSmallerNumber3Values();
            ComputeSellerCommission();
            HasStudentPassed();
            ComputeTuitionFees();
            ComputeTicketPrice();
        }

        public static void FindSmallerNumber2Values()
        {
            int nb1 = 2;
            int nb2 = 2;
            int smallestNumber = nb2;
            if (nb1 < nb2)
            {
                smallestNumber = nb1;
            }
            Console.WriteLine("smallestNumber = " + smallestNumber);
        }

        public static void FindSmallerNumber3Values()
        {
            int nb1 = 3;
            int nb2 = 2;
            int nb3 = 1;
            int smallestNumber = nb3;
            if (nb1 < nb2)
            {
                smallestNumber = nb1;
            }
            else if (nb2 < nb3)
            {
                smallestNumber = nb2;
            }
            Console.WriteLine("smallestNumber = " + smallestNumber);
        }

        public static void ComputeSellerCommission()
        {
            float salesAmount = 3500.95f;
            float sellerCommission = (HIGH_COMMISSION_RATE * salesAmount);

            if (salesAmount < HIGH_COMMISSION_MINIMAL_SALES)
            {
                sellerCommission = (LOW_COMMISSION_RATE * salesAmount);
            }
            Console.WriteLine("sellerCommission = " + sellerCommission);
        }

        public static void HasStudentPassed()
        {
            float gradeExam1 = 59.00f;
            float gradeExam2 = 59.00f;
            //Je divise la constante qui est un nombre entier par un float pour conserver la precision dans l'operation.
            float gradeValueExams = (gradeExam1 * (EXAM_1_VALUE / 100.0f)) + (gradeExam2 * (EXAM_2_VALUE / 100.0f));
            bool finalGrade = false;

            if (gradeValueExams >= MINIMAL_GRADE)
            {
                finalGrade = true;
            }
            Console.WriteLine("finalGrade = " + finalGrade);
        }

        public static void ComputeTuitionFees()
        {
            bool isResident = true;
            int nbCourses = 0;
            float tuitionFees = COST_PER_COURSE_NON_RESIDENT * nbCourses;

            if (isResident)
            {
                tuitionFees = COST_PER_COURSE_RESIDENT * nbCourses;
            }
            Console.WriteLine("tuitionFees = " + tuitionFees);
        }

        public static void ComputeTicketPrice()
        {
            int age = 13;
            bool isSkating = true;
            bool isSkiing = false;
            float ticketPrice = COST_ACCESS;

            if (isSkating)
            {
                ticketPrice += COST_SKATING;
            }
            if (isSkiing)
            {
                ticketPrice += COST_SKIING;
            }
            if (age < CHILD_REBATE_MAX_AGE)
            {
                // prof
                // Calcul incorrect. Ça fonctionne uniquement parce que c'est 50%
                // ticketPrice *= (1.0f-CHILD_REBATE_RATE);
                ticketPrice *= CHILD_REBATE_RATE;
            }
            Console.WriteLine("ticketPrice = " + ticketPrice);
        }
    }
}
