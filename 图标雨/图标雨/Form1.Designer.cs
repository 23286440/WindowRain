namespace 图标雨
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.计时器 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.间隔时间 = new System.Windows.Forms.NumericUpDown();
            this.下落速度 = new System.Windows.Forms.NumericUpDown();
            this.Bilibili链接 = new System.Windows.Forms.LinkLabel();
            this.源代码链接 = new System.Windows.Forms.LinkLabel();
            this.打赏链接 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.协议 = new System.Windows.Forms.Label();
            this.颜色选择 = new System.Windows.Forms.ColorDialog();
            this.颜色设定 = new System.Windows.Forms.Button();
            this.图片路径输入框 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.选择文件 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.间隔时间)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.下落速度)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_button
            // 
            this.Start_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start_button.BackgroundImage")));
            this.Start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_button.Location = new System.Drawing.Point(14, 125);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 36);
            this.Start_button.TabIndex = 0;
            this.Start_button.Text = "开始";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop_button.BackgroundImage")));
            this.Stop_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Stop_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop_button.Location = new System.Drawing.Point(95, 125);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(81, 36);
            this.Stop_button.TabIndex = 1;
            this.Stop_button.Text = "结束";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // 计时器
            // 
            this.计时器.Interval = 1000;
            this.计时器.Tick += new System.EventHandler(this.计时器_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "间隔时间（毫秒）：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "下落速度：";
            // 
            // 间隔时间
            // 
            this.间隔时间.BackColor = System.Drawing.SystemColors.Window;
            this.间隔时间.Location = new System.Drawing.Point(131, 7);
            this.间隔时间.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.间隔时间.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.间隔时间.Name = "间隔时间";
            this.间隔时间.Size = new System.Drawing.Size(120, 21);
            this.间隔时间.TabIndex = 4;
            this.间隔时间.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // 下落速度
            // 
            this.下落速度.Location = new System.Drawing.Point(131, 29);
            this.下落速度.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.下落速度.Name = "下落速度";
            this.下落速度.Size = new System.Drawing.Size(120, 21);
            this.下落速度.TabIndex = 5;
            this.下落速度.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Bilibili链接
            // 
            this.Bilibili链接.AutoSize = true;
            this.Bilibili链接.BackColor = System.Drawing.Color.Transparent;
            this.Bilibili链接.Location = new System.Drawing.Point(278, 80);
            this.Bilibili链接.Name = "Bilibili链接";
            this.Bilibili链接.Size = new System.Drawing.Size(53, 12);
            this.Bilibili链接.TabIndex = 21;
            this.Bilibili链接.TabStop = true;
            this.Bilibili链接.Text = "Bilibili";
            this.Bilibili链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Bilibili链接_LinkClicked);
            // 
            // 源代码链接
            // 
            this.源代码链接.AutoSize = true;
            this.源代码链接.BackColor = System.Drawing.Color.Transparent;
            this.源代码链接.Location = new System.Drawing.Point(231, 80);
            this.源代码链接.Name = "源代码链接";
            this.源代码链接.Size = new System.Drawing.Size(41, 12);
            this.源代码链接.TabIndex = 20;
            this.源代码链接.TabStop = true;
            this.源代码链接.Text = "源代码";
            this.源代码链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.源代码链接_LinkClicked);
            // 
            // 打赏链接
            // 
            this.打赏链接.AutoSize = true;
            this.打赏链接.BackColor = System.Drawing.Color.Transparent;
            this.打赏链接.Location = new System.Drawing.Point(196, 80);
            this.打赏链接.Name = "打赏链接";
            this.打赏链接.Size = new System.Drawing.Size(29, 12);
            this.打赏链接.TabIndex = 19;
            this.打赏链接.TabStop = true;
            this.打赏链接.Text = "打赏";
            this.打赏链接.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.打赏链接_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(196, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "作者：侏罗纪";
            // 
            // 协议
            // 
            this.协议.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.协议.AutoSize = true;
            this.协议.BackColor = System.Drawing.Color.Transparent;
            this.协议.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.协议.Location = new System.Drawing.Point(178, 150);
            this.协议.Name = "协议";
            this.协议.Size = new System.Drawing.Size(154, 14);
            this.协议.TabIndex = 22;
            this.协议.Text = "本软件使用MIT许可协议";
            // 
            // 颜色选择
            // 
            this.颜色选择.Color = System.Drawing.SystemColors.Control;
            // 
            // 颜色设定
            // 
            this.颜色设定.Location = new System.Drawing.Point(12, 62);
            this.颜色设定.Name = "颜色设定";
            this.颜色设定.Size = new System.Drawing.Size(111, 30);
            this.颜色设定.TabIndex = 23;
            this.颜色设定.Text = "选择透明化的颜色";
            this.颜色设定.UseVisualStyleBackColor = true;
            this.颜色设定.Click += new System.EventHandler(this.颜色设定_Click);
            // 
            // 图片路径输入框
            // 
            this.图片路径输入框.AllowDrop = true;
            this.图片路径输入框.Location = new System.Drawing.Point(82, 98);
            this.图片路径输入框.Name = "图片路径输入框";
            this.图片路径输入框.Size = new System.Drawing.Size(250, 21);
            this.图片路径输入框.TabIndex = 24;
            this.图片路径输入框.Text = "钉钉图标";
            this.图片路径输入框.DragDrop += new System.Windows.Forms.DragEventHandler(this.图片路径_DragDrop);
            this.图片路径输入框.DragEnter += new System.Windows.Forms.DragEventHandler(this.图片路径_DragEnter);
            this.图片路径输入框.DoubleClick += new System.EventHandler(this.图片路径_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "图片路径：";
            // 
            // 选择文件
            // 
            this.选择文件.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Violet;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(343, 173);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.图片路径输入框);
            this.Controls.Add(this.颜色设定);
            this.Controls.Add(this.协议);
            this.Controls.Add(this.Bilibili链接);
            this.Controls.Add(this.源代码链接);
            this.Controls.Add(this.打赏链接);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.下落速度);
            this.Controls.Add(this.间隔时间);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "图标雨";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.间隔时间)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.下落速度)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Timer 计时器;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown 间隔时间;
        private System.Windows.Forms.NumericUpDown 下落速度;
        private System.Windows.Forms.LinkLabel Bilibili链接;
        private System.Windows.Forms.LinkLabel 源代码链接;
        private System.Windows.Forms.LinkLabel 打赏链接;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label 协议;
        private System.Windows.Forms.ColorDialog 颜色选择;
        private System.Windows.Forms.Button 颜色设定;
        private System.Windows.Forms.TextBox 图片路径输入框;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog 选择文件;
    }
}

