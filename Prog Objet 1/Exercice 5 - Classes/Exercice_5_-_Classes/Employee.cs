namespace Exercice_5___Classes
{
    public class Employee
    {
        const float OCCASIONAL_RAISE = 0.32f;
        const float CONTRACTUAL_RAISE = 0.08f;

        //Class declaration
        private string m_employeeFullName;
        private int m_employeeBaseSalary;

        private EmployeeStatus m_employeeStatus;

        //Constructor
        public Employee (string p_employeeFullName, int p_employeeBaseSalary, EmployeeStatus p_employeeStatus)
        {
            this.EmployeeFullName = p_employeeFullName;
            this.EmployeeBaseSalary = p_employeeBaseSalary;

            this.EmployeeStatus = p_employeeStatus;
        }

        //Access Modifier
        public string EmployeeFullName
        {
            get { return m_employeeFullName; }
            private set { 
                    if (!string.IsNullOrEmpty(value))
                    {
                        m_employeeFullName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Employee.EmployeeFullName cannot be empty");
                    }
            }
        }

        public int EmployeeBaseSalary
        {
            get { return m_employeeBaseSalary; }
            private set {
                    if (value >= 0)
                    {
                        m_employeeBaseSalary = value;
                    }
                    else
                    {
                        throw new ArgumentException("Employee.EmployeeBaseSalary value cannot be negative");
                    }
            }
        }
        public EmployeeStatus EmployeeStatus
        {
            get { return m_employeeStatus; }
            set{
                m_employeeStatus = value;
            }
        }

        public float CalculateSalaryRaise(float percentageRaise)
        {
            float raisedSalary = EmployeeBaseSalary * (1 + percentageRaise);
            return raisedSalary;
        }

        public float CalculateRealSalary()
        {
            float realSalary = 0f;
            
            if (EmployeeStatus == EmployeeStatus.Occasional)
            {
                realSalary = CalculateSalaryRaise(OCCASIONAL_RAISE);
            }
            else if (EmployeeStatus == EmployeeStatus.Contractual)
            {
                realSalary = CalculateSalaryRaise(CONTRACTUAL_RAISE);
            }
            else
            {
                realSalary = EmployeeBaseSalary;
            }

            return realSalary;
        }

    }
}
