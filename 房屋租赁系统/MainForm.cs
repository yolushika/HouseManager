using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 房屋租赁系统.Models;

namespace 房屋租赁系统
{
    public partial class MainForm : Form
    {
        public string U_pvw { get; set; }
        public MainForm()
        {
            InitializeComponent();


        }
        private void UpdateMenuByU_pvw()
        {
            if (U_pvw == "普通用户")
            {
                用户管理ToolStripMenuItem.Visible = false;
                租户管理ToolStripMenuItem1.Visible = false;
                用户管理ToolStripMenuItem.Visible = false;
                房屋分类ToolStripMenuItem.Visible = false;
                租户管理ToolStripMenuItem1.Visible = false;
                房屋管理ToolStripMenuItem.Visible = false;
                订单管理ToolStripMenuItem.Visible = false;
                用户反馈ToolStripMenuItem.Visible = false;
            }
            else
            {
                用户管理ToolStripMenuItem.Visible = true;
                房屋分类ToolStripMenuItem.Visible = true;
                租户管理ToolStripMenuItem1.Visible = true;
                房屋管理ToolStripMenuItem.Visible = true;
                订单管理ToolStripMenuItem.Visible = true;
                寻找房屋ToolStripMenuItem.Visible = false;
                我的订单ToolStripMenuItem.Visible = false;
                我要反馈ToolStripMenuItem.Visible = false;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            UpdateMenuByU_pvw();
            menuStrip1.ShowItemToolTips = true;
        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        public void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_chaxun user_Chaxun = new User_chaxun();
            user_Chaxun.MdiParent = this;
            user_Chaxun.Show();
        }

        public void 租户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tenement_chaxun tenment_Chaxun = new Tenement_chaxun();
            tenment_Chaxun.MdiParent = this;
            tenment_Chaxun.Show();
        }

        public void 房屋管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            House_chaxun house_chaxun = new House_chaxun();
            house_chaxun.MdiParent = this;
            house_chaxun.Show();
        }

        public void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HR_chaxun hr_chaxun = new HR_chaxun();
            hr_chaxun.MdiParent = this;
            hr_chaxun.Show();
        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 房屋分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category_chaxun Cc = new Category_chaxun();
            Cc.MdiParent = this;
            Cc.Show();
        }

        private void 寻找房屋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            House_Search Hs = new House_Search();
            Hs.MdiParent = this;
            Hs.Show();
        }

        private void 我的订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_dingdan md = new My_dingdan();
            md.MdiParent = this;
            md.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 我要反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback_U fu = new Feedback_U();
            fu.MdiParent = this;
            fu.Show();
        }

        private void 用户反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback_A fa = new Feedback_A();
            fa.MdiParent = this;
            fa.Show();
        }

        private void 退出登录QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("退出登录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                return;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("真的要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }

        }
    }
    public static class GlobalData
    {
        /// <summary>
        /// 当前登录用户名（在登录时赋值）
        /// </summary>
        public static string LoginU_Name { get; set; }
    }
}
