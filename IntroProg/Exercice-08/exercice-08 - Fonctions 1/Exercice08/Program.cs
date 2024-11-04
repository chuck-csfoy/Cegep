using System;

namespace Exercice08
{
  public class Program
  {
    public const float COST_PER_COURSE_RESIDENT = 150.00f;
    public const float COST_PER_COURSE_NON_RESIDENT = 320.00f;

    public const float COST_ACCESS = 4.00f;
    public const float COST_SKATING = 4.00f;
    public const float COST_SKIING = 6.00f;
    public const float CHILD_REBATE_RATE = 0.50f;
    public const int CHILD_REBATE_MAX_AGE = 12;

    public static void Main(string[] args)
    {
      float tuitionFees = ComputerTuitionFees(0, true);
      Console.WriteLine($"tuitionFees = {tuitionFees}");

      float ticketPrice = ComputeTicketPrice(13, false, false);
      Console.WriteLine($"ticketPrice = {ticketPrice}");

      int sumOfDigits = ComputeSumOfDigits(48);
      Console.WriteLine($"sumOfDigits = {sumOfDigits}");

      int sumOfEvenNumbers = ComputeSumOfEvenNumbers(5);
      Console.WriteLine($"SumOfEvenNumbers = {sumOfEvenNumbers}");
    }
    public static float ComputerTuitionFees(int nbCourses, bool isResident)
    {
      float tuitionFees = COST_PER_COURSE_NON_RESIDENT * nbCourses;

      if (isResident)
      {
        tuitionFees = COST_PER_COURSE_RESIDENT * nbCourses;
      }
      return tuitionFees;
    }
    public static float ComputeTicketPrice(int age, bool isSkating, bool isSkiing)
    {
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
        ticketPrice = ticketPrice - (ticketPrice * CHILD_REBATE_RATE);
      }
      return ticketPrice;
    }
    public static int ComputeSumOfDigits(int number)
    {
      int sumOfDigits = 0;
      
      while (number > 0)
      {
        int temp = number % 10;
        sumOfDigits += temp;
        number /= 10;
      }
      return sumOfDigits;
    }
    public static int ComputeSumOfEvenNumbers(int nbEvenNumbers)
    {
      int sumOfEvenNumbers = 0;
      int i = 0; 
      while (i < nbEvenNumbers)
      {
        sumOfEvenNumbers += (i * 2);
        i++;
      }
      return sumOfEvenNumbers;
    }
  }
}
