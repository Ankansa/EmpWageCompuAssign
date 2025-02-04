﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompuAssign
{
    internal class Working20DaysUc5
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Total_Working_Days = 20;
        public static void Emp20DaysWage()
        {
            int totalEmpWage = 0;
            int empHrs = 0;
            int empWage = 0;

            for (int day = 0; day < Total_Working_Days; day++)
            {
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
                totalEmpWage += empWage;
                Console.WriteLine("Employee wage : " + empWage);
            }

            Console.WriteLine("Total Employee Wage for 20 days in month : " + totalEmpWage);
        }
    }
}

