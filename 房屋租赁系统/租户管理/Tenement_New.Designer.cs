namespace 房屋租赁系统
{
    partial class Tenement_New
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
            btn_ShowPwd = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            txtTel = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            dtpAge = new DateTimePicker();
            txtPwdAgain = new TextBox();
            txtPwd = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_ShowPwd
            // 
            btn_ShowPwd.FlatStyle = FlatStyle.Popup;
            btn_ShowPwd.Image = Properties.Resources.隐藏1;
            btn_ShowPwd.Location = new Point(741, 456);
            btn_ShowPwd.Name = "btn_ShowPwd";
            btn_ShowPwd.Size = new Size(50, 30);
            btn_ShowPwd.TabIndex = 35;
            btn_ShowPwd.UseVisualStyleBackColor = true;
            btn_ShowPwd.MouseDown += button_ShowPwd_MouseDown;
            btn_ShowPwd.MouseUp += button_ShowPwd_MouseUp;
            // 
            // button2
            // 
            button2.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button2.Image = Properties.Resources._018_取消;
            button2.Location = new Point(491, 608);
            button2.Name = "button2";
            button2.Size = new Size(128, 55);
            button2.TabIndex = 34;
            button2.Text = "返回";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            button1.Image = Properties.Resources._018_确认;
            button1.Location = new Point(178, 608);
            button1.Name = "button1";
            button1.Size = new Size(130, 55);
            button1.TabIndex = 33;
            button1.Text = "确认";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label7.Location = new Point(121, 523);
            label7.Name = "label7";
            label7.Size = new Size(195, 36);
            label7.TabIndex = 32;
            label7.Text = "确认密码：";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(344, 218);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(347, 30);
            txtTel.TabIndex = 31;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("华文行楷", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            radioButton2.Location = new Point(533, 380);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 37);
            radioButton2.TabIndex = 30;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("华文行楷", 16F, FontStyle.Regular, GraphicsUnit.Point, 134);
            radioButton1.Location = new Point(398, 380);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 37);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(121, 450);
            label6.Name = "label6";
            label6.Size = new Size(195, 36);
            label6.TabIndex = 28;
            label6.Text = "密    码：";
            // 
            // dtpAge
            // 
            dtpAge.Location = new Point(344, 294);
            dtpAge.Name = "dtpAge";
            dtpAge.Size = new Size(347, 30);
            dtpAge.TabIndex = 27;
            // 
            // txtPwdAgain
            // 
            txtPwdAgain.Location = new Point(342, 529);
            txtPwdAgain.Name = "txtPwdAgain";
            txtPwdAgain.PasswordChar = '*';
            txtPwdAgain.Size = new Size(347, 30);
            txtPwdAgain.TabIndex = 26;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(342, 456);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(347, 30);
            txtPwd.TabIndex = 25;
            // 
            // txtName
            // 
            txtName.Location = new Point(344, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(347, 30);
            txtName.TabIndex = 24;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(344, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(347, 30);
            txtUser.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(123, 372);
            label5.Name = "label5";
            label5.Size = new Size(195, 36);
            label5.TabIndex = 22;
            label5.Text = "性    别：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(121, 288);
            label4.Name = "label4";
            label4.Size = new Size(195, 36);
            label4.TabIndex = 21;
            label4.Text = "出生年月：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(121, 212);
            label3.Name = "label3";
            label3.Size = new Size(195, 36);
            label3.TabIndex = 20;
            label3.Text = "电话号码：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(123, 131);
            label2.Name = "label2";
            label2.Size = new Size(195, 36);
            label2.TabIndex = 19;
            label2.Text = "姓    名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(121, 56);
            label1.Name = "label1";
            label1.Size = new Size(195, 36);
            label1.TabIndex = 18;
            label1.Text = "新用户名：";
            // 
            // Tenement_New
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 700);
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
            Name = "Tenement_New";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "新建租户信息";
            Load += Tenement_New_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ShowPwd;
        private Button button2;
        private Button button1;
        private Label label7;
        private TextBox txtTel;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private DateTimePicker dtpAge;
        private TextBox txtPwdAgain;
        private TextBox txtPwd;
        private TextBox txtName;
        private TextBox txtUser;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}