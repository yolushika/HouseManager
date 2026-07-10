namespace 房屋租赁系统
{
    partial class Category_chaxun
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
            删除ToolStripMenuItem = new ToolStripMenuItem();
            导出Excel报表EToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            txt_New = new TextBox();
            btn_New = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            修改CToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 57);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 39);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 14F);
            label1.Location = new Point(68, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 19;
            label1.Text = "查询条件:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("楷体", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "不筛选", "类型编号", "房屋类型" });
            comboBox1.Location = new Point(303, 135);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 36);
            comboBox1.TabIndex = 18;
            // 
            // btn_chaxunSingle
            // 
            btn_chaxunSingle.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_chaxunSingle.Image = Properties.Resources._018_搜索;
            btn_chaxunSingle.Location = new Point(561, 57);
            btn_chaxunSingle.Margin = new Padding(4);
            btn_chaxunSingle.Name = "btn_chaxunSingle";
            btn_chaxunSingle.Size = new Size(116, 54);
            btn_chaxunSingle.TabIndex = 17;
            btn_chaxunSingle.Text = "查询";
            btn_chaxunSingle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_chaxunSingle.UseVisualStyleBackColor = true;
            btn_chaxunSingle.Click += btn_chaxunSingle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 26);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(504, 569);
            dataGridView1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.Font = new Font("楷体", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 删除ToolStripMenuItem, 修改CToolStripMenuItem, 导出Excel报表EToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1440, 40);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Font = new Font("楷体", 14F);
            删除ToolStripMenuItem.Image = Properties.Resources._018_垃圾桶;
            删除ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(158, 36);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(64, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 2;
            label2.Text = "类型名称：";
            // 
            // txt_New
            // 
            txt_New.Location = new Point(317, 68);
            txt_New.Margin = new Padding(4);
            txt_New.Name = "txt_New";
            txt_New.Size = new Size(294, 39);
            txt_New.TabIndex = 1;
            // 
            // btn_New
            // 
            btn_New.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_New.Image = Properties.Resources._018_添加;
            btn_New.Location = new Point(561, 163);
            btn_New.Margin = new Padding(4);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(116, 58);
            btn_New.TabIndex = 0;
            btn_New.Text = "新建";
            btn_New.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_New.UseVisualStyleBackColor = true;
            btn_New.Click += btn_New_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_New);
            groupBox1.Controls.Add(btn_New);
            groupBox1.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(561, 342);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(685, 239);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "新建类型";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(40, 56);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1286, 615);
            panel1.TabIndex = 24;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(btn_chaxunSingle);
            groupBox2.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(561, 57);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(685, 239);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "查询类型";
            // 
            // 修改CToolStripMenuItem
            // 
            修改CToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            修改CToolStripMenuItem.Image = Properties.Resources._018_编辑;
            修改CToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            修改CToolStripMenuItem.Name = "修改CToolStripMenuItem";
            修改CToolStripMenuItem.Size = new Size(196, 36);
            修改CToolStripMenuItem.Text = "修改（&C）";
            修改CToolStripMenuItem.Click += 修改CToolStripMenuItem_Click;
            // 
            // Category_chaxun
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 695);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("楷体", 14F);
            Margin = new Padding(4);
            Name = "Category_chaxun";
            Text = "房屋类型管理";
            WindowState = FormWindowState.Maximized;
            Load += Category_chaxun_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private Button btn_New;
        private Label label2;
        private TextBox txt_New;
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox2;
        private ToolStripMenuItem 导出Excel报表EToolStripMenuItem;
        private ToolStripMenuItem 修改CToolStripMenuItem;
    }
}