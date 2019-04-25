using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class AnimeBox : Actor
    {
        public readonly ReactangleControl Box;
        private Form Window;
        private readonly Random random = new Random();
        
        public AnimeBox(ReactangleControl box, Form window)
        {
            Box = box;
            Window = window;
        }

        public override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Box.Draw(e.Graphics);
        }

        public override void OnKeyPressed(KeyEventArgs e)
        {
            base.OnKeyPressed(e);
            
            Box.BackColor = Color.FromArgb(random.Next(1, 256), random.Next(1, 256), random.Next(1, 256));
            Window.BackColor = Color.FromArgb(random.Next(1, 256), random.Next(1, 256), random.Next(1, 256));
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    Box.Y = (Box.Y - Box.Height + Window.Height) % Window.Height;
                    break;
                case Keys.S:
                case Keys.Down:
                    Box.Y = (Box.Y + Box.Height + Window.Height) % Window.Height;
                    break;
                case Keys.A:
                case Keys.Left:
                    Box.X = (Box.X - Box.Width + Window.Width) % Window.Width;
                    break;
                case Keys.D:
                case Keys.Right:
                    Box.X = (Box.X + Box.Width + Window.Width) % Window.Width;
                    break;
            }
        }
    }
}