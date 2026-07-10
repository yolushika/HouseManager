using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.Models;
using 房屋租赁系统.DAL;
using System.Data.SqlClient;
//————第一步：添加引用————

namespace 房屋租赁系统.DAL
{
    public class UserService
    {
        //————第二步：由dataset获取List<User>，既把dataset的数据放在list中方便在层间传送————
        public List<User> ToModel(DataTable dt, bool uPvw = false)
        {
            List<User> list = new List<User>();
            User user;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                user = new User();
                user.UName1 = dt.Rows[i]["uName"].ToString();
                user.UPwd1 = dt.Rows[i]["uPwd"].ToString();
                user.UPvw1 = dt.Rows[i]["uPvw"].ToString();
                user.UNo1 = dt.Rows[i]["uNo"].ToString().ToLower();              
                list.Add(user);
            }
            return list;
        }
        //————第三步：编写按条件查询满足用户信息的方法————
        public List<User> GetUsers(string condition = "", string value = "")
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_User] where uName='{0}' AND uPwd='{1}'", condition, value);
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);//把dataset数据放置在list中并返回
        }
        public List<User> GetAllUsers()
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_User]");
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }        
        //————重载 获取列表的List<Model>————
        public List<User> Get(string condition, string find, bool uPvw = false)
        {
            string sqlStr = String.Format("SELECT * FROM [tbl_User] ");
            if (condition != string.Empty)
            {
                sqlStr += String.Format(" WHERE {0} LIKE '%{1}%' ", condition, find);
            }
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————新建用户————
        public void add(string Uname, string Upwd,string Upvw)
        {
            string sqlStr = string.Format("INSERT INTO [tbl_User] VALUES('{0}','{1}','{2}')",
                Uname, Upwd, Upvw);
            SqlHelper.Execute(sqlStr);
        }
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
        public bool New_User(string uName, string uPwd,string uPvw)
        {
            string sqlStr = string.Format("INSERT INTO [tbl_User] VALUES ('{0}','{1}','{2}')", uName, uPwd, uPvw);
            int Rows = SqlHelper.Execute(sqlStr);
            return Rows > 0;
        }        
        //————修改信息————
        public void ChangeInfo(User user)
        {
            string sqlStr = string.Format("UPDATE [tbl_User] SET uName='{0}',uPwd='{1}',uPvw='{2}' Where uNo='{3}'",
               user.UName1, user.UPwd1, user.UPvw1, user.UNo1);
            SqlHelper.Execute(sqlStr);
        }
        //————删除信息————
        public void delete(string uname)
        {
            string sqlStr = string.Format("DELETE FROM [tbl_User] Where uName='{0}'", uname);
            SqlHelper.Execute(sqlStr);
        }
    }
}
