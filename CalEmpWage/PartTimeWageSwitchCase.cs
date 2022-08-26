using System;


namespace CalEmpWage
{
    internal class PartTimeWageSwitchCase
    {
        public static void CalculatePartTimeWages()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck=random.Next(1,3);
            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present for full time");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present for part time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee daily wage including the part time is " + empWage);
        }
    }
}
