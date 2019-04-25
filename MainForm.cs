using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        List<Actor> actors = new List<Actor>();
        
        public MainForm()
        {
            InitializeComponent();
            KeyPreview = true;
            DoubleBuffered = true;

            var animeBox = new AnimeBox(new ReactangleControl(200, 200, 300, 300), this);
            actors.Add(animeBox);
            
            actors.Add(new AnimeBox(new ReactangleControl(200, 200, 150, 150), this));
            
            actors.Add(new LifestillerAnimation(this, animeBox));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            actors.ForEach(it => it.OnPaint(e));
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            actors.ForEach(it => it.OnKeyPressed(e));
            Invalidate();
        }
    }
}