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
using 房屋租赁系统.DAL;
using 房屋租赁系统.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 房屋租赁系统
{
    public partial class House_Search : Form
    {
        public House SelectedHouse { get; private set; }
        private string _selectedHouseNo; // 选中的房屋编号
        
        public House_Search()
        {
            InitializeComponent();
            this.Load += HouseInfoForm_Load;
            comboBox1.SelectedItem = "不筛选";
            dtp_StartDate = new DateTimePicker();
            dtp_StartDate.Format = DateTimePickerFormat.Short; // 格式：yyyy-MM-dd
            dtp_StartDate.Value = DateTime.Now; // 默认今天

            ////让ComboBox1中的数据源直接与tbl_Category绑定
            //CategoryManager cm = new CategoryManager();
            //List<Category> categoryName = cm.GetCategorys();
            //comboBox2.DataSource = categoryName;
            ////DisplayMember属性即为显示的文本内容
            //comboBox2.DisplayMember = "Cname1";
            ////ValueMember属性即为类型对于编号
            //comboBox2.ValueMember = "Cno1";
        }
        private void HouseInfoForm_Load(object sender, System.EventArgs e)
        {
            LoadHouseInfo();
        }
        public void LoadHouseInfo()
        {
            HouseService houseService = new HouseService();
            List<House> Allhouse = houseService.GetTheHouses();
            dataGridView1.DataSource = Allhouse;
            if (dataGridView1.Columns.Count >= 4)
            {
                dataGridView1.Columns[0].HeaderText = "房屋编号";
                dataGridView1.Columns[1].HeaderText = "具体地址";
                dataGridView1.Columns[2].HeaderText = "房屋面积";
                dataGridView1.Columns[3].HeaderText = "房屋楼层";
                dataGridView1.Columns[4].HeaderText = "月租金";
                dataGridView1.Columns[5].HeaderText = "房间数";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "房屋状态";
                dataGridView1.Columns[8].HeaderText = "房屋类型";
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // 列宽适应内容
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);     // 行高适应内容            
        }
        private void ReloadByCondition(string condition = "", string find = "")
        {
            HouseManager houseManager = new HouseManager();

            //使用HouseManager的查询方法
            List<House> list = houseManager.GetList(condition, find);

            dataGridView1.DataSource = list;
        }
        private void House_Search_Load(object sender, EventArgs e)
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

        private void btn_Choose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选中一行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //获取选中的House对象
            House selectedHouse = dataGridView1.CurrentRow.DataBoundItem as House;

            // 保存房屋编号（关键：用于后续更新状态）
            _selectedHouseNo = selectedHouse.Hno1; 

            txt_Radd.Text = selectedHouse.Hname1;
            txt_Rcategory.Text = selectedHouse.Hfloor1;
            txt_rent.Text = selectedHouse.Hrent1;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string rAdd=txt_Radd.Text;
            string rCategory=txt_Rcategory.Text;
            string rRent = txt_rent.Text.Trim();
            string rDays = txt_Rdays.Text.Trim();
            string rId = txt_RId.Text.Trim();
            string rName = txt_RName.Text.Trim();
            string rTel = txt_RTel.Text.Trim();
            DateTime? birthDate = dtp_Age.Value;
            string rSex = radioButton1.Checked ? "男" : "女";
            string rNote = rtb_RNote.Text;           
            string rDate = DateTime.Now.ToString("yyyy-MM-dd");
            string rUname = GlobalData.LoginU_Name;

            bool isValid = true;
            string errorMsg = "";
            
            if (string.IsNullOrEmpty(rAdd) || string.IsNullOrEmpty(rCategory))
            {
                MessageBox.Show("您尚未选房！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(rDays) || string.IsNullOrEmpty(rId) ||
                string.IsNullOrEmpty(rName) || string.IsNullOrEmpty(rTel))
            {
                MessageBox.Show("有未填入的信息，请返回确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rTel.Length != 11)
            {
                errorMsg = "电话号码必须为11位！";
                isValid = false;
                txt_RTel.Focus();
            }
            else if (rId.Length != 18)
            {
                errorMsg = "身份证号必须为18位！";
                isValid = false;
                txt_RId.Focus();
            }
            // 若失败，显示错误并终止
            if (!isValid)
            {
                MessageBox.Show(errorMsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //换算日期到年龄
            int age = DateTime.Now.Year - birthDate.Value.Year;
            if (DateTime.Now.Month < birthDate.Value.Month ||
                (DateTime.Now.Month == birthDate.Value.Month && DateTime.Now.Day < birthDate.Value.Day))
            {
                age--; // 未到生日，年龄减1
            }
            string rAge = age.ToString();
            //通过月租金获取总租金
            int pay = Convert.ToInt32(rDays) * Convert.ToInt32(rRent);
            string rPay = pay.ToString();

            new HRManager().add(rName, rId, rDays, rPay, rTel, rAge, rSex, rAdd, rCategory, rDate, rNote, "已成交", rUname);

            HouseManager housemanager = new HouseManager();
            housemanager.UpdateHouseStateByHno(_selectedHouseNo, "已出租");

            MessageBox.Show("订单生成中... ...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            MessageBox.Show("生成成功！请返回“我的订单”查看详情", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
