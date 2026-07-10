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
    public partial class Feedback_A : Form
    {
        public Feedback_A()
        {
            InitializeComponent();
            LoadFeedbackInfo();
            //this.Load += FeedbackInfoForm_Load;
        }
        public void LoadFeedbackInfo()
        {
            FeedbackManager feedbackManager = new FeedbackManager();
            List<Feedback> AllFeedback = feedbackManager.GetFeedbacks();
            dataGridView1.DataSource = AllFeedback;
            if (dataGridView1.Columns.Count >= 4)
            {
                dataGridView1.Columns[0].HeaderText = "反馈编号";
                dataGridView1.Columns[1].HeaderText = "反馈用户名";
                dataGridView1.Columns[2].HeaderText = "反馈日期";
                dataGridView1.Columns[3].HeaderText = "反馈内容";
                dataGridView1.Columns[4].HeaderText = "反馈类型";

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // 列宽适应内容
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);     // 行高适应内容
            }
        }
        private void Feedback_A_Load(object sender, EventArgs e)
        {

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选中一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Feedback selectedF = dataGridView1.CurrentRow.DataBoundItem as Feedback;

            string Funame = selectedF.FUname1;
            string Fdate = selectedF.Fdate1;
            string feedback = selectedF._Feedback1;

            txt_Funame.Text = Funame;
            txt_date.Text = Fdate;
            rtxt_content.Text = feedback;

        }

        private void 导出Excel报表EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridView(dataGridView1, "反馈信息表", "反馈信息");
        }
    }
}
