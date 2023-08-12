using System;
using System.Drawing;
using System.Windows.Forms;

namespace 图标雨
{
    public partial class RainWindow : Form
    {
        private readonly int 速度;
        public RainWindow(int v, string 图片路径,Color 颜色)
        {
            速度 = v;
            InitializeComponent();
            if (图片路径 != "钉钉图标")
            {
                BackgroundImage = Image.FromFile(图片路径);
            }
            TransparencyKey = 颜色;
            Show();
        }

        private void 下落触发_Tick(object sender, EventArgs e)
        {
            Point 位置 = Location;
            位置.Offset(0, 速度);
            Location = 位置;
            if (Location.Y > Screen.PrimaryScreen.Bounds.Height)
            {
                Close();
            }
        }

        private void RainWindow_Load(object sender, EventArgs e)
        {
            Size = BackgroundImage.Size;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            Random random = new Random();
            int randomNumber = random.Next(0, screenWidth);
            Location = new Point(randomNumber, -Size.Height);
            下落触发.Enabled = true;
        }
    }
}
