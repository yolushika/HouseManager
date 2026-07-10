namespace 房屋租赁系统
{
    partial class ChangeUserInfo
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
            label6 = new Label();
            txt_Uno = new TextBox();
            button2 = new Button();
            button1 = new Button();
            txt_Upwd = new TextBox();
            label3 = new Label();
            txt_UpwdAgain = new TextBox();
            label2 = new Label();
            txt_User = new TextBox();
            label1 = new Label();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("楷体", 18F);
            label6.Location = new Point(44, 72);
            label6.Name = "label6";
            label6.Size = new Size(195, 36);
            label6.TabIndex = 39;
            label6.Text = "用户编号：";
            // 
            // txt_Uno
            // 
            txt_Uno.Location = new Point(298, 78);
            txt_Uno.Name = "txt_Uno";
            txt_Uno.ReadOnly = true;
            txt_Uno.Size = new Size(452, 30);
            txt_Uno.TabIndex = 38;
            // 
            // button2
            // 
            button2.Font = new Font("楷体", 18F);
            button2.Image = Properties.Resources._018_取消;
            button2.Location = new Point(440, 424);
            button2.Name = "button2";
            button2.Size = new Size(204, 69);
            button2.TabIndex = 37;
            button2.Text = "取消修改";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 18F);
            button1.Image = Properties.Resources._018_确认;
            button1.Location = new Point(171, 424);
            button1.Name = "button1";
            button1.Size = new Size(208, 69);
            button1.TabIndex = 36;
            button1.Text = "确认修改";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_Upwd
            // 
            txt_Upwd.Location = new Point(298, 205);
            txt_Upwd.Name = "txt_Upwd";
            txt_Upwd.Size = new Size(452, 30);
            txt_Upwd.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 18F);
            label3.Location = new Point(44, 205);
            label3.Name = "label3";
            label3.Size = new Size(195, 36);
            label3.TabIndex = 30;
            label3.Text = "用户密码：";
            // 
            // txt_UpwdAgain
            // 
            txt_UpwdAgain.Location = new Point(298, 276);
            txt_UpwdAgain.Name = "txt_UpwdAgain";
            txt_UpwdAgain.Size = new Size(452, 30);
            txt_UpwdAgain.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 18F);
            label2.Location = new Point(44, 267);
            label2.Name = "label2";
            label2.Size = new Size(195, 36);
            label2.TabIndex = 28;
            label2.Text = "确认密码：";
            // 
            // txt_User
            // 
            txt_User.Location = new Point(298, 140);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(452, 30);
            txt_User.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 18F);
            label1.Location = new Point(44, 140);
            label1.Name = "label1";
            label1.Size = new Size(195, 36);
            label1.TabIndex = 26;
            label1.Text = "用 户 名：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(44, 331);
            label5.Name = "label5";
            label5.Size = new Size(195, 36);
            label5.TabIndex = 42;
            label5.Text = "权    限：";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("楷体", 18F);
            radioButton2.Location = new Point(544, 331);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(148, 40);
            radioButton2.TabIndex = 41;
            radioButton2.TabStop = true;
            radioButton2.Text = "管理员";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("楷体", 18F);
            radioButton1.Location = new Point(339, 331);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(184, 40);
            radioButton1.TabIndex = 40;
            radioButton1.TabStop = true;
            radioButton1.Text = "普通用户";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // ChangeUserInfo
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(label5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(txt_Uno);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_Upwd);
            Controls.Add(label3);
            Controls.Add(txt_UpwdAgain);
            Controls.Add(label2);
            Controls.Add(txt_User);
            Controls.Add(label1);
            Name = "ChangeUserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "用户信息修改";
            Load += ChangeUserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txt_Uno;
        private Button button2;
        private Button button1;
        private TextBox txt_Upwd;
        private Label label3;
        private TextBox txt_UpwdAgain;
        private Label label2;
        private TextBox txt_User;
        private Label label1;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}