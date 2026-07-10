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
    public partial class House_New : Form
    {
        private CategoryManager _categoryManager = new CategoryManager();
        public House_New()
        {
            InitializeComponent();
            txt_Hname.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //————在ComboBox中显示表tbl_Category中的数据————
        private void LoadCategoryToComboBox()
        {
            List<Category> c_name = _categoryManager.GetCategorys();

            //让ComboBox1中的数据源直接与tbl_Category绑定
            CategoryManager cm = new CategoryManager();
            List<Category> categoryName = cm.GetCategorys();
            comboBox1.DataSource = categoryName;
            //DisplayMember属性即为显示的文本内容
            comboBox1.DisplayMember = "Cname1";
            //ValueMember属性即为类型对于编号
            comboBox1.ValueMember = "Cno1";

            

        }
        private void House_New_Load(object sender, EventArgs e)
        {
            LoadCategoryToComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Hname = txt_Hname.Text.Trim();
            string Haera = txt_Haera.Text.Trim();
            string Hfloor = txt_Hfloor.Text.Trim();
            string Hrent = txt_Hrent.Text.Trim();
            string Hcount = txt_Hcount.Text.Trim();
            string Hc_name = comboBox1.Text.Trim();
            string selectedCno = comboBox1.SelectedValue.ToString();


            if (string.IsNullOrEmpty(Hname) || string.IsNullOrEmpty(Haera) || string.IsNullOrEmpty(Hfloor) || string.IsNullOrEmpty(Hrent) || string.IsNullOrEmpty(Hcount))
            {
                MessageBox.Show("有未填入的信息，请返回确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HouseManager houseManager = new HouseManager();
                houseManager.add(Hname, Haera, Hfloor, Hrent, Hcount, "空闲", selectedCno);
                MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Haera.Text = "";
                txt_Hname.Text = "";
                txt_Hfloor.Text = "";
                txt_Hrent.Text = "";
                txt_Hcount.Text = "";
                


                DialogResult result = MessageBox.Show("继续添加？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    return;
                }
                else { this.Close(); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //————将表tbl_Category中的数据绑定到ComboBox中————
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
