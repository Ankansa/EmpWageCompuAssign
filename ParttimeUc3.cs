﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompuAssign
{
    internal class ParttimeUc3
    {
        public static void Wage()
        {
            int Full_Time = 1;
            int Part_Time = 2;
            int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random obj = new Random();
            int num = obj.Next(0, 3);
            if (num == Full_Time)
            {
                empHrs = 8;
            }
            else if (num == Part_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee wage : " + empWage);
        }
    }
}
