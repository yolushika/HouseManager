namespace 房屋租赁系统
{
    partial class My_dingdan
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
            btn_tuizu = new Button();
            dtp_ReturnDate = new DateTimePicker();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txt_realRdays = new TextBox();
            txt_Rdays = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            导出Excel报表EToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 10);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1460, 614);
            dataGridView1.TabIndex = 0;
            // 
            // btn_tuizu
            // 
            btn_tuizu.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_tuizu.Location = new Point(1334, 690);
            btn_tuizu.Margin = new Padding(4);
            btn_tuizu.Name = "btn_tuizu";
            btn_tuizu.Size = new Size(149, 74);
            btn_tuizu.TabIndex = 1;
            btn_tuizu.Text = "退租";
            btn_tuizu.UseVisualStyleBackColor = true;
            btn_tuizu.Click += btn_tuizu_Click;
            // 
            // dtp_ReturnDate
            // 
            dtp_ReturnDate.Location = new Point(354, 36);
            dtp_ReturnDate.Margin = new Padding(4);
            dtp_ReturnDate.Name = "dtp_ReturnDate";
            dtp_ReturnDate.Size = new Size(381, 39);
            dtp_ReturnDate.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btn_tuizu);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(13, 68);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 877);
            panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_realRdays);
            groupBox1.Controls.Add(txt_Rdays);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtp_ReturnDate);
            groupBox1.Location = new Point(23, 654);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(771, 204);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "时间结算";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 14F);
            label3.Location = new Point(50, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 7;
            label3.Text = "实际租住时长：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 14F);
            label2.Location = new Point(50, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 6;
            label2.Text = "预期租住时长：";
            // 
            // txt_realRdays
            // 
            txt_realRdays.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_realRdays.Location = new Point(354, 155);
            txt_realRdays.Margin = new Padding(4);
            txt_realRdays.Name = "txt_realRdays";
            txt_realRdays.Size = new Size(190, 30);
            txt_realRdays.TabIndex = 5;
            // 
            // txt_Rdays
            // 
            txt_Rdays.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_Rdays.Location = new Point(354, 99);
            txt_Rdays.Margin = new Padding(4);
            txt_Rdays.Name = "txt_Rdays";
            txt_Rdays.Size = new Size(190, 30);
            txt_Rdays.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 14F);
            label1.Location = new Point(14, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 28);
            label1.TabIndex = 3;
            label1.Text = "选择退租的日期：";
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 导出Excel报表EToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1535, 40);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            // My_dingdan
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 974);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "My_dingdan";
            Text = "我的订单";
            WindowState = FormWindowState.Maximized;
            Load += My_dingdan_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_tuizu;
        private DateTimePicker dtp_ReturnDate;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox txt_realRdays;
        private TextBox txt_Rdays;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 导出Excel报表EToolStripMenuItem;
    }
}