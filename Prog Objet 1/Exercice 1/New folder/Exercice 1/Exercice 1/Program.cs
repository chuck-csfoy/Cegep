using Exercice_1;

public class Program
{ 
    public static void Main(string [] args)
    {
        float weight = 0;
        float height = 0;
        Library.CalculateBMI(weight, height);
        int[] values = { };
        int[] originalArray = { };
        int value = 0;
        Library.FindMinValue(values);
        Library.FindMaxValue(values);
        Library.LinearSearch(originalArray, value);

    }
}

