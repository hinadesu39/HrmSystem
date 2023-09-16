using HrmSystem.DAL;
using HrmSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem.BLL
{
    public class LoginUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsLocked { get; set; }
        private static LoginUser lu = null;

        private LoginUser()
        { } 

        public static LoginUser GetInstance()
        {
            if (lu == null)
            {
                lu = new LoginUser();
            }
            return lu;
        }

        public void InitMember(string un)
        {
            OperatorService opServ = new OperatorService();
            Operator op = opServ.GetOperator(un);
            if (op != null)
            {
                Id = op.Id;
                UserName = un;
                Password = op.Password;
                RealName = op.RealName;
                IsAdmin = op.IsAdmin;
                IsLocked = op.IsLocked;
            }
        }
    }
}
