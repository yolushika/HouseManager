namespace 房屋租赁系统
{
    partial class House_chaxun
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
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btn_chaxunSingle = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            新建ToolStripMenuItem = new ToolStripMenuItem();
            修改ToolStripMenuItem = new ToolStripMenuItem();
            删除ToolStripMenuItem = new ToolStripMenuItem();
            导出Excel报表EToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(523, 48);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 39);
            textBox1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 14F);
            label1.Location = new Point(50, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 13;
            label1.Text = "查询条件:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("楷体", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "不筛选", "房屋编号", "具体地址", "房屋面积", "房屋楼层", "月租金", "房间数", "房屋类型", "房屋状态" });
            comboBox1.Location = new Point(232, 45);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 36);
            comboBox1.TabIndex = 12;
            // 
            // btn_chaxunSingle
            // 
            btn_chaxunSingle.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_chaxunSingle.Image = Properties.Resources._018_搜索;
            btn_chaxunSingle.Location = new Point(980, 24);
            btn_chaxunSingle.Margin = new Padding(4);
            btn_chaxunSingle.Name = "btn_chaxunSingle";
            btn_chaxunSingle.Size = new Size(116, 80);
            btn_chaxunSingle.TabIndex = 11;
            btn_chaxunSingle.Text = "查询";
            btn_chaxunSingle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_chaxunSingle.UseVisualStyleBackColor = true;
            btn_chaxunSingle.Click += btn_chaxunSingle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 130);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1326, 429);
            dataGridView1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.Font = new Font("楷体", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 新建ToolStripMenuItem, 修改ToolStripMenuItem, 删除ToolStripMenuItem, 导出Excel报表EToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1465, 40);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 新建ToolStripMenuItem
            // 
            新建ToolStripMenuItem.Image = Properties.Resources._018_添加;
            新建ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            新建ToolStripMenuItem.Size = new Size(166, 36);
            新建ToolStripMenuItem.Text = "新建(&N)";
            新建ToolStripMenuItem.Click += 新建ToolStripMenuItem_Click;
            // 
            // 修改ToolStripMenuItem
            // 
            修改ToolStripMenuItem.Image = Properties.Resources._018_编辑;
            修改ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            修改ToolStripMenuItem.Size = new Size(166, 36);
            修改ToolStripMenuItem.Text = "修改(&C)";
            修改ToolStripMenuItem.Click += 修改ToolStripMenuItem_Click;
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Image = Properties.Resources._018_垃圾桶;
            删除ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(166, 36);
            删除ToolStripMenuItem.Text = "删除(&D)";
            删除ToolStripMenuItem.Click += 删除ToolStripMenuItem_Click;
            // 
            // 导出Excel报表EToolStripMenuItem
            // 
            导出Excel报表EToolStripMenuItem.Font = new Font("楷体", 14F);
            导出Excel报表EToolStripMenuItem.Image = Properties.Resources._018_数据;
            导出Excel报表EToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            导出Excel报表EToolStripMenuItem.Name = "导出Excel报表EToolStripMenuItem";
            导出Excel报表EToolStripMenuItem.Size = new Size(284, 36);
            导出Excel报表EToolStripMenuItem.Text = "导出Excel报表(&E)";
            导出Excel报表EToolStripMenuItem.Click += 导出Excel报表EToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btn_chaxunSingle);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(33, 77);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1406, 594);
            panel1.TabIndex = 16;
            // 
            // House_chaxun
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 708);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("楷体", 14F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "House_chaxun";
            Text = "房屋管理";
            WindowState = FormWindowState.Maximized;
            Load += House_chaxun_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button btn_chaxunSingle;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 新建ToolStripMenuItem;
        private ToolStripMenuItem 修改ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem 导出Excel报表EToolStripMenuItem;
    }
}