using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;

namespace 房屋租赁系统.BLL
{
    public class HouseManager
    {        
        public List<House> GetHouses()
        {
            return new HouseService().GetAllHouses();
        }
        public List<House> GetList(string condition = "", string find = "")
        {
            switch (condition)
            {
                case "房屋编号":
                    condition = "Hno";
                    break;
                case "具体地址":
                    condition = "Hname";
                    break;
                case "房屋面积":
                    condition = "Hname";
                    break;
                case "房屋楼层":
                    condition = "Hfloor";
                    break;
                case "月租金":
                    condition = "Hrent";
                    break;
                case "房间数":
                    condition = "Hcount";
                    break;                
                case "房屋状态":
                    condition = "Hstate";
                    break;
                case "不筛选":
                    condition = "";
                    break;
                default:
                    condition = "";
                    break;
            }
            return new HouseService().GetByHstate(condition, find);
        }        
        //————添加————
        public void add(string Hname, string Haera, string Hfloor, string Hrent, string Hcount, string Hstate, string Hc_no)
        {
            new HouseService().add(Hname, Haera, Hfloor, Hrent, Hcount, Hstate, Hc_no);
        }
        //————删除————
        public void delete(int Hno)
        {
            new HouseService().delete(Hno);
        }
        //————修改————
        public void ChangeInfo(House house)
        {
            new HouseService().ChangeInfo(house);
        }
        // ————更新房屋状态的方法————
        public void UpdateHouseStateByHno(string Hno,string Hstate)
        {
            new HouseService().UpdateHouseStateByHno(Hno,Hstate);
        }
        public void UpdateHouseStateByHname(string Hname, string Hstate)
        {
            new HouseService().UpdateHouseStateByHname(Hname, Hstate);
        }
    }
}
