using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomList
{
    public partial class ListItem : UserControl
    {

        private Image _icon;
        private Color _iconBack;
        private string _message;
        private string _title;


        public ListItem()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pctrBx.Image = value; }
        }

        [Category("Custom Properties")]
        public Color IconBackground
        {
            get { return _iconBack; }
            set { _iconBack = value; panel1.BackColor = value; }
        }

        [Category("Custom Properties")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Properties")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = value; }
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }
    }
}
