namespace Exercice_6
{
    public class Car
    {
        const double STOP_SPEED = 5;
        const double MAX_SPEED = 230;
        const double MIN_SPEED = 0;
        //Class declaration

        private string m_brand;
        private string m_model;
        private double m_speed;
        private bool m_isIgnited;

        //Constructor
        
        public Car(string p_brand, string p_model)
        {
            this.Brand = p_brand;
            this.Model = p_model;
            this.Speed = 0;
            this.IsIgnited = false;
        }

        //Access Modifier

        public string Brand
        {
            get { return m_brand; }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    m_brand = value;
                }
                else
                {
                    throw new ArgumentException("Car.Brand cannot be empty");
                }
            }
        }

        public string Model
        {
            get { return m_model; }
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    m_model = value;
                }
                else
                {
                    throw new ArgumentException("Car.Model cannot be empty");
                }
            }
        }

        public double Speed
        {
            get { return m_speed; }
            private set {
                if (value >= MAX_SPEED)
                {
                    m_speed = MAX_SPEED;
                }
                else if (value <= MIN_SPEED)
                {
                    m_speed = MIN_SPEED;
                }
                else
                {
                    m_speed = value;
                }
                // check docu math.clamp
            }
        }

        public bool IsIgnited
        {
            get { return m_isIgnited; }
            private set {
                m_isIgnited = value;
            }
        }

        public void StartCar()
        {
            IsIgnited = true;
        }

        public void StopCar()
        {
            if (Speed < STOP_SPEED)
            {
                Speed = 0;
                IsIgnited = false;
            }
            
        }

        public void Accelerate (double speedGained)
        {
            if (IsIgnited == true && speedGained > 0)
            {
                Speed += speedGained;
            }
        }
        public void Decelerate (double speedLost)
        {
            if (IsIgnited == true && speedLost > 0)
            {
                Speed -= speedLost;
            }
        }

        public override string ToString()
        {
            return $"Car brand: {Brand} \n Car model: {Model} \n Car speed {Speed} \n Car is running : {IsIgnited}\n";
        }
    }
}
