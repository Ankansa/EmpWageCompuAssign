using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompuAssign
{
    internal class SwitchWageUc4
    {

        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public static void EmpWage()
        {
            int empHrs = 0;
            int empWage = 0;

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

            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee wage : " + empWage);
        }

    }
}
