namespace 房屋租赁系统
{
    partial class User_zhuce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_zhuce));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUser = new TextBox();
            txtName = new TextBox();
            txtPwd = new TextBox();
            txtPwdAgain = new TextBox();
            dtpAge = new DateTimePicker();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            txtTel = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            btn_ShowPwd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(629, 64);
            label1.Name = "label1";
            label1.Size = new Size(195, 36);
            label1.TabIndex = 0;
            label1.Text = "新用户名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(631, 139);
            label2.Name = "label2";
            label2.Size = new Size(195, 36);
            label2.TabIndex = 1;
            label2.Text = "姓    名：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(629, 220);
            label3.Name = "label3";
            label3.Size = new Size(195, 36);
            label3.TabIndex = 2;
            label3.Text = "电话号码：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(629, 296);
            label4.Name = "label4";
            label4.Size = new Size(195, 36);
            label4.TabIndex = 3;
            label4.Text = "出生年月：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(631, 380);
            label5.Name = "label5";
            label5.Size = new Size(195, 36);
            label5.TabIndex = 4;
            label5.Text = "性    别：";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Linen;
            txtUser.Location = new Point(852, 70);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(347, 30);
            txtUser.TabIndex = 5;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Linen;
            txtName.Location = new Point(852, 145);
            txtName.Name = "txtName";
            txtName.Size = new Size(347, 30);
            txtName.TabIndex = 6;
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.Linen;
            txtPwd.Location = new Point(850, 464);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(347, 30);
            txtPwd.TabIndex = 7;
            // 
            // txtPwdAgain
            // 
            txtPwdAgain.BackColor = Color.Linen;
            txtPwdAgain.Location = new Point(850, 537);
            txtPwdAgain.Name = "txtPwdAgain";
            txtPwdAgain.PasswordChar = '*';
            txtPwdAgain.Size = new Size(347, 30);
            txtPwdAgain.TabIndex = 8;
            // 
            // dtpAge
            // 
            dtpAge.CalendarMonthBackground = Color.Linen;
            dtpAge.Location = new Point(852, 302);
            dtpAge.Name = "dtpAge";
            dtpAge.Size = new Size(347, 30);
            dtpAge.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(629, 458);
            label6.Name = "label6";
            label6.Size = new Size(195, 36);
            label6.TabIndex = 10;
            label6.Text = "密    码：";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("华文行楷", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            radioButton1.Location = new Point(906, 388);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 37);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("华文行楷", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            radioButton2.Location = new Point(1041, 388);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 37);
            radioButton2.TabIndex = 12;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.Linen;
            txtTel.Location = new Point(852, 226);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(347, 30);
            txtTel.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(629, 531);
            label7.Name = "label7";
            label7.Size = new Size(195, 36);
            label7.TabIndex = 14;
            label7.Text = "确认密码：";
            // 
            // button1
            // 
            button1.BackColor = Color.Linen;
            button1.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Location = new Point(632, 616);
            button1.Name = "button1";
            button1.Size = new Size(184, 55);
            button1.TabIndex = 15;
            button1.Text = "确认";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Location = new Point(999, 616);
            button2.Name = "button2";
            button2.Size = new Size(184, 55);
            button2.TabIndex = 16;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // btn_ShowPwd
            // 
            btn_ShowPwd.FlatStyle = FlatStyle.Popup;
            btn_ShowPwd.Image = Properties.Resources.隐藏1;
            btn_ShowPwd.Location = new Point(1218, 464);
            btn_ShowPwd.Name = "btn_ShowPwd";
            btn_ShowPwd.Size = new Size(50, 30);
            btn_ShowPwd.TabIndex = 17;
            btn_ShowPwd.UseVisualStyleBackColor = true;
            btn_ShowPwd.Click += btn_ShowPwd_Click;
            btn_ShowPwd.MouseDown += button_ShowPwd_MouseDown;
            btn_ShowPwd.MouseUp += button_ShowPwd_MouseUp;
            // 
            // User_zhuce
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1281, 692);
            Controls.Add(btn_ShowPwd);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txtTel);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(dtpAge);
            Controls.Add(txtPwdAgain);
            Controls.Add(txtPwd);
            Controls.Add(txtName);
            Controls.Add(txtUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User_zhuce";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_zhuce";
            Load += User_zhuce_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUser;
        private TextBox txtName;
        private TextBox txtPwd;
        private TextBox txtPwdAgain;
        private DateTimePicker dtpAge;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox txtTel;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button btn_ShowPwd;
    }
}