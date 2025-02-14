namespace Exercice24
{

  class Program
  {
    /*Version2 Pas completee... Je voulais le refaire l'exercice differemment pour une meilleure compréhension... Je vais y revenir.*/
    //  const string USER_PROMPT_FIRST_NAME = $"Please enter the student first name {student.FirstName}";
    //  const string USER_PROMPT_LAST_NAME = $"Please enter the student last name {student.LastName}";
    //  const string USER_PROMPT_REGISTRATION_NUMBER = $"Please enter the student last name {student.RegistrationNumber}";

    //  public static void Main(string[] args)
    //  {
    //    AskUserInput(USER_PROMPT_FIRST_NAME);
    //    AskUserInput(USER_PROMPT_LAST_NAME);
    //    AskUserInput(USER_PROMPT_REGISTRATION_NUMBER);
    //  }
    //  public static int AskUserInput(string USER_PROMPT)
    //  {
    //    int userValue = 0;
    //    List<Student> student = new List<Student>();

    //    bool isParseOk = false;
    //    do
    //    {
    //      Console.WriteLine(USER_PROMPT);

    //      string userInput = Console.ReadLine();

    //      userValue = int.Parse(userInput);

    //    } while (!isParseOk);
    //    return userValue;
    //  }

    public static void Main(string[] args)
    {
      AskUserInput();

    }
    public static int AskUserInput()
    {
      const int READ_STUDENT = 1;
      const int QUIT = 2;

      List<Student> students = new List<Student>();

      int userChoice = -1;
      do
      {
        Console.WriteLine("Please read student: 1 value or quit: 2 ");

        userChoice = int.Parse(Console.ReadLine());

        if (userChoice == READ_STUDENT)
        {
          students.Add(ReadStudent());
        }

      } while (userChoice != QUIT);

      return userChoice;
    }

    public static Student ReadStudent()
    {
      Student student = new Student();

      Console.WriteLine($"Please enter the student first name: {student.FirstName, -20}");
      student.FirstName = Console.ReadLine();
      Console.WriteLine($"Please enter the student last name: {student.LastName, -20}");
      student.LastName = Console.ReadLine();
      Console.WriteLine($"Please enter the student registration number: {student.RegistrationNumber, -8}");
      student.RegistrationNumber = int.Parse(Console.ReadLine());
      return student;

    }
  }
}
