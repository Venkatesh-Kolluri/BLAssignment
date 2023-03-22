using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class PartTimeEmployee
    {
        public static void employeWage()
        {
            int WAGE_PER_HR = 20;
            int FULL_DAY_HR = 8;
            int PART_TIME_HR = 4;
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            Random random = new Random();

            int empCheck = random.Next(0, 4);

            if (empCheck == IS_FULL_TIME)
            {
                int Daily_Wage = WAGE_PER_HR * FULL_DAY_HR;
                Console.WriteLine("Employee is Present and employee's Daily Wage is " + Daily_Wage + " rupees");

            }
            else if (empCheck == IS_PART_TIME)
            {
                int Part_Time_Wage = WAGE_PER_HR * PART_TIME_HR;
                Console.WriteLine("Employee is present and employee's part time wage is " + Part_Time_Wage + " rupees");

            }
            else
            {
                Console.WriteLine("Employee is absent and employees's wage is 0 rupees");
            }
        }
    }
}
