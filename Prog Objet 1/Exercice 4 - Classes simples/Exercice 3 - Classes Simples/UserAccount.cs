namespace Exercice_3___Classes_Simples
{
    //Class declaration
    public class UserAccount
    {
        private string m_userName;
        private string m_userPasswd;
        private int m_discriminator;
        private string m_userEmail;
        private bool m_isPremiumUser;

        //Constructor
        public UserAccount(string p_userName, string p_userPasswd, int p_discriminator, string p_userEmail, bool p_isPremiumUser)
        {
            this.UserName = p_userName;
            this.UserPasswd = p_userPasswd;
            this.Discriminator = p_discriminator;
            this.UserEmail = p_userEmail;
            this.IsPremiumUser = p_isPremiumUser;
        }

        //Access modifier
        public string UserName
        {
            get { return m_userName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    m_userName = value;
                }
                else
                {
                    throw new ArgumentException("UserAccount.UserName cannot be empty");
                }
            }
        }

        public string UserPasswd
        {
            get { return m_userPasswd;  }
            set {
                if (!String.IsNullOrEmpty(value))
                {
                    m_userPasswd = value;
                }
                else
                {
                    throw new ArgumentException("UserAccount.UserPasswd cannot be empty");
                }
            }
        }

        public int Discriminator
        {
            get { return m_discriminator; }
            set {
                if (value >= 0)
                {
                    m_discriminator = value;
                }
                else
                {
                    throw new ArgumentException("UserAccount.Discriminator value cannot be negative");
                }
            }
        }

        public string UserEmail
        {
            get { return m_userEmail; }
            set {
                if (!String.IsNullOrEmpty(value))
                {
                    m_userEmail = value;
                }
                else
                {
                    throw new ArgumentException("UserAccount.UserEmail cannot be empty");
                }
            }
        }

        public bool IsPremiumUser
        {
            get { return m_isPremiumUser; }
            set { m_isPremiumUser = value; }
        }
    }
}
