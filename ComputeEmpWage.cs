using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWages
{
    internal class ComputeEmpWage
    {

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        public static void employeeWages(String Company, int WAGE_PER_HR, int TOTAL_WORKING_HRS, int TOTAL_WORKING_DAY)
        {
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
                totalEmpWage += employeeWages;
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + ",EmpWage " + employeeWages + ",EmpHrs " + totalEmpHrs);

            }

            Console.WriteLine("Total Emp Wage for the company " + Company + " is: " + totalEmpWage + " Total EmpHrs " + totalEmpHrs);
        }

     /*   public static void Main(String[] args)
        {
            employeeWages("Dell", 30, 100, 22);
            employeeWages("Lenovo", 40, 110, 20);
        }
     */


    }
}
