using System;
using System.Transactions;

namespace CalEmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number\n 1. Employe Present absent\t");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    EmployeeCheck.EmployeeAttendance();
                    break;
                default :
                    Console.WriteLine("Entered wrong number");
                    break;

            }
                
        }
    }
}