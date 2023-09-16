using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem.Model
{
    public class SalarySheet
    {
        public Guid Id { set; get; }
        public int Year { set; get; }
        public int Month { set; get; }
        public Guid DepartmentId { set; get; }
    }
}
