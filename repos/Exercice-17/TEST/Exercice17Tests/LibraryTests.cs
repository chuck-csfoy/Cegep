using Exercice17;
using Xunit;

namespace Exercice17Test
{
  public class LibraryTests
  {
    
    [Fact]
    public void Sum_ArrayOf5Numbers_15 ()
    {
      // Arrange
      const int EXPECTED_SUM = 15;
      int[] values = new[] { 1, 2, 3, 4, 5 };

      // Act
      int sum = Library.Sum (values);

      // Assert
      Assert.Equal (EXPECTED_SUM, sum);

      Assert.Equal (-50, Library.Sum (new[] { -30, -20 }));
    }
    
    [Fact]
    public void Sum_ArrayOf3Numbers_0 ()
    {
      // Arrange
      const int EXPECTED_SUM = 0;
      int[] values = new[] { 4, -5, 1 };

      // Act
      int sum = Library.Sum (values);

      // Assert
      Assert.Equal (EXPECTED_SUM, sum);      
    }
    
    [Fact]
    public void Sum_ArrayOf2Numbers_Minus50 ()
    {
      // Arrange
      const int EXPECTED_SUM = -50;
      int[] values = new[] { -30, -20 };

      // Act
      int sum = Library.Sum (values);

      // Assert
      Assert.Equal (EXPECTED_SUM, sum);
    }
    
    [Fact]
    public void Sum_ArrayOf1Number_Minus1 ()
    {
      // Arrange
      const int EXPECTED_SUM = -1;
      int[] values = new[] { -1 };

      // Act
      int sum = Library.Sum (values);

      // Assert
      Assert.Equal (EXPECTED_SUM, sum);
    }
    
    [Fact]
    public void Sum_EmptyArray_0 ()
    {
      // A COMPLETER
      // Retirer la ligne suivante (qui fait toujours échouer le test) et inscrivez le code nécessaire pour le test
      //Assert.True (false);
      // Arrange
      const int EXPECTED_SUM = 0;
      int[] values = { };

      // Act
      int sum = Library.Sum(values);

      // Assert
      Assert.Equal(EXPECTED_SUM, sum);
    }
    
    [Fact]
    public void Sum_NullArray_Exception ()
    {
      // Arrange
      //int[] values;
      // Act
      // Assert
      Assert.Throws<System.ArgumentException> (() => Library.Sum (null));
    }
   
    [Fact]
    public void Average_ArrayOf5Numbers_3 ()
    {
      // Arrange
      const int EXPECTED_AVERAGE = 3;
      int[] values = { 1, 2, 3, 4, 5 };

      // Act
      int average = Library.Average (values);

      // Assert
      Assert.Equal (EXPECTED_AVERAGE, average);
    }
    
    [Fact]
    public void Average_ArrayOf2Numbers_Minus25 ()
    {
      // Arrange
      const int EXPECTED_AVERAGE = -25;
      int[] values = { -30, -20 };

      // Act
      int average = Library.Average (values);

      // Assert
      Assert.Equal (EXPECTED_AVERAGE, average);
    }

    [Fact]
    public void Average_ArrayOf1Number_Minus1 ()
    {
      // Arrange
      const int EXPECTED_AVERAGE = -1;
      int[] values = { -1 };

      // Act
      int average = Library.Average (values);

      // Assert
      Assert.Equal (EXPECTED_AVERAGE, average);
    }

    [Fact]
    public void Average_EmptyArray_0 ()
    {
      // Arrange
      const int EXPECTED_AVERAGE = 0;
      int[] values = { };

      // Act
      int average = Library.Average (values);

      // Assert
      Assert.Equal (EXPECTED_AVERAGE, average);
    }

    [Fact]
    public void Average_NullArray_Exception ()
    {
      // Arrange
      // Act
      // Assert
      Assert.Throws<System.ArgumentException> (() => Library.Average (null));
    }
    
    [Fact]
    public void Max_ArrayOf5Numbers_LastElement ()
    {
      // Arrange
      const int EXPECTED_MAX = 5;
      int[] values = { 1, 2, 3, 4, 5 };

      // Act
      int maxNumber = Library.Max (values);

      // Assert
      Assert.Equal (EXPECTED_MAX, maxNumber);
    }
    
    [Fact]
    public void Max_ArrayOf3Numbers_FirstElement ()
    {
      // Arrange
      const int EXPECTED_MAX = 4;
      int[] values = { 4, -5, 1 };

      // Act
      int maxNumber = Library.Max (values);

      // Assert
      Assert.Equal (EXPECTED_MAX, maxNumber);
    }

    [Fact]
    public void Max_ArrayOf2NegativeNumbers_LastElement ()
    {
      // Arrange
      const int EXPECTED_MAX = -20;
      int[] values = { -30, -20 };

      // Act
      int maxNumber = Library.Max (values);

      // Assert
      Assert.Equal (EXPECTED_MAX, maxNumber);

    }
    
    [Fact]
    public void Max_ArrayOf1Number_SingleElement ()
    {
      // Arrange
      const int EXPECTED_MAX = -1;
      int[] values = { -1 };

      // Act
      int maxNumber = Library.Max (values);

      // Assert
      Assert.Equal (EXPECTED_MAX, maxNumber);
    }
    
    [Fact]
    public void Max_EmptyArray_DefaultValue ()
    {
      // Arrange
      const int EXPECTED_MAX = int.MinValue;
      int[] values = { };

      // Act
      int maxNumber = Library.Max (values);

      // Assert
      Assert.Equal (EXPECTED_MAX, maxNumber);
    }

    [Fact]
    public void Max_NullArray_Exception ()
    {
      // Arrange
      // Act
      // Assert
      Assert.Throws<System.ArgumentException> (() => Library.Max (null));
    }
    
    [Fact]
    public void FilterEven_ArrayWithEvenAndOddNumbers_EvenNumbersInArray ()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { 2, 4 };
      int[] values = { 1, 2, 3, 4, 5 };

      // Act
      int[] evenNumbers = Library.FilterEven (values);

      // Assert      
      Assert.Equal(EXPECTED_EVEN_NUMBERS, evenNumbers);
    }
    
    [Fact]
    public void FilterEven_ArrayWithAllEvenNumbers_AllNumbersInArray ()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { 2, -4, 4 };
      int[] values = { 2, -4, 4 };

      // Act
      int[] evenNumbers = Library.FilterEven (values);

      // Assert
      Assert.Equal(EXPECTED_EVEN_NUMBERS, evenNumbers);
    }
    [Fact]
    public void FilterEven_ArrayWithoutEvenNumbers_EmptyArray ()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { };
      int[] values = { -31, -21 };

      // Act
      int[] evenNumbers = Library.FilterEven (values);

      // Assert
      Assert.Equal(EXPECTED_EVEN_NUMBERS, evenNumbers);
    }

    // A COMPLÉTER
    // Écrire un test qui permet de vérifier qu'un tableau vide retourne un tableau vide
    [Fact]
    public void FilterEven_EmptyArray_Exception ()
    {
      // Arrange
      int[] EXPECTED_EVEN_NUMBERS = { };
      int[] values = { };

      // Act
      int[] evenNumbers = Library.FilterEven(values);

      // Assert
      Assert.Equal(EXPECTED_EVEN_NUMBERS, evenNumbers);
    }

    [Fact]
    public void FilterEven_NullArray_Exception ()
    {
      // Arrange
      // Act
      // Assert
      Assert.Throws<System.ArgumentException> (() => Library.FilterEven (null));
    }
  }
}