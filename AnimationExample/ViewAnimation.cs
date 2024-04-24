using System.Numerics;

namespace AnimationExample
{
    public partial class ViewAnimation : Form, IViewAnimation
    {
        Graphics g;
        Bitmap bm;
        Size sizePictureBox = new Size(500, 500);

        public event Action ViewTick = delegate { };

        public ViewAnimation()
        {
            InitializeComponent();

            pbField.Size = sizePictureBox;
            bm = new Bitmap(sizePictureBox.Width, sizePictureBox.Height);
            g = Graphics.FromImage(bm);
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            ViewTick();
            pbField.Image = bm;
        }
        
        public void DrawCircle(Pen p, Vector2 center, float rad) 
        {
            g.DrawEllipse(p, center.X - rad, center.Y - rad, rad*2, rad*2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            ViewTick();
            pbField.Image = bm;
        }        
    }
}
