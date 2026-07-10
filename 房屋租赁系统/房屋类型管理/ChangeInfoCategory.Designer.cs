namespace 房屋租赁系统.房屋类型管理
{
    partial class ChangeInfoCategory
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
            button1 = new Button();
            button2 = new Button();
            txtCname = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 18F);
            button1.Image = Properties.Resources._018_确认;
            button1.Location = new Point(184, 226);
            button1.Name = "button1";
            button1.Size = new Size(208, 54);
            button1.TabIndex = 0;
            button1.Text = "确认修改";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("楷体", 18F);
            button2.Image = Properties.Resources._018_取消;
            button2.Location = new Point(474, 226);
            button2.Name = "button2";
            button2.Size = new Size(200, 54);
            button2.TabIndex = 1;
            button2.Text = "取消修改";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCname
            // 
            txtCname.Location = new Point(364, 114);
            txtCname.Name = "txtCname";
            txtCname.Size = new Size(401, 30);
            txtCname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 18F);
            label1.Location = new Point(108, 108);
            label1.Name = "label1";
            label1.Size = new Size(159, 36);
            label1.TabIndex = 3;
            label1.Text = "类型名：";
            // 
            // ChangeInfoCategory
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 318);
            Controls.Add(label1);
            Controls.Add(txtCname);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ChangeInfoCategory";
            Text = "房屋类型修改";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtCname;
        private Label label1;
    }
}