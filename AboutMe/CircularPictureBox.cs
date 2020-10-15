using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AboutMe
{
    public class CircularPictureBox : PictureBox
    {

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new System.Drawing.Region(graphicsPath);
            base.OnPaint(paintEventArgs);
        }


    }
}
