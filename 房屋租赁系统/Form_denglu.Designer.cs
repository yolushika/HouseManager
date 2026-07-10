namespace 房屋租赁系统
{
    partial class Form_denglu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_denglu));
            btnconfirm = new Button();
            btnreturn = new Button();
            txt_uName = new TextBox();
            txt_uPwd = new TextBox();
            lbl_uName = new Label();
            lbl_uPwd = new Label();
            SuspendLayout();
            // 
            // btnconfirm
            // 
            btnconfirm.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnconfirm.Location = new Point(157, 358);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(144, 55);
            btnconfirm.TabIndex = 0;
            btnconfirm.Text = "确认";
            btnconfirm.UseVisualStyleBackColor = true;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // btnreturn
            // 
            btnreturn.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnreturn.Location = new Point(553, 358);
            btnreturn.Name = "btnreturn";
            btnreturn.Size = new Size(144, 55);
            btnreturn.TabIndex = 1;
            btnreturn.Text = "返回";
            btnreturn.UseVisualStyleBackColor = true;
            btnreturn.Click += btnreturn_Click;
            // 
            // txt_uName
            // 
            txt_uName.Location = new Point(291, 155);
            txt_uName.Name = "txt_uName";
            txt_uName.Size = new Size(437, 30);
            txt_uName.TabIndex = 2;
            txt_uName.Text = "111";
            txt_uName.TextChanged += txt_uName_TextChanged;
            // 
            // txt_uPwd
            // 
            txt_uPwd.Location = new Point(291, 211);
            txt_uPwd.Name = "txt_uPwd";
            txt_uPwd.PasswordChar = '*';
            txt_uPwd.Size = new Size(437, 30);
            txt_uPwd.TabIndex = 3;
            txt_uPwd.Text = "111";
            txt_uPwd.TextChanged += txt_uPwd_TextChanged;
            // 
            // lbl_uName
            // 
            lbl_uName.AutoSize = true;
            lbl_uName.BackColor = Color.Transparent;
            lbl_uName.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_uName.Location = new Point(126, 149);
            lbl_uName.Name = "lbl_uName";
            lbl_uName.Size = new Size(159, 36);
            lbl_uName.TabIndex = 4;
            lbl_uName.Text = "用户名：";
            // 
            // lbl_uPwd
            // 
            lbl_uPwd.AutoSize = true;
            lbl_uPwd.BackColor = Color.Transparent;
            lbl_uPwd.Font = new Font("楷体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_uPwd.Location = new Point(126, 202);
            lbl_uPwd.Name = "lbl_uPwd";
            lbl_uPwd.Size = new Size(159, 36);
            lbl_uPwd.TabIndex = 5;
            lbl_uPwd.Text = "密  码：";
            // 
            // Form_denglu
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(865, 489);
            Controls.Add(lbl_uPwd);
            Controls.Add(lbl_uName);
            Controls.Add(txt_uPwd);
            Controls.Add(txt_uName);
            Controls.Add(btnreturn);
            Controls.Add(btnconfirm);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            Name = "Form_denglu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登录";
            Load += Form_denglu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconfirm;
        private Button btnreturn;
        private TextBox txt_uName;
        private TextBox txt_uPwd;
        private Label lbl_uName;
        private Label lbl_uPwd;
    }
}