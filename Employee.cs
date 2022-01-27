using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Employee
    {
        public void CalculateWage()
        {
            Random random = new Random();
            const int PRESENT = 1, ABSENT = 0, WAGE_PER_HR = 20, PART_TIME = 2, WORKING_DAYS = 20, MAX_WRK_HR = 100;
            int workinghour = 0;
            int totalwage = 0;
            int totalworkinghour = 0;
            Console.WriteLine("{0} {1} {2} {3}", "DAY", "WORKING_HOUR", "WAGE", "TOTAL_WRK_HR");
            for (int day = 0; day < WORKING_DAYS && totalworkinghour < MAX_WRK_HR; day++)
            {
                int empstatus = random.Next(3);
                switch (empstatus)
                {
                    case ABSENT:
                        workinghour = 0;
                        break;
                    case PRESENT:
                        workinghour = 12;
                        break;

                    case PART_TIME:
                        workinghour = 8;
                        break;
                }
                int wage = workinghour * WAGE_PER_HR;
                totalwage += wage;
                totalworkinghour += workinghour;
                Console.WriteLine("{0} {1} {2} {3}",day,workinghour,wage,totalworkinghour);
            }
            Console.WriteLine("Employee Monthly wage is {0}", totalwage);

        }
    }
}
