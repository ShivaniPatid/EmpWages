using System;

namespace CalEmpWage
{
    internal class DailyWage
    {
        public static void CalculateDailyWage()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck=random.Next(0,2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is "+empWage);
        }
    }
}
