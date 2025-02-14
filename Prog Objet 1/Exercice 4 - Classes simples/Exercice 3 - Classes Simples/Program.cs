namespace Exercice_3___Classes_Simples
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Object new instance

            UserAccount newUserAccount = new UserAccount("GrosJean", "123Gros", 1, "biglegros@mail.com", true);

            Console.WriteLine(newUserAccount.UserName + "\n"+ newUserAccount.UserPasswd + "\n" + newUserAccount.Discriminator
            + "\n" + newUserAccount.UserEmail + "\n" +newUserAccount.IsPremiumUser + "\n");

            IntSequence newIntSequence = new IntSequence(0);
            Console.WriteLine(newIntSequence.CurrentNumber);

            int currentNumber = newIntSequence.CurrentNumber;
            
            currentNumber = newIntSequence.Next();

            for (int i = 0; i < 5; i++)
            {
                newIntSequence.Next();
                Console.WriteLine(newIntSequence.CurrentNumber);
            }

            SmartLightBulb newSmartLightBulb = new SmartLightBulb(120, 100);
            Console.WriteLine(newSmartLightBulb.LightBulbPower + "\n" + newSmartLightBulb.LightBulbLuminosity);

        }
    }
}