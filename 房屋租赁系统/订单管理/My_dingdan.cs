using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;
using 房屋租赁系统.BLL;

namespace 房屋租赁系统
{
    public partial class My_dingdan : Form
    {
        private void LoadHRInfo()
        {
            HRService hRService = new HRService();
            List<HR> Allhrs = hRService.GetUserHR(GlobalData.LoginU_Name);
            dataGridView1.DataSource = Allhrs;
            if (dataGridView1.Columns.Count >= 10)
            {
                dataGridView1.Columns[0].HeaderText = "订单编号";
                dataGridView1.Columns[1].HeaderText = "订单提交人姓名";
                dataGridView1.Columns[2].HeaderText = "身份证号";
                dataGridView1.Columns[3].HeaderText = "租住时间/月";
                dataGridView1.Columns[4].HeaderText = "总租金";
                dataGridView1.Columns[5].HeaderText = "电话号码";
                dataGridView1.Columns[6].HeaderText = "年龄";
                dataGridView1.Columns[7].HeaderText = "性别";
                dataGridView1.Columns[8].HeaderText = "房屋地址";
                dataGridView1.Columns[9].HeaderText = "房屋类型";
                dataGridView1.Columns[10].HeaderText = "订单开始日期";
                dataGridView1.Columns[11].HeaderText = "订单备注";
                dataGridView1.Columns[12].HeaderText = "订单状态";
                dataGridView1.Columns[13].Visible = false;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // 列宽适应内容
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);     // 行高适应内容               
            }
        }

        public My_dingdan()
        {
            InitializeComponent();
            // 绑定窗体加载事件，触发数据加载
            this.Load += (sender, e) => LoadHRInfo();
        }
        private void My_dingdan_Load(object sender, EventArgs e)
        {
            LoadHRInfo(); // 调用加载订单的方法
        }
        //————计算时间租住时长————

        private void btn_tuizu_Click(object sender, EventArgs e)
        {
            //获取选中的订单数据（强转为HR对象）
            HR selectedHR = dataGridView1.CurrentRow.DataBoundItem as HR;

            string Hname = selectedHR.Radd1;
            string Rdays = selectedHR.Rdays1;
            string Rdate = selectedHR.Rdate1;
            string Rno = selectedHR.Rno1;

            if (selectedHR.Rstate1 == "已退租")
            {
                MessageBox.Show("该订单已退租，无需重复操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // 获取退租日期
            DateTime returnDate = DateTime.Parse(dtp_ReturnDate.Value.ToString("yyyy-MM-dd")); // 控件名称是dtp_ReturnDate
            DateTime startTime = DateTime.Parse(Rdate);

            int year = returnDate.Year - startTime.Year;
            int mounth = returnDate.Month - startTime.Month;
            int day = returnDate.Day - startTime.Day;

            if (day < 0)
            {
                mounth--;
                day += DateTime.DaysInMonth(returnDate.Year, returnDate.Month);
            }
            if (mounth < 0)
            {
                year--;
                mounth += 12;
            }

            int rPay = (year * 12 + mounth) * (Convert.ToInt32(selectedHR.Rpay1) / Convert.ToInt32(selectedHR.Rdays1));
            string Rpay = rPay.ToString();

            Rdate = (year * 12 + mounth).ToString();

            txt_Rdays.Text = selectedHR.Rdate1;
            txt_Rdays.Text = Rdate;
            new HRManager().UpdateHRState(Rdate, Rpay, "已退租", Rno);
            new HouseManager().UpdateHouseStateByHname(Hname, "空闲");
            MessageBox.Show("退租成功！状态已更新", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            LoadHRInfo();
        }

        private void My_dingdan_Load_1(object sender, EventArgs e)
        {

        }

        private void 导出Excel报表EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridView(dataGridView1, "我的订单信息表", "我的订单信息");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
