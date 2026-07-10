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
    public partial class User_chaxun : Form
    {       
        public User_chaxun()
        {
            InitializeComponent();
            this.Load += UserInfoForm_Load;
           // dataGridView1.AutoGenerateColumns = true;
            
            comboBox1.SelectedItem = "不筛选";
        }
        private void UserInfoForm_Load(object sender, System.EventArgs e)
        {
            LoadUserInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUserInfo()
        {
            UserManager um = new UserManager();
            List<User> Allusers = um.GetAllUsers();
            if (dataGridView1.Columns.Count >= 1)
            {
                dataGridView1.Columns[0].HeaderText = "用户名";
                dataGridView1.Columns[1].HeaderText = "用户密码";
                dataGridView1.Columns[2].HeaderText = "用户权限";
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // 列宽适应内容
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);     // 行高适应内容

            }
            dataGridView1.DataSource = Allusers;
        }
        private void ReloadByCondition(string condition = "", string find = "")
        {
            try
            {
                UserManager userManager = new UserManager();

                // 使用UserManager的查询方法
                List<User> list = userManager.GetList(condition, find);

                dataGridView1.DataSource = list;                
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_chaxun_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
            string uname = dataGridView1[0,this.dataGridView1.CurrentRow.Index].ToString();
            try
            {
                new UserManager().delete(uname);

                LoadUserInfo();
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_New user_New = new User_New();
            user_New.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选中一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //获取选中的User对象
            User selectedUser = dataGridView1.CurrentRow.DataBoundItem as User;

            ChangeUserInfo editForm = new ChangeUserInfo(selectedUser);
            editForm.Show();
        }

        private void 导出Excel报表EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportDataGridView(dataGridView1, "用户信息表", "用户信息");
        }
    }
}
