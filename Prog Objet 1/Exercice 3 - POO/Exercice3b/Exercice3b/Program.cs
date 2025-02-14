namespace Exercice3b
{
    class Program
    {
       public static void Main(string[] args)
       {
            // Objects declaration
            Rectangle newRectangle = new Rectangle(10,40);

            Console.WriteLine(newRectangle.Height + " X " + newRectangle.Width);

            newRectangle.Height = -100;
            Console.WriteLine(newRectangle.Height);

            int areaOfNewRectangle;

            areaOfNewRectangle = newRectangle.CalculateArea();
            Console.WriteLine("The rectangle area is " + areaOfNewRectangle);

            int peremeterOfNewRactangle;

            peremeterOfNewRactangle = newRectangle.CalculatePeremeter();
            Console.WriteLine("The rectangle peremeter is " + peremeterOfNewRactangle);
       }
    }
}
