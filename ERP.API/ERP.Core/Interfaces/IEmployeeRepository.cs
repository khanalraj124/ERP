using ERP.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Core.Interfaces
{
    public  interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee AddNewEmployee(Employee newEmployee);
    }
}
