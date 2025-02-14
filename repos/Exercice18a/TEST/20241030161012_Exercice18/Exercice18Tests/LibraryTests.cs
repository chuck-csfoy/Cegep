using Xunit;
using Exercice18;

namespace Exercice18Test
{

  public class LibraryTest
  {
    
    [Fact]
    public void Append_AppendInNotEmptyArray_ArrayWithNewElementAtTheEnd ()
    {
      // Arrange
      int[] originalArray = { 1, 2, 3 };
      const int ELEMENT_TO_APPEND = 4;
      int[] EXPECTED_ARRAY = { 1, 2, 3, ELEMENT_TO_APPEND };

      // Act
      int[] arrayWithNewElement = Library.Append (originalArray, ELEMENT_TO_APPEND);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, arrayWithNewElement);
    }

    // A COMPLETER
    // Ajouter un test pour tester l'ajout dans un tableau vide
    [Fact]
    public void Append_AppendEmptyArray_ArrayWithNewElementAtTheEnd()
    {
      // Arrange
      int[] originalArray = { };
      const int ELEMENT_TO_APPEND = 4;
      int[] EXPECTED_ARRAY = { ELEMENT_TO_APPEND };

      // Act
      int[] arrayWithNewElement = Library.Append(originalArray, ELEMENT_TO_APPEND);

      // Assert
      Assert.Equal(EXPECTED_ARRAY, arrayWithNewElement);
    }

    [Fact]
    public void Append_AppendNullArray_ArrayWithNewElementAtTheEnd()
    {
      // Arrange
      int[] originalArray = null;
      const int ELEMENT_TO_APPEND = 4;
      int[] EXPECTED_ARRAY = { };

      // Act

      // Assert
      Assert.Throws<System.ArgumentException>(() => Library.Append(originalArray, ELEMENT_TO_APPEND));
    }

    [Fact]
    public void GetDistinctElements_OnlyFirstElementRemoved_CorrespondingArray()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 1 };
      int[] EXPECTED_ARRAY = { 2, 3 };

      // Act
      int[] differenceArray = Library.GetDistinctElements (array1, array2);

      // Assert

      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }
    
    [Fact]
    public void GetDistinctElements_OnlyLastElementRemoved_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 3 };
      int[] EXPECTED_ARRAY = { 1, 2 };

      // Act
      int[] differenceArray = Library.GetDistinctElements (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
      Assert.Equal (new int[0], Library.GetDistinctElements(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
    }

    [Fact]
    public void GetDistinctElements_AllElementRemoved_EmptyArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] EXPECTED_ARRAY = { };

      // Act
      int[] differenceArray = Library.GetDistinctElements (array1, array1);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void GetDistinctElements_LastElementsRemovedIgnoringOrder_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 3, 2 };
      int[] EXPECTED_ARRAY = { 1 };

      // Act
      int[] differenceArray = Library.GetDistinctElements (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void GetDistinctElements_FirstElementsRemovedIgnoringOrder_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 2, 1 };
      int[] EXPECTED_ARRAY = { 3 };

      // Act
      int[] differenceArray = Library.GetDistinctElements (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void GetDistinctElements_FirstAndLastElementsRemovedIgnoringOrder_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 3, 1 };
      int[] EXPECTED_ARRAY = { 2 };

      // Act
      int[] differenceArray = Library.GetDistinctElements (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }

    // A COMPLETER
    // Ajoutez les tests pour les situations décrites dans l'énoncé.
    [Fact]
    public void GetDistinctElements_SameElementsDifferentOrder_CorrespondingArray()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 3, 2, 1 };
      int[] EXPECTED_ARRAY = { };

      // Act
      int[] differenceArray = Library.GetDistinctElements(array1, array2);

      // Assert
      Assert.Equal(EXPECTED_ARRAY, differenceArray);
    }
    [Fact]
    public void GetDistinctElements_SecondArrayLargerSize_CorrespondingArray()
    {
      // Arrange
      int[] array1 = { 1, 2, 3};
      int[] array2 = { 1, 2, 4, 5, 6};
      int[] EXPECTED_ARRAY = {3};

      // Act
      int[] differenceArray = Library.GetDistinctElements(array1, array2);

      // Assert
      Assert.Equal(EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void GetDistinctElements_EmptyFirstArraySecondArrayLargerSize_CorrespondingArray()
    {
      // Arrange
      int[] array1 = { };
      int[] array2 = {1, 2, 4, 5, 6};
      int[] EXPECTED_ARRAY = { };

      // Act
      int[] differenceArray = Library.GetDistinctElements(array1, array2);

      // Assert
      Assert.Equal(EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void GetDistinctElements_TwoEmptyArrays_CorrespondingArray()
    {
      // Arrange
      int[] array1 = { };
      int[] array2 = { };
      int[] EXPECTED_ARRAY = { };

      // Act
      int[] differenceArray = Library.GetDistinctElements(array1, array2);

      // Assert
      Assert.Equal(EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void GetDistinctElements_FirstNullArray_CorrespondingArray()
    {
      // Arrange
      int[] array1 = null;
      int[] array2 = {1, 2, 3};
      int[] EXPECTED_ARRAY = { };

      // Act
     
      // Assert
      Assert.Throws<System.ArgumentException>(() => Library.GetDistinctElements(array1, array2));
    }

    [Fact]
    public void Reverse_NotEmptyArrayOf3Elements_ArrayInReverseOrder ()
    {
      // Arrange
      int[] originalArray = { 1, 2, 3 };
      int[] EXPECTED_ARRAY = { 3, 2, 1 };

      // Act
      int[] reverseArray = Library.Reverse (originalArray);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, reverseArray);
    }

    // A COMPLETER
    // Ajoutez les tests pour les situations décrites dans l'énoncé.
    [Fact]
    public void Reverse_SingleElementArray_ArrayInReverseOrder()
    {
      // Arrange
      int[] originalArray = {1};
      int[] EXPECTED_ARRAY = {1};

      // Act
      int[] reverseArray = Library.Reverse(originalArray);

      // Assert
      Assert.Equal(EXPECTED_ARRAY, reverseArray);
    }

    [Fact]
    public void Reverse_EmptyArray_ArrayInReverseOrder()
    {
      // Arrange
      int[] originalArray = { };
      int[] EXPECTED_ARRAY = { };

      // Act
      int[] reverseArray = Library.Reverse(originalArray);

      // Assert
      Assert.Equal(EXPECTED_ARRAY, reverseArray);
    }

    [Fact]
    public void Reverse_NullArray_ArrayInReverseOrder()
    {
      // Arrange
      int[] originalArray = null;
      int[] EXPECTED_ARRAY = { };

      // Act
      // Assert
      Assert.Throws<System.ArgumentException>(() => Library.Reverse(originalArray));
    }
  }
}