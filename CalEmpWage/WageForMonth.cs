using System;


namespace CalEmpWage
{
    internal class WageForMonth
    {
        public static void CalculateWageForMonth()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            const int EMP_RATE_PER_HOUR = 20;
            for(int day = 1; day <= 20; day++)
            {
                Random random = new Random();
                int empCheck=random.Next(1,3);
                switch (empCheck)
                {
                    case 1:
                        empHrs=8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("daily employee wage is {0} total employee wage {1}",empWage,totalEmpWage);
            }
            Console.WriteLine("Total employee wage is "+totalEmpWage);
        }
    }
}
