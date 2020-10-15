using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomButton
{
    class FlatButton : Button
    {

        public Color OnMouseHoverBackColor { get; set; } = Color.DarkOrchid;

        public FlatButton()
        {
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;

        }


        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Width, Height);
            TextRenderer.DrawText(paintEventArgs.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            BackColor = OnMouseHoverBackColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            BackColor = Color.DodgerBlue;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            BackColor = Color.RoyalBlue;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            BackColor = Color.DodgerBlue;
        }

    }

}
