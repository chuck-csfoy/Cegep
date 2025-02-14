using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercice17;

namespace Exercice17Test
{
  [TestClass]
  public class LibraryTest
  {
	
    [TestMethod]
    public void CanSumArrayOf5Numbers()
    {
      // Arrange
      const int EXPECTED_SUM = 15;
      int[] values = new[] { 1, 2, 3, 4, 5 };

      // Act
      int sum = Library.Sum(values);

      // Assert
      Assert.AreEqual(EXPECTED_SUM, sum);

      Assert.AreEqual(-50, Library.Sum(new[] { -30, -20 }));
    }

    [TestMethod]
    public void CanSumArrayOf3Numbers()
    {
      // Arrange
      const int EXPECTED_SUM = 0;
      int[] values = new[] { 4, -5, 1 };

      // Act
      int sum = Library.Sum(values);

      // Assert
      Assert.AreEqual(EXPECTED_SUM, sum);
      Assert.AreEqual(0, Library.Sum(new[] { 4, -5, 1 }));
    }

    [TestMethod]
    public void CanSumArrayOf2Numbers()
    {
      // Arrange
      const int EXPECTED_SUM = -50;
      int[] values = new[] { -30, -20 };

      // Act
      int sum = Library.Sum(values);

      // Assert
      Assert.AreEqual(EXPECTED_SUM, sum);
    }

    [TestMethod]
    public void CanSumSingleItemArray()
    {
      // Arrange
      const int EXPECTED_SUM = -1;
      int[] values = new[] { -1 };

      // Act
      int sum = Library.Sum(values);

      // Assert
      Assert.AreEqual(EXPECTED_SUM, sum);
    }

    [TestMethod]
    public void CanSumEmptyArray()
    {
      // Arrange
      const int EXPECTED_SUM = 0;
      int[] values = { };

      // Act
      int sum = Library.Sum(values);

      // Assert
      Assert.AreEqual(EXPECTED_SUM, sum);
    }
	

	/*
    [TestMethod]
    public void CanAverageArrayOf5Numbers()
    {
      // Arrange
      const int EXPECTED_AVERAGE = 3;
      int[] values = { 1, 2, 3, 4, 5 };

      // Act
      int average = Library.Average(values);

      // Assert
      Assert.AreEqual(EXPECTED_AVERAGE, average);
    }

    [TestMethod]
    public void CanAverageArrayOf3Numbers()
    {
      // Arrange
      const int EXPECTED_AVERAGE = 0;
      int[] values = { 4, -5, 1 };

      // Act
      int average = Library.Average(values);

      // Assert
      Assert.AreEqual(EXPECTED_AVERAGE, average);
    }

    [TestMethod]
    public void CanAverageArrayOf2Numbers()
    {
      // Arrange
      const int EXPECTED_AVERAGE = -25;
      int[] values = { -30, -20 };

      // Act
      int average = Library.Average(values);

      // Assert
      Assert.AreEqual(EXPECTED_AVERAGE, average);
    }

    [TestMethod]
    public void CanAverageSingleItemArray()
    {
      // Arrange
      const int EXPECTED_AVERAGE = -1;
      int[] values = { -1 };

      // Act
      int average = Library.Average(values);

      // Assert
      Assert.AreEqual(EXPECTED_AVERAGE, average);
    }

    [TestMethod]
    public void CanAverageEmptyArray()
    {
      // Arrange
      const int EXPECTED_AVERAGE = 0;
      int[] values = { };

      // Act
      int average = Library.Average(values);

      // Assert
      Assert.AreEqual(EXPECTED_AVERAGE, average);
    }
	*/

	/*
    [TestMethod]
    public void CanFindMaxInArrayOf5Numbers()
    {
      // Arrange
      const int EXPECTED_MAX = 5;
      int[] values = { 1, 2, 3, 4, 5 };

      // Act
      int maxNumber = Library.Max(values);

      // Assert
      Assert.AreEqual(EXPECTED_MAX, maxNumber);
    }

    [TestMethod]
    public void CanFindMaxInArrayOf3Numbers()
    {
      // Arrange
      const int EXPECTED_MAX = 4;
      int[] values = { 4, -5, 1 };

      // Act
      int maxNumber = Library.Max(values);

      // Assert
      Assert.AreEqual(EXPECTED_MAX, maxNumber);
    }


    [TestMethod]
    public void CanFindMaxInArrayOf2Numbers()
    {
      // Arrange
      const int EXPECTED_MAX = -20;
      int[] values = { -30, -20 };

      // Act
      int maxNumber = Library.Max(values);

      // Assert
      Assert.AreEqual(EXPECTED_MAX, maxNumber);

    }

    [TestMethod]
    public void CanFindMaxInSingleItemArray()
    {
      // Arrange
      const int EXPECTED_MAX = -1;
      int[] values = { -1 };

      // Act
      int maxNumber = Library.Max(values);

      // Assert
      Assert.AreEqual(EXPECTED_MAX, maxNumber);
    }

    [TestMethod]
    public void CanFindMaxInEmptyArray()
    {
      // Arrange
      const int EXPECTED_MAX = int.MinValue;
      int[] values = { };

      // Act
      int maxNumber = Library.Max(values);

      // Assert
      Assert.AreEqual(EXPECTED_MAX, maxNumber);
    }
	*/
	
	/*
    [TestMethod]
    public void CanFilterEvenNumbersInArrayWith2EvenNumbers()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { 2, 4 };
      int[] values = { 1, 2, 3, 4, 5 };

      // Act
      int[] eventNumbers = Library.FilterEven(values);

      // Assert      
      Assert.IsTrue(ArrayAreEquals(EXPECTED_EVEN_NUMBERS, eventNumbers));
    }

    [TestMethod]
    public void CanFilterEvenNumbersInArrayWithAllEvenNumbers()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { 2, -4, 4 };
      int[] values = { 2, -4, 4 };

      // Act
      int[] eventNumbers = Library.FilterEven(values);

      // Assert
      Assert.IsTrue(ArrayAreEquals(EXPECTED_EVEN_NUMBERS, eventNumbers));
    }
    [TestMethod]
    public void CanFilterEvenNumbersInArrayWithZeroEvenNumber()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { };
      int[] values = { -31, -21 };

      // Act
      int[] eventNumbers = Library.FilterEven(values);

      // Assert
      Assert.IsTrue(ArrayAreEquals(EXPECTED_EVEN_NUMBERS, eventNumbers));
    }


    [TestMethod]
    public void CanFilterEvenNumbersInEmptyArray()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { };
      int[] values = { };

      // Act
      int[] eventNumbers = Library.FilterEven(values);

      // Assert
      Assert.IsTrue(ArrayAreEquals(EXPECTED_EVEN_NUMBERS, eventNumbers));
    }

    public bool ArrayAreEquals(int[] array1, int[] array2)
    {
      // A COMPLETER
      return false;
    }
	*/

  }
}