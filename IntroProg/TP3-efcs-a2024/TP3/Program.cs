using System.Globalization;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using System;
using System.Collections.Generic;

namespace TP3_ETU
{
    public class Program
    {

        // Sources des données
        public const string PLAYERS_FILE = "Files/players.csv";
        public const string CLANS_FILE = "Files/clans.csv";
        public const char PLAYERS_SEPARATION_TOKEN = ';';

        
        public const int EXPLORATION = 0;
        public const int COMBAT = 1;
        public const int TRADING = 2;
        public const int POLITICS = 3;
        public const int ALL = 4;
        public const string EXPLORATION_STR= "Exploration";
        public const string COMBAT_STR= "Combat";
        public const string TRADING_STR= "Trading";
        public const string POLITICS_STR= "Politics";
        public const string ALL_STR= "All";

        public const string HEADER = "\n" +
            "___________________________________________________________________________________________\n" +
            "___________________________________________________________________________________________\n" +
            "                                                                                           \r\n" +
            "████████╗██╗  ██╗███████╗     ██████╗██╗      █████╗ ███╗   ██╗     █████╗ ██████╗ ██████╗ \r\n" +
            "╚══██╔══╝██║  ██║██╔════╝    ██╔════╝██║     ██╔══██╗████╗  ██║    ██╔══██╗██╔══██╗██╔══██╗\r\n" +
            "   ██║   ███████║█████╗      ██║     ██║     ███████║██╔██╗ ██║    ███████║██████╔╝██████╔╝\r\n" +
            "   ██║   ██╔══██║██╔══╝      ██║     ██║     ██╔══██║██║╚██╗██║    ██╔══██║██╔═══╝ ██╔═══╝ \r\n" +
            "   ██║   ██║  ██║███████╗    ╚██████╗███████╗██║  ██║██║ ╚████║    ██║  ██║██║     ██║     \r\n" +
            "   ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝    ╚═╝  ╚═╝╚═╝     ╚═╝     \r\n" +
            "                                                                                           \r\n" +
            "___________________________________________________________________________________________\n" +
            "___________________________________________________________________________________________\n";
        
        public const string MENU = 
            "0: Quit\n" +
            "1: Add a clan\n" +
            "2: Update a clan\n" +
            "3: Remove a clan\n" +
            "4: List all clans\n" +
            "5: Add a player\n" +
            "_____________________\n" +
            "_____________________\n";

        public const string MENU_UPDATE =
            "0: Quit\n" +
            "1: Update name\n" +
            "2: Update creation year\n" +
            "3: Update type\n" +
            "4: Update score\n" +
            "_____________________\n" +
            "_____________________\n";

        public const int QUIT = 0;
        public const int ADD_CLAN = 1;
        public const int UPDATE_CLAN = 2;
        public const int REMOVE_CLAN = 3;
        public const int LIST_ALL_CLANS = 4;
        public const int ADD_PLAYER = 5;

        public const int UPDATE_CLAN_NAME = 1;
        public const int UPDATE_CLAN_YEAR = 2;
        public const int UPDATE_CLAN_TYPE = 3;
        public const int UPDATE_CLAN_SCORE = 4;

        public const int MAX_NAME_LENGHT = 20;
        public const int MIN_CREATION_YR = 2012;
        public const int MAX_CREATION_YR = 2024;
        public const int MIN_SCORE = 0;
        public const int MAX_SCORE = 9999;

        public static void Main(string[] args)
        {

            List<string> allPlayers = ReadPlayersFromFile(PLAYERS_FILE);
            List<Clan> allClans = ReadClansFromFile(CLANS_FILE);

            
            int userChoice = -1;
            do
            {
                WriteClansToFile(CLANS_FILE, allClans);
                WriteFile(PLAYERS_FILE, allPlayers.ToArray());
                DisplayHeaderColor(HEADER);
                Console.WriteLine(MENU);
                userChoice = AskUserChoice($"\nPlease choose an option in between {QUIT}-{ADD_PLAYER}", QUIT, ADD_PLAYER);
                
                DisplayUserChoice(userChoice);

                switch (userChoice)
                {
                    case QUIT:
                        Console.WriteLine("Exiting program...");
                        break;

                    case ADD_CLAN:
                        InsertClan(allClans, allPlayers);
                        break;

                    case UPDATE_CLAN:
                        UpdateClan(allClans);
                        break;

                    case REMOVE_CLAN:
                        RemoveClan(allClans, allPlayers);
                        break;

                    case LIST_ALL_CLANS:
                        DisplayClanList(allClans, allPlayers);
                        break;

                    case ADD_PLAYER:
                        AddPlayerToClan(allPlayers, allClans);
                        break;

                    default:
                        Console.WriteLine($"Invalid choice! Please select a valid option in between {QUIT} and {ADD_PLAYER}.");
                        break;
                }

            } while (userChoice != QUIT);


            Console.WriteLine("Ok bye!");
        }
        public static void DisplayHeaderColor(string HEADER)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(HEADER);

