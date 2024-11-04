using Xunit;
using Exercice18b;

namespace Exercice18bTest
{

  public class LibraryTest
  {
    
    [Fact]
    public void Clamp_NullArray_ThrowsException ()
    {
      // Arrange
      int[] originalArray = null;
      int[] EXPECTED_ARRAY = { };

      // Act
      // Assert
      Assert.Throws < System.ArgumentException> (()=>Library.Clamp(originalArray, 0,0));
    }

    [Fact]
    public void Clamp_ArrayWithLowerAndHigherValues_CorrespondingArray ()
    {
      // Arrange
      int[] expectedNumbers = { 3, 3, 3, 4, 5, 6, 7, 7, 7 };
      int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

      // Act
      Library.Clamp (numbers, 3, 7);

      // Assert
      Assert.Equal (expectedNumbers, numbers);
    }

    [Fact]
    public void Clamp_ArrayWithLowerAndHigherAnd_NegativeValues_CorrespondingArray ()
    {
      // Arrange
      int[] expectedNumbers = { -3, 0, 3 };
      int[] numbers = { -5, 0, 5 };

      // Act
      Library.Clamp (numbers, -3, 3);

      // Assert
      Assert.Equal (expectedNumbers, numbers);
    }

    [Fact]
    public void Clamp_MinAndMaxAreEquals_ArrayWithOnlyOneValue ()
    {
      // Arrange
      int[] expectedNumbers = { 5, 5, 5 };
      int[] numbers = { 1, 2, 3 };

      // Act
      Library.Clamp (numbers, 5, 5);

      // Assert
      Assert.Equal (expectedNumbers, numbers);
    }

    [Fact]
    public void Clamp_EmptyArray_EmptyArray ()
    {
      // Arrange
      int[] expectedNumbers = new int[0];
      int[] numbers = new int[0];

      // Act
      Library.Clamp (numbers, 5, 5);

      // Assert
      Assert.Equal (expectedNumbers, numbers);
    }
     
    [Fact]
    public void Insert_NullArray_ThrowsException ()
    {
      // Arrange
      // Act
      // Assert
      Assert.Throws<System.ArgumentException> (() => Library.Insert (null, 0, 0));
    }
    [Fact]
    public void Insert_IndexOutOfArrayRangeOriginalArrayWithNewElementAtPositionNeg1_ThrowsException()
    {
      // Arrange
      int[] numbers = { 1, 2, 3, 4};
      // Act
      // Assert
      Assert.Throws<System.ArgumentException>(() => Library.Insert(numbers,-1, 4));
    }

    [Fact]
    public void Insert_IndexOutOfArrayRangeOriginalArrayWithNewElementAtPositionPos6_ThrowsException()
    {
      // Arrange
      int[] numbers = { 1, 2, 3, 4};
      // Act
      // Assert
      Assert.Throws<System.ArgumentException>(() => Library.Insert(numbers, 6, 4));
    }

    [Fact]
    public void Insert_EmptyArray_ArrayWithSingleElement ()
    {
      // Arrange
      int[] EXPECTED_ARRAY = { 1 };
      int[] numbers = { };

      // Act
      int[] result = Library.Insert (numbers, 0, 1);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, result);
    }

    [Fact]
    public void Insert_AtBeginningInNotEmptyArray_OriginalArrayWithNewElementAtPosition0 ()
    {
      // Arrange
      int[] EXPECTED_ARRAY = { 4, 1, 2, 3 };
      int[] numbers = { 1, 2, 3 };

      // Act
      int[] result = Library.Insert (numbers, 0, 4);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, result);
    }

    [Fact]
    public void Insert_NotAtBeginningNorAtEndInNotEmptyArray_OriginalArrayWithNewElementAtPosition1 ()
    {
      // Arrange
      int[] EXPECTED_ARRAY = { 1, 4, 2, 3 };
      int[] numbers = { 1, 2, 3 };

      // Act
      int[] result = Library.Insert (numbers, 1, 4);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, result);
    }

    [Fact]
    public void Insert_AtEndInNotEmptyArray_OriginalArrayWithNewElementAtEnd ()
    {
      // Arrange
      int[] EXPECTED_ARRAY = { 1, 2, 3, 4 };
      int[] numbers = { 1, 2, 3 };

      // Act
      int[] result = Library.Insert (numbers, numbers.Length, 4);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, result);
    }
     
    [Fact]
    public void Dedup_NullArray_ThrowsException ()
    {
      // Arrange
      // Act
      // Assert
      Assert.Throws < System.ArgumentException> (() => Library.Dedup (null));
    }
      
    [Fact]
    public void Dedup_NotEmptyArrayWithDuplicates_ArrayWithNoDuplicate ()
    {
      // Arrange
      int[] expectedNumbers = { 1, 2 };

      // Act
      int[] result = Library.Dedup (new[] { 1, 1, 2 });

      // Assert
      Assert.Equal (expectedNumbers, result);

    }

    [Fact]
    public void Dedup_MultipleConstantElementArray_ArrayWithOnlyOneElement ()
    {
      // Arrange
      int[] expectedNumbers = { 1 };

      // Act
      int[] result = Library.Dedup (new[] { 1, 1, 1 });

      // Assert
      Assert.Equal (expectedNumbers, result);
    }

    [Fact]
    public void Dedup_ArrayWithoutDuplicate_OriginalArray ()
    {
      // Arrange
      int[] expectedNumbers = { 1, 2, 3 };

      // Act
      int[] result = Library.Dedup (new[] { 1, 2, 3 });

      // Assert
      Assert.Equal (expectedNumbers, result);
    }

    [Fact]
    public void Dedup_EmptyArray_EmptyArray ()
    {
      // Arrange
      int[] expectedNumbers = new int [0];

      // Act
      int[] result = Library.Dedup (new int[0]);

      // Assert
      Assert.Equal (expectedNumbers, result);

    }
    [Fact]
    public void Contains_NullArray_ThrowsException()
    {
      // Arrange
      int[] result = null;
      int[] EXPECTED_ARRAY = { };
      // Act
      // Assert
      Assert.Throws<System.ArgumentException>(() => Library.Contains(0, result));
    }
  }
}