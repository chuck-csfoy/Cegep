namespace Exercice_3___Classes_Simples
{
    public class IntSequence
    {
        //Class declaration

        private int m_currentNumber;

        //Constructor
        public IntSequence(int p_currentNumber)
        {
            this.CurrentNumber = p_currentNumber;
        }
        //Access modifier
        public int CurrentNumber
        {
            get { return m_currentNumber; }
            private set
            {
                if (value >= 0)
                {
                    m_currentNumber = value;
                }
                else
                {
                    throw new ArgumentException("IntSequence.CurrentNumber value cannot be negative");
                }
            }
        }

        public int Next()
        {
            return this.m_currentNumber++;
        }
    }
}
