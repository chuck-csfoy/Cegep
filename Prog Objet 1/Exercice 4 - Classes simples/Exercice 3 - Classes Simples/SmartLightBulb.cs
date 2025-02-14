namespace Exercice_3___Classes_Simples
{
    public class SmartLightBulb
    {
        //Class declaration
        private int m_lightBulbPower;
        private int m_lightBulbLuminosity;

        //Constructor
        public SmartLightBulb(int p_lightBulbPower, int p_lightBulbLuminosity)
        {
            this.m_lightBulbPower = p_lightBulbPower;
            this.LightBulbLuminosity = p_lightBulbLuminosity;
        }
        //Access modifier
        public int LightBulbPower
        {
            get { return m_lightBulbPower; }
           
        }

        public int LightBulbLuminosity
        {
            get { return m_lightBulbLuminosity; }
            set {
                if (value >= 0 && value <= 100)
                {
                    m_lightBulbLuminosity = value;
                }
                else
                {
                    throw new ArgumentException("SmartLightBulb.LightBulbLuminosity value cannot be outside of range");
                }
            }
        }
    }
}
