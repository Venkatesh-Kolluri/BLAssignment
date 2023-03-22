using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class UsingSwitchCase
    {
        public static void switchCase()
        {
            int WAGE_PER_HR = 20;
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 2);

            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
