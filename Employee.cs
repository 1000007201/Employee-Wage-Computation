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
            const int PRESENT = 1, ABSENT = 0, WAGE_PER_HR = 20, PART_TIME = 2, WORKING_DAYS = 20;
            int workinghour = 0;
            int totalwage = 0;
            for (int i = 0; i < WORKING_DAYS; i++)
            {
                int empstatus = random.Next(3);
                switch (empstatus)
                {
                    case ABSENT:
                        Console.WriteLine("Employee is Absent");
                        break;
                    case PRESENT:
                        Console.WriteLine("Employee is Present");
                        workinghour = 12;
                        break;

                    case PART_TIME:
                        Console.WriteLine("Employee is present part time");
                        workinghour = 8;
                        break;
                }
                int wage = workinghour * WAGE_PER_HR;
                totalwage += wage;
            }
            Console.WriteLine("Employee Monthly wage is {0}", totalwage);

        }
    }
}
