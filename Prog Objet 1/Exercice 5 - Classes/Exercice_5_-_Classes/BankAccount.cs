namespace Exercice_5___Classes
{
    public class BankAccount
    {
        const int CREDIT_LIMIT = 5000;

        //Class declaration

        private string m_clientName;
        private float m_balance;
        private float m_lineOfCredit;

        //Constructor
        public BankAccount(string p_clientName, float p_balance, float p_lineOfCredit)
        {
            this.ClientName = p_clientName;
            this.Balance = p_balance;
            this.LineOfCredit = p_lineOfCredit;
        }

        public BankAccount(string p_clientName)
        {
            this.ClientName = p_clientName;
            this.Balance = 0;
            this.LineOfCredit = 0;
        }


        //Access Modifier
        public string ClientName
        {
            get { return m_clientName; }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    m_clientName = value;
                }
                else
                {
                    throw new ArgumentException("BankAccount.ClientName cannot be empty");
                }
            }
        }

        public float Balance
        {
            get { return m_balance; }
            set {
                    m_balance = value;
            }
        }

        public float LineOfCredit
        {
            get { return m_lineOfCredit; }
            set {
                if (value > CREDIT_LIMIT)
                {
                    throw new ArgumentException("Line of credit cannot exceed the allowed limit.");
                }
                m_lineOfCredit = value;
            }
        }

        public void Deposit(float amountToDeposit)
        {
            if (amountToDeposit <= 0)
            {
                throw new ArgumentException("Deposit amount must be a positive number.");
            }

            if (LineOfCredit > 0)
            {
                LineOfCredit = LineOfCredit - amountToDeposit;
            }

            if (LineOfCredit < 0)
            {
                Balance = Balance + (LineOfCredit * -1);
                LineOfCredit = 0;
            }

            else
            {
                Balance += amountToDeposit;
            }
        }

        public void Withdraw(float amountToWithdraw)
        {
            if (amountToWithdraw <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be a positive number.");
            }

            if (amountToWithdraw <= Balance)
            {
                Balance -= amountToWithdraw;
            }

            if (amountToWithdraw > Balance)
            {   
                if (Balance < 0)
                {
                    LineOfCredit = LineOfCredit + (Balance * -1);
                }

                if (LineOfCredit <= CREDIT_LIMIT)
                {
                    LineOfCredit = LineOfCredit + amountToWithdraw;
                }

                else
                {
                    throw new ArgumentException("Insufficient funds.");
                }
            }
        }

        public override string ToString()
        {
            return $"New BankAccount: \n Client Name: {ClientName} \n Balance: {Balance}$ \n Line Of Credit: {LineOfCredit}$ \n";
        }
    }
}
