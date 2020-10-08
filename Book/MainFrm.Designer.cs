namespace Book
{
    partial class MainFrm
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
            this.trVw = new System.Windows.Forms.TreeView();
            this.grpBxSelectedNodeInformation = new System.Windows.Forms.GroupBox();
            this.grpBxReviews = new System.Windows.Forms.GroupBox();
            this.txtBxEval = new System.Windows.Forms.TextBox();
            this.lblEval = new System.Windows.Forms.Label();
            this.txtBxText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtBxAppendices = new System.Windows.Forms.TextBox();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.txtBxChapters = new System.Windows.Forms.TextBox();
            this.txtBxPages = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.txtBxPublisher = new System.Windows.Forms.TextBox();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.txtBxISBN = new System.Windows.Forms.TextBox();
            this.grpBxAuthors = new System.Windows.Forms.GroupBox();
            this.txtBxFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAppendices = new System.Windows.Forms.Label();
            this.lblChapters = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.cmbBxIsbn = new System.Windows.Forms.ComboBox();
            this.lblRemoveIsbn = new System.Windows.Forms.Label();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.grpBxSelectedNodeInformation.SuspendLayout();
            this.grpBxReviews.SuspendLayout();
            this.grpBxAuthors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trVw
            // 
            this.trVw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trVw.Location = new System.Drawing.Point(0, 0);
            this.trVw.Name = "trVw";
            this.trVw.Size = new System.Drawing.Size(310, 633);
            this.trVw.TabIndex = 0;
            // 
            // grpBxSelectedNodeInformation
            // 
            this.grpBxSelectedNodeInformation.Controls.Add(this.grpBxReviews);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxAppendices);
            this.grpBxSelectedNodeInformation.Controls.Add(this.btnAddNode);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxChapters);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxPages);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxPrice);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxPublisher);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxTitle);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxISBN);
            this.grpBxSelectedNodeInformation.Controls.Add(this.grpBxAuthors);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblAppendices);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblChapters);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblPages);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblPrice);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblPublisher);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblTitle);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblIsbn);
            this.grpBxSelectedNodeInformation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxSelectedNodeInformation.Location = new System.Drawing.Point(12, 12);
            this.grpBxSelectedNodeInformation.Name = "grpBxSelectedNodeInformation";
            this.grpBxSelectedNodeInformation.Size = new System.Drawing.Size(324, 482);
            this.grpBxSelectedNodeInformation.TabIndex = 1;
            this.grpBxSelectedNodeInformation.TabStop = false;
            this.grpBxSelectedNodeInformation.Text = "Book Information";
            // 
            // grpBxReviews
            // 
            this.grpBxReviews.Controls.Add(this.txtBxEval);
            this.grpBxReviews.Controls.Add(this.lblEval);
            this.grpBxReviews.Controls.Add(this.txtBxText);
            this.grpBxReviews.Controls.Add(this.lblText);
            this.grpBxReviews.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxReviews.Location = new System.Drawing.Point(6, 276);
            this.grpBxReviews.Name = "grpBxReviews";
            this.grpBxReviews.Size = new System.Drawing.Size(312, 164);
            this.grpBxReviews.TabIndex = 16;
            this.grpBxReviews.TabStop = false;
            this.grpBxReviews.Text = "Review Information";
            // 
            // txtBxEval
            // 
            this.txtBxEval.Location = new System.Drawing.Point(97, 23);
            this.txtBxEval.Multiline = true;
            this.txtBxEval.Name = "txtBxEval";
            this.txtBxEval.Size = new System.Drawing.Size(210, 49);
            this.txtBxEval.TabIndex = 24;
            // 
            // lblEval
            // 
            this.lblEval.AutoSize = true;
            this.lblEval.ForeColor = System.Drawing.Color.Black;
            this.lblEval.Location = new System.Drawing.Point(58, 26);
            this.lblEval.Name = "lblEval";
            this.lblEval.Size = new System.Drawing.Size(31, 13);
            this.lblEval.TabIndex = 16;
            this.lblEval.Text = "Eval:";
            // 
            // txtBxText
            // 
            this.txtBxText.Location = new System.Drawing.Point(97, 78);
            this.txtBxText.Multiline = true;
            this.txtBxText.Name = "txtBxText";
            this.txtBxText.Size = new System.Drawing.Size(210, 48);
            this.txtBxText.TabIndex = 15;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.ForeColor = System.Drawing.Color.Black;
            this.lblText.Location = new System.Drawing.Point(58, 78);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 13;
            this.lblText.Text = "Text:";
            // 
            // txtBxAppendices
            // 
            this.txtBxAppendices.Location = new System.Drawing.Point(102, 158);
            this.txtBxAppendices.Name = "txtBxAppendices";
            this.txtBxAppendices.Size = new System.Drawing.Size(210, 20);
            this.txtBxAppendices.TabIndex = 23;
            // 
            // btnAddNode
            // 
            this.btnAddNode.ForeColor = System.Drawing.Color.Black;
            this.btnAddNode.Location = new System.Drawing.Point(233, 446);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(85, 23);
            this.btnAddNode.TabIndex = 2;
            this.btnAddNode.Text = "Add";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // txtBxChapters
            // 
            this.txtBxChapters.Location = new System.Drawing.Point(102, 134);
            this.txtBxChapters.Name = "txtBxChapters";
            this.txtBxChapters.Size = new System.Drawing.Size(210, 20);
            this.txtBxChapters.TabIndex = 22;
            // 
            // txtBxPages
            // 
            this.txtBxPages.Location = new System.Drawing.Point(102, 111);
            this.txtBxPages.Name = "txtBxPages";
            this.txtBxPages.Size = new System.Drawing.Size(210, 20);
            this.txtBxPages.TabIndex = 21;
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(102, 88);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(210, 20);
            this.txtBxPrice.TabIndex = 20;
            // 
            // txtBxPublisher
            // 
            this.txtBxPublisher.Location = new System.Drawing.Point(102, 65);
            this.txtBxPublisher.Name = "txtBxPublisher";
            this.txtBxPublisher.Size = new System.Drawing.Size(210, 20);
            this.txtBxPublisher.TabIndex = 19;
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(102, 42);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(210, 20);
            this.txtBxTitle.TabIndex = 18;
            // 
            // txtBxISBN
            // 
            this.txtBxISBN.Location = new System.Drawing.Point(102, 19);
            this.txtBxISBN.Name = "txtBxISBN";
            this.txtBxISBN.Size = new System.Drawing.Size(210, 20);
            this.txtBxISBN.TabIndex = 17;
            // 
            // grpBxAuthors
            // 
            this.grpBxAuthors.Controls.Add(this.txtBxFullName);
            this.grpBxAuthors.Controls.Add(this.lblFullName);
            this.grpBxAuthors.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxAuthors.Location = new System.Drawing.Point(6, 187);
            this.grpBxAuthors.Name = "grpBxAuthors";
            this.grpBxAuthors.Size = new System.Drawing.Size(312, 83);
            this.grpBxAuthors.TabIndex = 14;
            this.grpBxAuthors.TabStop = false;
            this.grpBxAuthors.Text = "Author Information";
            // 
            // txtBxFullName
            // 
            this.txtBxFullName.Location = new System.Drawing.Point(96, 23);
            this.txtBxFullName.Multiline = true;
            this.txtBxFullName.Name = "txtBxFullName";
            this.txtBxFullName.Size = new System.Drawing.Size(210, 48);
            this.txtBxFullName.TabIndex = 15;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(51, 26);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(38, 13);
            this.lblFullName.TabIndex = 13;
            this.lblFullName.Text = "Name:";
            // 
            // lblAppendices
            // 
            this.lblAppendices.AutoSize = true;
            this.lblAppendices.ForeColor = System.Drawing.Color.Black;
            this.lblAppendices.Location = new System.Drawing.Point(26, 161);
            this.lblAppendices.Name = "lblAppendices";
            this.lblAppendices.Size = new System.Drawing.Size(66, 13);
            this.lblAppendices.TabIndex = 11;
            this.lblAppendices.Text = "Appendices:";
            // 
            // lblChapters
            // 
            this.lblChapters.AutoSize = true;
            this.lblChapters.ForeColor = System.Drawing.Color.Black;
            this.lblChapters.Location = new System.Drawing.Point(40, 137);
            this.lblChapters.Name = "lblChapters";
            this.lblChapters.Size = new System.Drawing.Size(52, 13);
            this.lblChapters.TabIndex = 10;
            this.lblChapters.Text = "Chapters:";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.ForeColor = System.Drawing.Color.Black;
            this.lblPages.Location = new System.Drawing.Point(51, 114);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(40, 13);
            this.lblPages.TabIndex = 9;
            this.lblPages.Text = "Pages:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(58, 91);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.ForeColor = System.Drawing.Color.Black;
            this.lblPublisher.Location = new System.Drawing.Point(39, 68);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblPublisher.TabIndex = 2;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(62, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.ForeColor = System.Drawing.Color.Black;
            this.lblIsbn.Location = new System.Drawing.Point(57, 23);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 0;
            this.lblIsbn.Text = "ISBN:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trVw);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.btnLoadXml);
            this.splitContainer1.Panel2.Controls.Add(this.grpBxSelectedNodeInformation);
            this.splitContainer1.Size = new System.Drawing.Size(657, 633);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.cmbBxIsbn);
            this.groupBox2.Controls.Add(this.lblRemoveIsbn);
            this.groupBox2.Controls.Add(this.btnRemoveBook);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 500);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 91);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ISBN Information";
            // 
            // btnModify
            // 
            this.btnModify.ForeColor = System.Drawing.Color.Black;
            this.btnModify.Location = new System.Drawing.Point(142, 62);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 23);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // cmbBxIsbn
            // 
            this.cmbBxIsbn.FormattingEnabled = true;
            this.cmbBxIsbn.Location = new System.Drawing.Point(102, 23);
            this.cmbBxIsbn.Name = "cmbBxIsbn";
            this.cmbBxIsbn.Size = new System.Drawing.Size(210, 21);
            this.cmbBxIsbn.TabIndex = 14;
            this.cmbBxIsbn.SelectedIndexChanged += new System.EventHandler(this.cmbBxIsbn_SelectedIndexChanged);
            // 
            // lblRemoveIsbn
            // 
            this.lblRemoveIsbn.AutoSize = true;
            this.lblRemoveIsbn.ForeColor = System.Drawing.Color.Black;
            this.lblRemoveIsbn.Location = new System.Drawing.Point(62, 26);
            this.lblRemoveIsbn.Name = "lblRemoveIsbn";
            this.lblRemoveIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblRemoveIsbn.TabIndex = 13;
            this.lblRemoveIsbn.Text = "ISBN:";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveBook.Location = new System.Drawing.Point(233, 62);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveBook.TabIndex = 3;
            this.btnRemoveBook.Text = "Remove";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(245, 598);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(85, 23);
            this.btnLoadXml.TabIndex = 7;
            this.btnLoadXml.Text = "Load XML";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 633);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainFrm";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.grpBxSelectedNodeInformation.ResumeLayout(false);
            this.grpBxSelectedNodeInformation.PerformLayout();
            this.grpBxReviews.ResumeLayout(false);
            this.grpBxReviews.PerformLayout();
            this.grpBxAuthors.ResumeLayout(false);
            this.grpBxAuthors.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trVw;
        private System.Windows.Forms.GroupBox grpBxSelectedNodeInformation;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Label lblAppendices;
        private System.Windows.Forms.Label lblChapters;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox grpBxAuthors;
        private System.Windows.Forms.TextBox txtBxFullName;
        private System.Windows.Forms.TextBox txtBxISBN;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.TextBox txtBxPublisher;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.TextBox txtBxPages;
        private System.Windows.Forms.TextBox txtBxChapters;
        private System.Windows.Forms.TextBox txtBxAppendices;
        private System.Windows.Forms.GroupBox grpBxReviews;
        private System.Windows.Forms.Label lblEval;
        private System.Windows.Forms.TextBox txtBxText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRemoveIsbn;
        private System.Windows.Forms.ComboBox cmbBxIsbn;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtBxEval;
    }
}

