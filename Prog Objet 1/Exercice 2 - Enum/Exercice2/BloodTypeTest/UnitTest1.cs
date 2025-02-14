using Exercice2;
using System.Runtime.InteropServices;

namespace BloodTypeTest
{
    public class UnitTest1
    {
        [Fact]
        public void DisplayArray_NullArray_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => Program.DisplayArray(null));
        }

        [Fact]
        public void DisplayArray_EmptyArray_Exception()
        {
            //Arrange
            BloodType[] studentsBloodTypes = { };
            //Act & Assert
            Assert.Throws<ArgumentException>(() => Program.DisplayArray(studentsBloodTypes));
        }

        [Fact]
        public void CalculateProportion_ArrayOf10ValuesWithValidValues_ExpectedValue()
        {
            //Arrange
            BloodType[] studentsBloodTypes = {BloodType.A, BloodType.B, BloodType.AB, BloodType.O, 
            BloodType.O, BloodType.O, BloodType.O, BloodType.O, BloodType.AB, BloodType.A };

            const float EXPECTED_VALUE = 20f;
            //Act
            float bloodTypeProportion = Program.CalculateProportion(studentsBloodTypes, BloodType.A);
            //Assert
            Assert.Equal(EXPECTED_VALUE, bloodTypeProportion);
        }

        [Fact]
        public void CalculateProportion_NullArray_Exception()
        {
            //Arrange
            //Act & Assert
            Assert.Throws<ArgumentException>(() => Program.CalculateProportion(null, BloodType.A));
        }

        [Fact]
        public void CalculateProportion_EmptyArray_Exception()
        {
            //Arrange
            BloodType[] studentsBloodTypes = { };
            //Act & Assert
            Assert.Throws<ArgumentException>(() => Program.CalculateProportion(studentsBloodTypes, BloodType.A));
        }

        [Fact]
        public void CalculateProportion_ArrayOf1PresentValue_ExpectedValue()
        {
            //Arrange
            BloodType[] studentsBloodTypes = { BloodType.A };
            const float EXPECTED_VALUE = 100f;

            //Act
            float bloodTypeProportion = Program.CalculateProportion(studentsBloodTypes, BloodType.A);

            //Assert
            Assert.Equal(EXPECTED_VALUE, bloodTypeProportion);
        }

        [Fact]
        public void CalculateProportion_ArrayOf1NotPresentValue_ExpectedValue()
        {
            //Arrange
            BloodType[] studentsBloodTypes = { BloodType.B };
            const float EXPECTED_VALUE = 0f;

            //Act
            float bloodTypeProportion = Program.CalculateProportion(studentsBloodTypes, BloodType.A);

            //Assert
            Assert.Equal(EXPECTED_VALUE, bloodTypeProportion);
        }

        [Fact]
        public void CalculateProportion_ArrayOf5NotPresentValue_ExpectedValue()
        {
            //Arrange
            BloodType[] studentsBloodTypes = { BloodType.AB, BloodType.B, BloodType.B, BloodType.O, BloodType.AB};
            const float EXPECTED_VALUE = 0f;

            //Act
            float bloodTypeProportion = Program.CalculateProportion(studentsBloodTypes, BloodType.A);

            //Assert
            Assert.Equal(EXPECTED_VALUE, bloodTypeProportion);
        }

        [Fact]
        public void CalculateProportion_ArrayOf5PresentValue_ExpectedValue()
        {
            //Arrange
            BloodType[] studentsBloodTypes = { BloodType.A, BloodType.A, BloodType.A, BloodType.A, BloodType.A };
            const float EXPECTED_VALUE = 100f;

            //Act
            float bloodTypeProportion = Program.CalculateProportion(studentsBloodTypes, BloodType.A);

            //Assert
            Assert.Equal(EXPECTED_VALUE, bloodTypeProportion);
        }
    }
}