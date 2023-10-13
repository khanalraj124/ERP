using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Infra.Data
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public int WorkerID { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal MaxExpenseAmount { get; set; }
    }
}
