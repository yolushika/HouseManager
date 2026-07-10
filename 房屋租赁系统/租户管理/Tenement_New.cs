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

namespace 房屋租赁系统
{
    public partial class Tenement_New : Form
    {
        public Tenement_New()
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
        private void Tenement_New_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uName = txtUser.Text.Trim(); // 新用户名
            string Tuname = txtUser.Text.Trim();
            string uPwd = txtPwd.Text; // 密码
            string uPwdAgain = txtPwdAgain.Text; // 确认密码
            string tName = txtName.Text.Trim(); // 姓名
            string tTel = txtTel.Text.Trim(); // 电话号码
            DateTime? birthDate = dtpAge.Value;
            string tSex = radioButton1.Checked ? "男" : "女";

            zhuceManager zhuce = new zhuceManager();
            bool isValid = true;
            string errorMsg = "";
            if (string.IsNullOrWhiteSpace(uName) || string.IsNullOrWhiteSpace(uPwd) ||
       string.IsNullOrWhiteSpace(uPwdAgain) || string.IsNullOrWhiteSpace(tName) ||
       string.IsNullOrWhiteSpace(tTel) || !birthDate.HasValue)
            {
                errorMsg = "所有字段不能为空！";
                isValid = false;
                txtName.Focus();
            }
            else if (uPwd != uPwdAgain)
            {
                errorMsg = "两次密码不一致！";
                isValid = false;
                txtPwdAgain.Text = "";
                txtPwdAgain.Focus();
            }
            // 2.3 检查用户名是否已存在
            else if (zhuce.IsUexist(uName))
            {
                errorMsg = "用户名已存在，请更换！";
                isValid = false;
                txtName.Focus();
            }
            // 2.4 检查电话号码格式（可选，示例）
            else if (tTel.Length != 11)
            {
                errorMsg = "电话号码必须为11位！";
                isValid = false;
                txtTel.Focus();
            }

            // 若验证失败，显示错误并终止
            if (!isValid)
            {
                MessageBox.Show(errorMsg, "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int age = DateTime.Now.Year - birthDate.Value.Year;
            if (DateTime.Now.Month < birthDate.Value.Month ||
                (DateTime.Now.Month == birthDate.Value.Month && DateTime.Now.Day < birthDate.Value.Day))
            {
                age--; // 未到生日，年龄减1
            }
            string tAge = age.ToString();

            bool userSuccess = zhuce.zhuceUser(uName, uPwd);
            bool tenementSuccess = zhuce.zhuceTenement(tTel, tName, tSex, tAge, Tuname);

            MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
