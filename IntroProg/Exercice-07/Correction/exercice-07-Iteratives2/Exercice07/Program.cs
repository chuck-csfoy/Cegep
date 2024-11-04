using System;
using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace Exercice07
{
  public class Program
  {
    const string USERNAME = "intro";
    const string PASSWORD = "w10";
    public static void Main(string[] args)
    {
      ReadNumber();
      ReadUsernamePassword();
      ReadUsernamePasswordLimitedAttempts();
      GenerateRandomNumbers();
    }
    public static void ReadNumber()
    {
      const int MIN = 0;
      const int MAX = 10;

      bool success = false;
      int number;

      do
      {
        Console.WriteLine($"Entrez un nombre entre {MIN} et {MAX} : ");
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
          success = (number >= MIN && number <= MAX);
        }
      } while (!success);
      Console.WriteLine($"Le nombre saisi est un nombre entier");
    }

    public static void ReadUsernamePassword()
    {
      bool authentification = false;

      do
      {
        Console.WriteLine($"Enter Username");
        string username = Console.ReadLine();
        Console.WriteLine($"Enter Password");
        string password = Console.ReadLine();
        if ((username == USERNAME) && (password == PASSWORD))
        {
          authentification = true;
          Console.WriteLine($"Authentification réussie");
        }
        else
        {
          Console.WriteLine($"Authentification échouée");
        }
      } while (!authentification);
    }

    public static void ReadUsernamePasswordLimitedAttempts()
    {
      bool authentification = false;
      int attempts = 1;
      //Aurait du creer une Constante pour MAX_ATTEMPS qui elle est egale a 3. Et ensuite comparer attempts a la constante MAX_ATTEMPS.
      do
      {
        Console.WriteLine($"Enter Username");
        string username = Console.ReadLine();
        Console.WriteLine($"Enter Password");
        string password = Console.ReadLine();
        if ((username == USERNAME) && (password == PASSWORD))
        {
          authentification = true;
          Console.WriteLine($"Authentification réussie");
        }
        // prof
        // Tu aurais pu (et dû) utiliser une constante pour 3
        /*utilise une fois -20%*/
        else if (attempts == 3)
        {
          Console.WriteLine($"Essaies d'authentification échouées");
          break;
        }
        else
        {
          Console.WriteLine($"Authentification échouée");
        }
        attempts++;
        // prof
        // Tu aurais pu (et dû) utiliser une constante pour 3
        /*utilise une 2e fois -20% encore*/
      } while (!authentification && (attempts <= 3));
    }
    public static void GenerateRandomNumbers()
    {
      const int NB_TO_GENERATE = 3000;

      int nbBetween01And33 = 0;
      int nbBetween34And66 = 0;
      int nbBetween67And99 = 0;

      int nbGenerated = 0;

      Random random = new Random();
      while (nbGenerated < NB_TO_GENERATE)
      {
        int value = random.Next(1, 100);
        // prof
        // Condition erronée. Pourquoi vérifier si < 3000 alors que tu demandes < 100?
        // ***CPW ATTENTION CETTE CONDITION CI-DESSOUS EST SURPERFLUE et incorrecte de comparer la valeur avec une quantitee d'entrees*** 
        /*if (value <= NB_TO_GENERATE)*/
        //{
        if (value <= 33)
        {
          nbBetween01And33++;
        }
        else if (value <= 66)
        {
          nbBetween34And66++;
        }
        else
        {
          nbBetween67And99++;
        }
        //}
        nbGenerated++;
      }
      Console.WriteLine($"Nombre de valeurs entre 01 et 33 (inclusivement) = {nbBetween01And33}");
      Console.WriteLine($"Nombre de valeurs entre 34 et 66 (inclusivement) = {nbBetween34And66}");
      Console.WriteLine($"Nombre de valeurs entre 67 et 99 (inclusivement) = {nbBetween67And99}");
    }
  }
}
