using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.Models;
using 房屋租赁系统.DAL;
using System.Data.SqlClient;
using System.Data;

namespace 房屋租赁系统.DAL
{
    public class CategoryService
    {//————由dataset获取List<Category>，既把dataset的数据放在list中方便在层间传送————
        public List<Category> ToModel(DataTable dt, bool cNo = false, bool cName = false, bool cC = false)
        {
            List<Category> list = new List<Category>();
            Category category;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                category = new Category();
                category.Cno1 = (int)dt.Rows[i]["Cno"];
                category.Cname1 = dt.Rows[i]["Cname"].ToString();                
                list.Add(category);
            }
            return list;
        }
        //————编写按条件查询满足类别信息的方法————
        public List<Category> GetCategory(string condition = "", string value = "")
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_Category] WHERE Cno LIKE '%{0}%'", condition, value);
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);//把dataset数据放置在list中并返回
        }
        public List<Category> GetAllCategorys()
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_Category]");
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————获取单类型Model————
        public Category Get(string cNo = null, bool cName = true)
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_Category] WHERE Cno LIKE '%{0}%'", cNo);
            DataSet ds = SqlHelper.Query(sqlStr);
            if (ds.Tables[0].Rows.Count == 0) throw new Exception("类型不存在");
            return ToModel(ds.Tables[0], cName)[0];
        }
        //————重载 获取列表的List<Model>————
        public List<Category> Get(string condition, string find, bool cNo = false, bool cName = false)
        {
            string sqlStr = String.Format("SELECT * FROM [tbl_Category] ");
            if (condition != string.Empty)
            {
                sqlStr += String.Format(" WHERE {0} LIKE '%{1}%' ", condition, find);
            }
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————新建类别————
        public bool add(string cName)
        {
            string sqlStr = string.Format("INSERT INTO [tbl_Category] VALUES('{0}')",
               cName);
            int Rows = SqlHelper.Execute(sqlStr);
            return Rows > 0;
        }
        //————删除类别————
        public void delete(int cNo)
        {
            string sqlStr = string.Format("DELETE FROM [tbl_Category] Where Cno='{0}'", cNo);
            SqlHelper.Execute(sqlStr);
        }
        //————修改类别————
        public void ChangeInfo(Category category)
        {
            string sqlStr = string.Format("UPDATE [tbl_Category] SET Cname='{0}' Where Cno='{1}'",
                category.Cname1, category.Cname1);
            SqlHelper.Execute(sqlStr);
        }
        //————检查类型名是否已存在————
        public bool isCexist(string cName)
        {
            string sqlStr = string.Format("SELECT Cname FROM [tbl_Category] Where Cname='{0}'", cName);
            DataSet ds = SqlHelper.Query(sqlStr);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }        
    }
}
