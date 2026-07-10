using Microsoft.VisualBasic.ApplicationServices;
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
using 房屋租赁系统.Models;


namespace 房屋租赁系统
{
    public partial class ChangeTenementInfo : Form
    {
        public Tenement SelectedTenement { get; private set; }
        public ChangeTenementInfo(Tenement tenement)
        {
            InitializeComponent();
            SelectedTenement = tenement;
        }

        private void ChangeTenementInfo_Load(object sender, EventArgs e)
        {
            if (SelectedTenement == null)
            {
                MessageBox.Show("未获取到用户信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txt_tTel.Text = SelectedTenement.Ttel1;
            txt_tName.Text = SelectedTenement.Tname1;
            txt_tAge.Text = SelectedTenement.Tage1;
            txt_tUname.Text = SelectedTenement.Tuname1;
            if (SelectedTenement.Tsex1 == "男")
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

            string tTel = txt_tTel.Text;
            string tName = txt_tName.Text.Trim();
            string tAge = txt_tAge.Text.Trim();
            string tUname = txt_tUname.Text.Trim();
            string tSex = radioButton1.Checked ? "男" : "女";

            if (string.IsNullOrWhiteSpace(tTel) || string.IsNullOrWhiteSpace(tName) ||
      string.IsNullOrWhiteSpace(tAge) || string.IsNullOrEmpty(tUname))
            {
                errorMsg = "所有字段不能为空！";
                isValid = false;
                txt_tTel.Focus();
            }

            Tenement tenement = new Tenement
            {
                Ttel1 = tTel,
                Tname1 = tName,
                Tage1 = tAge,
                Tsex1 = tSex,
                Tuname1 = tUname
            };

            try
            {
                TenementManager tenementManager = new TenementManager();
                tenementManager.ChangeInfo(tenement); // 传递包含主键的User对象

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
