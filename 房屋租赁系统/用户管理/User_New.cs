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

namespace 房屋租赁系统
{
    public partial class User_New : Form
    {
        public User_New()
        {
            InitializeComponent();
        }
        private void button_ShowPwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.PasswordChar = '\0';
            txtPwdAgain.PasswordChar = '\0';
        }
        private void button_ShowPwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.PasswordChar = '*';
            txtPwdAgain.PasswordChar = '*';
        }
        private void button_ShowPwd_MouseLeave(object sender, EventArgs e)
        {
            txtPwd.PasswordChar = '*';
            txtPwdAgain.PasswordChar = '*';
        }

        private void User_New_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uName = txtUser.Text.Trim();
            string uPwd = txtPwd.Text;
            string uPwdAgain = txtPwdAgain.Text;
            string uPvw = radioButton1.Checked ? "普通用户" : "管理员";

            UserManager New = new UserManager();
            bool isValid = true;
            string errorMsg = "";
            if (string.IsNullOrWhiteSpace(uName) || string.IsNullOrWhiteSpace(uPwd) ||
       string.IsNullOrWhiteSpace(uPwdAgain))
            {
                errorMsg = "所有字段不能为空！";
                isValid = false;
                txtUser.Focus();
            }
            else if (uPwd != uPwdAgain)
            {
                errorMsg = "两次密码不一致！";
                isValid = false;
                txtPwdAgain.Text = "";
                txtPwdAgain.Focus();
            }
            //检查用户名是否已存在
            else if (New.IsUexist(uName))
            {
                errorMsg = "用户名已存在，请更换！";
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show(errorMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool userSuccess = New.New_user(uName, uPwd, uPvw);

            MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_ShowPwd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
