using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomButton
{
    class NewButton : Button
    {

        public Color OnMouseHoverBackColor { get; set; } = Color.DarkOrchid;

        public NewButton()
        {
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;

        }


    }
}
