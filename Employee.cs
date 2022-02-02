using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Employee
    {
        public void CalculateWage(string company_name,int wage_per_hr,int max_wrk_days,int max_wrk_hr)
        {
            Random random = new Random();
            const int PRESENT = 1, ABSENT = 0,PART_TIME = 2;
            int workinghour = 0;
            int totalwage = 0;
            int totalworkinghour = 0;
            Console.WriteLine("{0} {1} {2} {3} {4}","Company Name", "DAY", "WORKING_HOUR", "WAGE", "TOTAL_WRK_HR");
            for (int day = 0; day < max_wrk_days && totalworkinghour < max_wrk_hr; day++)
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
                int wage = workinghour * wage_per_hr;
                totalwage += wage;
                totalworkinghour += workinghour;
                Console.WriteLine("{0} {1} {2} {3} {4}",company_name,day,workinghour,wage,totalworkinghour);
            }
            Console.WriteLine("Employee Monthly wage is {0}", totalwage);

        }
    }
}
