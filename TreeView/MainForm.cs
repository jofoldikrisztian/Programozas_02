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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TreeNode mainTreeNode = new TreeNode();

            mainTreeNode.Name = "mainNode";
            mainTreeNode.Text = "Main";
            mainTreeNode.Tag = "";
            
            trVw.Nodes.Add(mainTreeNode);

        }



        private void btnAddNode_Click(object sender, MouseEventArgs e)
        {

            if (trVw.SelectedNode == null)
            {
                MessageBox.Show("Select a node");
            }
            else
            {
                NewNodeForm newNodeForm = new NewNodeForm();

                newNodeForm.ShowDialog();

                if (string.IsNullOrWhiteSpace(newNodeForm.NewNodeName))
                {
                    return;
                }

                TreeNode treeNode = new TreeNode();

                treeNode.Name = newNodeForm.NewNodeName;
                treeNode.Text = newNodeForm.NewNodeText;
                treeNode.Tag = newNodeForm.NewNodeTag;


                trVw.SelectedNode.Nodes.Add(treeNode);
                trVw.SelectedNode.ExpandAll();
            }


        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            if (trVw.SelectedNode.Name != "mainNode")
            {
                trVw.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("You can't delete the main node.");
            }

            
        }

        private void trVw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                txtBxName.Text = "";
                txtBxParentName.Text = "";
                txtBxText.Text = "";
                txtBxTag.Text = "";
                txtBxName.Text = trVw.SelectedNode.Name;
                txtBxText.Text = trVw.SelectedNode.Text;
                txtBxTag.Text = trVw.SelectedNode.Tag.ToString();

                if (trVw.SelectedNode.Parent != null)
                {
                    txtBxParentName.Text = trVw.SelectedNode.Parent.Text;
                }
            }
            catch
            {

            }
        }

        private void trVw_Click(object sender, EventArgs e)
        {
            clearBackColorRecursively(trVw.TopNode);
        }


        private void clearBackColorRecursively(TreeNode treeNode)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.BackColor = Color.White; clearBackColorRecursively(node);
            }
        }

        private void btnFindBy_Click(object sender, EventArgs e)
        {
            if (trVw.TopNode == null)
                return;

            clearBackColorRecursively(trVw.TopNode);

            switch ((sender as Button).Name)
            {
                case "btnFindByName":
                    TreeNode[] treeNodes = trVw.TopNode.Nodes.Find(txtBxSearchByName.Text, true);
                    for (int i = 0; i < treeNodes.Length; ++i)
                        treeNodes[i].BackColor = Color.Yellow;

                    if (treeNodes.Length > 0)
                        trVw.SelectedNode = treeNodes[0];
                    break;

                case "btnFindByText":
                    findByText(trVw.TopNode, true);
                    break;

                case "btnFindByTag":
                    findByTag(trVw.TopNode, true);
                    break;
            }
        }

        private void findByText(TreeNode treeNode, bool select)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                if (node.Text == txtBxSearchByText.Text)
                {
                    node.BackColor = Color.Yellow;
                    if (select)
                    {
                        trVw.SelectedNode = node;
                        select = false;
                    }
                }
                findByText(node, select);
            }
        }

        private void findByTag(TreeNode treeNode, bool select)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                if (node.Tag.ToString() == txtBxSearchByTag.Text)
                {
                    node.BackColor = Color.Yellow;
                    if (select)
                    {
                        trVw.SelectedNode = node;
                        select = false;
                    }
                }
                findByTag(node, select);
            }
        }


    }

}
