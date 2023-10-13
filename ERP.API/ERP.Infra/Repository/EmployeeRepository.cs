using ERP.Core.Interfaces;
using ERP.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Infra.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee AddNewEmployee(Employee newEmployee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
