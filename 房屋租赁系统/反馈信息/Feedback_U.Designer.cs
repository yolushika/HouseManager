namespace 房屋租赁系统
{
    partial class Feedback_U
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
            rtxt_Feedback = new RichTextBox();
            ckb_niming = new CheckBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rtxt_Feedback
            // 
            rtxt_Feedback.Location = new Point(30, 33);
            rtxt_Feedback.Name = "rtxt_Feedback";
            rtxt_Feedback.Size = new Size(907, 389);
            rtxt_Feedback.TabIndex = 1;
            rtxt_Feedback.Text = "";
            // 
            // ckb_niming
            // 
            ckb_niming.AutoSize = true;
            ckb_niming.Font = new Font("楷体", 12F);
            ckb_niming.Location = new Point(672, 585);
            ckb_niming.Name = "ckb_niming";
            ckb_niming.Size = new Size(132, 28);
            ckb_niming.TabIndex = 2;
            ckb_niming.Text = "匿名提交";
            ckb_niming.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 14F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = Properties.Resources._018_确认;
            button1.Location = new Point(828, 585);
            button1.Name = "button1";
            button1.Size = new Size(131, 49);
            button1.TabIndex = 3;
            button1.Text = "提交";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("楷体", 14F);
            radioButton1.Location = new Point(247, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(289, 32);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "操作体验和功能建议";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("楷体", 14F);
            radioButton2.Location = new Point(13, 35);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(163, 32);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "系统有bug";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("楷体", 14F);
            radioButton3.Location = new Point(13, 111);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(233, 32);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "信息更新有延迟";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("楷体", 14F);
            radioButton4.Location = new Point(13, 73);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(177, 32);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.Text = "投诉与举报";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("楷体", 14F);
            radioButton5.Location = new Point(247, 77);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(93, 32);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "其它";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(22, 464);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 158);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "反馈类型";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtxt_Feedback);
            groupBox2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(22, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(973, 440);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "反馈内容";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(ckb_niming);
            panel1.Location = new Point(13, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 649);
            panel1.TabIndex = 11;
            // 
            // Feedback_U
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 796);
            Controls.Add(panel1);
            Name = "Feedback_U";
            Text = "我要反馈";
            WindowState = FormWindowState.Maximized;
            Load += Feedback_U_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtxt_Feedback;
        private CheckBox ckb_niming;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
    }
}