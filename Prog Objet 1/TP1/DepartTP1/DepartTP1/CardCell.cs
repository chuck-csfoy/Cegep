using SolutionTP1;

namespace DepartTP1
{
    public class CardCell
    {
        //Class declaration

        private int m_value = 0;
        private bool m_isMarked = false;

        //Constructor
        public CardCell(int p_value)
        {
            this.Value = p_value;
            this.IsMarked = false;
        }

        //Access Modifier

        public int Value
        {
            get { return m_value; }
            private set {
                if (value > 0)
                {
                    m_value = value;
                }
            }
        }

        public bool IsMarked
        {
            get { return m_isMarked; }
            private set { m_isMarked = value; }
        }

        public void MarkCell(int numberDrawn)
        {
            if (numberDrawn == Value)
            {
                IsMarked = true;
            }
        }
    }
}
