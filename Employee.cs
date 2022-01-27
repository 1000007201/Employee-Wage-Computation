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
            const int PRESENT = 1, ABSENT = 0, WAGE_PER_HR = 20, PART_TIME = 2;
            int workinghour = 0;
            int empstatus = random.Next(3);
            switch (empstatus)
            {
                case PRESENT:
                    Console.WriteLine("Employee is Present");
                    workinghour = 12;
                    break;
                case ABSENT:
                    Console.WriteLine("Employee is present");
                    break;
                case PART_TIME:
                    Console.WriteLine("Employee is present part time");
                    workinghour = 8;
                    break;
            }
            int wage = workinghour * WAGE_PER_HR;
            Console.WriteLine("Employee daily wage is {0}", wage);

        }
    }
}
