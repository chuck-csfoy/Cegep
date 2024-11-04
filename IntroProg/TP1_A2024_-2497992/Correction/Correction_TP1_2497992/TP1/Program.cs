using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    #region LOGOS
    const string MAIN_APP_LOGO = @"
__________         __    __                       
\______   \_____ _/  |__/  |_  ___________ ___.__.
 |    |  _/\__  \\   __\   __\/ __ \_  __ <   |  |
 |    |   \ / __ \|  |  |  | \  ___/|  | \/\___  |
 |______  /(____  /__|  |__|  \___  >__|   / ____|
        \/      \/                \/       \/     
 ";
    #endregion

    #region BATTERY_DISPLAY_CONSTANTS
    const int BATTERY_STARTING_COLUMN = 3;
    const int BATTERY_STARTING_ROW = 1;
    const int NB_BATTERY_CHARGE_ROWS = 10;
    const int TEXT_COLOR_CHARGE_THRESHOLD = 30;

    const string BATTERY_TOP = " ___====___ ";
    const string BATTERY_FILL = "          ";
    const string BATTERY_SIDE = "|";
    const string BATTERY_BOTTOM = " ~~~~~~~~~~ ";
    #endregion

    const int RULE_SERIAL_LENGHT = 8;
    const int RULE_ID_LENGHT = 4;
    public static readonly string STR_MENU_SERIAL = $"Serial Number (8 digits):";
    public static readonly string STR_MENU_ID = $"ID:";
    public static readonly string SN_ERROR = $"(Invalid Serial Number)";
    public static readonly string ID_ERROR = $"(Invalid ID Number)";
    public static readonly string MESSAGE_ERROR = $"(Press any key to continue)";

    const int USE_BATTERY = 1;
    const int CHARGE_BATTERY = 2;
    const int LOGOUT = 3;
    const int DEFAULT = 4;
    const int CHARGE_MAX = 100;
    const int RECHARGE_MAX = 30;
    const int CHARGE_INITIAL = 50;
    public static readonly string STR_MENU_BATTERY = $"\n1: ({USE_BATTERY}) Use battery\n2: ({CHARGE_BATTERY}) Charge battery\n3: ({LOGOUT}) Logout\n\nYour choice:";
    public static readonly string USER_CHOICE_ERROR = $"(Invalid operation)";
    public static readonly string CHARGE_AMOUNT_CHOICE_ERROR = $"(Invalid amount)";

    public static void Main(string[] args)
    {
        // PROF : enlever les variables inutilisées
        bool isUserAuthenticated = false;
        bool isQuittingOperation = false;
        int chargePercentage = CHARGE_INITIAL;

        while (true)
        {
            ManageUserAuthentication(STR_MENU_SERIAL);
            // PROF : pourquoi mettre un retour si on ne s'en sert pas (TDA)
            int userInputChoice = ManageBatteryOperationUserChoice(STR_MENU_BATTERY, chargePercentage);
        }
    }

    public static void PromptMenu(string promptMenu)
    {
        Console.Clear();
        Console.WriteLine(MAIN_APP_LOGO);
        Console.WriteLine(promptMenu);
        Console.SetCursorPosition(26, 08);
    }
    public static void PromptError()
    {
        // PROF : utiliser des constantes lorsque des valeurs se répètent (TDA)
        WriteError(SN_ERROR, 50, 8);
        WriteText(MESSAGE_ERROR, 0, 9);
        Console.ReadKey();
        Console.Clear();
    }
    public static void PromptErrorID()
    {
        WriteError(ID_ERROR, 50, 8);
        WriteText(MESSAGE_ERROR, 0, 9);
        Console.ReadKey();
        Console.Clear();
    }
    public static void PromptErrorUserChoice()
    {
        // PROF : utiliser des constantes lorsque des valeurs se répètent (TDA)
        WriteError(USER_CHOICE_ERROR, 50, 17);
        WriteText(MESSAGE_ERROR, 0, 18);
        Console.ReadKey();
        Console.Clear();
    }
    public static void PromptErrorChargeAmountChoice()
    {
        WriteError(CHARGE_AMOUNT_CHOICE_ERROR, 50, 17);
        WriteText(MESSAGE_ERROR, 0, 18);
        Console.ReadKey();
        Console.Clear();
    }
    public static void ManageUserAuthentication(string promptMenu)
    {
        string userInputStr = "";
        string validNumberStr = "";
        bool isUserInputSnStr = false;
        bool isUserInputIdStr = false;
        bool isValidID = false;

        do
        {
            PromptMenu(STR_MENU_SERIAL);
            userInputStr = Console.ReadLine();
            if (userInputStr != null)
            {
                isUserInputSnStr = true;
                bool isValidSN = CheckSerialNumber(userInputStr);
                if (isValidSN == true)
                {
                    validNumberStr = userInputStr;
                }
                else
                {
                    isUserInputSnStr = false;
                }
            }
        } while (!isUserInputSnStr);
        do
        {
            PromptMenu(STR_MENU_ID);
            userInputStr = Console.ReadLine();
            if (userInputStr != null)
            {
                isUserInputIdStr = true;

                // PROF : on ne valide jamais l'ID puisqu'on ne se sert pas de ce résultat
                isValidID = ReadID(validNumberStr, userInputStr);
            }
            else
            {
                isValidID = false;
            }
        } while (!isUserInputIdStr);
    }
    public static bool CheckSerialNumber(string userInputStr)
    {
        int userInputStrLength = userInputStr.Length;
        bool isValidSN = false;
        string validNumberStr = "";
        if (userInputStrLength == RULE_SERIAL_LENGHT)
        {
            isValidSN = true;
            CheckStringIsNumber(userInputStr);
        }
        else
        {
            isValidSN = false;
            PromptError();
            PromptMenu(STR_MENU_SERIAL);
        }
        return isValidSN;
    }
    public static bool CheckStringIsNumber(string userInputStr)
    {
        int inputStrLength = userInputStr.Length;
        string validNumberStr = "";
        bool isStringNumber = false;

        for (int index = 0; index < inputStrLength; index++)
        {
            if (!Char.IsNumber(userInputStr[index]))
            {
                isStringNumber = false;
                PromptError();
                PromptMenu(STR_MENU_SERIAL);
                // PROF : on pourrait break, sinon on pourrait juste mettre un chiffre à la fin et ça fonctionnerait partiellement (CIC)
            }
            else
            {
                isStringNumber = true;
                validNumberStr += userInputStr[index];
            }
        }
        return isStringNumber;
    }
    public static bool ReadID(string validNumberStr, string userInputStr)
    {
        int validNumberStrLength = validNumberStr.Length;
        int index = RULE_ID_LENGHT;
        string inputStrID = "";
        bool isValidID = false;

        inputStrID = validNumberStr.Substring(index);
        if (inputStrID == userInputStr)
        {
            isValidID = true;
        }
        else
        {
            isValidID = false;
            PromptErrorID();
        }
        return isValidID;
    }
    public static int ManageBatteryOperationUserChoice(string batteryMenuOption, int chargePercentage)
    {
        int userInputChoice = -1;
        bool isParseSuccess = false;
        bool isQuittingOperation = false;
        while (!isQuittingOperation)
        {
            if (batteryMenuOption == STR_MENU_BATTERY)
            {
                do
                {
                    Console.Clear();
                    DisplayBatteryCharge(chargePercentage);
                    Console.WriteLine(batteryMenuOption);
                    // PROF : utiliser des constantes lorsque des valeurs se répètent (TDA)
                    Console.SetCursorPosition(26, 17);
                    string userInput = Console.ReadLine();
                    isParseSuccess = int.TryParse(userInput, out userInputChoice);

                    if (userInputChoice != USE_BATTERY && userInputChoice != CHARGE_BATTERY && userInputChoice != LOGOUT)
                    {
                        PromptErrorUserChoice();
                    }
                    else if (userInputChoice == LOGOUT)
                    {
                        isQuittingOperation = true;
                        Console.WriteLine("OK BYE...Closing in 5 seconds...");
                        // PROF : ça ne ferme pas la console : ça met en pause l'exécution :)
                        Thread.Sleep(5000); /*J'ai trouvé cette méthode pour fermer la console sur: https://csharpforums.net/threads/how-to-close-a-console-application-window.7739*/
                    }
                    else
                    {
                        ReadUserInput(batteryMenuOption, userInputChoice, chargePercentage);
                    }
                } while (!isParseSuccess || userInputChoice < USE_BATTERY || userInputChoice > LOGOUT);
            }

        }
        Console.Clear();
        return userInputChoice;
    }
    public static int ReadUserInput(string batteryMenuOption, int userInputChoice, int chargePercentage)
    {
        switch (userInputChoice)
        {
            case USE_BATTERY:
                chargePercentage = ManageBatteryUsage(chargePercentage);
                break;
            case CHARGE_BATTERY:
                chargePercentage = ManageBatteryCharge(chargePercentage);
                break;
            case LOGOUT:
                ManageBatteryOperationUserChoice(batteryMenuOption, chargePercentage);
                break;
            default:
                return 1;
        }
        return chargePercentage;
    }

    public static int ManageBatteryUsage(int chargePercentage)
    {
        int userChoiceAmount = -1;
        bool isBatteryUsageValid = false;
        do
        {
            DisplayBatteryCharge(chargePercentage);
            userChoiceAmount = DisplayBatteryChargeUserChoice(chargePercentage, RECHARGE_MAX);
            // PROF : la fonction Math.Min existe déjà. La condition est aussi un peu bizarre considérant qu'on peut passer par deux chemins pour afficher la même erreur (CIC)
            if (userChoiceAmount <= Min(chargePercentage, RECHARGE_MAX) || userChoiceAmount >= 0 || userChoiceAmount <= CHARGE_MAX)
            {
                if (userChoiceAmount > chargePercentage)
                {
                    PromptErrorChargeAmountChoice();
                }
                else
                {
                    chargePercentage -= userChoiceAmount;
                    isBatteryUsageValid = true;
                }
            }
            else
            {
                PromptErrorChargeAmountChoice();
            }
        } while (!isBatteryUsageValid);

        DisplayBatteryCharge(chargePercentage);
        Console.WriteLine($"You used ({userChoiceAmount})%.\nThe battery is now at ({chargePercentage})%\n");
        WriteText(MESSAGE_ERROR, 0, 18);
        Console.ReadKey();

        return chargePercentage;
    }

    public static int ManageBatteryCharge(int chargePercentage)
    {
        int userChoiceAmount = -1;

        bool isBatteryUsageValid = false;
        do
        {
            DisplayBatteryCharge(chargePercentage);
            userChoiceAmount = DisplayBatteryChargeUserChoice(chargePercentage, RECHARGE_MAX);
            if (userChoiceAmount >= 0 || userChoiceAmount <= (CHARGE_MAX - chargePercentage))
            {
                chargePercentage += userChoiceAmount;
                isBatteryUsageValid = true;
            }
            else
            {
                PromptErrorChargeAmountChoice();
            }
        } while (!isBatteryUsageValid);

        DisplayBatteryCharge(chargePercentage);
        Console.WriteLine($"You used ({userChoiceAmount})%.\nThe battery is now at ({chargePercentage})%\n");
        WriteText(MESSAGE_ERROR, 0, 18);
        Console.ReadKey();

        return chargePercentage;
    }
    // PROF : bonne utilisation du découpage en fonction en général!
    public static void DisplayBatteryCharge(int chargePercentage)
    {
        Console.Clear();
        PrintBattery(chargePercentage);
    }

    public static int DisplayBatteryChargeUserChoice(int chargePercentage, int desiredUsageAmount)
    {
        int userChoiceAmount;
        bool isParseSuccess = false;
        do
        {
            DisplayBatteryCharge(chargePercentage);
            Console.WriteLine($"\n\nCurrent battery charge: ({chargePercentage})%\nDesired amount (max {desiredUsageAmount}): ");
            Console.SetCursorPosition(26, 15);
            string userChoiceStr = Console.ReadLine();
            isParseSuccess = int.TryParse(userChoiceStr, out userChoiceAmount);
            if (isParseSuccess == false)
            {
                PromptErrorChargeAmountChoice();
            }
        } while (!isParseSuccess);
        return userChoiceAmount;
    }

    public static int Min(int val1, int val2)
    {
        int intMin = 1;
        if (val1 < val2)
        {
            intMin = val1;
        }
        else
        {
            intMin = val2;
        }
        return intMin;
    }


    #region UTILITY_FUNCTIONS  
    /// <summary>
    /// Permet d'écrire du texte à la console à un endroit précis
    /// </summary>
    /// <param name="text">Le texte à écrire</param>
    /// <param name="x">La colonne à laquelle écrire le texte</param>
    /// <param name="y">La ligne à laquelle écrire le texte.  La première ligne est en haut et le numéro de ligne augmente en descendant</param>
    static void WriteText(string text, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text);
    }
    /// <summary>
    /// Permet de signaler une erreur à la console à un endroit précis
    /// </summary>
    /// <param name="text">Le texte à écrire</param>
    /// <param name="x">La colonne à laquelle écrire le texte</param>
    /// <param name="y">La ligne à laquelle écrire le texte.  La première ligne est en haut et le numéro de ligne augmente en descendant</param>
    static void WriteError(string text, int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        WriteText(text, x, y);
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Permet d'afficher la batterie dans la console à un endroit prédéterminé (vous pourriez le changer).
    /// </summary>
    /// <param name="chargePercentage">Le pourcentage de charge courant de la batterie. Vous devriez le garder à quelque part dans votre application et le passer en paramètre ici</param>
    static void PrintBattery(int chargePercentage)
    {
        const int BATTERY_CONTENT_START = BATTERY_STARTING_ROW + 1;
        int nbFilledLines = Math.Min(NB_BATTERY_CHARGE_ROWS, chargePercentage / NB_BATTERY_CHARGE_ROWS);
        int nbEmptyLines = Math.Max(0, NB_BATTERY_CHARGE_ROWS - nbFilledLines);

        WriteText(BATTERY_TOP, BATTERY_STARTING_COLUMN, BATTERY_STARTING_ROW);
        for (int i = 0; i < nbEmptyLines; i++)
        {
            WriteBatteryEmptyLine(BATTERY_STARTING_COLUMN, BATTERY_CONTENT_START + i);
        }
        for (int i = nbEmptyLines; i < NB_BATTERY_CHARGE_ROWS + 1; i++)
        {
            WriteBatteryChargedLine(chargePercentage, BATTERY_STARTING_COLUMN, BATTERY_CONTENT_START + i);
        }
        WriteText(BATTERY_BOTTOM, BATTERY_STARTING_COLUMN, BATTERY_CONTENT_START + NB_BATTERY_CHARGE_ROWS);
    }

    // PROF : fonctions utilitaires pour rendre la fonction d'affichage de la batterie plus concis.
    static void WriteBatteryChargedLine(int chargePercentage, int x, int y)
    {
        ConsoleColor color = ConsoleColor.White;
        if (chargePercentage >= TEXT_COLOR_CHARGE_THRESHOLD)
            color = ConsoleColor.Green;
        else
            color = ConsoleColor.Red;

        WriteText(BATTERY_SIDE, x, y);
        Console.BackgroundColor = color;
        WriteText(BATTERY_FILL, x + 1, y);
        Console.BackgroundColor = ConsoleColor.Black;
        WriteText(BATTERY_SIDE, x + BATTERY_FILL.Length + 1, y);
    }

    static void WriteBatteryEmptyLine(int x, int y)
    {
        string line = string.Format("{0}{1}{0}", BATTERY_SIDE, BATTERY_FILL);
        WriteText(line, x, y);
    }

    // TODO : vous pouvez ajouter d'autres fonctions utilitaires

    #endregion
}