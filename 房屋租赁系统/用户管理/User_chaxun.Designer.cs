namespace 房屋租赁系统
{
    partial class User_chaxun
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
            dataGridView1 = new DataGridView();
            uName1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uPwd1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uPvw1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            btn_chaxunSingle = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            新建ToolStripMenuItem = new ToolStripMenuItem();
            修改ToolStripMenuItem = new ToolStripMenuItem();
            删除ToolStripMenuItem = new ToolStripMenuItem();
            导出Excel报表EToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { uName1DataGridViewTextBoxColumn, uPwd1DataGridViewTextBoxColumn, uPvw1DataGridViewTextBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(23, 132);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1115, 400);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // uName1DataGridViewTextBoxColumn
            // 
            uName1DataGridViewTextBoxColumn.DataPropertyName = "UName1";
            uName1DataGridViewTextBoxColumn.HeaderText = "UName1";
            uName1DataGridViewTextBoxColumn.MinimumWidth = 8;
            uName1DataGridViewTextBoxColumn.Name = "uName1DataGridViewTextBoxColumn";
            uName1DataGridViewTextBoxColumn.ReadOnly = true;
            uName1DataGridViewTextBoxColumn.Width = 150;
            // 
            // uPwd1DataGridViewTextBoxColumn
            // 
            uPwd1DataGridViewTextBoxColumn.DataPropertyName = "UPwd1";
            uPwd1DataGridViewTextBoxColumn.HeaderText = "UPwd1";
            uPwd1DataGridViewTextBoxColumn.MinimumWidth = 8;
            uPwd1DataGridViewTextBoxColumn.Name = "uPwd1DataGridViewTextBoxColumn";
            uPwd1DataGridViewTextBoxColumn.ReadOnly = true;
            uPwd1DataGridViewTextBoxColumn.Width = 150;
            // 
            // uPvw1DataGridViewTextBoxColumn
            // 
            uPvw1DataGridViewTextBoxColumn.DataPropertyName = "UPvw1";
            uPvw1DataGridViewTextBoxColumn.HeaderText = "UPvw1";
            uPvw1DataGridViewTextBoxColumn.MinimumWidth = 8;
            uPvw1DataGridViewTextBoxColumn.Name = "uPvw1DataGridViewTextBoxColumn";
            uPvw1DataGridViewTextBoxColumn.ReadOnly = true;
            uPvw1DataGridViewTextBoxColumn.Width = 150;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // btn_chaxunSingle
            // 
            btn_chaxunSingle.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_chaxunSingle.Image = Properties.Resources._018_搜索;
            btn_chaxunSingle.Location = new Point(905, 19);
            btn_chaxunSingle.Margin = new Padding(4);
            btn_chaxunSingle.Name = "btn_chaxunSingle";
            btn_chaxunSingle.Size = new Size(116, 80);
            btn_chaxunSingle.TabIndex = 1;
            btn_chaxunSingle.Text = "查询";
            btn_chaxunSingle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_chaxunSingle.UseVisualStyleBackColor = true;
            btn_chaxunSingle.Click += btn_chaxunSingle_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("楷体", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "不筛选", "用户名", "用户权限" });
            comboBox1.Location = new Point(213, 41);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 36);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 14F);
            label1.Location = new Point(24, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 3;
            label1.Text = "查询条件:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(500, 41);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 39);
            textBox1.TabIndex = 4;
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
            menuStrip1.Size = new Size(1238, 40);
            menuStrip1.TabIndex = 5;
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
            panel1.Location = new Point(23, 72);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 555);
            panel1.TabIndex = 6;
            // 
            // User_chaxun
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 651);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("楷体", 14F);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "User_chaxun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "用户查询";
            WindowState = FormWindowState.Maximized;
            Load += User_chaxun_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn uName1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uPwd1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uPvw1DataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private Button btn_chaxunSingle;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 新建ToolStripMenuItem;
        private ToolStripMenuItem 修改ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem 导出Excel报表EToolStripMenuItem;
    }
}