using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IEmployee
    {
        public void AddCompanyEmpWage(string company_name, int wage_per_hr, int max_wrk_days, int max_wrk_hr);
        public void CalculateWage();
    }
}
