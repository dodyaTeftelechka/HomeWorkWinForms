using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ReactangleControl : UserControl
    {
        #region SvoistvaReactangle

        Color[] colors = 
            {Color.Chocolate, Color.Red, Color.Coral, Color.Green, Color.DeepPink, Color.Gold, Color.HotPink};

        Timer timer = new Timer();
        int index = 0;
        bool i = true;

        public int Y
        {
            get => rect.Y;
            set => rect.Y = value;
        }

        public int X
        {
            get => rect.X;
            set => rect.X = value;
        }

        public int Height
        {
            get => rect.Height;
            set => rect.Height = value;
        }

        public int Width
        {
            get => rect.Width;
            set => rect.Width = value;
        }


        Rectangle rect;
        public Brush brush;
        public Pen pen;

        #endregion

        public ReactangleControl(int x, int y, int w, int h)
        {
            rect = new Rectangle(x, y, w, h);
            timer.Interval = 300;
            timer.Tick += (s, e) =>
            {
                if (i) index++;
                else index--;

                if (index == colors.Length - 1) i = false;
                if (index == 0) i = true;
                Invalidate();
            };
            timer.Start();
        }

        public void Draw(Graphics e)
        {
            brush = new SolidBrush(colors[index]);
            pen = new Pen(Color.Black);
            e.FillRectangle(brush, rect);
            e.DrawRectangle(pen, rect);
        }
    }
}