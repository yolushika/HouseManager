using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;

namespace 房屋租赁系统.BLL
{
    public class zhuceManager
    {
        public bool IsUexist(string uName)
        {
            return new zhuceService().isUexist(uName);
        }
        public bool zhuceUser(string uName, string uPwd) 
        {
            return new zhuceService().zhuce_User(uName, uPwd);
        }
        public bool zhuceTenement(string tTel, string tName, string tSex, string tAge,string Tuname)
        {
            return new zhuceService().zhuce_Tenement(tTel, tName, tSex, tAge, Tuname);
        }
    }
}
