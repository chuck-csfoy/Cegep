namespace Exercice_1
{
    public class Library
    {
        //1.1 indice de masse corporelle
        public static float CalculateBMI(float weight, float height)
        {
            if (weight < 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("Weight and height must be non-negative, and height must be greater than zero.");
            }

            float BMI = weight / (height * height);
            //float BMI = weight / Math.Pow(height, 2);
            return BMI;
        }
        //1.2 Valeur minimale et valeur maximale
        public static int FindMinValue(int [] values)
        {
            if (values is null)
            {
                throw new ArgumentException("Array can't be null");
            }
            int minNumber = int.MaxValue;
            int index = 0;
            int valuesLength = values.Length;

            while (index < valuesLength)
            {
                if (values[index] < minNumber)
                {
                    minNumber = values[index];
                }
                index++;
            }
            return minNumber;
        }

        public static int FindMaxValue(int[] values)
        {
            if (values is null)
            {
                throw new ArgumentException("Array can't be null");
            }
            int maxNumber = int.MinValue;
            int index = 0;
            
            while (index < values.Length)
            {
                if (values[index] > maxNumber)
                {
                    maxNumber = values[index];
                }
                index++;
            }
            return maxNumber;
        }

        //1.3 Recherche
        public static bool LinearSearch (int[] originalArray, int value)
        {
            if (originalArray is null)
            {
                throw new ArgumentException("Array can't be null");
            }

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (value == originalArray[i])
                {
                    return true;
                }
            }

            return false;
        }
        //1.4 Vérifier tri
        public static bool VerifySort (int[] originalArray)
        {
            if (originalArray is null)
            {
                throw new ArgumentException("Array can't be null");
            }
            if (originalArray.Length > 1)
            {
                for (int i = 0; i < originalArray.Length - 1; i++)
                {
                    if (originalArray[i] > originalArray[i + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //1.5 Inverser
        public static int[] ReverseArrayValues(int[] originalArray)
        {
            if (originalArray is null)
            {
                throw new ArgumentException("Array can't be null");
            }
            int[] reverseArray = new int[originalArray.Length];

            for (int i = originalArray.Length - 1; i >= 0; i--)
            {
                reverseArray[originalArray.Length - 1 - i] = originalArray[i];
            }

            return reverseArray;
        }

        //1.6 Échange
        public static void SwapArrayValues (int[] originalArray, int swapIndex1, int swapIndex2)
        {
            if (originalArray is null)
            {
                throw new ArgumentException("Array can't be null");
            }

            if (swapIndex1 < 0 || swapIndex2 < 0 || swapIndex1 >= originalArray.Length || swapIndex2 >= originalArray.Length)
            {
                throw new ArgumentException("Index is out of bounds");
            }

            int temp = originalArray[swapIndex1];
            originalArray[swapIndex1] = originalArray[swapIndex2];
            originalArray[swapIndex2] = temp;
        }

        //1.7 Somme des tableaux
        public static int[] SumOfTwoArrays (int[] arrayA, int[] arrayB)
        {
            if (arrayA == null || arrayB == null)
            {
                throw new ArgumentException("Arrays cannot be null");
            }
            if (arrayA.Length != arrayB.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            int[] resultArray = new int[arrayA.Length];
            
            for (int i = 0; i < arrayA.Length; i++)
            {
               resultArray[i] = arrayA[i] + arrayB[i];   
            }

            return resultArray;
        }

        //1.8 Insérer
        public static void InsertNewValueInArray (float[] originalArray, int insertIndex, float valueToInsert)
        {
            if (originalArray is null)
            {
                throw new ArgumentException("The array cannot be null.");
            }
            if (originalArray.Length == 0)
            {
                throw new ArgumentException("The array cannot be empty");
            }
            if (insertIndex < 0 || insertIndex >= originalArray.Length)
            {
                throw new ArgumentException("Insert index is out of bounds.");
            }

            for (int i = originalArray.Length -1; i > insertIndex; i--)
            {
                originalArray[i] = originalArray[i - 1];
            }
            
            originalArray[insertIndex] = valueToInsert;
        }
    }
}
