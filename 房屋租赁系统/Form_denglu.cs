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
using 房屋租赁系统.BLL;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace 房屋租赁系统
{
    public partial class Form_denglu : Form
    {
        private Form1 _mainForm;
        public Form_denglu(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;            
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            
            //————获取用户输入————
            string Uname = txt_uName.Text.Trim();
            string Upwd = txt_uPwd.Text;
            //————验证输入有效性————
            if (string.IsNullOrEmpty(Uname))
            {
                MessageBox.Show("用户名不能为空！");
                txt_uName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Upwd))
            {
                MessageBox.Show("密码不能为空！");
                txt_uPwd.Focus();
                return;
            }
            //————调用BLL层验证登录————
            UserManager userManager = new UserManager();
            List<User> users = userManager.GetUsers(Uname, Upwd);
            //————判断登录结果————           
            if (users != null && users.Count > 0)
            {
                User currentuser = users[0];
                MainForm mainForm = new MainForm();
                mainForm.U_pvw = currentuser.UPvw1;
                
                if (currentuser.UPvw1 == "管理员")
                {                 
                    mainForm.Show();
                    this.Close();
                    if (_mainForm != null && !_mainForm.IsDisposed)
                    {
                        _mainForm.Hide();
                    }
                    GlobalData.LoginU_Name = Uname;
                    MessageBox.Show("欢迎回来！管理员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                   
                    mainForm.Show();
                    
                    this.Close();
                    if (_mainForm != null && !_mainForm.IsDisposed)
                    {
                        _mainForm.Hide();
                    }
                    GlobalData.LoginU_Name = Uname;
                    MessageBox.Show($"欢迎使用房屋租赁系统！{GlobalData.LoginU_Name}!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else 
            {
                MessageBox.Show("用户不存在或密码错误！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_uPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_uName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_denglu_Load(object sender, EventArgs e)
        {
            txt_uName.Focus();
        }
    }
}
