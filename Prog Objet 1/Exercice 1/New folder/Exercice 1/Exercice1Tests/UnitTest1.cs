using Exercice_1;

namespace Exercice1Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateBMI_WithValidWeightAndHeight()
        {
            // Arrange
            const float EXPECTED_BMI = 19.9094105f;
            float weight = 58.9f;
            float height = 1.72f;

            // Act
            float BMI = Library.CalculateBMI(weight, height);

            // Assert
            Assert.Equal(EXPECTED_BMI, BMI, 0.1);
        }

        [Fact]
        public void CalculateBMI_WithValidWeightAndNonValidHeight()
        {
            // Arrange
            const float EXPECTED_BMI = 0f;
            float weight = 58.9f;
            float height = 0f;

            // Act & Assert 
            // https://learn.microsoft.com/en-us/dotnet/api/system.dividebyzeroexception?view=net-9.0
            Assert.Throws<DivideByZeroException>(() => Library.CalculateBMI(weight, height));
        }

        [Fact]
        public void CalculateBMI_WithNullWeightAndValidHeight()
        {
            // Arrange
            const float EXPECTED_BMI = 0f;
            float weight = 0f;
            float height = 1.72f;
            // Act
            float BMI = Library.CalculateBMI(weight, height);
            // Assert
            Assert.Equal(EXPECTED_BMI, BMI);
        }

        [Fact]
        public void CalculateBMI_WithNegativeWeight_ThrowsException()
        {
            // Arrange
            float weight = -58.9f;
            float height = 1.72f;

            // Act & Arrange
            Assert.Throws<ArgumentOutOfRangeException>(() => Library.CalculateBMI(weight, height));
        }

        [Fact]
        public void CalculateBMI_WithNegativeHeight_ThrowsException()
        {
            // Arrange
            float weight = 58.9f;
            float height = -1.72f;

            // Act & Arrange
            Assert.Throws<ArgumentOutOfRangeException>(() => Library.CalculateBMI(weight, height));
        }

        [Fact]
        public void FindMinValue_ArrayOf7Numbers_LastElement()
        {
            // Arrange
            const int EXPECTED_MIN = 1;
            int[] values = { 5, 4, 3, 2, 6, 7, 1 };

            // Act
            int minNumber = Library.FindMinValue(values);

            // Assert
            Assert.Equal(EXPECTED_MIN, minNumber);
        }
        [Fact]
        public void FindMinValue_ArrayOf5Numbers_FirstElement()
        {
            // Arrange
            const int EXPECTED_MIN = 1;
            int[] values = { 1, 4, 3, 5, 2 };

            // Act
            int minNumber = Library.FindMinValue(values);

            // Assert
            Assert.Equal(EXPECTED_MIN, minNumber);
        }
        [Fact]
        public void FindMinValue_ArrayOf4NegativeNumbers_LastElement()
        {
            // Arrange
            const int EXPECTED_MIN = -4;
            int[] values = { -1, -2, -3, -4 };

            // Act
            int minNumber = Library.FindMinValue(values);

            // Assert
            Assert.Equal(EXPECTED_MIN, minNumber);
        }
        [Fact]
        public void FindMinValue_ArrayOf1NegativeNumber_SingleElement()
        {
            // Arrange
            const int EXPECTED_MIN = -4;
            int[] values = { -4 };

            // Act
            int minNumber = Library.FindMinValue(values);

            // Assert
            Assert.Equal(EXPECTED_MIN, minNumber);
        }
        [Fact]
        public void FindMinValue_EmptyArray_DefaultValue()
        {
            // Arrange
            const int EXPECTED_MIN = int.MaxValue;
            int[] values = { };

            // Act
            int minNumber = Library.FindMinValue(values);

            // Assert
            Assert.Equal(EXPECTED_MIN, minNumber);
        }
        [Fact]
        public void FinMinValue_NullArray_Exception()
        {
            // Arrange 
            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => Library.FindMinValue(null));
        }

        [Fact]

        public void FindMaxValue_ArrayOf5Numbers_LastElement()
        {
            // Arrange
            const int EXPECTED_MAX = 5;
            int[] values = { 1, 2, 3, 4, 5 };

            // Act
            int maxNumber = Library.FindMaxValue(values);

            // Assert
            Assert.Equal(EXPECTED_MAX, maxNumber);
        }

        [Fact]
        public void FindMaxValue_ArrayOf3Numbers_FirstElement()
        {
            // Arrange
            const int EXPECTED_MAX = 4;
            int[] values = { 4, -5, 1 };

            // Act
            int maxNumber = Library.FindMaxValue(values);

            // Assert
            Assert.Equal(EXPECTED_MAX, maxNumber);
        }

        [Fact]
        public void FindMaxValue_ArrayOf2NegativeNumbers_LastElement()
        {
            // Arrange
            const int EXPECTED_MAX = -20;
            int[] values = { -30, -20 };

            // Act
            int maxNumber = Library.FindMaxValue(values);

            // Assert
            Assert.Equal(EXPECTED_MAX, maxNumber);

        }

        [Fact]
        public void FindMaxValue_ArrayOf1Number_SingleElement()
        {
            // Arrange
            const int EXPECTED_MAX = -1;
            int[] values = { -1 };

            // Act
            int maxNumber = Library.FindMaxValue(values);

            // Assert
            Assert.Equal(EXPECTED_MAX, maxNumber);
        }

        [Fact]
        public void FindMaxValue_EmptyArray_DefaultValue()
        {
            // Arrange
            const int EXPECTED_MAX = int.MinValue;
            int[] values = { };

            // Act
            int maxNumber = Library.FindMaxValue(values);

            // Assert
            Assert.Equal(EXPECTED_MAX, maxNumber);
        }

        [Fact]
        public void FindMaxValue_NullArray_Exception()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<System.ArgumentException>(() => Library.FindMaxValue(null));
        }

        [Fact]
        public void LinearSearch_ValuePresentInArray_ReturnsTrue()
        {
            // Arrange
            int[] testArray = new int[] { 1, 6, 8, 21, 34, 38 };

            // Act & Assert
            Assert.True(Library.LinearSearch(testArray, 1));
            Assert.True(Library.LinearSearch(testArray, 6));
            Assert.True(Library.LinearSearch(testArray, 8));
            Assert.True(Library.LinearSearch(testArray, 21));
            Assert.True(Library.LinearSearch(testArray, 34));
            Assert.True(Library.LinearSearch(testArray, 38));
        }

        [Fact]
        public void LinearSearch_ValueNotPresentInArray_ReturnsFlase()
        {
            // Arrange
            int[] testArray = new int[] { 1, 6, 8, 21, 34, 38 };

            // Act & Assert
            Assert.False(Library.LinearSearch(testArray, 0));
            Assert.False(Library.LinearSearch(testArray, -4));
            Assert.False(Library.LinearSearch(testArray, 12));
            Assert.False(Library.LinearSearch(testArray, 25));
            Assert.False(Library.LinearSearch(testArray, 44));
            Assert.False(Library.LinearSearch(testArray, 188));
        }
        [Fact]
        public void LinearSearch_NullArray_ThrowsArgumentException()
        {
            // Arrange
            int[] testArray = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Library.LinearSearch(testArray, 5));
        }

        [Fact]
        public void VerifySort_SortedArray_ReturnsTrue()
        {
            // Arrange
            int[] testArray = new int[] { 1, 2, 3, 4, 5 };

            // Act & Assert
            Assert.True(Library.VerifySort(testArray));
        }

        [Fact]
        public void VerifySort_UnsortedArray_ReturnsFalse()
        {
            // Arrange
            int[] testArray = new int[] { 3, 2, 5, 4, 1 };

            // Act & Assert
            Assert.False(Library.VerifySort(testArray));
        }

        [Fact]
        public void VerifySort_ArrayOf1Number_ReturnsTrue()
        {
            // Arrange
            int[] testArray = new int[] { 5 };

            // Act & Assert
            Assert.True(Library.VerifySort(testArray));
        }

        [Fact]
        public void VerifySort_EmptyArray_ReturnsTrue()
        {
            // Arrange
            int[] testArray = new int[0];

            // Act & Assert
            Assert.True(Library.VerifySort(testArray));
        }

        [Fact]
        public void VerifySort_NullArray_ThrowsArgumentException()
        {
            // Arrange
            int[] testArray = null;
            // Act & Assert
            Assert.Throws<ArgumentException>(() => Library.VerifySort(testArray));
        }
    }
}