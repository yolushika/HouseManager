using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.Models;
using 房屋租赁系统.DAL;

namespace 房屋租赁系统.BLL
{
    public class UserManager
    {
        public List<User> GetAllUsers()
        { 
            return new UserService().GetAllUsers();
        }
        //通过GetUser方法获得UserService类GetUser方法，获取满足条件的数据
        public List<User> GetUsers(string condition = "", string value = "")
        {
            return new UserService().GetUsers(condition, value);
        }
        public List<User> GetList(string condition = "", string find = "", bool uPwv = false)
        {
            switch (condition) 
            {
                case "用户名":
                    condition = "uName";
                    break;                
                case "用户权限":
                    condition = "uPvw";
                    break;
                default:
                    condition = "";
                    break;
            }
            return new UserService().Get(condition,find,uPwv);
        }
        //————新建用户————        
        public bool IsUexist(string uName)
        {
            return new zhuceService().isUexist(uName);
        }
        public bool New_user(string uName, string uPwd, string uPvw)
        {
            return new UserService().New_User(uName, uPwd, uPvw);
        }
        //————删除用户————
        public void delete(string uname)
        {
            new UserService().delete(uname);
        }
        //————修改用户————
        public void ChangeInfo(User user)
        {
            new UserService().ChangeInfo(user);
        }
    }
}
