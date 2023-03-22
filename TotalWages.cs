using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class TotalWages
    {
        public static void employeeWages()
        {
            int WAGE_PER_HR = 20;

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int TOTAL_WORKING_DAY = 20;
            int TOTAL_WORKING_HRS = 100;

            int emphrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalWorkingDays < TOTAL_WORKING_DAY && totalEmpHrs <= TOTAL_WORKING_HRS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                if (empCheck == IS_FULL_TIME)
                {
                    emphrs = 8;
                    totalEmpHrs += emphrs;

                }
                else if (empCheck == IS_PART_TIME)
                {
                    emphrs = 4;
                    totalEmpHrs += emphrs;

                }
                else
                {
                    emphrs = 0;
                    totalEmpHrs += emphrs;

                }



            }
            int totalEmpWage = totalEmpHrs * WAGE_PER_HR;
            Console.WriteLine("Day:" + totalWorkingDays + " Emp hrs: " + totalEmpHrs);

            Console.WriteLine("Total Emp Wage: " + totalEmpWage);


        }
    }
}
