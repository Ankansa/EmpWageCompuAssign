using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompuAssign
{
    internal class Max100HrsUc6
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Total_Working_Days = 20;
        public const int Max_Hours_In_Month = 100;
        public static void EmpMax100HrsWage()
        {
            int totalWorkingDays = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= Max_Hours_In_Month && totalWorkingDays < Total_Working_Days)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case Full_Time:
                        empHrs = 8;
                        break;

                    case Part_Time:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Days : {0} Emp Hours : {1}", totalWorkingDays, empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}
