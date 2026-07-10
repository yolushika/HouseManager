namespace 房屋租赁系统
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            用户管理ToolStripMenuItem = new ToolStripMenuItem();
            租户管理ToolStripMenuItem1 = new ToolStripMenuItem();
            房屋管理ToolStripMenuItem = new ToolStripMenuItem();
            订单管理ToolStripMenuItem = new ToolStripMenuItem();
            房屋分类ToolStripMenuItem = new ToolStripMenuItem();
            寻找房屋ToolStripMenuItem = new ToolStripMenuItem();
            我的订单ToolStripMenuItem = new ToolStripMenuItem();
            我要反馈ToolStripMenuItem = new ToolStripMenuItem();
            用户反馈ToolStripMenuItem = new ToolStripMenuItem();
            退出登录QToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Font = new Font("楷体", 14F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 用户管理ToolStripMenuItem, 租户管理ToolStripMenuItem1, 房屋管理ToolStripMenuItem, 订单管理ToolStripMenuItem, 房屋分类ToolStripMenuItem, 寻找房屋ToolStripMenuItem, 我的订单ToolStripMenuItem, 我要反馈ToolStripMenuItem, 用户反馈ToolStripMenuItem, 退出登录QToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new Size(1904, 91);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 用户管理ToolStripMenuItem
            // 
            用户管理ToolStripMenuItem.AutoToolTip = true;
            用户管理ToolStripMenuItem.Image = Properties.Resources.人员数量;
            用户管理ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            用户管理ToolStripMenuItem.Size = new Size(182, 87);
            用户管理ToolStripMenuItem.Text = "用户管理(&U)";
            用户管理ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            用户管理ToolStripMenuItem.Click += 用户管理ToolStripMenuItem_Click;
            // 
            // 租户管理ToolStripMenuItem1
            // 
            租户管理ToolStripMenuItem1.Image = Properties.Resources.人物1;
            租户管理ToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            租户管理ToolStripMenuItem1.Name = "租户管理ToolStripMenuItem1";
            租户管理ToolStripMenuItem1.Size = new Size(182, 87);
            租户管理ToolStripMenuItem1.Text = "租户管理(&T)";
            租户管理ToolStripMenuItem1.TextImageRelation = TextImageRelation.ImageAboveText;
            租户管理ToolStripMenuItem1.Click += 租户管理ToolStripMenuItem1_Click;
            // 
            // 房屋管理ToolStripMenuItem
            // 
            房屋管理ToolStripMenuItem.Image = Properties.Resources.主页;
            房屋管理ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            房屋管理ToolStripMenuItem.Name = "房屋管理ToolStripMenuItem";
            房屋管理ToolStripMenuItem.Size = new Size(182, 87);
            房屋管理ToolStripMenuItem.Text = "房屋管理(&H)";
            房屋管理ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            房屋管理ToolStripMenuItem.Click += 房屋管理ToolStripMenuItem_Click;
            // 
            // 订单管理ToolStripMenuItem
            // 
            订单管理ToolStripMenuItem.Image = Properties.Resources.信息;
            订单管理ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            订单管理ToolStripMenuItem.Name = "订单管理ToolStripMenuItem";
            订单管理ToolStripMenuItem.Size = new Size(182, 87);
            订单管理ToolStripMenuItem.Text = "订单管理(&I)";
            订单管理ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            订单管理ToolStripMenuItem.Click += 订单管理ToolStripMenuItem_Click;
            // 
            // 房屋分类ToolStripMenuItem
            // 
            房屋分类ToolStripMenuItem.Image = Properties.Resources.更多;
            房屋分类ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            房屋分类ToolStripMenuItem.Name = "房屋分类ToolStripMenuItem";
            房屋分类ToolStripMenuItem.Size = new Size(182, 87);
            房屋分类ToolStripMenuItem.Text = "房屋分类(&L)";
            房屋分类ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            房屋分类ToolStripMenuItem.Click += 房屋分类ToolStripMenuItem_Click;
            // 
            // 寻找房屋ToolStripMenuItem
            // 
            寻找房屋ToolStripMenuItem.Image = Properties.Resources.查询;
            寻找房屋ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            寻找房屋ToolStripMenuItem.Name = "寻找房屋ToolStripMenuItem";
            寻找房屋ToolStripMenuItem.Size = new Size(182, 87);
            寻找房屋ToolStripMenuItem.Text = "寻找房屋(&S)";
            寻找房屋ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            寻找房屋ToolStripMenuItem.Click += 寻找房屋ToolStripMenuItem_Click;
            // 
            // 我的订单ToolStripMenuItem
            // 
            我的订单ToolStripMenuItem.Image = Properties.Resources.个人信息1;
            我的订单ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            我的订单ToolStripMenuItem.Name = "我的订单ToolStripMenuItem";
            我的订单ToolStripMenuItem.Size = new Size(182, 87);
            我的订单ToolStripMenuItem.Text = "我的订单(&M)";
            我的订单ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            我的订单ToolStripMenuItem.Click += 我的订单ToolStripMenuItem_Click;
            // 
            // 我要反馈ToolStripMenuItem
            // 
            我要反馈ToolStripMenuItem.Image = Properties.Resources.疑问;
            我要反馈ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            我要反馈ToolStripMenuItem.Name = "我要反馈ToolStripMenuItem";
            我要反馈ToolStripMenuItem.Size = new Size(182, 87);
            我要反馈ToolStripMenuItem.Text = "我要反馈(&F)";
            我要反馈ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            我要反馈ToolStripMenuItem.Click += 我要反馈ToolStripMenuItem_Click;
            // 
            // 用户反馈ToolStripMenuItem
            // 
            用户反馈ToolStripMenuItem.Image = Properties.Resources.统计图;
            用户反馈ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            用户反馈ToolStripMenuItem.Name = "用户反馈ToolStripMenuItem";
            用户反馈ToolStripMenuItem.Size = new Size(182, 87);
            用户反馈ToolStripMenuItem.Text = "用户反馈(&B)";
            用户反馈ToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            用户反馈ToolStripMenuItem.Click += 用户反馈ToolStripMenuItem_Click;
            // 
            // 退出登录QToolStripMenuItem
            // 
            退出登录QToolStripMenuItem.Image = Properties.Resources.锁定;
            退出登录QToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            退出登录QToolStripMenuItem.Name = "退出登录QToolStripMenuItem";
            退出登录QToolStripMenuItem.Size = new Size(182, 87);
            退出登录QToolStripMenuItem.Text = "退出登录(&Q)";
            退出登录QToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            退出登录QToolStripMenuItem.Click += 退出登录QToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 884);
            Controls.Add(menuStrip1);
            Font = new Font("方正粗黑宋简体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "房屋租赁系统";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 用户管理ToolStripMenuItem;
        private ToolStripMenuItem 租户管理ToolStripMenuItem1;
        private ToolStripMenuItem 房屋管理ToolStripMenuItem;
        private ToolStripMenuItem 订单管理ToolStripMenuItem;
        private ToolStripMenuItem 房屋分类ToolStripMenuItem;
        private ToolStripMenuItem 寻找房屋ToolStripMenuItem;
        private ToolStripMenuItem 我的订单ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem 我要反馈ToolStripMenuItem;
        private ToolStripMenuItem 用户反馈ToolStripMenuItem;
        private ToolStripMenuItem 退出登录QToolStripMenuItem;
    }
}