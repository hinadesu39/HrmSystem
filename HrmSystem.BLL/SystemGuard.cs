using HrmSystem.DAL;
using HrmSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HrmSystem.BLL
{
    public class SystemGuard
    {
        public UserType checkUser(string un,string pwd)
        {
            OperatorService opServ = new OperatorService();
            Operator op = opServ.GetOperator(un);

            OperationLogServ logServ = new OperationLogServ();
            OperationLog log = new OperationLog();
            log.id = Guid.NewGuid();
            log.ActionDate = DateTime.Now;

            UserType ut;
            if(op == null||op.IsDeleted)
            {
                log.ActionDesc = "非法登陆，无效用户！！！";
                log.OperatorId = Guid.Empty;
                ut = UserType.noUser;
            }
            else if(op.Password != pwd)
            {
                log.ActionDesc = "非法登陆，密码错误！！！";
                log.OperatorId = op.Id;
                ut = UserType.passwordError;
            }
            else
            {
                LoginUser lu =  LoginUser.GetInstance();
                lu.InitMember(un);
                log.ActionDesc = "合法登陆，登陆成功！！！";
                log.OperatorId = op.Id;
                ut = UserType.validUser;
            }
            logServ.Add(log);
            return ut;
        }
        public enum UserType { validUser, passwordError, noUser}

    }

    
}
