using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCompuAssign
{
    internal class AttendanceUc1
    {
        public static void Attendance()
        {
            int Full_Time = 1;
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
