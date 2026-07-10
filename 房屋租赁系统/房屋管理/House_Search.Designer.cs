namespace 房屋租赁系统
{
    partial class House_Search
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
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btn_chaxunSingle = new Button();
            txt_RTel = new TextBox();
            txt_RName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_RId = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dtp_Age = new DateTimePicker();
            label8 = new Label();
            txt_Radd = new TextBox();
            label9 = new Label();
            txt_Rcategory = new TextBox();
            rtb_RNote = new RichTextBox();
            label10 = new Label();
            label13 = new Label();
            txt_Rdays = new TextBox();
            btn_Choose = new Button();
            btn_Confirm = new Button();
            btn_Return = new Button();
            label2 = new Label();
            txt_rent = new TextBox();
            panel1 = new Panel();
            dtp_StartDate = new DateTimePicker();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 167);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1429, 463);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 20);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 39);
            textBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 14F);
            label1.Location = new Point(60, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 17;
            label1.Text = "查询条件:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("楷体", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "不筛选", "房屋编号", "具体地址", "房屋面积", "房屋楼层", "月租金", "房屋类型", "房间数" });
            comboBox1.Location = new Point(285, 81);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 36);
            comboBox1.TabIndex = 16;
            // 
            // btn_chaxunSingle
            // 
            btn_chaxunSingle.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_chaxunSingle.Image = Properties.Resources._018_搜索;
            btn_chaxunSingle.Location = new Point(706, 79);
            btn_chaxunSingle.Margin = new Padding(4);
            btn_chaxunSingle.Name = "btn_chaxunSingle";
            btn_chaxunSingle.Size = new Size(116, 80);
            btn_chaxunSingle.TabIndex = 15;
            btn_chaxunSingle.Text = "查询";
            btn_chaxunSingle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_chaxunSingle.UseVisualStyleBackColor = true;
            btn_chaxunSingle.Click += btn_chaxunSingle_Click;
            // 
            // txt_RTel
            // 
            txt_RTel.Font = new Font("Microsoft YaHei UI", 9F);
            txt_RTel.Location = new Point(956, 114);
            txt_RTel.Margin = new Padding(4);
            txt_RTel.Name = "txt_RTel";
            txt_RTel.Size = new Size(446, 30);
            txt_RTel.TabIndex = 40;
            // 
            // txt_RName
            // 
            txt_RName.Font = new Font("Microsoft YaHei UI", 9F);
            txt_RName.Location = new Point(956, 51);
            txt_RName.Margin = new Padding(4);
            txt_RName.Name = "txt_RName";
            txt_RName.Size = new Size(446, 30);
            txt_RName.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("楷体", 14F);
            label5.Location = new Point(745, 240);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 35;
            label5.Text = "性    别：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("楷体", 14F);
            label4.Location = new Point(742, 181);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 34;
            label4.Text = "出生年月：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 14F);
            label3.Location = new Point(745, 114);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 33;
            label3.Text = "电话号码：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("楷体", 14F);
            label6.Location = new Point(742, 54);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 32;
            label6.Text = "姓    名：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("楷体", 14F);
            label7.Location = new Point(4, 261);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(152, 28);
            label7.TabIndex = 43;
            label7.Text = "身份证号：";
            // 
            // txt_RId
            // 
            txt_RId.Font = new Font("Microsoft YaHei UI", 9F);
            txt_RId.Location = new Point(214, 259);
            txt_RId.Margin = new Padding(4);
            txt_RId.Name = "txt_RId";
            txt_RId.Size = new Size(446, 30);
            txt_RId.TabIndex = 44;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("华文行楷", 14F);
            radioButton2.Location = new Point(1221, 241);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 33);
            radioButton2.TabIndex = 47;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("华文行楷", 14F);
            radioButton1.Location = new Point(1049, 241);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(66, 33);
            radioButton1.TabIndex = 46;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dtp_Age
            // 
            dtp_Age.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtp_Age.Location = new Point(956, 178);
            dtp_Age.Margin = new Padding(4);
            dtp_Age.Name = "dtp_Age";
            dtp_Age.Size = new Size(446, 30);
            dtp_Age.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("楷体", 14F);
            label8.Location = new Point(5, 86);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 50;
            label8.Text = "房屋楼层：";
            // 
            // txt_Radd
            // 
            txt_Radd.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_Radd.Location = new Point(219, 22);
            txt_Radd.Margin = new Padding(4);
            txt_Radd.Name = "txt_Radd";
            txt_Radd.ReadOnly = true;
            txt_Radd.Size = new Size(441, 30);
            txt_Radd.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("楷体", 14F);
            label9.Location = new Point(5, 24);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(152, 28);
            label9.TabIndex = 48;
            label9.Text = "所在小区：";
            // 
            // txt_Rcategory
            // 
            txt_Rcategory.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_Rcategory.Location = new Point(221, 84);
            txt_Rcategory.Margin = new Padding(4);
            txt_Rcategory.Name = "txt_Rcategory";
            txt_Rcategory.ReadOnly = true;
            txt_Rcategory.Size = new Size(438, 30);
            txt_Rcategory.TabIndex = 53;
            // 
            // rtb_RNote
            // 
            rtb_RNote.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rtb_RNote.Location = new Point(23, 368);
            rtb_RNote.Margin = new Padding(4);
            rtb_RNote.Name = "rtb_RNote";
            rtb_RNote.Size = new Size(714, 162);
            rtb_RNote.TabIndex = 54;
            rtb_RNote.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label10.Location = new Point(6, 316);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(180, 28);
            label10.TabIndex = 55;
            label10.Text = "备注(选填)：";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("楷体", 14F);
            label13.Location = new Point(5, 202);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(194, 28);
            label13.TabIndex = 58;
            label13.Text = "租住时间/月：";
            // 
            // txt_Rdays
            // 
            txt_Rdays.Font = new Font("Microsoft YaHei UI", 9F);
            txt_Rdays.Location = new Point(288, 201);
            txt_Rdays.Margin = new Padding(4);
            txt_Rdays.Name = "txt_Rdays";
            txt_Rdays.Size = new Size(372, 30);
            txt_Rdays.TabIndex = 59;
            // 
            // btn_Choose
            // 
            btn_Choose.Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_Choose.Image = Properties.Resources._018_确认;
            btn_Choose.Location = new Point(1316, 97);
            btn_Choose.Margin = new Padding(4);
            btn_Choose.Name = "btn_Choose";
            btn_Choose.Size = new Size(187, 63);
            btn_Choose.TabIndex = 61;
            btn_Choose.Text = "确认选房";
            btn_Choose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Choose.UseVisualStyleBackColor = true;
            btn_Choose.Click += btn_Choose_Click;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Font = new Font("楷体", 14F);
            btn_Confirm.Location = new Point(760, 448);
            btn_Confirm.Margin = new Padding(4);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(187, 63);
            btn_Confirm.TabIndex = 62;
            btn_Confirm.Text = "提交订单";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // btn_Return
            // 
            btn_Return.Font = new Font("楷体", 14F);
            btn_Return.Location = new Point(975, 448);
            btn_Return.Margin = new Padding(4);
            btn_Return.Name = "btn_Return";
            btn_Return.Size = new Size(187, 63);
            btn_Return.TabIndex = 63;
            btn_Return.Text = "我再想想";
            btn_Return.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 14F);
            label2.Location = new Point(5, 142);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 64;
            label2.Text = "月 租 金：";
            // 
            // txt_rent
            // 
            txt_rent.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txt_rent.Location = new Point(221, 145);
            txt_rent.Margin = new Padding(4);
            txt_rent.Name = "txt_rent";
            txt_rent.ReadOnly = true;
            txt_rent.Size = new Size(438, 30);
            txt_rent.TabIndex = 65;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtp_StartDate);
            panel1.Controls.Add(txt_rent);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_Return);
            panel1.Controls.Add(btn_Confirm);
            panel1.Controls.Add(txt_Rdays);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(rtb_RNote);
            panel1.Controls.Add(txt_Rcategory);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_Radd);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(dtp_Age);
            panel1.Controls.Add(txt_RId);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_RTel);
            panel1.Controls.Add(txt_RName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(74, 698);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1429, 629);
            panel1.TabIndex = 67;
            // 
            // dtp_StartDate
            // 
            dtp_StartDate.Location = new Point(23, 537);
            dtp_StartDate.Margin = new Padding(4);
            dtp_StartDate.Name = "dtp_StartDate";
            dtp_StartDate.Size = new Size(381, 39);
            dtp_StartDate.TabIndex = 66;
            dtp_StartDate.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_Choose);
            panel2.Controls.Add(btn_chaxunSingle);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(15, 14);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1840, 1382);
            panel2.TabIndex = 68;
            // 
            // House_Search
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1866, 1410);
            Controls.Add(panel2);
            Font = new Font("楷体", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(4);
            Name = "House_Search";
            Text = "寻找房屋";
            WindowState = FormWindowState.Maximized;
            Load += House_Search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Button btn_chaxunSingle;
        private TextBox txt_RTel;
        private TextBox txt_RName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private TextBox txt_RId;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dtp_Age;
        private Label label8;
        private TextBox txt_Radd;
        private Label label9;
        private TextBox txt_Rcategory;
        private RichTextBox rtb_RNote;
        private Label label10;
        private Label label13;
        private TextBox txt_Rdays;
        private Button btn_Choose;
        private Button btn_Confirm;
        private Button btn_Return;
        private Label label2;
        private TextBox txt_rent;
        private Panel panel1;
        private Panel panel2;
        private DateTimePicker dtp_StartDate;
    }
}