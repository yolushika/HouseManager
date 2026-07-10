using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.Models;
using System.Data.SqlClient;
using System.Data;

namespace 房屋租赁系统.DAL
{
    public class zhuceService
    {
        public bool isUexist(string uName)
        {
            string sqlStr = string.Format("SELECT uName FROM [tbl_User] Where uName='{0}'", uName);
            DataSet ds = SqlHelper.Query(sqlStr);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public bool zhuce_User(string uName, string uPwd)
        {
            string sqlStr = string.Format("INSERT INTO [tbl_User] VALUES ('{0}','{1}','{2}')", uName, uPwd,"普通用户");
            int Rows = SqlHelper.Execute(sqlStr);
            return Rows > 0;
        }
        public bool zhuce_Tenement(string tTel, string tName, string tSex, string tAge, string Tuname)
        {
            string sqlStr = string.Format("INSERT INTO [tbl_Tenement] VALUES ('{0}','{1}','{2}', '{3}','{4}')", tTel, tName, tSex, tAge,Tuname);
            int Rows = SqlHelper.Execute(sqlStr);
            return Rows > 0;
        }
    }
}
