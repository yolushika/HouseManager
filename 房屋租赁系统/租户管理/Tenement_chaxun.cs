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
    public partial class Tenement_chaxun : Form
    {       
        public Tenement_chaxun()
        {
            InitializeComponent();
            this.Load += TenementInfoForm_Load;
            comboBox1.SelectedItem = "不筛选";
        }
        private void TenementInfoForm_Load(object sender, System.EventArgs e)
        {
            LoadTenementInfo();
        }
        //显示所有信息
        private void LoadTenementInfo()
        {
            TenementService tenementService = new TenementService();
            List<Tenement> Alltenements = tenementService.GetAllTenements();
            dataGridView1.DataSource = Alltenements;
            if (dataGridView1.Columns.Count >= 4)
            {
                dataGridView1.Columns[0].HeaderText = "电话号码";
                dataGridView1.Columns[1].HeaderText = "租户姓名";
                dataGridView1.Columns[2].HeaderText = "租户性别";
                dataGridView1.Columns[3].HeaderText = "租户年龄";
                dataGridView1.Columns[4].HeaderText = "用户名";

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // 列宽适应内容
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);     // 行高适应内容
            }
        }
        private void ReloadByCondition(string condition = "", string find = "")
        {
            try
            {
                TenementManager tenementManager = new TenementManager();

                // 使用UserManager的查询方法
                List<Tenement> list = tenementManager.GetList(condition, find);

                dataGridView1.DataSource = list;                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Tenement_chaxun_Load(object sender, EventArgs e)
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
            string tTel = dataGridView1.CurrentRow.Cells["Ttel1"].Value?.ToString();
            try
            {
                new TenementManager().delete(tTel);

                LoadTenementInfo();
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tenement_New tn = new Tenement_New();
            tn.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选中一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //获取选中的Tenement对象
            Tenement selectedTenement = dataGridView1.CurrentRow.DataBoundItem as Tenement;

            ChangeTenementInfo editForm = new ChangeTenementInfo(selectedTenement);
            editForm.Show();
        }

        private void 导出Excel报表EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridView(dataGridView1, "租户信息表", "租户信息");
        }
    }
}
