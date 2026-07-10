using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using 房屋租赁系统.Models;
using System.Data.SqlClient;//————第一步：添加引用————


namespace 房屋租赁系统.DAL
{
    public class TenementService
    {
        public List<Tenement> ToModel(DataTable dt, bool tTel = false, bool tSex = false)
        {
            List<Tenement> list = new List<Tenement>();
            Tenement tenement;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tenement = new Tenement();
                tenement.Ttel1 = dt.Rows[i]["Ttel"].ToString();
                tenement.Tname1 = dt.Rows[i]["Tname"].ToString();
                tenement.Tsex1 = dt.Rows[i]["Tsex"].ToString();
                tenement.Tage1 = dt.Rows[i]["Tage"].ToString();
                tenement.Tuname1 = dt.Rows[i]["Tuname"].ToString();
                             
                list.Add(tenement);
            }
            return list;
        }
        public List<Tenement> GetAllTenements()
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_Tenement]");
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————获取单人租客信息————
        public Tenement Get(string tName = null, bool tTel = true, bool tSex = true)
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_Tenement] WHERE Tname LIKE '%{0}%'", tName);
            DataSet ds = SqlHelper.Query(sqlStr);
            if (ds.Tables[0].Rows.Count == 0) throw new Exception("用户不存在");
            return ToModel(ds.Tables[0], tTel, tSex)[0];
        }
        public List<Tenement> Get(string condition,string find,bool tTel=false,bool tSex = false)
        {
            string sqlStr = String.Format("SELECT * FROM [tbl_Tenement] ");
            if (condition != string.Empty)
            {
                sqlStr += String.Format(" WHERE {0} LIKE '%{1}%' ", condition, find);
            }
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————新建租户————

        //————修改租户————
        public void ChangeInfo(Tenement t)
        {
            string sqlStr = string.Format("UPDATE [tbl_Tenement] SET Ttel='{0}',Tname='{1}',Tsex='{2}',Tage='{3}',Tuname='{4}' Where Ttel='{5}'",
               t.Ttel1, t.Tname1, t.Tsex1, t.Tage1, t.Tuname1, t.Ttel1);
            SqlHelper.Execute(sqlStr);
        }
        //————删除租户————
        public void delete(string tTel)
        {
            string sqlStr = string.Format("DELETE FROM [tbl_Tenement] Where Ttel='{0}'", tTel);
            SqlHelper.Execute(sqlStr);
        }
    }
}
