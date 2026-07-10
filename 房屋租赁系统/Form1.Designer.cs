namespace 房屋租赁系统
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_Title = new Label();
            btnzhuce = new Button();
            btndenglu = new Button();
            btn_quit = new Button();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Location = new Point(358, 225);
            lbl_Title.Margin = new Padding(10, 0, 10, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(541, 86);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "房屋租赁系统";
            // 
            // btnzhuce
            // 
            btnzhuce.BackColor = Color.Linen;
            btnzhuce.Font = new Font("楷体", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnzhuce.Location = new Point(290, 507);
            btnzhuce.Name = "btnzhuce";
            btnzhuce.Size = new Size(683, 63);
            btnzhuce.TabIndex = 1;
            btnzhuce.Text = "注册";
            btnzhuce.UseVisualStyleBackColor = false;
            btnzhuce.Click += btnzhuce_Click;
            // 
            // btndenglu
            // 
            btndenglu.BackColor = Color.Linen;
            btndenglu.Font = new Font("楷体", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btndenglu.Location = new Point(290, 432);
            btndenglu.Name = "btndenglu";
            btndenglu.Size = new Size(683, 63);
            btndenglu.TabIndex = 2;
            btndenglu.Text = "登录";
            btndenglu.UseVisualStyleBackColor = false;
            btndenglu.Click += btndenglu_Click;
            // 
            // btn_quit
            // 
            btn_quit.BackColor = Color.Linen;
            btn_quit.BackgroundImageLayout = ImageLayout.None;
            btn_quit.Font = new Font("楷体", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btn_quit.Image = Properties.Resources.power_off_line;
            btn_quit.Location = new Point(1184, 1);
            btn_quit.Name = "btn_quit";
            btn_quit.Size = new Size(93, 83);
            btn_quit.TabIndex = 3;
            btn_quit.UseVisualStyleBackColor = false;
            btn_quit.Click += btn_quit_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "房屋租赁系统";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(48F, 86F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1283, 692);
            Controls.Add(btn_quit);
            Controls.Add(btndenglu);
            Controls.Add(btnzhuce);
            Controls.Add(lbl_Title);
            Font = new Font("华文新魏", 41.9999962F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(14, 10, 14, 10);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "房屋租赁系统";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Button btnzhuce;
        private Button btndenglu;
        private Button btn_quit;
        public NotifyIcon notifyIcon1;
    }    
}
