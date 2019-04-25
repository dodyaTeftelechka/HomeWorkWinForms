using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public abstract class Actor
    {
        protected bool stopPaint;

        public virtual void OnPaint(PaintEventArgs e)
        {
            stopPaint = false;
        }

        public virtual void OnKeyPressed(KeyEventArgs e)
        {
            stopPaint = true;
        }
    }
}
