using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.Models;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace 房屋租赁系统.DAL
{
    public class HouseService
    {
        public List<House> ToModel(DataTable dt, bool Hno = false, bool Hname = false,
            bool Harea = false, bool Hfloor = false, bool Hrent = false,
            bool Hcount = false, bool Hc_no = false, bool Hstate = false, bool Cname = false)
        {
            List<House> list = new List<House>();
            House house;
            
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                house = new House();
                
                house.Hno1 = dt.Rows[i]["Hno"].ToString();
                house.Hname1 = dt.Rows[i]["Hname"].ToString();
                house.Harea1 = dt.Rows[i]["Haera"].ToString();
                house.Hfloor1 = dt.Rows[i]["Hfloor"].ToString();
                house.Hrent1 = dt.Rows[i]["Hrent"].ToString();
                house.Hcount1 = dt.Rows[i]["Hcount"].ToString();
                house.Hc_no1 = (int)dt.Rows[i]["Hc_no"];
                house.Hstate1 = dt.Rows[i]["Hstate"].ToString();
                house.Cname1= dt.Rows[i]["Cname"].ToString();               
                
                list.Add(house);
            }
            return list;
        }
        public List<House> GetAllHouses()
        {
            string sqlStr = string.Format("SELECT tbl_House.* ,tbl_Category.Cname FROM tbl_House ,tbl_Category WHERE tbl_House.Hc_no = tbl_Category.Cno");
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        //————获取单个房屋信息————
        public House Get1(string Hno = null, bool Hname = true, bool Harea = true, bool Hfloor = true,
            bool Hrent = true, bool Hcount = true, bool Hc_name = true, bool Hstate = true)
        {
            //string sqlStr = string.Format("SELECT tbl_House.*,tbl_Category.Cname FROM [tbl_House],[tbl_Category] WHERE tbl_House.Hno LIKE '%{0}%'", Hno);
            
            string sqlStr = string.Format("SELECT tbl_House.* ,tbl_Category.Cname FROM tbl_House ,tbl_Category WHERE tbl_House.Hc_no = tbl_Category.Cno and tbl_House.Hno LIKE '%{0}%'", Hno);
            DataSet ds = SqlHelper.Query(sqlStr);
            if (ds.Tables[0].Rows.Count == 0) throw new Exception("用户不存在");
            return ToModel(ds.Tables[0], Hname, Harea, Hfloor, Hrent, Hcount,Hc_name)[0];
        }
        //————根据房屋状态获取单个信息————
        public List<House> GetTheHouses()
        {
            string sqlStr = string.Format("SELECT tbl_House.* ,tbl_Category.Cname FROM tbl_House ,tbl_Category WHERE tbl_House.Hc_no = tbl_Category.Cno and Hstate = '{0}'", "空闲");
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }
        public List<House> GetByHstate(string condition, string find)
        {
            string sqlStr = String.Format("SELECT tbl_House.* ,tbl_Category.Cname FROM tbl_House ,tbl_Category WHERE tbl_House.Hc_no = tbl_Category.Cno ");
            if (condition != string.Empty)
            {
                sqlStr += String.Format("AND {0} LIKE '%{1}%' ", condition, find);
            }
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }                
        //————新建房屋————
        public void add(string Hname, string Haera, string Hfloor, string Hrent, string Hcount, string Hstate,string Hc_no)
        {
            string sqlStr = string.Format(
            "INSERT INTO [tbl_House] (Hname, Haera, Hfloor, Hrent, Hcount, Hstate,Hc_no) " + // 指定列名
            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}')",  // 值的数量必须与列名数量相同
            Hname, Haera, Hfloor, Hrent, Hcount, Hstate, Hc_no  // 参数顺序与列名顺序对应
        );
            SqlHelper.Execute(sqlStr);
        }
        //————修改信息————
        public void ChangeInfo(House house)
        {
            string sqlStr1 = string.Format("UPDATE [tbl_House] SET Hname='{0}',Haera='{1}',Hfloor='{2}',Hrent='{3}',Hcount='{4}',Hc_no='{5}' Where Hno='{6}'",
                house.Hname1, house.Harea1, house.Hfloor1, house.Hrent1, house.Hcount1, house.Hc_no1, house.Hno1);
            
            SqlHelper.Execute(sqlStr1);
        }
        //————删除信息————
        public void delete(int Hno)
        {
            string sqlStr = string.Format("DELETE FROM [tbl_House] Where Hno='{0}'", Hno);
            SqlHelper.Execute(sqlStr);
        }
        // ————更新房屋状态的方法————
        public void UpdateHouseStateByHno(string Hno,string Hstate)
        {
            string sqlStr = string.Format("UPDATE [tbl_House] SET Hstate = '{0}' WHERE Hno = '{1}'", Hstate, Hno);            
            SqlHelper.Execute(sqlStr); // 执行更新
        }
        public void UpdateHouseStateByHname(string Hname, string Hstate)
        {
            string sqlStr = string.Format("UPDATE [tbl_House] SET Hstate = '{0}' WHERE Hname = '{1}'", Hstate, Hname);
            SqlHelper.Execute(sqlStr); // 执行更新
        }
    }
}
