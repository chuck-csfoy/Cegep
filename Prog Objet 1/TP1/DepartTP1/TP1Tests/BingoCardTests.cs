using DepartTP1;
using SolutionTP1;
using System;
using Xunit;

namespace TP1Tests
{
    public class BingoCardTests
    {

        [Fact]
        public void ComputeScore_EmptyCard_ReturnsZero()
        {
            // Arrange

            const int NB_LINES = 5;
            const int EXPECTED_VALUE = 0;
            NumberGenerator newGenerator = new NumberGenerator();
            BingoCard newBingoCard = new BingoCard(NB_LINES, newGenerator);

            // Act

            int score = newBingoCard.ComputeScore();

            // Assert

            Assert.Equal(EXPECTED_VALUE, score);

        }

        [Fact]
        public void ComputeScore_NegativeNumber_ShouldNotMarkAnyCell()
        {
            // Arrange

            const int NB_LINES = 5;
            const int NB_NEGATIVE = -5;
            NumberGenerator newGenerator = new NumberGenerator();
            BingoCard newBingoCard = new BingoCard(NB_LINES, newGenerator);
            bool initialCellMarkedState = newBingoCard.CardCells[0, 0].IsMarked;

            // Act

            newBingoCard.MarkNumber(NB_NEGATIVE);

            // Assert

            Assert.Equal(initialCellMarkedState, newBingoCard.CardCells[0,0].IsMarked);
        }

        [Fact]
        public void ComputeScore_ValidDifferentSizeBingoCardWithoutFullRowOrCol_ShouldReturnCorrectScore()
        {
            // Arrange

            const int NB_LINES = 10;
            const int NO_SCORE = 0;
            NumberGenerator newGenerator = new NumberGenerator();
            BingoCard newBingoCard = new BingoCard(NB_LINES, newGenerator);

            newBingoCard.MarkNumber(newBingoCard.CardCells[0, 0].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[5, 1].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[3, 2].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[1, 3].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[1, 4].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[2, 5].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[4, 6].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[7, 7].Value);
            newBingoCard.MarkNumber(newBingoCard.CardCells[0, 9].Value);
            

            // Act
            int expectedScore = newBingoCard.ComputeScore();

            // Assert
            Assert.Equal(expectedScore, NO_SCORE);
        }

        [Fact]
        public void ComputeScore_FullRowMarked_ReturnsCorrectRowScore()
        {
            // Arrange

            const int NB_LINES = 5;
            BingoCard newBingoCard = new BingoCard(NB_LINES, new NumberGenerator());

            for (int col = 0; col < NB_LINES; col++)
            {
                newBingoCard.MarkNumber(newBingoCard.CardCells[0, col].Value);
            }

            // Act

            int score = newBingoCard.ComputeScore();
            int expectedScore = 0;

            for (int col = 0; col < NB_LINES; col++)
            {
                expectedScore += newBingoCard.CardCells[0, col].Value;
            }

            // Assert

            Assert.Equal(expectedScore, score);
        }

        [Fact]
        public void ComputeScore_FullColMarked_ReturnsCorrectColScore()
        {
            // Arrange

            const int NB_LINES = 5;
            BingoCard newBingoCard = new BingoCard(NB_LINES, new NumberGenerator());

            // Act

            for (int row = 0; row < NB_LINES; row++)
            {
                newBingoCard.MarkNumber(newBingoCard.CardCells[row, 0].Value);
            }

            int score = newBingoCard.ComputeScore();
            int expectedScore = 0;

            for (int row = 0; row < NB_LINES; row++)
            {
                expectedScore += newBingoCard.CardCells[row, 0].Value;
            }

            // Assert

            Assert.Equal(expectedScore, score);
        }

        [Fact]
        public void ComputeScore_OneFullRowAndColumn_ReturnsCorrectScore()
        {
            // Arrange

            const int NB_LINES = 5;
            BingoCard newBingoCard = new BingoCard(NB_LINES, new NumberGenerator());

            // Act

            for (int col = 0; col < BingoCard.NB_LINES; col++)
            {
                newBingoCard.MarkNumber(newBingoCard.CardCells[0, col].Value);
            }
            
            for (int row = 0; row < BingoCard.NB_LINES; row++)
            {
                newBingoCard.MarkNumber(newBingoCard.CardCells[row, 0].Value);
            }

            int score = newBingoCard.ComputeScore();
            int expectedScore = 0;

            for (int col = 0; col < BingoCard.NB_LINES; col++)
            {
                expectedScore += newBingoCard.CardCells[0, col].Value;
            }

            for (int row = 0; row < BingoCard.NB_LINES; row++)
            {
                expectedScore += newBingoCard.CardCells[row, 0].Value;
            }

            // Assert

            Assert.Equal(expectedScore, score);
        }

    }
}