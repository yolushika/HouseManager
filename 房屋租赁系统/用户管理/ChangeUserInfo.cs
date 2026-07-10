using Microsoft.VisualBasic.Devices;
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

namespace 房屋租赁系统
{
    public partial class ChangeUserInfo : Form
    {
        public User SelectedUser { get; private set; }
        public ChangeUserInfo(User user)
        {
            InitializeComponent();
            SelectedUser = user;
        }

        private void ChangeUserInfo_Load(object sender, EventArgs e)
        {
            if (SelectedUser == null)
            {
                MessageBox.Show("未获取到用户信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txt_Uno.Text = SelectedUser.UNo1;
            txt_User.Text = SelectedUser.UName1; 
            txt_Upwd.Text = SelectedUser.UPwd1;
            
            if (SelectedUser.UPvw1 == "普通用户")
                radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string errorMsg = "";

            string Uno = txt_Uno.Text;
            string _User = txt_User.Text.Trim();
            string UPwd = txt_Upwd.Text.Trim();
            string UpwdAgain = txt_UpwdAgain.Text.Trim();
            string UPvw = radioButton1.Checked ? "普通用户" : "管理员";

            if (string.IsNullOrWhiteSpace(Uno) || string.IsNullOrWhiteSpace(UPwd) ||
      string.IsNullOrWhiteSpace(UpwdAgain)||string.IsNullOrEmpty(_User))
            {
                errorMsg = "所有字段不能为空！";
                isValid = false;
                txt_User.Focus();
            }
            else if (txt_Upwd.Text != txt_UpwdAgain.Text)
            {
                errorMsg = "两次密码不一致！";
                isValid = false;
                txt_UpwdAgain.Text = "";
                txt_UpwdAgain.Focus();
            }
            if (!isValid) 
            {
                MessageBox.Show(errorMsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                UNo1 = Uno,
                UName1 = _User,
                UPwd1 = UPwd,
                UPvw1 = UPvw
            };

            try
            {
                UserManager userManager = new UserManager();
                userManager.ChangeInfo(user); // 传递包含主键的User对象

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
