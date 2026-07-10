using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 房屋租赁系统.BLL;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;

namespace 房屋租赁系统
{
    public partial class Feedback_U : Form
    {
        public Feedback_U()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string feedback = rtxt_Feedback.Text;
            string fUname = GlobalData.LoginU_Name;            
            string fDate = DateTime.Now.ToString("yyyy-MM-dd");
            string fCategory;
            if (radioButton1.Checked)       // "系统有bug"
            {
                fCategory = radioButton1.Text;
            }
            else if (radioButton2.Checked)  // "操作体验和功能建议"
            {
                fCategory = radioButton2.Text;
            }
            else if (radioButton3.Checked)  // "投诉与举报"
            {
                fCategory = radioButton3.Text;
            }
            else if (radioButton4.Checked)  // "信息更新有延迟"
            {
                fCategory = radioButton4.Text;
            }
            else if (radioButton5.Checked)  // "其它"
            {
                fCategory = radioButton5.Text;
            }
            else
            {
                // 若没有选中任何选项，提示用户
                MessageBox.Show("请选择反馈类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 阻止提交
            }



            if (string.IsNullOrEmpty(feedback))
            {
                MessageBox.Show("反馈信息不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("确认提交反馈吗？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (ckb_niming.Checked==false)
            {
                FeedbackManager fm = new FeedbackManager();
                fm.add(GlobalData.LoginU_Name, fDate, feedback, fCategory);
            }
            else if(ckb_niming.Checked==true) 
            {
                FeedbackManager fm = new FeedbackManager();
                fm.add("", fDate, feedback, fCategory);
            }
            MessageBox.Show("提交成功！感谢您的反馈", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Feedback_U_Load(object sender, EventArgs e)
        {

        }
    }
}
