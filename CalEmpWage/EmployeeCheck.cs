using System;

namespace CalEmpWage
{
    internal class EmployeeCheck
    {
        public static void EmployeeAttendance()
        {
            Random random = new Random();
            int empCheck=random.Next(0,2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is prsent");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
