using System;
using System.Runtime.InteropServices;

namespace Exercice18
{
  public class Library
  {
    // TODO Créer la fonction "Append".
    public static int[] Append(int[] originalArray, int newElement)
    {
      if (originalArray is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      int[] appendedArray = new int[originalArray.Length+1];
      int index;
      for (index = 0; index < originalArray.Length; index++)
      {
        appendedArray[index] = originalArray[index];
      }
      appendedArray[index] = newElement;
      return appendedArray;
    }
    // TODO Créer la fonction "GetDistinctElements".
    public static int[] GetDistinctElements(int[] arrayA, int[] arrayB)
    {
      if (arrayA is null || arrayB is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      int[] arrayC = { };
      for (int i = 0; i < arrayA.Length; i++)
      {
        if (!Contains(arrayA[i],arrayB))
        {
          arrayC = Append(arrayC, arrayA[i]);
        }
      }
      return arrayC;
    }
    // TODO Créer la fonction "Contains".
    public static bool Contains(int elementOfArrayA, int[] arrayB)
    {
      bool isIntContainedInArrayOfInt = false;
      for (int i = 0; i < arrayB.Length; i++)
      {
        if (elementOfArrayA == arrayB[i])
        {
          isIntContainedInArrayOfInt = true;
        }
      }
      return isIntContainedInArrayOfInt;
    }
    // TODO Créer la fonction "Reverse".
    public static int[] Reverse(int[] originalArray)
    {
      if (originalArray is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      int[] reverseArray = { };
      for (int i = originalArray.Length-1; i >= 0; i--)
      {
        reverseArray = Append(reverseArray, originalArray[i]);
      }
      return reverseArray;
    }
  }
}
