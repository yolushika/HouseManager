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
using 房屋租赁系统.房屋类型管理;

namespace 房屋租赁系统
{
    public partial class Category_chaxun : Form
    {
        public void SetHeaderText()
        {
            if (dataGridView1.Columns.Contains("Cno1"))
                dataGridView1.Columns["Cno1"].HeaderText = "类型编号";

            if (dataGridView1.Columns.Contains("Cname1"))
                dataGridView1.Columns["Cname1"].HeaderText = "房屋类型";
        }
        public Category_chaxun()
        {
            InitializeComponent();
            this.Load += CategoryInfoForm_Load;
            comboBox1.SelectedItem = "不筛选";
        }

        private void Category_chaxun_Load(object sender, EventArgs e)
        {

        }
        private void CategoryInfoForm_Load(object sender, System.EventArgs e)
        {
            LoadCategoryInfo();
        }
        public void LoadCategoryInfo()
        {
            CategoryService categoryService = new CategoryService();
            List<Category> Allcategorys = categoryService.GetAllCategorys();
            dataGridView1.DataSource = Allcategorys;
            if (dataGridView1.Columns.Count >= 1)
            {
                dataGridView1.Columns[0].HeaderText = "类型编号";
                dataGridView1.Columns[1].HeaderText = "房屋类型";
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // 列宽适应内容
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);     // 行高适应内容
            }
        }
        private void ReloadByCondition(string condition = "", string find = "")
        {
            try
            {
                CategoryManager categoryManager = new CategoryManager();

                // 使用UserManager的查询方法
                List<Category> list = categoryManager.GetList(condition, find);

                dataGridView1.DataSource = list;
                SetHeaderText();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败: {ex.Message}", "错误",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            int cNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Cno1"].Value);
            try
            {
                new CategoryManager().delete(cNo);

                LoadCategoryInfo();
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            string Cname = txt_New.Text;

            CategoryManager New = new CategoryManager();
            bool isValid = true;
            string errorMsg = "";
            if (string.IsNullOrWhiteSpace(Cname))
            {
                errorMsg = "类型名称不能为空！";
                isValid = false;
                txt_New.Focus();
            }
            else if (New.IsCexist(Cname))
            {
                errorMsg = "当前类型已存在，请更换！";
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(errorMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool categorySuccess = New.add(Cname);


            MessageBox.Show("新建成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_New.Text = "";
        }

        private void btn_change_Click(object sender, EventArgs e)
        {

        }

        private void 导出Excel报表EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridView(dataGridView1, "房屋类型信息表", "房屋类型信息");
        }

        private void 修改CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选中一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //获取选中的Tenement对象
            Category selectedCategory = dataGridView1.CurrentRow.DataBoundItem as Category;

            ChangeInfoCategory editForm = new ChangeInfoCategory(selectedCategory);
            editForm.Show();
        }
    }
}
