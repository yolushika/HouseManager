using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using 房屋租赁系统.Models;
using System.Data.SqlClient;

namespace 房屋租赁系统.DAL
{
    public class HRService
    {
        public List<HR> ToModel(DataTable dt, bool rNo = false, bool rName = false,
            bool rId = false, bool rDays = false, bool rPay = false, bool rTel = false, bool rAge = false,
            bool rSex = false, bool rAdd = false, bool rCategory = false, bool rDate=false, bool rState = false)
        {
            List<HR> list = new List<HR>();
            HR hr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                hr = new HR();
                hr.Rno1 = dt.Rows[i]["Rno"].ToString();
                hr.Rname1 = dt.Rows[i]["Rname"].ToString();
                hr.RId1 = dt.Rows[i]["RId"].ToString();
                hr.Rdays1 = dt.Rows[i]["Rdays"].ToString();
                hr.Rpay1 = dt.Rows[i]["Rpay"].ToString();
                hr.Rtel1 = dt.Rows[i]["Rtel"].ToString();
                hr.Rage1 = dt.Rows[i]["Rage"].ToString();
                hr.Rsex1 = dt.Rows[i]["Rsex"].ToString();
                hr.Radd1 = dt.Rows[i]["Radd"].ToString();
                hr.Rcategory1 = dt.Rows[i]["Rcategory"].ToString();
                hr.Rnote1 = dt.Rows[i]["Rnote"].ToString();
                hr.Rdate1 = dt.Rows[i]["Rdate"].ToString();
                hr.Rstate1 = dt.Rows[i]["Rstate"].ToString();
                //————按条件查询————              
                if (rNo) hr.Rno1 = dt.Rows[i]["Rno"].ToString();
                if (rName) hr.Rname1 = dt.Rows[i]["Rname"].ToString();
                if (rId) hr.RId1 = dt.Rows[i]["RId"].ToString();
                if (rDays) hr.Rdays1 = dt.Rows[i]["Rdays"].ToString();
                if (rPay) hr.Rpay1 = dt.Rows[i]["Rpay"].ToString();
                if (rTel) hr.Rtel1 = dt.Rows[i]["Rtel"].ToString();
                if (rAge) hr.Rage1 = dt.Rows[i]["Rage"].ToString();
                if (rSex) hr.Rsex1 = dt.Rows[i]["Rsex"].ToString();
                if (rAdd) hr.Radd1 = dt.Rows[i]["Radd"].ToString();
                if (rCategory) hr.Rcategory1 = dt.Rows[i]["Rcategory"].ToString();
                if(rDate) hr.Rdate1 = dt.Rows[i]["Rdate"].ToString();
                if (rState) hr.Rstate1 = dt.Rows[i]["Rstate"].ToString();
                list.Add(hr);
            }
            return list;
        }
        public List<HR> GetAllHRs()
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_HR]");
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————查询单个订单————
        public HR Get(string rNo = null, bool rName = false, bool rId = false, bool rDays = false,
            bool rPay = false, bool rTel = false, bool rAge = false,
            bool rSex = false, bool rAdd = false, bool rCategory = false, bool rDate = false, bool rState = false, bool rUname = false)
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_HR] WHERE Rno LIKE '%{0}%'", rNo);
            DataSet ds = SqlHelper.Query(sqlStr);
            if (ds.Tables[0].Rows.Count == 0) throw new Exception("订单不存在！");
            return ToModel(ds.Tables[0], rName, rId, rDays, rPay, rTel, rAge, rSex, rAdd, rCategory, rDate, rState, rUname)[0];
        }
        public List<HR> GetList(string condition, string find,
            bool rName = true, bool rId = true, bool rDays = true,
            bool rPay = true, bool rTel = true, bool rAge = true,
            bool rSex = true, bool rAdd = true, bool rCategory = true,
            bool rDate = true, bool rState = true,bool rUname = true)
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_HR]");
            if (!string.IsNullOrEmpty(condition) && !string.IsNullOrEmpty(find))
            {
                sqlStr += string.Format(" WHERE {0} LIKE '%{1}%'", condition, find);
            }

            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————添加订单————
        public void add(string rName = null, string rId = null, string rDays = null,
            string rPay = null, string rTel = null, string rAge = null,
            string rSex = null, string rAdd = null, string rCategory = null,
            string rDate = null, string rNote = null, string rState = null, string rUname = null)
        {
            string sqlStr = string.Format(
            "INSERT INTO tbl_HR (Rname, RId, Rdays, Rpay, Rtel, Rage, Rsex, Radd, Rcategory, Rdate, Rnote, Rstate, Runame) " + // 指定列名
            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}','{11}','{12}')",  // 值的数量必须与列名数量相同
            rName, rId, rDays, rPay, rTel, rAge, rSex, rAdd, rCategory,rDate, rNote, rState, rUname // 参数顺序与列名顺序对应
        );
            SqlHelper.Execute(sqlStr);
        }
        //————删除订单————
        public void delete(int Rno)
        {
            string sqlStr = string.Format("DELETE FROM [tbl_HR] Where Rno='{0}'", Rno);
            SqlHelper.Execute(sqlStr);
        }
        //————获取当前登录用户名下的订单————
        public List<HR> GetUserHR(string Runame)
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_HR] WHERE Runame = '{0}'", Runame);
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————更新我的订单信息————
        public void UpdateHRState(string Rdays, string Rpay, string Rstate, string Rno)
        {
            string sqlStr = string.Format("UPDATE [tbl_HR] SET Rdays = '{0}',Rpay='{1}',Rstate='{2}' WHERE Rno = '{3}'", Rdays, Rpay, Rstate, Rno);
            SqlHelper.Execute(sqlStr); // 执行更新
        }
    }
}
