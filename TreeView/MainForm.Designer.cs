namespace TreeView
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBxSelectedNodeInformation = new System.Windows.Forms.GroupBox();
            this.txtBxTag = new System.Windows.Forms.TextBox();
            this.txtBxText = new System.Windows.Forms.TextBox();
            this.txtBxParentName = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBxNodeSearchByName = new System.Windows.Forms.GroupBox();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.txtBxSearchByName = new System.Windows.Forms.TextBox();
            this.lblNodeSearchByName = new System.Windows.Forms.Label();
            this.grpBxNodeSearchByText = new System.Windows.Forms.GroupBox();
            this.btnFindByText = new System.Windows.Forms.Button();
            this.txtBxSearchByText = new System.Windows.Forms.TextBox();
            this.lblNodeSearchByText = new System.Windows.Forms.Label();
            this.grpBxNodeSearchByTag = new System.Windows.Forms.GroupBox();
            this.btnFindByTag = new System.Windows.Forms.Button();
            this.txtBxSearchByTag = new System.Windows.Forms.TextBox();
            this.lblNodeSearchByTag = new System.Windows.Forms.Label();
            this.trVw = new System.Windows.Forms.TreeView();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.grpBxSelectedNodeInformation.SuspendLayout();
            this.grpBxNodeSearchByName.SuspendLayout();
            this.grpBxNodeSearchByText.SuspendLayout();
            this.grpBxNodeSearchByTag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxSelectedNodeInformation
            // 
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxTag);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxText);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxParentName);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxName);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblTag);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblText);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblParentName);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblName);
            this.grpBxSelectedNodeInformation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxSelectedNodeInformation.Location = new System.Drawing.Point(173, 12);
            this.grpBxSelectedNodeInformation.Name = "grpBxSelectedNodeInformation";
            this.grpBxSelectedNodeInformation.Size = new System.Drawing.Size(309, 116);
            this.grpBxSelectedNodeInformation.TabIndex = 0;
            this.grpBxSelectedNodeInformation.TabStop = false;
            this.grpBxSelectedNodeInformation.Text = "Selected Node Information";
            // 
            // txtBxTag
            // 
            this.txtBxTag.Location = new System.Drawing.Point(88, 88);
            this.txtBxTag.Name = "txtBxTag";
            this.txtBxTag.ReadOnly = true;
            this.txtBxTag.Size = new System.Drawing.Size(215, 20);
            this.txtBxTag.TabIndex = 7;
            // 
            // txtBxText
            // 
            this.txtBxText.Location = new System.Drawing.Point(88, 65);
            this.txtBxText.Name = "txtBxText";
            this.txtBxText.ReadOnly = true;
            this.txtBxText.Size = new System.Drawing.Size(215, 20);
            this.txtBxText.TabIndex = 6;
            // 
            // txtBxParentName
            // 
            this.txtBxParentName.Location = new System.Drawing.Point(88, 42);
            this.txtBxParentName.Name = "txtBxParentName";
            this.txtBxParentName.ReadOnly = true;
            this.txtBxParentName.Size = new System.Drawing.Size(215, 20);
            this.txtBxParentName.TabIndex = 5;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(88, 19);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.ReadOnly = true;
            this.txtBxName.Size = new System.Drawing.Size(215, 20);
            this.txtBxName.TabIndex = 4;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTag.Location = new System.Drawing.Point(53, 91);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 3;
            this.lblTag.Text = "Tag:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblText.Location = new System.Drawing.Point(51, 68);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text:";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblParentName.Location = new System.Drawing.Point(10, 45);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(72, 13);
            this.lblParentName.TabIndex = 1;
            this.lblParentName.Text = "Parent Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblName.Location = new System.Drawing.Point(44, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // grpBxNodeSearchByName
            // 
            this.grpBxNodeSearchByName.Controls.Add(this.btnFindByName);
            this.grpBxNodeSearchByName.Controls.Add(this.txtBxSearchByName);
            this.grpBxNodeSearchByName.Controls.Add(this.lblNodeSearchByName);
            this.grpBxNodeSearchByName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxNodeSearchByName.Location = new System.Drawing.Point(173, 134);
            this.grpBxNodeSearchByName.Name = "grpBxNodeSearchByName";
            this.grpBxNodeSearchByName.Size = new System.Drawing.Size(309, 110);
            this.grpBxNodeSearchByName.TabIndex = 1;
            this.grpBxNodeSearchByName.TabStop = false;
            this.grpBxNodeSearchByName.Text = "NodeSearch (By Name)";
            // 
            // btnFindByName
            // 
            this.btnFindByName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFindByName.Location = new System.Drawing.Point(227, 43);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(75, 23);
            this.btnFindByName.TabIndex = 10;
            this.btnFindByName.Text = "Find";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindBy_Click);
            // 
            // txtBxSearchByName
            // 
            this.txtBxSearchByName.Location = new System.Drawing.Point(87, 17);
            this.txtBxSearchByName.Name = "txtBxSearchByName";
            this.txtBxSearchByName.Size = new System.Drawing.Size(215, 20);
            this.txtBxSearchByName.TabIndex = 8;
            // 
            // lblNodeSearchByName
            // 
            this.lblNodeSearchByName.AutoSize = true;
            this.lblNodeSearchByName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNodeSearchByName.Location = new System.Drawing.Point(46, 20);
            this.lblNodeSearchByName.Name = "lblNodeSearchByName";
            this.lblNodeSearchByName.Size = new System.Drawing.Size(38, 13);
            this.lblNodeSearchByName.TabIndex = 0;
            this.lblNodeSearchByName.Text = "Name:";
            // 
            // grpBxNodeSearchByText
            // 
            this.grpBxNodeSearchByText.Controls.Add(this.btnFindByText);
            this.grpBxNodeSearchByText.Controls.Add(this.txtBxSearchByText);
            this.grpBxNodeSearchByText.Controls.Add(this.lblNodeSearchByText);
            this.grpBxNodeSearchByText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxNodeSearchByText.Location = new System.Drawing.Point(173, 250);
            this.grpBxNodeSearchByText.Name = "grpBxNodeSearchByText";
            this.grpBxNodeSearchByText.Size = new System.Drawing.Size(309, 107);
            this.grpBxNodeSearchByText.TabIndex = 2;
            this.grpBxNodeSearchByText.TabStop = false;
            this.grpBxNodeSearchByText.Text = "Node Search (By Text)";
            // 
            // btnFindByText
            // 
            this.btnFindByText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFindByText.Location = new System.Drawing.Point(227, 46);
            this.btnFindByText.Name = "btnFindByText";
            this.btnFindByText.Size = new System.Drawing.Size(75, 23);
            this.btnFindByText.TabIndex = 10;
            this.btnFindByText.Text = "Find";
            this.btnFindByText.UseVisualStyleBackColor = true;
            this.btnFindByText.Click += new System.EventHandler(this.btnFindBy_Click);
            // 
            // txtBxSearchByText
            // 
            this.txtBxSearchByText.Location = new System.Drawing.Point(87, 19);
            this.txtBxSearchByText.Name = "txtBxSearchByText";
            this.txtBxSearchByText.Size = new System.Drawing.Size(215, 20);
            this.txtBxSearchByText.TabIndex = 9;
            // 
            // lblNodeSearchByText
            // 
            this.lblNodeSearchByText.AutoSize = true;
            this.lblNodeSearchByText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNodeSearchByText.Location = new System.Drawing.Point(47, 22);
            this.lblNodeSearchByText.Name = "lblNodeSearchByText";
            this.lblNodeSearchByText.Size = new System.Drawing.Size(31, 13);
            this.lblNodeSearchByText.TabIndex = 1;
            this.lblNodeSearchByText.Text = "Text:";
            // 
            // grpBxNodeSearchByTag
            // 
            this.grpBxNodeSearchByTag.Controls.Add(this.btnFindByTag);
            this.grpBxNodeSearchByTag.Controls.Add(this.txtBxSearchByTag);
            this.grpBxNodeSearchByTag.Controls.Add(this.lblNodeSearchByTag);
            this.grpBxNodeSearchByTag.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxNodeSearchByTag.Location = new System.Drawing.Point(173, 363);
            this.grpBxNodeSearchByTag.Name = "grpBxNodeSearchByTag";
            this.grpBxNodeSearchByTag.Size = new System.Drawing.Size(309, 99);
            this.grpBxNodeSearchByTag.TabIndex = 3;
            this.grpBxNodeSearchByTag.TabStop = false;
            this.grpBxNodeSearchByTag.Text = "Node Search (By Tag)";
            // 
            // btnFindByTag
            // 
            this.btnFindByTag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFindByTag.Location = new System.Drawing.Point(227, 45);
            this.btnFindByTag.Name = "btnFindByTag";
            this.btnFindByTag.Size = new System.Drawing.Size(75, 23);
            this.btnFindByTag.TabIndex = 10;
            this.btnFindByTag.Text = "Find";
            this.btnFindByTag.UseVisualStyleBackColor = true;
            this.btnFindByTag.Click += new System.EventHandler(this.btnFindBy_Click);
            // 
            // txtBxSearchByTag
            // 
            this.txtBxSearchByTag.Location = new System.Drawing.Point(87, 18);
            this.txtBxSearchByTag.Name = "txtBxSearchByTag";
            this.txtBxSearchByTag.Size = new System.Drawing.Size(215, 20);
            this.txtBxSearchByTag.TabIndex = 9;
            // 
            // lblNodeSearchByTag
            // 
            this.lblNodeSearchByTag.AutoSize = true;
            this.lblNodeSearchByTag.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblNodeSearchByTag.Location = new System.Drawing.Point(47, 21);
            this.lblNodeSearchByTag.Name = "lblNodeSearchByTag";
            this.lblNodeSearchByTag.Size = new System.Drawing.Size(29, 13);
            this.lblNodeSearchByTag.TabIndex = 2;
            this.lblNodeSearchByTag.Text = "Tag:";
            // 
            // trVw
            // 
            this.trVw.Location = new System.Drawing.Point(13, 12);
            this.trVw.Name = "trVw";
            this.trVw.Size = new System.Drawing.Size(154, 495);
            this.trVw.TabIndex = 4;
            this.trVw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trVw_AfterSelect);
            this.trVw.Click += new System.EventHandler(this.trVw_Click);
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Location = new System.Drawing.Point(306, 480);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(88, 23);
            this.btnRemoveNode.TabIndex = 5;
            this.btnRemoveNode.Text = "Remove Node";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Location = new System.Drawing.Point(401, 480);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 23);
            this.btnAddNode.TabIndex = 6;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddNode_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 515);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.btnRemoveNode);
            this.Controls.Add(this.trVw);
            this.Controls.Add(this.grpBxNodeSearchByTag);
            this.Controls.Add(this.grpBxNodeSearchByText);
            this.Controls.Add(this.grpBxNodeSearchByName);
            this.Controls.Add(this.grpBxSelectedNodeInformation);
            this.Name = "MainForm";
            this.Text = "TreeView";
            this.grpBxSelectedNodeInformation.ResumeLayout(false);
            this.grpBxSelectedNodeInformation.PerformLayout();
            this.grpBxNodeSearchByName.ResumeLayout(false);
            this.grpBxNodeSearchByName.PerformLayout();
            this.grpBxNodeSearchByText.ResumeLayout(false);
            this.grpBxNodeSearchByText.PerformLayout();
            this.grpBxNodeSearchByTag.ResumeLayout(false);
            this.grpBxNodeSearchByTag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxSelectedNodeInformation;
        private System.Windows.Forms.TextBox txtBxTag;
        private System.Windows.Forms.TextBox txtBxText;
        private System.Windows.Forms.TextBox txtBxParentName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpBxNodeSearchByName;
        private System.Windows.Forms.GroupBox grpBxNodeSearchByText;
        private System.Windows.Forms.GroupBox grpBxNodeSearchByTag;
        private System.Windows.Forms.TreeView trVw;
        private System.Windows.Forms.TextBox txtBxSearchByName;
        private System.Windows.Forms.Label lblNodeSearchByName;
        private System.Windows.Forms.TextBox txtBxSearchByText;
        private System.Windows.Forms.Label lblNodeSearchByText;
        private System.Windows.Forms.TextBox txtBxSearchByTag;
        private System.Windows.Forms.Label lblNodeSearchByTag;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.Button btnFindByText;
        private System.Windows.Forms.Button btnFindByTag;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.Button btnAddNode;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}