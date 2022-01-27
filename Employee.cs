using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Employee
    {
        public void Attendence()
        {
            Random random = new Random();
            const int PRESENT = 1, ABSENT = 0;
            if (random.Next(2) == PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            if (random.Next(2) == ABSENT)
            {
                Console.WriteLine("Employee is present");
            }

        }
    }
}
