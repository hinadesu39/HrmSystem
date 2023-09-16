using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem.Model
{
    public class LogSearchWhere
    {
        public Guid Name { set; get; }
        public string Key { set; get; }
        public bool IsDateExit { set; get; }
        public DateTime Begin { set; get; }
        public DateTime End { set; get; }
    }
}
