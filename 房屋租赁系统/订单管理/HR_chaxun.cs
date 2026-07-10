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
    public partial class HR_chaxun : Form
    {
        private void SetHeaderText()
        {
            if (dataGridView1.Columns.Contains("tbl_Tenement.Ttel1"))
                dataGridView1.Columns["tbl_Tenement.Ttel1"].HeaderText = "电话号码";

            if (dataGridView1.Columns.Contains("tbl_House.Hno1"))
                dataGridView1.Columns["tbl_House.Hno1"].HeaderText = "房屋编号";

            if (dataGridView1.Columns.Contains("tbl_HR.Rdays1"))
                dataGridView1.Columns["tbl_HR.Rdays1"].HeaderText = "租住天数";

            if (dataGridView1.Columns.Contains("tbl_HR.Rpay1"))
                dataGridView1.Columns["tbl_HR.Rpay1"].HeaderText = "总租金";
        }
        public HR_chaxun()
        {
            InitializeComponent();
            this.Load += HRInfoForm_Load;
            comboBox1.SelectedItem = "不筛选";
        }
        private void HRInfoForm_Load(object sender, System.EventArgs e)
        {
            LoadHRInfo();
        }
        private void LoadHRInfo()
        {
            HRService hRService = new HRService();
            List<HR> Allhrs = hRService.GetAllHRs();
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
        private void ReloadByCondition(string condition = "", string find = "")
        {
            try
            {
                HRManager hrManager = new HRManager();

                // 使用HRManager的查询方法
                List<HR> list = hrManager.GetHRList(condition, find);

                dataGridView1.DataSource = list;
                SetHeaderText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HR_chaxun_Load(object sender, EventArgs e)
        {

        }

        private void btn_chaxunSingle_Click(object sender, EventArgs e)
        {
            string condition = comboBox1.SelectedItem.ToString();
            string findValue = textBox1.Text.Trim();

            if (condition != "不筛选" && string.IsNullOrWhiteSpace(findValue))
            {
                MessageBox.Show("请填入要查找的值", "提示",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ReloadByCondition(condition, findValue);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选中要删除的行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("是否确认删除？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            int rno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Rno1"].Value);
            try
            {
                new HRManager().delete(rno);

                LoadHRInfo();
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 导出Excel报表EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridView(dataGridView1, "订单信息表", "订单信息");
        }
    }
}
