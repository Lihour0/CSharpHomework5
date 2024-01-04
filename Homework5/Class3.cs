namespace Homework5
{
    internal class Class3
    {
        double salary;

        private double CalculateTax(double salary)
        {
            if (salary <= 800000)
            {
                return 0;
            }
            else if (salary <= 12500000)
            {
                return salary * 0.05;
            }
            else if (salary <= 80000000)
            {
                return salary * 0.10;
            }
            else if (salary <= 125000000)
            {
                return salary * 0.15;
            }
            else
            {
                return salary * 0.20;
            }
        }
        public void input()
        {

            Console.Write("Enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine($"The tax for a salary of {salary} is {CalculateTax(salary)}");

        }

    }
}
