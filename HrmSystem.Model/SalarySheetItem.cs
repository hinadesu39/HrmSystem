using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem.Model
{
    public class SalarySheetItem
    {
        public Guid Id { get; set; }
        public Guid SheetId { get; set; }
        public Guid EmployeeId { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Fine { get; set; }
        public decimal Other { get; set; }
    }

}
