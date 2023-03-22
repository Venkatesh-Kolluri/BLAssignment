using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class DailyEmployeeWage
    {
        public static void getEmployeeWage()
        {
            int WAGE_PER_HR = 20;
            int FULL_DAY_HR = 8;
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                int Daily_Wage = WAGE_PER_HR * FULL_DAY_HR;
                Console.WriteLine("Employee is Present and his Daily Wage is " + Daily_Wage + " rupees");

            }
            else
            {
                Console.WriteLine("Employee is absent and his Daily Wage is 0 rupees");
            }


        }


    }
}
