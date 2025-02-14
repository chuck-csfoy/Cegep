using SolutionTP1;

namespace DepartTP1
{

    public class BingoCard
    {
        public const int NB_LINES = 5;
        //Class declaration

        private CardCell[,] m_cardCells;
        private int m_nbDrawnedNumbers;

        //Constructor

        public BingoCard(int p_nbLines, NumberGenerator p_generator)
        {
            m_nbDrawnedNumbers = 0;
            m_cardCells = new CardCell[p_nbLines, p_nbLines];

            for (int row = 0; row < p_nbLines; row++)
            {
                for (int col = 0; col < p_nbLines; col++)
                {
                    m_cardCells[row, col] = new CardCell(p_generator.Next());
                }
            }
        }

        //Access Modifier

        public CardCell[,] CardCells
        {
            get { return m_cardCells; }
            private set { m_cardCells = value; }
        }

        public int NbDrawnedNumbers
        {
            get { return m_nbDrawnedNumbers; }
            private set { m_nbDrawnedNumbers = value; }
        }

        public void MarkNumber(int value)
        {
            if (value < 0)
            {
                return;
            }
            
            m_nbDrawnedNumbers++;
            
            for (int row = 0; row < CardCells.GetLength(0); row++)
            {
                for (int col = 0; col < CardCells.GetLength(1); col++)
                {
                    //if (CardCells[row, col].Value == value)
                    {
                        CardCells[row, col].MarkCell(value);

                    }
                }
            }
        }

        public int ComputeScore()
        {
            int totalScore = 0;

            for (int i = 0; i < CardCells.GetLength(0); i++)
            {
                if (ValidateFullRow(i))
                {
                    totalScore += GetFullRowScore(i);
                }

                if (ValidateFullCol(i))
                {
                    totalScore +=  GetFullColScore(i);
                }
            }

            return totalScore;
        }
        private bool ValidateFullRow(int col)
        {
            for (int row = 0; row < CardCells.GetLength(1); row++)
            {
                if (!CardCells[row, col].IsMarked)
                {
                    return false;
                }
            }

            return true;
        }
        private int GetFullRowScore(int col)
        {
            int rowScore = 0;
            for (int row = 0; row < CardCells.GetLength(1); row++)
            {
                if (!CardCells[row, col].IsMarked)
                {
                    rowScore = 0;
                    break;
                }

                else
                {
                    rowScore += CardCells[row, col].Value;
                }
            }

            return rowScore;
        }

        private bool ValidateFullCol(int row)
        {
            for (int col = 0; col < CardCells.GetLength(0); col++)
            {
                if (!CardCells[row, col].IsMarked)
                {
                    return false;
                }
            }

            return true;
        }

        private int GetFullColScore(int row)
        {
            int colScore = 0;

            for (int col = 0; col < CardCells.GetLength(0); col++)
            {
                if (!CardCells[row, col].IsMarked)
                {
                    colScore = 0;
                    break;
                }

                else
                {
                    colScore += CardCells[row, col].Value;
                }
            }

            return colScore;
        }
    }
}
