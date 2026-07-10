using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;

namespace 房屋租赁系统.BLL
{
    public class CategoryManager
    {
        public List<Category> GetCategorys()
        {
            return new CategoryService().GetAllCategorys();
        }
        public List<Category> GetList(string condition = "", string find = "", bool cNo = true, bool cName = true)
        {
            switch (condition)
            {
                case "类型编号":
                    condition = "Cno";
                    break;
                case "房屋类型":
                    condition = "Cname";
                    break;                
                case "不筛选":
                    condition = "";
                    break;
                default:
                    condition = "";
                    break;
            }
            return new CategoryService().Get(condition, find, cNo, cName);
        }
        //————添加————
        public bool add(string cName)
        {
           return new CategoryService().add(cName);            
        }
        //————删除————
        public void delete(int cNo)
        {
            new CategoryService().delete(cNo);
        }
        //————修改————
        public void ChangeInfo(Category category)
        {
            new CategoryService().ChangeInfo(category);
        }
        //————检查类型名是否已存在————
        public bool IsCexist(string cName)
        {
            return new CategoryService().isCexist(cName);
        }
    }
}
