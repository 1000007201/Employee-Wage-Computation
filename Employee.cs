using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Employee:IEmployee
    {
        const int PRESENT = 1, ABSENT = 0, PART_TIME = 2;
        int no_of_company;
        int index = 0;
        CompanyEmpWage[] companyEmpWageArray;

        public Employee(int no_of_company)
        {
            this.no_of_company = no_of_company;
            companyEmpWageArray = new CompanyEmpWage[no_of_company];
        }

        public void AddCompanyEmpWage(string company_name, int wage_per_hr, int max_wrk_days, int max_wrk_hr)
        {
            companyEmpWageArray[index] = new CompanyEmpWage(company_name, wage_per_hr, max_wrk_days, max_wrk_hr);
            index++;
        }
        public void CalculateWage()
        {
            for (int i = 0; i < no_of_company; i++)
            {
                companyEmpWageArray[i].SetTotalEmpwage(CalculateWage(companyEmpWageArray[i]));
                Console.WriteLine(companyEmpWageArray[i].ToString());
            }

        }

        public int CalculateWage(CompanyEmpWage companyEmpWage)
        {
            Random random = new Random();

            int workinghour = 0;
            int totalwage = 0;
            int totalworkinghour = 0;
            for (int day = 0; day < companyEmpWage.max_wrk_days && totalworkinghour < companyEmpWage.max_wrk_hr; day++)
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
                int wage = workinghour * companyEmpWage.wage_per_hr;
                totalwage += wage;
                totalworkinghour += workinghour;
            }
            return totalwage;

        }
    }
}
