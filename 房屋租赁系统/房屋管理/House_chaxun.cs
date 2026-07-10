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
    public partial class House_chaxun : Form
    {        
        public House_chaxun()
        {
            InitializeComponent();
            this.Load += HouseInfoForm_Load;
            comboBox1.SelectedItem = "不筛选";           
        }
        private void HouseInfoForm_Load(object sender, System.EventArgs e)
        {
            LoadHouseInfo();
        }
        public void LoadHouseInfo()
        {
            HouseManager houseManager = new HouseManager();
            List<House> Allhouse = houseManager.GetHouses();
            dataGridView1.DataSource = Allhouse;
            

            if (dataGridView1.Columns.Count >= 4)
            {
                dataGridView1.Columns[0].HeaderText = "房屋编号";
                dataGridView1.Columns[1].HeaderText = "具体地址";
                dataGridView1.Columns[2].HeaderText = "房屋面积";
                dataGridView1.Columns[3].HeaderText = "房屋楼层";
                dataGridView1.Columns[4].HeaderText = "月租金";
                dataGridView1.Columns[5].HeaderText = "房间数";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "房屋状态";
                dataGridView1.Columns[8].HeaderText = "房屋类型";

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // 列宽适应内容
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);     // 行高适应内容
            }
        }
        private void ReloadByCondition(string condition = "", string find = "")
        {
            try
            {
                HouseManager houseManager = new HouseManager();

                // 使用HouseManager的查询方法
                List<House> list = houseManager.GetList(condition, find);

                dataGridView1.DataSource = list;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void House_chaxun_Load(object sender, EventArgs e)
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

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            House_New house_New = new House_New();
            house_New.Show();
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
            int rno = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Hno1"].Value);
            try
            {
                new HouseManager().delete(rno);

                LoadHouseInfo();
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选中一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //获取选中的House对象
            House selectedHouse = dataGridView1.CurrentRow.DataBoundItem as House;

            ChangeHouseInfo editForm = new ChangeHouseInfo(selectedHouse);
            editForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 导出Excel报表EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridView(dataGridView1, "房屋信息表", "房屋信息");
        }
    }
}
