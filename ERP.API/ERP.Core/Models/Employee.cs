using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Infra.Data
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int WorkerID { get; set; }
        public decimal PayPerHour { get; set; }
    }
}
