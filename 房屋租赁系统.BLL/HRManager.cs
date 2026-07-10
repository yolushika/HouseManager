using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;

namespace 房屋租赁系统.BLL
{
    public class HRManager
    {
        public List<HR> GetHR()
        {
            return new HRService().GetAllHRs();
        }
        public List<HR> GetHRList(string condition = "不筛选", string find = "", 
            bool rName = false, bool rId = false, bool rDays = false,
            bool rPay = false, bool rTel = false, bool rAge = false,
            bool rSex = false, bool rAdd = false, bool rCategory=false, 
            bool rDate=false,  bool rState = false)
        {               
            switch (condition)
            {
                case "订单提交人姓名":
                    condition = "Rname";  
                    break;
                case "身份证号":
                    condition = "RId";  
                    break;
                case "租住时间/月":
                    condition = "Rdays";    
                    break;
                case "总租金":
                    condition = "Rpay"; 
                    break;
                case "电话号码":
                    condition = "Rtel";
                    break;
                case "年龄":
                    condition = "Rage";
                    break;
                case "性别":
                    condition = "Rsex";
                    break;
                case "房屋地址":
                    condition = "Radd";
                    break;
                case "房屋类型":
                    condition = "Rcategory";
                    break;
                case "订单开始日期":
                    condition = "Rdate";
                    break;
                case "订单状态":
                    condition = "Rstate";
                    break;
                case "不筛选":
                    condition = "";         
                    break;
                default:
                    condition = "";         
                    break;
            }
            return new HRService().GetList(condition, find, rName, rId, rDays,
                rPay, rTel, rAge, rSex, rAdd, rCategory, rDate, rState);
        }
        //————添加订单————
        public void add(string rName = null, string rId = null, string rDays = null,
            string rPay = null, string rTel = null, string rAge = null,
            string rSex = null, string rAdd = null, string rCategory = null,
            string rDate = null, string rNote = null, string rState = null, string rUname = null)
        {
            new HRService().add(rName, rId, rDays, rPay, rTel, rAge, rSex, rAdd, rCategory, rDate, rNote, rState, rUname);
        }
        //————删除订单————
        public void delete(int Rno)
        {
            new HRService().delete(Rno);
        }
        //————获取当前登录用户名下的订单————
        public List<HR> GetUserHRs(string Runame)
        {
            return new HRService().GetUserHR(Runame);
        }
        //————更新我的订单信息————
        public void UpdateHRState(string Rdays, string Rpay, string Rstate, string Rno)
        {
            new HRService().UpdateHRState(Rdays, Rpay, Rstate, Rno);
        }
    }
}
