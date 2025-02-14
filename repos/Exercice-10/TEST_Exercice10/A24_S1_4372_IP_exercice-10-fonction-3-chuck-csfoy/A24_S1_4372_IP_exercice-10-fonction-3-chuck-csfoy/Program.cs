using System;

public class Program
{
  const int ROLLDICE6 = 1;
  const int ROLLDICE20 = 2;
  const int QUIT = 3;
  const int MIN = 1;
  const int MAXDICE_6 = 6;
  const int MAXDICE_20 = 20;

  public static void Main(string[] args)
  {
    int    diceValue;
    string Question = $"Choose from the following options : ({ROLLDICE6}) Roll dice 6, ({ROLLDICE20}) Roll dice 20, ({QUIT}) Quit";
    bool   isQuitting = false;

    while (!isQuitting)
    {
      int userChoice = AskUserChoice(Question);
      if (userChoice == ROLLDICE6)
      {
        diceValue = RollDice(MAXDICE_6);
        DisplayResult(diceValue, MAXDICE_6);
      }
      if (userChoice == ROLLDICE20)
      {
        diceValue = RollDice(MAXDICE_20);
        DisplayResult(diceValue, MAXDICE_20);
      }
      if (userChoice == QUIT)
      {
        isQuitting = true;
        Console.WriteLine("SEEYA");
      }
    }
  }
  public static int GenerateRandomNumber(int Min, int Max)
  {
    int    numberGenerated;
    Random random = new Random();
    numberGenerated = random.Next(Min, Max + 1);//Max +1: La valeur superieur MAX n'est jamais incluse dans les resultats random
    return numberGenerated;
  }
  public static int AskUserChoice(string Question)
  {
    int  userChoice = 0;
    bool isConversionOk = false;
    do
    {
      Console.WriteLine(Question);
      string userInput = Console.ReadLine();
      isConversionOk = int.TryParse(userInput, out userChoice);
      if (userChoice != ROLLDICE6 && userChoice != ROLLDICE20 && userChoice != QUIT)
      {
        Console.WriteLine("ERROR");
      }
    } while (!isConversionOk || userChoice < ROLLDICE6 || userChoice > QUIT);
    return userChoice;
  }
  public static int RollDice(int nbSides)
  {
    int diceValue = 0;

    if (nbSides == MAXDICE_6)
    {
      diceValue = GenerateRandomNumber(MIN, MAXDICE_6);
    }
    else if (nbSides == MAXDICE_20)
    {
      diceValue = GenerateRandomNumber(MIN, MAXDICE_20);
    }
    return diceValue;
  }
  public static void DisplayResult(int diceValue, int nbSides)
  {
    Console.WriteLine($"Dice roll {nbSides} : {diceValue}");
  }
}
