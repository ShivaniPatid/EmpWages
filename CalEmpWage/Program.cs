using System;
using System.Transactions;

namespace CalEmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number\n 1. Employe Present absent\t 2. Employee daily wage\t 3. Part time wage\n 4. Part time wage using switch case\t 5. Calculate wage for month\t 6. Calculate wage for month using while loop");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    EmployeeCheck.EmployeeAttendance();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    PartTimeWage.CalculatePartTimeWage();
                    break;
                case 4:
                    PartTimeWageSwitchCase.CalculatePartTimeWages();
                    break;
                case 5:
                    WageForMonth.CalculateWageForMonth();
                    break;
                case 6:
                    WageForMonthWhileLoop.CalculateWage();
                    break;
                default :
                    Console.WriteLine("Entered wrong number");
                    break;

            }
                
        }
    }
}