namespace 房屋租赁系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("真的要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btndenglu_Click(object sender, EventArgs e)
        {
            Form_denglu form = new Form_denglu(this);
            form.Show();
        }

        private void btnzhuce_Click(object sender, EventArgs e)
        {
            User_zhuce user_Zhuce = new User_zhuce();
            user_Zhuce.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
