using System;

namespace Exercice18b
{
  public class Library
  {
    // Code de la fonction Clamp
    public static void Clamp(int[] originalArray, int minArrayValue, int maxArrayValue)
    {
      if (originalArray == null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      for (int i = 0; i < originalArray.Length; i++)
      {
        if (originalArray[i] <= minArrayValue)
        {
          originalArray[i] = minArrayValue;
        }
        if (originalArray[i] >= maxArrayValue)
        {
          originalArray[i] = maxArrayValue;
        }
        int[] modifiedArray = originalArray;
      }
    }

    // Code de la fonction Insert
    public static int[] Insert(int[] originalArray, int positionToInsert, int newElement)
    {
      if (originalArray == null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      if (positionToInsert < 0 || positionToInsert > originalArray.Length)
      {
        throw new ArgumentException("Index to insert new integer can't be out of range");
      }
      int[] resultArrayWithNewELementAdded = new int[originalArray.Length + 1];
      for (int i = 0; i < positionToInsert; i++)
      {
        resultArrayWithNewELementAdded[i] = originalArray[i];
      }
      resultArrayWithNewELementAdded[positionToInsert] = newElement;
      for (int i = positionToInsert; i < originalArray.Length; i++)
      {
        resultArrayWithNewELementAdded[i + 1] = originalArray[i];
      }
      return resultArrayWithNewELementAdded;
    }

    // Code de la fonction Dedup
    // CPW: La fonction "GetDistinctElements" (Difference) de l'exercice 18a aurait pu etre réutilisée ici.
    // Par contre, je cherchais a résaliser cet excercie sans réutiliser la fonction "Append" même si la taille du tableau soit inconnue
    // suivants vos commentaires sur l'excercie 18a afin d'eviter d'allouer un tableau a plusieurs reprises.
    // J'y ai investi beaucoup de temps mais j'estime cette version plus adéquate et plus efficace.

    public static int[] Dedup(int[] originalArray)
    {
      if (originalArray is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      int[] tempArray = new int[originalArray.Length];
      int neverSeenCount = 0;
     
      for (int i = 0; i < originalArray.Length; i++)
      {
          int currentPositionElement = originalArray[i];
          if (!Contains(currentPositionElement, tempArray))
          {
            tempArray[neverSeenCount] = currentPositionElement;
            neverSeenCount++;
          }
      }
      int[] resultArrayWithoutDup = new int[neverSeenCount];
      for (int i = 0; i < neverSeenCount; i++)
      {
        resultArrayWithoutDup[i] = tempArray[i];
      }
      return resultArrayWithoutDup;
    }

    // Code de la fonction Contains qui n'est pas demandée mais qui risque
    // d'être utile pour la fonction Dedup
    // CPW: Version modifiée de la fonction "Contains" suivant a vos commentaires.
    public static bool Contains(int elementToSearch, int[] inputArray)
    {
      if (inputArray is null)
      {
        throw new ArgumentException("Array or values can't be null or empty");
      }
      bool isContainedInInputArray = false;
      for (int i = 0; i < inputArray.Length; i++)
      {
        if (elementToSearch == inputArray[i])
        {
          isContainedInInputArray = true;
        }
      }
      return isContainedInInputArray;
    }
  }
}
