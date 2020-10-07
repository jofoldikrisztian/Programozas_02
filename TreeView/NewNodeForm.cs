using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class NewNodeForm : Form
    {

        public string NewNodeName { get; set; }
        public string NewNodeText { get; set; }
        public string NewNodeTag { get; set; }

        public NewNodeForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBxName.Text))
                NewNodeName = txtBxName.Text;
            else
            {
                MessageBox.Show("Name the node.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtBxText.Text))
                NewNodeText = txtBxText.Text;
            else
            {
                MessageBox.Show("Provide the new node's text.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtBxTag.Text))
                NewNodeTag = txtBxTag.Text;
            else
            {
                MessageBox.Show("Provide the new node's tag.");
                return;
            }

            Close();
        }
    }
}
