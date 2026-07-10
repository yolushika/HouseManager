using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;

namespace 房屋租赁系统.BLL
{
    public class TenementManager
    {
        public List<Tenement> GetTenement()
        {
            return new TenementService().GetAllTenements();
        }
        public List<Tenement> GetList(string condition = "", string find = "", bool tTel = false, bool tSex = false)
        {
            switch (condition) 
            {
                case "电话号码":
                    condition = "Ttel";
                    break;
                case "租户姓名":
                    condition = "Tname";
                    break;
                case "租户性别":
                    condition = "Tsex";
                    break;
                case"不筛选":
                    condition = "";
                    break;
                default:
                    condition = "";
                    break;
            }
            
            return new TenementService().Get(condition, find, tTel, tSex);
        }
        //————新建租户————

        //————修改租户————
        public void ChangeInfo(Tenement t)
        {
            new TenementService().ChangeInfo(t);
        }
        //————删除租户————
        public void delete(string tTel)
        {
            new TenementService().delete(tTel);
        }
    }    
}
