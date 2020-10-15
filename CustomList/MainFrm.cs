using CustomList.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomList
{
    public partial class CustomList : Form
    {
        public CustomList()
        {
            InitializeComponent();
        }

        private void CustomList_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void populateItems()
        {
            ListItem[] listItems = new ListItem[20];



            for (int i = 0; i < listItems.Length; ++i)
            {
                listItems[i] = new ListItem();

                listItems[i].Icon = Resources.avatar;
                listItems[i].Width = flwLyPnl.Width;
                listItems[i].IconBackground = Color.Silver;
                listItems[i].Title = "Get Data Somewhere";
                listItems[i].Message = "Any data source";
                flwLyPnl.Controls.Add(listItems[i]);
            }
        }
    }
}
