using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace Exercice20
{
  public static class Library
  {
    // TODO : Faire la fonction BubbleSort.
    public static void BubbleSort(int[] originalArray)
    {
      if (originalArray is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      bool isValueToSwap = false;
      do
      {
        isValueToSwap = false;
        for (int i = 0; i < originalArray.Length - 1; i++)
        {
          if (originalArray[i] > originalArray[i + 1])
          {
            int temp = originalArray[i];
            originalArray[i] = originalArray[i + 1];
            originalArray[i + 1] = temp;
            isValueToSwap = true;
          }
        }
      } while (isValueToSwap);
    }
    // TODO : Faire la fonction LinearSearch.
    public static int LinearSearch(int elementToSearch, int[] originalArray)
    {
      if (originalArray is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      
      bool isElementToSearchFound = false;
      int positionElementToSearch = 0;
      for (int i = 0; i < originalArray.Length; i++)
      {
        if (originalArray[i] == elementToSearch)
        {
          positionElementToSearch = i;
          isElementToSearchFound = true;
        }
        else if (!isElementToSearchFound)
        {
          positionElementToSearch = -1;
        }
      }
      if (originalArray.Length == 0)
      {
        positionElementToSearch = -1;
      }
      return positionElementToSearch;
    }
    // TODO : Faire la fonction BinarySearch.
    public static int BinarySearch(int elementToSearch, int[] originalArray)
    {
      if (originalArray is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      int indexMin = 0;
      int indexMax = originalArray.Length - 1;
      while (indexMax >= indexMin)
      {
        int indexMid = indexMin + (indexMax - indexMin) / 2;
        if (originalArray[indexMid] == elementToSearch)
        {
          return indexMid;
        }
        else if (originalArray[indexMid] < elementToSearch)
        {
          indexMin = indexMid + 1;
        }
        else
        {
          indexMax = indexMid - 1;
        }
      }
      return -1;
    }
  }
}