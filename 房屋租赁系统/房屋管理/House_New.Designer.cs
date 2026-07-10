namespace 房屋租赁系统
{
    partial class House_New
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
            label1 = new Label();
            txt_Hname = new TextBox();
            label2 = new Label();
            txt_Hfloor = new TextBox();
            label3 = new Label();
            txt_Haera = new TextBox();
            txt_Hrent = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_Hcount = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 18F);
            label1.Location = new Point(97, 66);
            label1.Name = "label1";
            label1.Size = new Size(195, 36);
            label1.TabIndex = 0;
            label1.Text = "具体地址：";
            // 
            // txt_Hname
            // 
            txt_Hname.Location = new Point(383, 75);
            txt_Hname.Name = "txt_Hname";
            txt_Hname.Size = new Size(452, 30);
            txt_Hname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 18F);
            label2.Location = new Point(97, 193);
            label2.Name = "label2";
            label2.Size = new Size(195, 36);
            label2.TabIndex = 2;
            label2.Text = "房屋楼层：";
            // 
            // txt_Hfloor
            // 
            txt_Hfloor.Location = new Point(383, 202);
            txt_Hfloor.Name = "txt_Hfloor";
            txt_Hfloor.Size = new Size(452, 30);
            txt_Hfloor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 18F);
            label3.Location = new Point(97, 129);
            label3.Name = "label3";
            label3.Size = new Size(195, 36);
            label3.TabIndex = 4;
            label3.Text = "房屋面积：";
            // 
            // txt_Haera
            // 
            txt_Haera.Location = new Point(383, 138);
            txt_Haera.Name = "txt_Haera";
            txt_Haera.Size = new Size(452, 30);
            txt_Haera.TabIndex = 5;
            // 
            // txt_Hrent
            // 
            txt_Hrent.Location = new Point(383, 267);
            txt_Hrent.Name = "txt_Hrent";
            txt_Hrent.Size = new Size(452, 30);
            txt_Hrent.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("楷体", 18F);
            label4.Location = new Point(97, 258);
            label4.Name = "label4";
            label4.Size = new Size(195, 36);
            label4.TabIndex = 7;
            label4.Text = "月 租 金：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("楷体", 18F);
            label5.Location = new Point(95, 327);
            label5.Name = "label5";
            label5.Size = new Size(195, 36);
            label5.TabIndex = 8;
            label5.Text = "房 间 数：";
            // 
            // txt_Hcount
            // 
            txt_Hcount.Location = new Point(383, 336);
            txt_Hcount.Name = "txt_Hcount";
            txt_Hcount.Size = new Size(452, 30);
            txt_Hcount.TabIndex = 9;
            txt_Hcount.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 18F);
            button1.Image = Properties.Resources._018_确认;
            button1.Location = new Point(168, 474);
            button1.Name = "button1";
            button1.Size = new Size(233, 64);
            button1.TabIndex = 10;
            button1.Text = "确认新建";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("楷体", 18F);
            button2.Image = Properties.Resources._018_取消;
            button2.Location = new Point(485, 474);
            button2.Name = "button2";
            button2.Size = new Size(231, 64);
            button2.TabIndex = 11;
            button2.Text = "取消新建";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(97, 399);
            label6.Name = "label6";
            label6.Size = new Size(195, 36);
            label6.TabIndex = 12;
            label6.Text = "房屋类型：";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(383, 403);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(452, 32);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // House_New
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 572);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_Hcount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_Hrent);
            Controls.Add(txt_Haera);
            Controls.Add(label3);
            Controls.Add(txt_Hfloor);
            Controls.Add(label2);
            Controls.Add(txt_Hname);
            Controls.Add(label1);
            Name = "House_New";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "新建房屋信息";
            Load += House_New_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Hname;
        private Label label2;
        private TextBox txt_Hfloor;
        private Label label3;
        private TextBox txt_Haera;
        private TextBox txt_Hrent;
        private Label label4;
        private Label label5;
        private TextBox txt_Hcount;
        private Button button1;
        private Button button2;
        private Label label6;
        private ComboBox comboBox1;
    }
}