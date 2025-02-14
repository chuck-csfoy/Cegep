namespace Exercice_5___Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Object new instance

            Employee newEmployee = new Employee("GrosJean", 20000, EmployeeStatus.Permanent);

            //Console.WriteLine(newEmployee.EmployeeFullName + "\n" + newEmployee.EmployeeBaseSalary + "\n" + EmployeeStatus.Permanent + "\n");
            Console.WriteLine($"New Employee: \n Employee Full Name: {newEmployee.EmployeeFullName} \n Employee Base Salary: {newEmployee.EmployeeBaseSalary}  \n Employee Status:");

            BankAccount account1 = new BankAccount("Johnny Cash", 100000f, 0f);
            BankAccount account2 = new BankAccount("July BlingBling", 0f, 4900f);
            BankAccount account3 = new BankAccount("Bobby Crappy", 0f, 100f);

            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

            account1.Deposit(200);
            account2.Withdraw(300);
            account3.Deposit(200);

            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

        }
    }
}