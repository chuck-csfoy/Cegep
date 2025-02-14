using Exercice_5___Classes;
using System.Security.Principal;

namespace TestEmployee
{
    public class EmployeeTests
    {
        [Fact]
        public void Constructor_EmployeeNameIsEmpty_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Employee("", 25000, EmployeeStatus.Occasional));
        }
        [Fact]
        public void Constructor_ValidParameterValuesShouldInitializePropertiesCorrectly_ExpectedValues()
        {
            // Arrange & Act
            Employee employee = new Employee("Johnny", 350000, EmployeeStatus.Contractual);

            // Assert
            Assert.Equal("Johnny", employee.EmployeeFullName);
            Assert.Equal(350000, employee.EmployeeBaseSalary);
            Assert.Equal(EmployeeStatus.Contractual, employee.EmployeeStatus);
        }
        //[Fact]
        //public float CalculateRealSalary_ValidSalaryEmployeeStatusContractual_ExpectedValues()
        //{
        //    // Arrange 
        //    Employee employee = new Employee("Johnny", 35000, EmployeeStatus.Contractual);

        //    // Act
        //    float realSalary = employee.CalculateRealSalary(EmployeeStatus.Contractual);

        //    // Assert
        //    Assert.Equal(37800, realSalary);
        //}
    }
}