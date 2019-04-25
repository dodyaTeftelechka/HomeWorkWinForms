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
        Bitmap[] animation =
        {
            new Bitmap("../../AnimationsLifestiller/output-0.png"),
            new Bitmap("../../AnimationsLifestiller/output-1.png"),
            new Bitmap("../../AnimationsLifestiller/output-2.png"),
            new Bitmap("../../AnimationsLifestiller/output-3.png"),
            new Bitmap("../../AnimationsLifestiller/output-4.png"),
            new Bitmap("../../AnimationsLifestiller/output-5.png"),
            new Bitmap("../../AnimationsLifestiller/output-6.png"),
            new Bitmap("../../AnimationsLifestiller/output-7.png"),
            new Bitmap("../../AnimationsLifestiller/output-8.png"),
            new Bitmap("../../AnimationsLifestiller/output-9.png"),
            new Bitmap("../../AnimationsLifestiller/output-10.png"),
            new Bitmap("../../AnimationsLifestiller/output-11.png"),
            new Bitmap("../../AnimationsLifestiller/output-12.png"),
            new Bitmap("../../AnimationsLifestiller/output-13.png"),
            new Bitmap("../../AnimationsLifestiller/output-14.png"),
            new Bitmap("../../AnimationsLifestiller/output-15.png"),
            new Bitmap("../../AnimationsLifestiller/output-16.png"),
            new Bitmap("../../AnimationsLifestiller/output-17.png"),
            new Bitmap("../../AnimationsLifestiller/output-18.png"),
            new Bitmap("../../AnimationsLifestiller/output-19.png"),
            new Bitmap("../../AnimationsLifestiller/output-20.png"),
            new Bitmap("../../AnimationsLifestiller/output-21.png"),
            new Bitmap("../../AnimationsLifestiller/output-22.png"),
            new Bitmap("../../AnimationsLifestiller/output-23.png"),
            new Bitmap("../../AnimationsLifestiller/output-24.png"),
            new Bitmap("../../AnimationsLifestiller/output-25.png"),
            new Bitmap("../../AnimationsLifestiller/output-26.png"),
            new Bitmap("../../AnimationsLifestiller/output-27.png"),
            new Bitmap("../../AnimationsLifestiller/output-28.png"),
            new Bitmap("../../AnimationsLifestiller/output-29.png"),
            new Bitmap("../../AnimationsLifestiller/output-30.png"),
            new Bitmap("../../AnimationsLifestiller/output-31.png"),
            new Bitmap("../../AnimationsLifestiller/output-32.png"),
            new Bitmap("../../AnimationsLifestiller/output-33.png"),
            new Bitmap("../../AnimationsLifestiller/output-34.png"),
            new Bitmap("../../AnimationsLifestiller/output-35.png"),
            new Bitmap("../../AnimationsLifestiller/output-36.png")
        };        

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
        }

        public override void OnPaint(PaintEventArgs e)
        {
            point = new Point(X, Y);
            if (stopPaint)
                base.OnPaint(e);
            else
                numAnimation = (numAnimation + 1) % animation.Length;
            e.Graphics.DrawImage(animation[numAnimation],
                new Rectangle(animeBox.Box.X, animeBox.Box.Y, animeBox.Box.Width, animeBox.Box.Height));
        }
    }
}