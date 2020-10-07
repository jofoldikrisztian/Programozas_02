using System;
using System.Windows.Forms;

namespace ListViewDemo
{
    public partial class FrmListViewDemo : Form
    {
        public FrmListViewDemo()
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxId.Text) || string.IsNullOrEmpty(txtBxName.Text))
                return;

            ListViewItem item = new ListViewItem(new string[] { txtBxId.Text, txtBxName.Text });
            //ListViewItem item = new ListViewItem(txtBxId.Text);
            //item.SubItems.Add(txtBxName.Text);

            lstVw.Items.Add(item);
            txtBxId.Clear();
            txtBxName.Clear();
            txtBxId.Focus();
        }

        private void bttnRemove_Click(object sender, EventArgs e)
        {
            if (lstVw.SelectedIndices.Count > 0)
                lstVw.Items.RemoveAt(lstVw.SelectedIndices[0]);
        }
    }
}