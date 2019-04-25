using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class LifestillerAnimation : Actor
    {
        List<Bitmap> animation = new List<Bitmap>();

        int numAnimation;
        private Point point = new Point(500, 200);
        private AnimeBox animeBox;

        public int Y
        {
            get => point.Y;
            set => point.Y = value;
        }

        public int X
        {
            get => point.X;
            set => point.X = value;
        }


        public LifestillerAnimation(Form form, AnimeBox animeBox)
        {
            Timer timer = new Timer();
            timer.Tick += (s, e) => form.Invalidate();
            timer.Interval = 20;
            timer.Start();
            this.animeBox = animeBox;
            for (int i = 0; i < 37; i++) 
                animation.Add(new Bitmap($"../../AnimationsLifestiller/output-{i}.png"));
        }

        public override void OnPaint(PaintEventArgs e)
        {
            point = new Point(X, Y);
            if (stopPaint)
                base.OnPaint(e);
            else
                numAnimation = (numAnimation + 1) % animation.Count;
            e.Graphics.DrawImage(animation[numAnimation],
                new Rectangle(animeBox.Box.X, animeBox.Box.Y, animeBox.Box.Width, animeBox.Box.Height));
        }
    }
}