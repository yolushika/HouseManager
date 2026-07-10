using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 房屋租赁系统.Models;

namespace 房屋租赁系统.DAL
{
    public class FeedbackService
    {
        public List<Feedback> ToModel(DataTable dt)
        {
            List<Feedback> list = new List<Feedback>();
            Feedback feedback;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                feedback = new Feedback();
                feedback.Fno1 = dt.Rows[i]["Fno"].ToString();
                feedback.FUname1 = dt.Rows[i]["FUname"].ToString();
                feedback.Fdate1 = dt.Rows[i]["Fdate"].ToString();
                feedback._Feedback1 = dt.Rows[i]["_Feedback"].ToString();
                feedback.Fcategory1= dt.Rows[i]["Fcategory"].ToString();                
                list.Add(feedback);
            }
            return list;
        }         
        public List<Feedback> GetAllFeedbacks()
        {
            string sqlStr = string.Format("SELECT * FROM [tbl_Feedback]");
            DataSet ds = SqlHelper.Query(sqlStr);
            return ToModel(ds.Tables[0]);
        }               
        //————用户新建反馈————
        public void add(string FUname, string Fdate, string feedback, string Fcategory)
        {
            string sqlStr = string.Format(
            "INSERT INTO [tbl_Feedback] (FUname, Fdate, _Feedback, Fcategory) " + // 指定列名
            "VALUES ('{0}', '{1}', '{2}', '{3}')",  // 值的数量必须与列名数量相同
            FUname, Fdate, feedback, Fcategory // 参数顺序与列名顺序对应
        );
            SqlHelper.Execute(sqlStr);
        }
    }
}
