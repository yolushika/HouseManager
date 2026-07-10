namespace 房屋租赁系统
{
    partial class Feedback_A
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
            dataGridView1 = new DataGridView();
            rtxt_content = new RichTextBox();
            txt_Funame = new TextBox();
            txt_date = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_check = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            导出Excel报表EToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(100, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1223, 422);
            dataGridView1.TabIndex = 0;
            // 
            // rtxt_content
            // 
            rtxt_content.Font = new Font("楷体", 18F);
            rtxt_content.Location = new Point(558, 89);
            rtxt_content.Name = "rtxt_content";
            rtxt_content.ReadOnly = true;
            rtxt_content.Size = new Size(922, 205);
            rtxt_content.TabIndex = 1;
            rtxt_content.Text = "";
            // 
            // txt_Funame
            // 
            txt_Funame.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_Funame.Location = new Point(235, 36);
            txt_Funame.Name = "txt_Funame";
            txt_Funame.ReadOnly = true;
            txt_Funame.Size = new Size(281, 30);
            txt_Funame.TabIndex = 2;
            // 
            // txt_date
            // 
            txt_date.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_date.Location = new Point(235, 100);
            txt_date.Name = "txt_date";
            txt_date.ReadOnly = true;
            txt_date.Size = new Size(281, 30);
            txt_date.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 14F);
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 4;
            label1.Text = "反 馈 人：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 14F);
            label2.Location = new Point(3, 93);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 5;
            label2.Text = "反馈时间：";
            // 
            // btn_check
            // 
            btn_check.Font = new Font("楷体", 14F);
            btn_check.Location = new Point(1370, 50);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(219, 85);
            btn_check.TabIndex = 6;
            btn_check.Text = "查看具体反馈";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 14F);
            label3.Location = new Point(558, 34);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 7;
            label3.Text = "反馈内容:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_date);
            groupBox1.Controls.Add(txt_Funame);
            groupBox1.Controls.Add(rtxt_content);
            groupBox1.Font = new Font("楷体", 10F);
            groupBox1.Location = new Point(45, 534);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1598, 320);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "反馈内容";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btn_check);
            panel1.Controls.Add(dataGridView1);
            panel1.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            panel1.Location = new Point(14, 123);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1734, 888);
            panel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 导出Excel报表EToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1784, 40);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // 导出Excel报表EToolStripMenuItem
            // 
            导出Excel报表EToolStripMenuItem.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            导出Excel报表EToolStripMenuItem.Image = Properties.Resources._018_数据;
            导出Excel报表EToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            导出Excel报表EToolStripMenuItem.Name = "导出Excel报表EToolStripMenuItem";
            导出Excel报表EToolStripMenuItem.Size = new Size(284, 36);
            导出Excel报表EToolStripMenuItem.Text = "导出Excel报表(&E)";
            导出Excel报表EToolStripMenuItem.Click += 导出Excel报表EToolStripMenuItem_Click;
            // 
            // Feedback_A
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 999);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("楷体", 14F);
            MainMenuStrip = menuStrip1;
            Name = "Feedback_A";
            Text = "Feedback_A";
            WindowState = FormWindowState.Maximized;
            Load += Feedback_A_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RichTextBox rtxt_content;
        private TextBox txt_Funame;
        private TextBox txt_date;
        private Label label1;
        private Label label2;
        private Button btn_check;
        private Label label3;
        private GroupBox groupBox1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 导出Excel报表EToolStripMenuItem;
    }
}