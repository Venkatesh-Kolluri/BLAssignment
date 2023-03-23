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
            int IS_FULL_TIME = 1;
            int emphr = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                emphr = 8;

            }
            else
            {
                emphr = 0;
            }

            int Daily_Wage = WAGE_PER_HR * emphr;
            Console.WriteLine("Employee Daily Wage is " + Daily_Wage + " rupees");


        }


    }
}
