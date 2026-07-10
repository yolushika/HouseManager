namespace 房屋租赁系统
{
    partial class User_New
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
            txtUser = new TextBox();
            label1 = new Label();
            btn_ShowPwd = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            txtPwdAgain = new TextBox();
            txtPwd = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(314, 98);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(347, 30);
            txtUser.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(91, 92);
            label1.Name = "label1";
            label1.Size = new Size(195, 36);
            label1.TabIndex = 6;
            label1.Text = "新用户名：";
            // 
            // btn_ShowPwd
            // 
            btn_ShowPwd.FlatStyle = FlatStyle.Popup;
            btn_ShowPwd.Image = Properties.Resources.隐藏1;
            btn_ShowPwd.Location = new Point(709, 248);
            btn_ShowPwd.Name = "btn_ShowPwd";
            btn_ShowPwd.Size = new Size(50, 30);
            btn_ShowPwd.TabIndex = 24;
            btn_ShowPwd.UseVisualStyleBackColor = true;
            btn_ShowPwd.Click += btn_ShowPwd_Click;
            btn_ShowPwd.MouseDown += button_ShowPwd_MouseDown;
            btn_ShowPwd.MouseUp += button_ShowPwd_MouseUp;
            // 
            // button2
            // 
            button2.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Image = Properties.Resources._018_取消;
            button2.Location = new Point(452, 393);
            button2.Name = "button2";
            button2.Size = new Size(141, 55);
            button2.TabIndex = 23;
            button2.Text = "返回";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Image = Properties.Resources._018_确认;
            button1.Location = new Point(162, 393);
            button1.Name = "button1";
            button1.Size = new Size(137, 55);
            button1.TabIndex = 22;
            button1.Text = "确认";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(91, 315);
            label7.Name = "label7";
            label7.Size = new Size(195, 36);
            label7.TabIndex = 21;
            label7.Text = "确认密码：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(91, 242);
            label6.Name = "label6";
            label6.Size = new Size(195, 36);
            label6.TabIndex = 20;
            label6.Text = "密    码：";
            // 
            // txtPwdAgain
            // 
            txtPwdAgain.Location = new Point(314, 321);
            txtPwdAgain.Name = "txtPwdAgain";
            txtPwdAgain.PasswordChar = '*';
            txtPwdAgain.Size = new Size(347, 30);
            txtPwdAgain.TabIndex = 19;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(314, 248);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(347, 30);
            txtPwd.TabIndex = 18;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("楷体", 18F);
            radioButton1.Location = new Point(308, 170);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(184, 40);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "普通用户";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("楷体", 18F);
            radioButton2.Location = new Point(513, 170);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(148, 40);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "管理员";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(91, 170);
            label2.Name = "label2";
            label2.Size = new Size(195, 36);
            label2.TabIndex = 27;
            label2.Text = "权    限：";
            // 
            // User_New
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btn_ShowPwd);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPwdAgain);
            Controls.Add(txtPwd);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Name = "User_New";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "新建用户信息";
            Load += User_New_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label label1;
        private Button btn_ShowPwd;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label6;
        private TextBox txtPwdAgain;
        private TextBox txtPwd;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
    }
}