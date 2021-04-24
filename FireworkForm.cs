using System;
using System.Drawing;
using System.Windows.Forms;

namespace BirthdayNotifier
{
    public partial class FireworkForm : Form
    {
        Bitmap[] fireworks = { Resources.Firework1, Resources.Firework2, Resources.Firework3 };
        int index = 0;
        Timer changeTimer = new Timer();
        public FireworkForm()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            ImageAnimator.Animate(fireworks[index], new EventHandler(this.OnFrameChanged));
            changeTimer.Interval = 7500;
            changeTimer.Tick += new EventHandler(this.OnChangeTick);
            changeTimer.Enabled = true;
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        { 
            ImageAnimator.UpdateFrames();
            FireworkPictureBox.BackgroundImage = fireworks[index];
        }
        private void OnFrameChanged(object sender, EventArgs args) => FireworkPictureBox.Invalidate();
        private void OnChangeTick(object sender, EventArgs args)
        {
            index = index > 1 ? 0 : index + 1;
            ImageAnimator.Animate(fireworks[index], new EventHandler(this.OnFrameChanged));
        }
        private void FireworkForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
    }
}
