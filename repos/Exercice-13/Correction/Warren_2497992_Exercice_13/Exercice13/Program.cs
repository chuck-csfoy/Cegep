using System;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Exercice13
{
    public class Program
    {
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;
        const int YES = 1;
        const int NO = 2;
        const int WINNER_PLAYER_1 = 1;
        const int WINNER_PLAYER_2 = 2;
        const int DRAW = 0;
        // PROF : C'est une bonne façon de faire! Très bonne chose également de le spécifier.
        //Je voulais déclarer comme variables globales. J'ai trouvé cette façon de déclarer qui semble adéquate sur :https://stackoverflow.com/questions/14368129/how-to-use-global-variables-in-c.
        public static readonly string STR_MENU_1 = $"Choose from the following options : ({ROCK}) ROCK, ({PAPER}) PAPER, ({SCISSORS}) SCISSORS";
        public static readonly string STR_MENU_2 = $"PLAY AGAIN ? ({YES}) YES or ({NO}) NO";

        public static void Main(string[] args)
        {
            int determinedWinner = -1;
            bool isQuitting = false;

            while (!isQuitting)
            {
                // PROF : pas besoin de le remettre dans une variable. Tu peux le passer en paramètre directement puisqu'il n'est pas modifié.
                string promptMenu = STR_MENU_1;
                int player1Choice = PromptInt(promptMenu);

                if (player1Choice == ROCK || player1Choice == PAPER || player1Choice == SCISSORS)
                {
                    int nbGenerated = GenerateRandom(ROCK, SCISSORS);
                    int player2Choice = nbGenerated;
                    determinedWinner = DetermineWinner(player1Choice, player2Choice);
                    int winner = determinedWinner;
                    ShowGameResults(player1Choice, player2Choice, winner);
                }
                promptMenu = STR_MENU_2;
                player1Choice = PromptInt(promptMenu);
                if (player1Choice == YES)
                {
                    isQuitting = false;
                }
                if (player1Choice == NO)
                {
                    isQuitting = true;
                    Console.WriteLine("Goodbye! Good Games!!!");
                    // PROF : en mettant isQuitting à true, pas besoin de break
                    break;
                }
            }
        }

        public static int PromptInt(string promptMenu)
        {
            int player1Choice = -1;
            bool isParseSuccess = false;

            // PROF : en procédant de cette façon, tu dupliques du code. Tu aurais pu extraire le code dupliqué.
            // La méthode devrait d'ailleurs seulement vérifier que la conversion est valide. 
            // On devrait faire la vérification de la plage de choix à l'extérieur ou dans une autre fonction.
            if (promptMenu == STR_MENU_1)
            {
                do
                {
                    Console.WriteLine(promptMenu);
                    string playerInput = Console.ReadLine();
                    isParseSuccess = int.TryParse(playerInput, out player1Choice);
                    if (player1Choice != ROCK && player1Choice != PAPER && player1Choice != SCISSORS)
                    {
                        Console.WriteLine("ERROR : PLEASE ENTER A VALID CHOICE");
                    }
                } while (!isParseSuccess || player1Choice < ROCK || player1Choice > SCISSORS);
            }
            if (promptMenu == STR_MENU_2)
            {
                do
                {
                    Console.WriteLine(promptMenu);
                    string playerInput = Console.ReadLine();
                    isParseSuccess = int.TryParse(playerInput, out player1Choice);
                    if (player1Choice != YES && player1Choice != NO)
                    {
                        Console.WriteLine("ERROR : PLEASE ENTER A VALID CHOICE");
                    }
                } while (!isParseSuccess || player1Choice < YES || player1Choice > NO);
            }
            Console.Clear(); // Permet d'effacer le contenu de la console
            return player1Choice;
        }
        public static int GenerateRandom(int ROCK, int SCISSORS)
        {
            int nbGenerated;
            Random random = new Random();
            nbGenerated = random.Next(ROCK, SCISSORS + 1);
            return nbGenerated;
        }

        public static int DetermineWinner(int player1Choice, int player2Choice)
        {
            int determinedWinner = DRAW;

            if ((player1Choice == ROCK && player2Choice == PAPER) || (player1Choice == PAPER && player2Choice == SCISSORS)
            || (player1Choice == SCISSORS && player2Choice == ROCK))
            {
                determinedWinner = WINNER_PLAYER_2;
            }
            else if ((player1Choice == ROCK && player2Choice == SCISSORS) || (player1Choice == PAPER && player2Choice == ROCK)
            || (player1Choice == SCISSORS && player2Choice == PAPER))
            {
                determinedWinner = WINNER_PLAYER_1;
            }
            if ((player1Choice == ROCK && player2Choice == ROCK) || (player1Choice == PAPER && player2Choice == PAPER)
            || (player1Choice == SCISSORS && player2Choice == SCISSORS))
            {
                determinedWinner = DRAW;
            }
            return determinedWinner;
        }
        public static string ChoiceToText(int playerChoice)
        {
            string textValue = "";

            switch (playerChoice)
            {
                case ROCK:
                    textValue = "Rock";
                    break;
                case PAPER:
                    textValue = "Paper";
                    break;
                case SCISSORS:
                    textValue = "Scissors";
                    break;
                // PROF : on aurait pu ajouter un default: dans le cas d'une valeur invalide
            }
            return textValue;
        }

        public static void ShowGameResults(int player1Choice, int player2Choice, int winner)
        {
            int playerChoice = 0;

            Console.Clear(); // Permet d'effacer le contenu de la console
            if (player1Choice > 0)
            {
                playerChoice = player1Choice;
                string textValue = ChoiceToText(playerChoice);
                Console.WriteLine($"Game Result :\nPlayer 1 choice: {textValue}");
            }
            if (player2Choice > 0)
            {
                playerChoice = player2Choice;
                string textValue = ChoiceToText(playerChoice);
                Console.WriteLine($"Player 2 choice: {textValue}");
            }
            Console.WriteLine($"Winner is : PLAYER {winner}");
        }
    }
}
