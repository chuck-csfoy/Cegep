namespace Exercice25
{



  class Program
  {

    public const int READ_ITEM = 1;

    public const int QUIT = 0;
    public const int READ_BILL = 1;
    public const int PRINT_BILL = 2;
    public const int SAVE_BILL = 3;
    public const int LOAD_BILL = 4;

    public const float TPS_RATE = 0.05f;
    public const float TVQ_RATE = 0.0975f;

    public const string BILL_FILE_NAME = "Bill.csv";
    public const string SEPARATOR = ";";

    /*Je n'ai pas reussi a faire l'option 3 et 4 du menu sans faire crasher mon program... Mon Norton antivirus donne un code de violation error et la ligne 263 sembe en probleme...*/
    /*Je ne comprends pas pourqoi la fonction WriteFile cause ce problème...*/

    public static void Main(string[] args)
    {
      Bill currentBill = new Bill();

      InitBill(currentBill);

      int userChoice = -1;
      do 
      {
        Console.WriteLine("_____________________\n        MENU      \n_____________________");
        Console.WriteLine("0: Quit");
        Console.WriteLine("1: Enter new invoice");
        Console.WriteLine("2: Display invoice");
        Console.WriteLine("3: Save last invoice");
        Console.WriteLine("4: Load saved invoice\n_____________________");

        userChoice = AskUserChoice("\nPlease choose an option (0-4):", 0, 4);

        switch (userChoice)
        {
          case QUIT:
            Console.WriteLine("Exiting program...");
            break;

          case READ_BILL:
            currentBill = GenNewInvoice();
            break;

          case PRINT_BILL:
            DisplayInvoiceFormat(currentBill);
            break;

          case SAVE_BILL:
            SaveBill(currentBill);
            break;

          case LOAD_BILL:
            LoadBill(currentBill);
            break;

          default:
            Console.WriteLine("Invalid choice! Please select a valid option in between 0 and 4.");
            break;
        }

      } while (userChoice != QUIT);

      Console.WriteLine("Goodbye!");
    }

    public static int AskUserChoice(string question, int min, int max)
    {
      int userChoice = -1;
      bool inputIsOk = false;
      do
      {
        Console.WriteLine(question);
        string userInput = Console.ReadLine();
        inputIsOk = int.TryParse(userInput, out userChoice);

      } while (!inputIsOk || userChoice < min || userChoice > max);

      return userChoice;
    }
    //1.3
    public static void InitBill(Bill Customer)
    {
      Customer.ClientName = "";
      Customer.Items = new List<Item>();
    }
    //1.4
    public static Item ReadInvoiceItem()
    {
      Item invoicedItem = new Item();

      Console.WriteLine($"Please enter the description: {invoicedItem.Description}");
      invoicedItem.Description = Console.ReadLine();

      Console.WriteLine($"Please enter the price per unit: {invoicedItem.UnitPrice}");
      invoicedItem.UnitPrice = float.Parse(Console.ReadLine());

      Console.WriteLine($"Please enter the quantity for this item: {invoicedItem.Quantity}");
      invoicedItem.Quantity = int.Parse(Console.ReadLine());
      
      return invoicedItem;
    }
    //1.5
    public static Bill GenNewInvoice()
    {
      const int READ_INVOICE = 1;
      const int QUIT = 2;
      Bill newInvoice = new Bill();

      InitBill(newInvoice);

      string prompt_user = $"Do you want to add an item to the invoice? {READ_INVOICE} to read item to add or {QUIT} to quit invoice.";

      int userChoice = -1;

      Console.WriteLine($"Please enter customer name: ");
      newInvoice.ClientName = Console.ReadLine();

      do
      {
        userChoice = AskUserChoice(prompt_user, READ_INVOICE, QUIT);
        if (userChoice == READ_INVOICE)
        {
          newInvoice.Items.Add(ReadInvoiceItem());
        }
      } while (userChoice != QUIT);

      return newInvoice;
    }

    //1.6
    public static float CalculateInvoiceSubTotal(Bill list)
    {
      float subTotal = 0f;

      foreach (Item item in list.Items)
      {
        subTotal += item.UnitPrice * item.Quantity;
      }

      return subTotal;
    }

    //1.6
    public static float CalculateInvoiceTaxesFromSubtotal(float subTotal)
    {
      float tpsTax = subTotal * TPS_RATE;
      float tvqTax = subTotal * TVQ_RATE;
      float taxes = tpsTax + tvqTax;

      return taxes;
    }

    /*J'ai trouvé cette facon d'afficher les strings par interpolation et mise en forme sur https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting*/
    /*J'ai utilisé String.Format tel que demandé dans l'énoncé mais il me semble que ca serait plus simple d'utiliser l'interpolation pour afficher le dernier bloc de code.*/
    //1.7
    
    public static void DisplayInvoiceFormat(Bill bill)
    {
      Console.WriteLine($"Client Name:  {bill.ClientName}");

      Console.WriteLine($"{ "Description",-25} { "UnitPrice",10} { "Quantity",10} { "$$$",12}");

      float subTotal = 0f;

      foreach (Item item in bill.Items)
      {
        float totalPrice = item.UnitPrice * item.Quantity;
        
        Console.WriteLine($"{item.Description,-25} {item.UnitPrice,10:C2} {item.Quantity,10} {totalPrice,12:C2}");

        subTotal += totalPrice;
      }

      float taxes = (float)Math.Round(CalculateInvoiceTaxesFromSubtotal(subTotal), 2);

      float totalAmount = (float)Math.Round(subTotal + taxes, 2);

      //Console.WriteLine($"\n{"Sub-Total:",-25} { subTotal,12:C2}");
      //Console.WriteLine($"{"Taxes:",-25} {taxes,12:C2}");
      //Console.WriteLine($"{"Total Amount:",-25} {totalAmount,12:C2}");

      Console.WriteLine("\n" + String.Format("{0,-25} {1,12:C2}", "Sub-Total:", subTotal));
      Console.WriteLine(String.Format("{0,-25} {1,12:C2}", "Taxes:", taxes));
      Console.WriteLine(String.Format("{0,-25} {1,12:C2}", "Total Amount:", totalAmount));

    }

    private static void LoadBill(Bill bill)
    {
      if (null == bill)
        throw new ArgumentException("La facture ne peut pas être null");
      string[] allLines = ReadFile(BILL_FILE_NAME);
      InitBill(bill);
      bill.ClientName = allLines[0];
      for (int i = 1; i < allLines.Length; i++)
      {
        // Extraire les éléments de la ligne
        string[] elements = allLines[i].Split(SEPARATOR, StringSplitOptions.RemoveEmptyEntries);
        Item item = new Item();
        item.Description = elements[0];
        item.UnitPrice = float.Parse(elements[1]);
        item.Quantity = int.Parse(elements[2]);
        bill.Items.Add(item);
      }
    }

    private static void SaveBill(Bill bill)
    {
      if (null == bill)
        throw new ArgumentException("La facture ne peut pas être null");
      List<string> allLines = new List<string>();
      allLines.Add(bill.ClientName);
      foreach (Item item in bill.Items)
      {
        string line = item.Description + SEPARATOR + Convert.ToString(item.UnitPrice) + SEPARATOR + Convert.ToInt32(item.Quantity);
        allLines.Add(line);
      }
      WriteFile(BILL_FILE_NAME, allLines.ToArray());
    }


    #region FONCTIONS UTILITAIRES
    /// <summary>
    /// Lit un fichier texte et stocke une ligne par cellule de tableau.
    /// </summary>
    /// <param name="fileName">Nom du fichier à lire. Il doit être situé
    /// dans le dossier bin/Debug/net6.0</param>
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
    /// dans le dossier bin/Debug/net5.0</param>
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