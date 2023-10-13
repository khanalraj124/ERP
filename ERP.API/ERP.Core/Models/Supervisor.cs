using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Infra.Data
{
    public class Supervisor
    {
        public int SupervisorID { get; set; }
        public int WorkerID { get; set; }
        public decimal AnnualSalary { get; set; }
    }
}
