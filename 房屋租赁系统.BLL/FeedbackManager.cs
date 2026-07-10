using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;

namespace 房屋租赁系统.BLL
{
    public class FeedbackManager
    {
        public List<Feedback> GetFeedbacks()
        {
            return new FeedbackService().GetAllFeedbacks();
        }       
        //————用户新建反馈————
        public void add(string FUname, string Fdate, string feedback, string Fcategory)
        {
            new FeedbackService().add(FUname, Fdate, feedback, Fcategory);
        }
    }
}
