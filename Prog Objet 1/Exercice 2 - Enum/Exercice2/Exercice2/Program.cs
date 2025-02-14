namespace Exercice2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BloodType[] studentsBloodTypes = {BloodType.A, BloodType.B, BloodType.AB, BloodType.O, 
            BloodType.A, BloodType.B, BloodType.AB, BloodType.O, BloodType.O, BloodType.O};
            
            DisplayArray(studentsBloodTypes);
            float bloodTypeProportion = CalculateProportion(studentsBloodTypes,BloodType.A);
            Console.WriteLine("\n");
            Console.WriteLine($"The blood type proportion of blood type {BloodType.A} is {bloodTypeProportion}%");
        }

        public static void DisplayArray (BloodType[] studentsBloodTypes)
        {
            if (studentsBloodTypes is null)
            {
                throw new ArgumentException("Array can't be null");
            }
            if (studentsBloodTypes.Length < 1)
            {
                throw new ArgumentException("Array can't be empty");
            }

            for (int i = 0; i < studentsBloodTypes.Length; i++)
            {
                Console.WriteLine($"Person #{i}: {studentsBloodTypes[i]}");
            }
        }

        public static float CalculateProportion (BloodType[] studentsBloodTypes, BloodType bloodType)
        {
            if (studentsBloodTypes is null)
            {
                throw new ArgumentException("Array can't be null");
            }
            if (studentsBloodTypes.Length == 0)
            {
                throw new ArgumentException("Array can't be empty");
            }

            float bloodTypeProportion = 0.0f;
            int bloodTypeCount = 0;

            for (int i = 0; i < studentsBloodTypes.Length ;i++)
            {
                if (bloodType == studentsBloodTypes[i])
                {
                    bloodTypeCount++;
                }
            }

            bloodTypeProportion = ((float)bloodTypeCount / studentsBloodTypes.Length) * 100;

            return bloodTypeProportion;
        }
    }
}

