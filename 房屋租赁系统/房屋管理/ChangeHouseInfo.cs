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
using 房屋租赁系统.BLL;
using 房屋租赁系统.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 房屋租赁系统
{
    public partial class ChangeHouseInfo : Form
    {
        private CategoryManager _categoryManager = new CategoryManager();
        public House SelectedHouse { get; private set; }

        public ChangeHouseInfo(House house)
        {
            InitializeComponent();
            SelectedHouse = house;
        }
        //————在ComboBox中显示表tbl_Category中的数据————
        private void LoadCategoryToComboBox()
        {
            //让ComboBox2中的数据源直接与tbl_Category绑定
            CategoryManager cm = new CategoryManager();
            List<Category> categoryName = cm.GetCategorys();
            comboBox1.DataSource = categoryName;
            //DisplayMember属性即为显示的文本内容
            comboBox1.DisplayMember = "Cname1";
            //ValueMember属性即为类型对于编号
            comboBox1.ValueMember = "Cno1";

            List<Category> c_name = _categoryManager.GetCategorys();
            
        }
        

        private void ChangeHouseInfo_Load(object sender, EventArgs e)
        {
            LoadCategoryToComboBox();
            if (SelectedHouse == null)
            {
                MessageBox.Show("未获取到房屋信息！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            txt_Hno.Text = SelectedHouse.Hno1;
            txt_Hname.Text = SelectedHouse.Hname1;
            txt_Haera.Text = SelectedHouse.Harea1;
            txt_Hfloor.Text = SelectedHouse.Hfloor1;
            txt_Hrent.Text = SelectedHouse.Hrent1;
            txt_Hcount.Text = SelectedHouse.Hcount1;
            comboBox1.Text = SelectedHouse.Hc_no1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Hno=txt_Hno.Text;
            string Hname = txt_Hname.Text.Trim();
            string Haera = txt_Haera.Text.Trim();
            string Hfloor = txt_Hfloor.Text.Trim();
            string Hrent = txt_Hrent.Text.Trim();
            string Hcount = txt_Hcount.Text.Trim();
            string Hc_no = comboBox1.SelectedValue.ToString();

            House house = new House
            {
                Hno1 = Hno,
                Hname1 = Hname,
                Harea1 = Haera,
                Hfloor1 = Hfloor,
                Hrent1 = Hrent,
                Hcount1 = Hcount,
                Hc_no1 = Convert.ToInt32(Hc_no)
            };

            try
            {
                HouseManager houseManager = new HouseManager();
                houseManager.ChangeInfo(house); // 传递包含主键的House对象

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
