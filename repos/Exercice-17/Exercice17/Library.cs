using System;

namespace Exercice17
{
  public class Library
  {
    public static int Sum(int[] values)
    {
      int index = 0;

      if (values is null)
      {
        throw new ArgumentException("Array or values can't be null");
      }
      int sum = 0;
      int valuesLength = values.Length;
      while (index < valuesLength)
      {
        sum += values[index];
        index++;
      }
      return sum;
    }

    public static int Average(int[] values)
    {
      int averageOfValues = 0;
      if (values is null)
      {
        throw new ArgumentException("Array or values can't be null");
      }
      int totalNbOfValues = values.Length;
      if (totalNbOfValues > 0)
      {
        averageOfValues = Sum(values) /totalNbOfValues;
      }
      return averageOfValues;
    }

    public static int Max(int[] values)
    {
      if (values is null)
      {
        throw new ArgumentException("Array or values can't be null");
      }
      int maxNumber = int.MinValue;
      int index = 0;
      int valuesLength = values.Length;
      while (index < valuesLength)
      {
        if (values[index] > maxNumber)
        {
          maxNumber = values[index];
        }
        index++;
      }
      return maxNumber;
    }

    public static bool IsEven(int numbers)
    {
      bool isEven = false;
      if (numbers % 2 == 0)
      {
        isEven = true;
      }
      return isEven;
    }

    public static int CountEven(int[] numbers)
    {
      int evenNumbersCount = 0;
      int index = 0;
      while (index < numbers.Length)
      {
        if (IsEven(numbers[index]))
        {
          evenNumbersCount += 1;
        }
        index++;
      } 
      return evenNumbersCount;
    }

    public static int[] FilterEven(int[] values)
    {
      if (values is null)
      {
        throw new ArgumentException("Array or values can't be null");
      }
      int[] evenNumbers = new int[CountEven(values)];
      int index1 = 0;
      int index2 = index1;
      while (index1 < values.Length)
      {
        if (IsEven(values[index1]))
        {
          evenNumbers[index2] = values[index1];
          index2++;
        }
        index1++;
      }
      return evenNumbers;
    }
  }
}