            Console.ResetColor();
        }
        public static void DisplayUserChoice(int userChoice)
        {
            Console.Clear();
            
            Console.WriteLine($"Your choice: {userChoice}\n");
        }
        public static int AskUserChoice(string question, int min, int max)
        {
            int userChoice = -1;
            bool isInputOk = false;

            do
            {
                Console.WriteLine(question);
                string userInput = Console.ReadLine();
                isInputOk = int.TryParse(userInput, out userChoice);

            } while (!isInputOk || userChoice < min || userChoice > max);
            return userChoice;
        }

        public static int AskUserChoiceWithDefault(string question, int min, int max, int defaultValue)
        {
            int userChoice = -1;
            bool isInputOk = false;

            do
            {
                Console.WriteLine(question);
                string userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    return defaultValue;
                }

                isInputOk = int.TryParse(userInput, out userChoice);
            } while (!isInputOk || userChoice < min || userChoice > max);
            
            return userChoice;
        }

        public static void ChangeErrorMessageTextColor(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);

            
            Console.ResetColor();
           
        }

        //Note;Method String.IsNullOrEmpty(String) trouvée pour valider si une string est null ou vide... https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=net-9.0
        public static bool ValidateClanName(string nameClan)
        {
            
            if (nameClan.Length > MAX_NAME_LENGHT || string.IsNullOrEmpty(nameClan))
            {
                ChangeErrorMessageTextColor($"Clan name must be at maximum {MAX_NAME_LENGHT} Characters long. Please enter a valid name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateClanYear(int yearClan)
        {
            if (yearClan < MIN_CREATION_YR || yearClan > MAX_CREATION_YR)
            {
                ChangeErrorMessageTextColor($"Clan creation year must in between {MIN_CREATION_YR} and {MAX_CREATION_YR}. Please enter a valid year.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateClanType(int typeClan)
        {
            if (typeClan < EXPLORATION || typeClan > ALL)
            {
                ChangeErrorMessageTextColor($"Clan type must be must in between {EXPLORATION} and {ALL}. Please enter a valid type.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateClanScore(int scoreClan)
        {
            if (scoreClan < MIN_SCORE || scoreClan > MAX_SCORE)
            {
                ChangeErrorMessageTextColor($"Clan score must be must in between {MIN_SCORE} and {MAX_SCORE}. Please enter a valid score.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidateClanInput(string nameClan, int yearClan, int typeClan, int scoreClan)
        {
            return ValidateClanName(nameClan) &&
                   ValidateClanYear(yearClan) &&
                   ValidateClanType(typeClan) &&
                   ValidateClanScore(scoreClan);
        }
        public static void InitClan(Clan clan)
        {
            if (clan == null)
            {
                throw new ArgumentNullException(nameof(clan));
            }
            clan.Name = "";
            clan.CreationYear = 0;
            clan.Type = 0;
            clan.Score = 0;
            clan.Players = new List<int>();

        }
        public static Clan GetClanInputs(List<Clan> allClans)
        {
            if (allClans.Count == 0)
            {
                Console.WriteLine("No clans available to update.");
                return new Clan();
            }

            string promptUserMenu = $"Do you want to add a clan to list? {ADD_CLAN} to add clan or {QUIT} to quit to app menu.";
            string promptUserName = $"Enter a clan name (Maximum {MAX_NAME_LENGHT} characters):";
            string promptUserYear = $"Enter a clan creation year (Minimum {MIN_CREATION_YR} and maximum {MAX_CREATION_YR}):";
            string promptUserType = $"Enter a clan type:({EXPLORATION}: EXPLORATION, {COMBAT}: COMBAT, {TRADING}: TRADING, {POLITICS}: POLITICS, {ALL}: ALL): ";
            string promptUserScore = $"Enter a clan score (Minimum {MIN_SCORE} and maximum {MAX_SCORE}):";
            
            Clan newClan = new Clan();
            InitClan(newClan);

            do
            {
                Console.WriteLine(promptUserName);
                newClan.Name = Console.ReadLine();
            } while (!ValidateClanName(newClan.Name));

            do
            {
                newClan.CreationYear = AskUserChoice(promptUserYear, MIN_CREATION_YR, MAX_CREATION_YR); 
            } while (!ValidateClanYear(newClan.CreationYear));
            
            do
            {
                newClan.Type = AskUserChoice(promptUserType, EXPLORATION, ALL);
            } while (!ValidateClanType(newClan.Type));

            do
            {
                newClan.Score = AskUserChoice(promptUserScore, MIN_SCORE, MAX_SCORE);
            } while (!ValidateClanScore(newClan.Score));

            return newClan;
        }
        public static void InsertClan(List<Clan> allClans, List<string> allPlayers)
        {
            Clan newClan = GetClanInputs(allClans);
            if (string.IsNullOrEmpty(newClan.Name))
            {
                Console.WriteLine("Clan creation aborted.");
            }
            string promptUserSuccess = "New clan added with success.";
            string promptUserFailed = "Failed to add new clan.";

            if (ValidateClanInput(newClan.Name, newClan.CreationYear, newClan.Type, newClan.Score))
            {
                Library.InsertClan(allClans, newClan);
                Console.WriteLine(promptUserSuccess);
            }
            else
            {
                Console.WriteLine(promptUserFailed);
            }

            //Note;Method String.ToUpper() trouvée pour modifier l'entrée utilisateur... https://learn.microsoft.com/en-us/dotnet/api/system.string.toupper?view=net-8.0#system-string-toupper
            Console.WriteLine("Do you want to add player(s) (Y or N)?");
            string userChoiceAddPlayer = Console.ReadLine();
            do
            {
                if (userChoiceAddPlayer != null)
                {
                    userChoiceAddPlayer = userChoiceAddPlayer.ToUpper();
                }

                if (userChoiceAddPlayer == "Y")
                {
                    Console.WriteLine("Available players from list: ");
                    for (int i = 0; i < allPlayers.Count; i++)
                    {
                        Console.WriteLine($"{i} {allPlayers[i]}");
                    }

                }
                if (userChoiceAddPlayer != "Y" && userChoiceAddPlayer != "N")
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                }

                Console.WriteLine("Enter the player number to add:");
                bool isValidPlayerIndex = int.TryParse(Console.ReadLine(), out int playerIndex);

                if (playerIndex >= 0 && playerIndex < allPlayers.Count)
                {
                    newClan.Players.Add(playerIndex);
                    Console.WriteLine("Players added to clan number with success.");
                }
                else
                {
                    Console.WriteLine("Failed to add player to clan.");
                }

            } while (userChoiceAddPlayer != "Y" && userChoiceAddPlayer != "N");
        }
        
        public static void UpdateClan(List<Clan> allClans)
        {
            if (allClans.Count == 0)
            {
                Console.WriteLine("No clans available to update.");
                return;
            }

            Console.WriteLine("Select the clan to update:\n");
            for (int i = 0; i < allClans.Count; i++)
            {
                Console.WriteLine($"{i}: {allClans[i].Name}");
            }

            int clanIndex = AskUserChoice("Enter the index of the clan to update:", 0, allClans.Count - 1);

            Clan selectedClan = allClans[clanIndex];

            Console.WriteLine($"\nUpdating clan: {selectedClan.Name}");
            Console.WriteLine($"\nCurrent details: Name: {selectedClan.Name}, Year: {selectedClan.CreationYear}, " +
                      $"Type: {selectedClan.Type}, Score: {selectedClan.Score}");
            Console.WriteLine($"\nEnter new details for the clan (or press Enter to keep existing values):");

            Console.WriteLine($"Enter a new clan name (Maximum {MAX_NAME_LENGHT} characters):");
            string newName = Console.ReadLine();

            if (!string.IsNullOrEmpty(newName))
            {
               selectedClan.Name = newName;
            }

            selectedClan.CreationYear = AskUserChoiceWithDefault($"Enter a new creation year ({MIN_CREATION_YR}-{MAX_CREATION_YR})" +
            $"(or press 0 to keep existing values)", MIN_CREATION_YR, MAX_CREATION_YR,selectedClan.CreationYear);
            
            selectedClan.Type = AskUserChoiceWithDefault($"Enter a new type ({EXPLORATION}-{ALL})" +
            $"(or press 0 to keep existing values)", EXPLORATION, ALL, selectedClan.Type);

            selectedClan.Score = AskUserChoiceWithDefault($"Enter a new score({MIN_SCORE}-{MAX_SCORE})" +
            $"(or press 0 to keep existing values)", MIN_SCORE, MAX_SCORE, selectedClan.Score);
            
            if (selectedClan == null)
            {
                Console.WriteLine("update operation canceled. Returning to main menu");
                return;
            }

            if (ValidateClanInput(selectedClan.Name, selectedClan.CreationYear, selectedClan.Type, selectedClan.Score))
            {
                Library.UpdateClan(allClans, clanIndex, selectedClan);
                Console.WriteLine("Clan updated successfully!");
            }

            else
            {
                Console.WriteLine("Failed to update clan. Invalid input.");
            }
        }

        public static void RemoveClan(List<Clan> allClans, List<string> allPlayers)
        {
            const int QUIT = -1;
            string promptUserRemove = $"Enter {QUIT} to cancel clan removal";
            int userChoice = 0;
            do
            {
                if (userChoice == QUIT)
                {
                    Console.WriteLine("Returning to app main menu.");
                    return;
                }

                DisplayClanList(allClans, allPlayers);

                int clanIndexToRemove = AskUserChoice("\nEnter the clan number ot be removed", 0, allClans.Count -1);

                if (clanIndexToRemove > 0 && clanIndexToRemove <= allClans.Count)
                {
                    Library.RemoveClan(allClans, clanIndexToRemove);
                    Console.WriteLine("clan removed with success.");
                    return;
                }
                else
                {
                    Console.WriteLine("Failed to remove clan.");
                    
                }
                userChoice = AskUserChoice(promptUserRemove, QUIT, QUIT);
            } while (userChoice != QUIT);
        }

        public static void DisplayClanList(List<Clan> allClans, List<string> allPlayers)
        {
            Console.WriteLine("List of Clans: ");
            Console.WriteLine($"{"Index", -7}{"Name",-21} {"Year",-5} {"Type",-12} {"Score",-5} {"Player(s)", -4}");
            Console.WriteLine($"{"=====", -7}{"=====================",-21} {"====",-5} {"===========",-12} {"=====",-5} {"=========", -4}");

            for (int i = 0; i < allClans.Count; i++)
            {
                string displayType = "";
                if (allClans[i].Type == EXPLORATION)
                {
                    displayType = EXPLORATION_STR;
                }
                if (allClans[i].Type == COMBAT)
                {
                    displayType = COMBAT_STR;
                }
                if (allClans[i].Type == TRADING)
                {
                    displayType = TRADING_STR;
                }
                if (allClans[i].Type == POLITICS)
                {
                    displayType = POLITICS_STR;
                }
                if (allClans[i].Type == ALL)
                {
                    displayType = ALL_STR;
                }
                List<int> Players = allClans[i].Players;
                string playerName = "";
                for (int playerIndex = 0; playerIndex < Players.Count; playerIndex++)
                {
                    
                   playerName += allPlayers[Players[playerIndex]];

                }
                Console.WriteLine($"{i+ ":", -6} {allClans[i].Name, -21} {allClans[i].CreationYear, -5} {displayType, -12} {allClans[i].Score, -5} {playerName}");
            }

        }
        public static void AddPlayerToClan(List<string> allPlayers, List<Clan> allClans)
        {
            Console.WriteLine("Enter a new player name: ");
            
            string playerName = Console.ReadLine();
            allPlayers.Add(playerName);

            Console.WriteLine("New player added with success.");

            DisplayClanList(allClans, allPlayers);

            Console.WriteLine("Enter the number of the clan to add this player to:");
            bool isValidClanIndex = int.TryParse(Console.ReadLine(), out int clanIndex);
            
            if (isValidClanIndex && clanIndex > 0 && clanIndex < allClans.Count)
            {
                allClans[clanIndex].Players.Add(allPlayers.Count - 1);
                Console.WriteLine("Players added to clan number with success.");
            }
            else
            {
                Console.WriteLine("Failed to add player to clan.");
            }
        }

        #region FILE ACCESS

        // PROF : vous aurez peut-être à modifier les noms des propriétés suivantes.
        private static void WriteClansToFile(string fileName, List<Clan> allClans)
        {
            string[] allLines = new string[allClans.Count];
            for (int i = 0; i < allClans.Count; i++)
            {
                allLines[i] = allClans[i].Name;
                allLines[i] += "," + Convert.ToString(allClans[i].CreationYear);
                allLines[i] += "," + Convert.ToString(allClans[i].Type);
                allLines[i] += "," + Convert.ToString(allClans[i].Score);
                allLines[i] += ",";

                for (int j = 0; j < allClans[i].Players.Count; j++)
                {
                    if (j > 0)
                        allLines[i] += ";";
                    allLines[i] += Convert.ToString(allClans[i].Players[j]);
                }



            }
            WriteFile(fileName, allLines);
        }

        private static List<string> ReadPlayersFromFile(string filename)
        {
            List<string> players = new List<string>();
            string[] allLines = ReadFile(filename);
            for (int i = 0; i < allLines.Length; i++)
            {
                if (!string.IsNullOrEmpty(allLines[i]))
                {
                    players.Add(allLines[i]);
                }
            }
            return players;
        }

        private static List<Clan> ReadClansFromFile(string fileName)
        {
            List<Clan> allClans = new List<Clan>();
            string[] allLines = ReadFile(fileName);
            for (int i = 0; i < allLines.Length && !string.IsNullOrEmpty(allLines[i]); i++)
            {
                string[] currentLine = allLines[i].Split(",", StringSplitOptions.RemoveEmptyEntries);
                Clan newClan = new Clan();
                newClan.Name = currentLine[0];
                newClan.CreationYear = int.Parse(currentLine[1]);
                newClan.Type = int.Parse(currentLine[2]);
                newClan.Score = int.Parse(currentLine[3]);
                newClan.Players = new List<int>();
                if (currentLine.Length > 4)
                {
                    string[] playersId = currentLine[4].Split(";", StringSplitOptions.RemoveEmptyEntries);
                    foreach (string id in playersId)
                    {
                        newClan.Players.Add(int.Parse(id));
                    }
                }
                allClans.Add(newClan);
            }
            return allClans;
        }

        /// <summary>
        /// Lit un fichier texte et stocke une ligne par cellule de tableau.
        /// </summary>
        /// <param name="fileName">Nom du fichier à lire. Il doit être situé
        /// dans le dossier bin/Debug/net6.0/Files</param>
        /// <param name="nbLinesMax">Nombres de lignes maximum qui pourront être lues dans le fichier</param>
        /// <returns>Un tableau des lignes lues</returns>
        public static string[] ReadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName, System.Text.Encoding.UTF8);
            List<string> allLines = new List<string>();

            while (!reader.EndOfStream)
            {
#pragma warning disable CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
                string line = reader.ReadLine();
#pragma warning restore CS8600 // Conversion de littéral ayant une valeur null ou d'une éventuelle valeur null en type non-nullable.
                allLines.Add(line);

            }

            reader.Close();

            return allLines.ToArray();
        }

        /// <summary>
        /// Écrit un fichier texte à partir d'un tableau de lignes.
        /// </summary>
        /// <param name="fileName">Nom du fichier à écrire. Il sera situé
        /// dans le dossier bin/Debug/net6.0/Files</param>
        /// <param name="linesToWrite">Tableau contenant les lignes à écrire</param>
        public static void WriteFile(string fileName, string[] linesToWrite)
        {
            StreamWriter writer = new StreamWriter(fileName, false, System.Text.Encoding.UTF8);

            for (int i = 0; i < linesToWrite.Length; i++)
            {
                writer.WriteLine(linesToWrite[i]);
            }

            writer.Close();
        }

        #endregion

    }
}