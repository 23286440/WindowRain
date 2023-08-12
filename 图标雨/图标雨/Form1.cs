using System;
using System.Windows.Forms;

namespace 图标雨
{
    public partial class Main : Form
    {
        string 图片路径;
        public Main()
        {
            InitializeComponent();
        }

        private void 计时器_Tick(object sender, EventArgs e)
        {
            _ = new RainWindow((int)Math.Round(下落速度.Value), 图片路径,颜色选择.Color);
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            图片路径 = 图片路径输入框.Text;
            if (System.IO.File.Exists(图片路径) || 图片路径 == "钉钉图标")
            {
                计时器.Interval = (int)Math.Round(间隔时间.Value);
                计时器.Enabled = true;
            }
            else
            {
                _ = MessageBox.Show("文件路径无效 ≧ ﹏ ≦", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            计时器.Enabled = false;
        }

        private void 打赏链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://afdian.net/a/Zhuluoji");
        }

        private void 源代码链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/23286440/WindowRain");
        }

        private void Bilibili链接_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://space.bilibili.com/1927497544");
        }

        private void 颜色设定_Click(object sender, EventArgs e)
        {
            颜色选择.ShowDialog();
        }

        private void 图片路径_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            图片路径输入框.Text = filepaths[0];
        }

        private void 图片路径_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void 图片路径_DoubleClick(object sender, EventArgs e)
        {
            if(选择文件.ShowDialog() == DialogResult.OK)
            {
                图片路径输入框.Text = 选择文件.FileName;
            }
        }
    }
}
