using DepartTP1;
using System;

namespace SolutionTP1
{
    class Program
    {
        public const int BINGO_CARD_SIZE = 5;
        public const int BINGO_CARD_CELL_ALIGNEMENT = 4;
        public const int MAX_NB_BINGO_CARDS = 5;
        public const long DRAWN_NUMBERS_SEED = 8473718269;
        
        public static void Main(string[] args)
        {
            BingoCard[] bingoCards = GenerateBingoCards();

            FindWinningBingoCard(bingoCards);
        }

        public static void MarkBingoCard(BingoCard[] bingoCards, int NextDrawnNumber)
        {
            for(int i = 0; i < bingoCards.Length; i++)
            {
                bingoCards[i].MarkNumber(NextDrawnNumber);
            }
        }

        public static void FindWinningBingoCard(BingoCard[] bingoCards)
        {
            int drawIndex = 0;
            bool winnerFound = false;
            int winningCardIndex = -1;
            int winningScore = 0;

            NumberGenerator DrawnNumber = GenerateDrawnNumber();

            do
            {
                int NextDrawnNumber = DrawnNumber.Next();

                MarkBingoCard(bingoCards, NextDrawnNumber);
                if (drawIndex == 0)
                {
                    Console.WriteLine("Draw:");
                }
                drawIndex++;
                DisplayDrawnNumbers(NextDrawnNumber, drawIndex);

                for (int i = 0; i < bingoCards.Length; i++)
                {
                    if (bingoCards[i].ComputeScore() > 0)
                    {
                        winningScore = bingoCards[i].ComputeScore();

                        Console.WriteLine("\n");
                        DisplayBingoCard(bingoCards[i]);

                        winningCardIndex = i;
                        winnerFound = true;
                        Console.WriteLine($"\nBingo card #{winningCardIndex + 1} wins!\nNumber of draw required {bingoCards[i].NbDrawnedNumbers}\nWinner score: {winningScore}");
                    }
                }

            } while (!winnerFound);
        }

        public static void DisplayDrawnNumbers(int NextDrawnNumber, int drawIndex)
        {
            Console.Write($"{NextDrawnNumber},");
        }

        public static BingoCard[] GenerateBingoCards()
        {
            BingoCard[] bingoCards = new BingoCard[MAX_NB_BINGO_CARDS];
            long NumberGeneratorSeed = 0L;

            for (int bingoCardIndex = 0; bingoCardIndex < MAX_NB_BINGO_CARDS; bingoCardIndex++)
            {
                bingoCards[bingoCardIndex] = new BingoCard(BINGO_CARD_SIZE, new NumberGenerator(NumberGeneratorSeed));
                
                NumberGeneratorSeed++;
                
                Console.Write($"\n BingoCard #{bingoCardIndex + 1}:\n\n");
                
                DisplayBingoCard(bingoCards[bingoCardIndex]);
                
            }
            Console.WriteLine();
            return bingoCards;
        }
        public static void DisplayBingoCard(BingoCard bingoCard)
        {
            for (int row = 0; row < BINGO_CARD_SIZE; row++) 
            {
                for (int col = 0; col < BINGO_CARD_SIZE; col++)
                {
                    Console.Write($"{bingoCard.CardCells[row, col].Value, BINGO_CARD_CELL_ALIGNEMENT}");
                    
                    if (bingoCard.CardCells[row, col].IsMarked)
                    {
                        Console.Write($"*");
                    }
                }
                Console.WriteLine();
            }
        }

        public static NumberGenerator GenerateDrawnNumber()
        {
            NumberGenerator DrawnNumber = new NumberGenerator(DRAWN_NUMBERS_SEED);
            
            return DrawnNumber;
        }
    }
}
