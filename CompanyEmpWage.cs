using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        public string company_name;
        public int wage_per_hr;
        public int max_wrk_days;
        public int max_wrk_hr;
        public int totalEmpwage;

        public CompanyEmpWage(string company_name,int wage_per_hr,int max_wrk_days,int max_wrk_hr)
        {
            this.company_name = company_name;
            this.wage_per_hr = wage_per_hr;
            this.max_wrk_days = max_wrk_days;
            this.max_wrk_hr = max_wrk_hr;
        }
        public void SetTotalEmpwage(int totalEmpwage)
        {
            this.totalEmpwage = totalEmpwage;   
        }
        public string ToString()
        {
            return $"Total Employee Wage of {this.company_name} is {this.totalEmpwage}";
        }
    }
}
