namespace Exercice_6
{
    
    class Program
    {

        public const int QUIT = 0;
        public const int CREATE_NEW_CAR = 1;
        public const int START_CAR = 2;
        public const int STOP_CAR = 3;
        public const int ACCELERATE_CAR = 4;
        public const int DECELERATE_CAR = 5;
        public const int CAR_STATUS = 6;

        public const int MAX_BRAND_LENGHT = 20;
        public const int MAX_MODEL_LENGHT = 20;
        public const int MIN_BRAND_LENGHT = 3;
        public const int MIN_MODEL_LENGHT = 1;

        public const string HEADER =

        @"
        ______________________________________________________________________
        ______________________________________________________________________
        ________________ ________     _______________ _______ ________________
        __  ____/___    |___  __ \    __  ____/___  / ___    |__  ___/__  ___/
        _  /     __  /| |__  /_/ /    _  /     __  /  __  /| |_____ \ _____ \ 
        / /___   _  ___ |_  _, _/     / /___   _  /____  ___ |____/ / ____/ / 
        \____/   /_/  |_|/_/ |_|      \____/   /_____//_/  |_|/____/  /____/  
        ______________________________________________________________________
        ______________________________________________________________________
        ";


        public const string MENU =
            "0: Quit\n" +
            "1: Create new car\n" +
            "2: Start car\n" +
            "3: Stop car\n" +
            "4: Accelerate\n" +
            "5: Decelarate\n" +
            "6: Car Status\n" +
            "_____________________\n" +
            "_____________________\n";

        
        public static void Main(string[] args)
        {

            Car newCar = null;

            int userChoice = -1;
            do
            {
                DisplayHeaderColor(HEADER);
                Console.WriteLine(MENU);
                userChoice = AskUserChoice($"\nPlease choose an option in between {QUIT}-{CAR_STATUS}", QUIT, CAR_STATUS);

                DisplayUserChoice(userChoice);

                switch (userChoice)
                {
                    case QUIT:
                        Console.WriteLine("Exiting program...");
                        break;

                    case CREATE_NEW_CAR:
                        newCar = GetCarInputs();
                        break;

                    case START_CAR:
                        if(newCar != null)
                        {
                            newCar.StartCar();
                            Console.WriteLine("Ingnition! Car is started!");
                        }
                        else
                            Console.WriteLine("No car created yet!");
                        break;

                    case STOP_CAR:
                        if (newCar != null)
                        {
                            newCar.StopCar();
                            Console.WriteLine("Car was stopped!");
                        }
                        else
                            Console.WriteLine("No car created yet!");
                        break;
                    //Convert.ToDouble method trouvée pour convertir une string en double https://learn.microsoft.com/en-us/dotnet/api/system.convert.todouble?view=net-9.0
                    case ACCELERATE_CAR:
                        if (newCar != null)
                        {
                            Console.Write("Enter speed to accelerate: ");
                            double speedGain = Convert.ToDouble(Console.ReadLine());
                            newCar.Accelerate(speedGain);

                        }
                        else
                            Console.WriteLine("No car created yet!");
                        break;

                    case DECELERATE_CAR:
                        if (newCar != null)
                        {
                            Console.Write("Enter speed to decelerate: ");
                            double speedLoss = Convert.ToDouble(Console.ReadLine());
                            newCar.Decelerate(speedLoss);
                        }
                        else
                            Console.WriteLine("No car created yet!");
                        break;

                    case CAR_STATUS:
                        if (newCar != null)
                            Console.WriteLine(newCar);
                        else
                            Console.WriteLine("No car created yet!");
                        break;

                    default:
                        Console.WriteLine($"Invalid choice! Please select a valid option in between {QUIT} and {CAR_STATUS}.");
                        break;
                }

            } while (userChoice != QUIT);


            Console.WriteLine("Ok bye!");
        }

        public static void DisplayHeaderColor(string HEADER)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(HEADER);

            Console.ResetColor();
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

        public static void DisplayUserChoice(int userChoice)
        {
            Console.Clear();

            Console.WriteLine($"Your choice: {userChoice}\n");
        }

        public static Car GetCarInputs()
        {
            string carBrand;
            string carModel;
            string promptUserMenu = $"{CREATE_NEW_CAR} or {QUIT} to quit to app menu.";
            string promptUserBrand = $"Enter a car brand (Maximum {MAX_BRAND_LENGHT} characters):";
            string promptUserModel = $"Enter a car model (Minimum {MAX_MODEL_LENGHT} characters):";
            Console.WriteLine(promptUserMenu);
            
            do
            {
                Console.WriteLine(promptUserBrand);
                carBrand = Console.ReadLine();
            } while (!ValidateCarBrand(carBrand));
            
            do
            {
                Console.WriteLine(promptUserModel);
                carModel = Console.ReadLine();
            } while (!ValidateCarModel(carModel));

            
            return new Car(carBrand, carModel);
        }

        public static bool ValidateCarBrand(string carBrand)
        {

            if (carBrand.Length > MAX_BRAND_LENGHT || string.IsNullOrEmpty(carBrand))
            {
                Console.WriteLine($"Brand name must be at maximum {MAX_BRAND_LENGHT} Characters long. Please enter a valid name.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateCarModel(string carModel)
        {
            if (carModel.Length > MAX_MODEL_LENGHT || string.IsNullOrEmpty(carModel))
            {
                Console.WriteLine($"Model name must be at maximum {MAX_MODEL_LENGHT} Characters long. Please enter a valid name.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
