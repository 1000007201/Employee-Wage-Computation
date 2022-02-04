using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Employee
    {
        const int PRESENT = 1, ABSENT = 0, PART_TIME = 2;
        string company_name;
        int wage_per_hr;
        int max_wrk_days;
        int max_wrk_hr;
        public Employee(string company_name, int wage_per_hr, int max_wrk_days, int max_wrk_hr)
        {
            this.company_name = company_name;
            this.wage_per_hr = wage_per_hr;
            this.max_wrk_days = max_wrk_days;
            this.max_wrk_hr = max_wrk_hr;
        }
        public void CalculateWage()
        {
            Random random = new Random();
            
            int workinghour = 0;
            int totalwage = 0;
            int totalworkinghour = 0;
            Console.WriteLine("{0} {1} {2} {3} {4}","Company Name", "DAY", "WORKING_HOUR", "WAGE", "TOTAL_WRK_HR");
            for (int day = 0; day < this.max_wrk_days && totalworkinghour < this.max_wrk_hr; day++)
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
                int wage = workinghour * this.wage_per_hr;
                totalwage += wage;
                totalworkinghour += workinghour;
                Console.WriteLine("{0} {1} {2} {3} {4}",this.company_name,day,workinghour,wage,totalworkinghour);
            }
            Console.WriteLine($"Total Employee wage for {this.company_name} is  {totalwage}");

        }
    }
}
