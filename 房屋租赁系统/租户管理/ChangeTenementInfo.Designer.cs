namespace 房屋租赁系统
{
    partial class ChangeTenementInfo
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
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            txt_tTel = new TextBox();
            button2 = new Button();
            button1 = new Button();
            txt_tAge = new TextBox();
            label3 = new Label();
            txt_tUname = new TextBox();
            label2 = new Label();
            txt_tName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(47, 284);
            label5.Name = "label5";
            label5.Size = new Size(195, 36);
            label5.TabIndex = 55;
            label5.Text = "性    别：";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("楷体", 18F);
            radioButton2.Location = new Point(576, 282);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 40);
            radioButton2.TabIndex = 54;
            radioButton2.TabStop = true;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("楷体", 18F);
            radioButton1.Location = new Point(371, 282);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 40);
            radioButton1.TabIndex = 53;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("楷体", 18F);
            label6.Location = new Point(47, 86);
            label6.Name = "label6";
            label6.Size = new Size(195, 36);
            label6.TabIndex = 52;
            label6.Text = "电话号码：";
            // 
            // txt_tTel
            // 
            txt_tTel.Location = new Point(301, 92);
            txt_tTel.Name = "txt_tTel";
            txt_tTel.Size = new Size(452, 30);
            txt_tTel.TabIndex = 51;
            // 
            // button2
            // 
            button2.Font = new Font("楷体", 18F);
            button2.Image = Properties.Resources._018_取消;
            button2.Location = new Point(438, 438);
            button2.Name = "button2";
            button2.Size = new Size(200, 67);
            button2.TabIndex = 50;
            button2.Text = "取消修改";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 18F);
            button1.Image = Properties.Resources._018_确认;
            button1.Location = new Point(147, 438);
            button1.Name = "button1";
            button1.Size = new Size(201, 67);
            button1.TabIndex = 49;
            button1.Text = "确认修改";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_tAge
            // 
            txt_tAge.Location = new Point(301, 219);
            txt_tAge.Name = "txt_tAge";
            txt_tAge.Size = new Size(452, 30);
            txt_tAge.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 18F);
            label3.Location = new Point(47, 219);
            label3.Name = "label3";
            label3.Size = new Size(195, 36);
            label3.TabIndex = 47;
            label3.Text = "年    龄：";
            // 
            // txt_tUname
            // 
            txt_tUname.Location = new Point(301, 352);
            txt_tUname.Name = "txt_tUname";
            txt_tUname.Size = new Size(452, 30);
            txt_tUname.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 18F);
            label2.Location = new Point(47, 343);
            label2.Name = "label2";
            label2.Size = new Size(195, 36);
            label2.TabIndex = 45;
            label2.Text = "用 户 名：";
            // 
            // txt_tName
            // 
            txt_tName.Location = new Point(301, 154);
            txt_tName.Name = "txt_tName";
            txt_tName.Size = new Size(452, 30);
            txt_tName.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 18F);
            label1.Location = new Point(47, 154);
            label1.Name = "label1";
            label1.Size = new Size(195, 36);
            label1.TabIndex = 43;
            label1.Text = "姓    名：";
            // 
            // ChangeTenementInfo
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(txt_tTel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_tAge);
            Controls.Add(label3);
            Controls.Add(txt_tUname);
            Controls.Add(label2);
            Controls.Add(txt_tName);
            Controls.Add(label1);
            Name = "ChangeTenementInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "租户信息修改";
            Load += ChangeTenementInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private TextBox txt_tTel;
        private Button button2;
        private Button button1;
        private TextBox txt_tAge;
        private Label label3;
        private TextBox txt_tUname;
        private Label label2;
        private TextBox txt_tName;
        private Label label1;
    }
}