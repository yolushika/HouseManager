using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 房屋租赁系统.BLL;
using 房屋租赁系统.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace 房屋租赁系统.房屋类型管理
{
    public partial class ChangeInfoCategory : Form
    {
        public Category SelectedCategory { get; private set; }

        public ChangeInfoCategory(Category Category)
        {
            InitializeComponent();
            SelectedCategory = Category;
        }
        private void ChangeTenementInfo_Load(object sender, EventArgs e)
        {
            if (SelectedCategory == null)
            {
                MessageBox.Show("未获取到用户信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txtCname.Text = SelectedCategory.Cname1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string errorMsg = "";

            string cName = txtCname.Text;

            Category c = new Category {
                Cno1 = SelectedCategory.Cno1,
                Cname1 = cName                
            };
            try
            {
                CategoryManager cm = new CategoryManager();
                cm.ChangeInfo(c); // 传递包含主键的User对象

                MessageBox.Show("修改操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
