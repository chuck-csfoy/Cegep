
using System.Security.Cryptography;

namespace Exercice23
{
  public class Program
  {
    const string USER_PROMPT = "Enter a positive numbers to be added to a list or a negative value entry number to exit";
    public static void Main(string[] args)
    {
      List<int> listPositiveNumbers = new List<int>();

      AddNumbersToList(listPositiveNumbers);

      DisplayListNumbers(listPositiveNumbers);

      GetMaxListValue(listPositiveNumbers);

      DeletePairValuesFromList(listPositiveNumbers);

      DisplayListNumbers(listPositiveNumbers);

    }
    public static int AskUserInputNumbers()
    {
      int userInputNumbers = 0;
      bool isParseOk = false;
      do {
        Console.WriteLine(USER_PROMPT);
        string userInputString = Console.ReadLine();
        isParseOk = int.TryParse(userInputString, out userInputNumbers);

      } while (!isParseOk);
      return userInputNumbers;
    }
    public static void AddNumbersToList(List <int> listPositiveNumbers)
    {
      int userInput = -1;
      do
      {
        userInput = AskUserInputNumbers();
        if(userInput > 0)
        {
          listPositiveNumbers.Add(userInput);
        }
      } while (userInput > 0);
    }
    public static void DisplayListNumbers(List <int> p_list)
    {
      
      int lastElementOfString = p_list[p_list.Count-1];
      string DisplayResult = "[";

      for (int i = 0; i < p_list.Count; i++)
      {
        DisplayResult += p_list[i];
        DisplayResult += ',';

        if (i == p_list.Count -1)
        {
          DisplayResult = DisplayResult.Remove((DisplayResult.Length - 1)); //remove the comma at last position.
        }
      }
        DisplayResult += "]";

      //foreach (int value in list)
      //{
      //  if (value < lastElementOfString)
      //  {
      //    displayListFormat += value;
      //    displayListFormat += ',';
      //  }
      //  else if (value == lastElementOfString)
      //  {
      //    displayListFormat += value;
      //  }
      //}
      //  displayListFormat += ']';
      Console.WriteLine(DisplayResult);
    }
    public static void GetMaxListValue(List<int> listPositiveNumbers)
    {
      int max = 0;
      foreach(int value in listPositiveNumbers)
      {
        while (value > max)
        {
          max = value;
        }
      }
        Console.WriteLine("La valeur maximum de la liste est: " + max);
    }
    public static void DeletePairValuesFromList(List<int> listPositiveNumbers)
    {
      int listLen = listPositiveNumbers.Count;
      for (int i = listLen -1; i >= 0; i--)
      {
        if (listPositiveNumbers[i] % 2 == 0)
        {
          listPositiveNumbers.RemoveAt(i);
        }
      }
    }
  }
}