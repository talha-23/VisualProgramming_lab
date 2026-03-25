namespace LAB_7.Components
{
    public class SalaryService
    {
        public double gettax(double salary)
        { return salary * 0.1;       }

        public double getinsurance(double salary)
        {    return salary * 0.05;   }

        public double getbonus(double salary)
        { return salary * 0.2; }

        public double getnetsalary(double salary)
        {
            var tax = gettax(salary);
            var insurance = getinsurance(salary);
            var bonus = getbonus(salary);
            return salary - tax - insurance + bonus;
        }
    }
}
