using DepartTP1;
using SolutionTP1;
using Xunit;
using System;


namespace TP1Tests
{
    public class CardCellTests
    {

        [Fact]
        public void Constructor_ValueNegative_ValueShouldInitializePropertyCorrectlyAtDefaultValue_ExpectedValue()
        {
            // Arrange

            const int EXPECTED_VALUE = 0;

            // Act

            CardCell newCardCell = new CardCell(-1);

            // Assert

            Assert.Equal(EXPECTED_VALUE, newCardCell.Value);
        }

        [Fact]
        public void Constructor_ValuesNotEqual_ValueShouldNotInitializePropertiesCorrectly_ExpectedValue()
        {
            // Arrange
            
            const int EXPECTED_VALUE = 5;
            
            // Act

            CardCell newCardCell = new CardCell(EXPECTED_VALUE);

            // Assert

            Assert.False(EXPECTED_VALUE + 1 == newCardCell.Value);
        }

        [Fact]
        public void Constructor_ValueZero_ValueShouldInitializePropertiesCorrectly_ExpectedValue()
        {
            // Arrange & Act

            CardCell newCardCell = new CardCell(0);

            // Assert

            Assert.Equal(0, newCardCell.Value);
        }

        [Fact]
        public void Constructor_Value999_ValueShouldInitializePropertiesCorrectly_ExpectedValue()
        {
            // Arrange
            const int EXPECTED_VALUE = 999;
            
            // Act

            CardCell newCardCell = new CardCell(EXPECTED_VALUE);

            // Assert

            Assert.Equal(EXPECTED_VALUE, newCardCell.Value);
        }

        [Fact]
        public void MarkCell_ValueZeroAndNumberDrawnZero_ShouldChangeIsMarkedValueToTrue()
        {
            // Arrange

            const int NUMBER_DRAWN = 0;
            CardCell newCardCell = new CardCell(NUMBER_DRAWN);

            // Act
            
            newCardCell.MarkCell(NUMBER_DRAWN);

            // Assert

            Assert.True(newCardCell.IsMarked);
        }

        [Fact]
        public void MarkCell_ValueZeroAndNumberDrawn999_ShouldChangeIsMarkedValueToFalse()
        {
            // Arrange

            const int NUMBER_DRAWN = 999;
            CardCell newCardCell = new CardCell(0);

            // Act

            newCardCell.MarkCell(NUMBER_DRAWN);

            // Assert

            Assert.False(newCardCell.IsMarked);
        }
    }
}
