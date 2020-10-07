using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar
{
    public partial class FrmTrackBar : Form
    {
        public FrmTrackBar()
        {
            InitializeComponent();
            updateColor();
        }

        private void FrmTrackBar_Load(object sender, EventArgs e)
        {

        }

        private void trckBr_Scroll(object sender, EventArgs e)
        {

            updateColor();

        }

        private void updateColor()
        {
            pctrBxColor.BackColor = Color.FromArgb(trckBrRed.Value, trckBrGreen.Value, trckBrBlue.Value);

            lblCurrentColor.Text = "Current color is: " + "(" +
            trckBrRed.Value + ", " +
            trckBrGreen.Value + " ," +
            trckBrBlue.Value + ")";
        }


    }
}
