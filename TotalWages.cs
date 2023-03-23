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

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int TOTAL_WORKING_DAY = 20;
            const int TOTAL_WORKING_HRS = 100;

            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int employeeWages = 0;
            int totalEmpWage = 0;

            while (totalWorkingDays < TOTAL_WORKING_DAY && totalEmpHrs <= TOTAL_WORKING_HRS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                employeeWages = empHrs * WAGE_PER_HR;
                Console.WriteLine("Day:" + employeeWages);
                totalEmpWage += employeeWages;

            }
           
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);

        }
    }
}
