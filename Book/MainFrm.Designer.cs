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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBxAppendices = new System.Windows.Forms.TextBox();
            this.txtBxChapters = new System.Windows.Forms.TextBox();
            this.txtBxPages = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.txtBxPublisher = new System.Windows.Forms.TextBox();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.txtBxISBN = new System.Windows.Forms.TextBox();
            this.lblAppendices = new System.Windows.Forms.Label();
            this.lblChapters = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.grpBxReviews = new System.Windows.Forms.GroupBox();
            this.txtBxText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtBxEval = new System.Windows.Forms.TextBox();
            this.lblEval = new System.Windows.Forms.Label();
            this.grpBxAuthors = new System.Windows.Forms.GroupBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLoadXML = new System.Windows.Forms.Button();
            this.grpBxISBNInformation = new System.Windows.Forms.GroupBox();
            this.cmbBxIsbn = new System.Windows.Forms.ComboBox();
            this.lblRemoveISBN = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpBxSelectedNodeInformation.SuspendLayout();
            this.grpBxReviews.SuspendLayout();
            this.grpBxAuthors.SuspendLayout();
            this.grpBxISBNInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // trVw
            // 
            this.trVw.Location = new System.Drawing.Point(0, -2);
            this.trVw.Name = "trVw";
            this.trVw.Size = new System.Drawing.Size(267, 751);
            this.trVw.TabIndex = 0;
            // 
            // grpBxSelectedNodeInformation
            // 
            this.grpBxSelectedNodeInformation.Controls.Add(this.btnAdd);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxAppendices);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxChapters);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxPages);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxPrice);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxPublisher);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxTitle);
            this.grpBxSelectedNodeInformation.Controls.Add(this.txtBxISBN);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblAppendices);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblChapters);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblPages);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblPrice);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblPublisher);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblTitle);
            this.grpBxSelectedNodeInformation.Controls.Add(this.lblISBN);
            this.grpBxSelectedNodeInformation.Controls.Add(this.grpBxReviews);
            this.grpBxSelectedNodeInformation.Controls.Add(this.grpBxAuthors);
            this.grpBxSelectedNodeInformation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxSelectedNodeInformation.Location = new System.Drawing.Point(273, 12);
            this.grpBxSelectedNodeInformation.Name = "grpBxSelectedNodeInformation";
            this.grpBxSelectedNodeInformation.Size = new System.Drawing.Size(369, 579);
            this.grpBxSelectedNodeInformation.TabIndex = 1;
            this.grpBxSelectedNodeInformation.TabStop = false;
            this.grpBxSelectedNodeInformation.Text = "Book Information";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(237, 529);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 25);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // txtBxAppendices
            // 
            this.txtBxAppendices.Location = new System.Drawing.Point(100, 169);
            this.txtBxAppendices.Name = "txtBxAppendices";
            this.txtBxAppendices.Size = new System.Drawing.Size(244, 20);
            this.txtBxAppendices.TabIndex = 15;
            // 
            // txtBxChapters
            // 
            this.txtBxChapters.Location = new System.Drawing.Point(100, 145);
            this.txtBxChapters.Name = "txtBxChapters";
            this.txtBxChapters.Size = new System.Drawing.Size(244, 20);
            this.txtBxChapters.TabIndex = 14;
            // 
            // txtBxPages
            // 
            this.txtBxPages.Location = new System.Drawing.Point(100, 121);
            this.txtBxPages.Name = "txtBxPages";
            this.txtBxPages.Size = new System.Drawing.Size(244, 20);
            this.txtBxPages.TabIndex = 13;
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(100, 97);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(244, 20);
            this.txtBxPrice.TabIndex = 12;
            // 
            // txtBxPublisher
            // 
            this.txtBxPublisher.Location = new System.Drawing.Point(99, 73);
            this.txtBxPublisher.Name = "txtBxPublisher";
            this.txtBxPublisher.Size = new System.Drawing.Size(245, 20);
            this.txtBxPublisher.TabIndex = 11;
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(99, 49);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(245, 20);
            this.txtBxTitle.TabIndex = 10;
            // 
            // txtBxISBN
            // 
            this.txtBxISBN.Location = new System.Drawing.Point(99, 25);
            this.txtBxISBN.Name = "txtBxISBN";
            this.txtBxISBN.Size = new System.Drawing.Size(245, 20);
            this.txtBxISBN.TabIndex = 9;
            // 
            // lblAppendices
            // 
            this.lblAppendices.AutoSize = true;
            this.lblAppendices.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAppendices.Location = new System.Drawing.Point(27, 172);
            this.lblAppendices.Name = "lblAppendices";
            this.lblAppendices.Size = new System.Drawing.Size(66, 13);
            this.lblAppendices.TabIndex = 8;
            this.lblAppendices.Text = "Appendices:";
            // 
            // lblChapters
            // 
            this.lblChapters.AutoSize = true;
            this.lblChapters.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblChapters.Location = new System.Drawing.Point(41, 148);
            this.lblChapters.Name = "lblChapters";
            this.lblChapters.Size = new System.Drawing.Size(52, 13);
            this.lblChapters.TabIndex = 7;
            this.lblChapters.Text = "Chapters:";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPages.Location = new System.Drawing.Point(53, 124);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(40, 13);
            this.lblPages.TabIndex = 6;
            this.lblPages.Text = "Pages:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPrice.Location = new System.Drawing.Point(59, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblPublisher.Location = new System.Drawing.Point(40, 76);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblPublisher.TabIndex = 4;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(63, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblISBN.Location = new System.Drawing.Point(58, 28);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            // 
            // grpBxReviews
            // 
            this.grpBxReviews.Controls.Add(this.txtBxText);
            this.grpBxReviews.Controls.Add(this.lblText);
            this.grpBxReviews.Controls.Add(this.txtBxEval);
            this.grpBxReviews.Controls.Add(this.lblEval);
            this.grpBxReviews.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxReviews.Location = new System.Drawing.Point(7, 322);
            this.grpBxReviews.Name = "grpBxReviews";
            this.grpBxReviews.Size = new System.Drawing.Size(356, 187);
            this.grpBxReviews.TabIndex = 1;
            this.grpBxReviews.TabStop = false;
            this.grpBxReviews.Text = "Review Information";
            // 
            // txtBxText
            // 
            this.txtBxText.Location = new System.Drawing.Point(92, 98);
            this.txtBxText.Multiline = true;
            this.txtBxText.Name = "txtBxText";
            this.txtBxText.Size = new System.Drawing.Size(244, 62);
            this.txtBxText.TabIndex = 5;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblText.Location = new System.Drawing.Point(55, 101);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Text:";
            // 
            // txtBxEval
            // 
            this.txtBxEval.Location = new System.Drawing.Point(92, 19);
            this.txtBxEval.Multiline = true;
            this.txtBxEval.Name = "txtBxEval";
            this.txtBxEval.Size = new System.Drawing.Size(244, 62);
            this.txtBxEval.TabIndex = 3;
            // 
            // lblEval
            // 
            this.lblEval.AutoSize = true;
            this.lblEval.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblEval.Location = new System.Drawing.Point(55, 22);
            this.lblEval.Name = "lblEval";
            this.lblEval.Size = new System.Drawing.Size(31, 13);
            this.lblEval.TabIndex = 2;
            this.lblEval.Text = "Eval:";
            // 
            // grpBxAuthors
            // 
            this.grpBxAuthors.Controls.Add(this.txtBxName);
            this.grpBxAuthors.Controls.Add(this.lblName);
            this.grpBxAuthors.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxAuthors.Location = new System.Drawing.Point(7, 209);
            this.grpBxAuthors.Name = "grpBxAuthors";
            this.grpBxAuthors.Size = new System.Drawing.Size(356, 106);
            this.grpBxAuthors.TabIndex = 0;
            this.grpBxAuthors.TabStop = false;
            this.grpBxAuthors.Text = "Author Information";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(92, 26);
            this.txtBxName.Multiline = true;
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(244, 62);
            this.txtBxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblName.Location = new System.Drawing.Point(48, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnLoadXML
            // 
            this.btnLoadXML.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLoadXML.Location = new System.Drawing.Point(529, 708);
            this.btnLoadXML.Name = "btnLoadXML";
            this.btnLoadXML.Size = new System.Drawing.Size(107, 25);
            this.btnLoadXML.TabIndex = 17;
            this.btnLoadXML.Text = "Load XML";
            this.btnLoadXML.UseVisualStyleBackColor = true;
            this.btnLoadXML.Click += new System.EventHandler(this.btnloadXml_Click);
            // 
            // grpBxISBNInformation
            // 
            this.grpBxISBNInformation.Controls.Add(this.cmbBxIsbn);
            this.grpBxISBNInformation.Controls.Add(this.lblRemoveISBN);
            this.grpBxISBNInformation.Controls.Add(this.btnModify);
            this.grpBxISBNInformation.Controls.Add(this.btnRemove);
            this.grpBxISBNInformation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBxISBNInformation.Location = new System.Drawing.Point(273, 598);
            this.grpBxISBNInformation.Name = "grpBxISBNInformation";
            this.grpBxISBNInformation.Size = new System.Drawing.Size(369, 104);
            this.grpBxISBNInformation.TabIndex = 2;
            this.grpBxISBNInformation.TabStop = false;
            this.grpBxISBNInformation.Text = "ISBN Information";
            // 
            // cmbBxIsbn
            // 
            this.cmbBxIsbn.FormattingEnabled = true;
            this.cmbBxIsbn.Location = new System.Drawing.Point(103, 29);
            this.cmbBxIsbn.Name = "cmbBxIsbn";
            this.cmbBxIsbn.Size = new System.Drawing.Size(240, 21);
            this.cmbBxIsbn.TabIndex = 21;
            // 
            // lblRemoveISBN
            // 
            this.lblRemoveISBN.AutoSize = true;
            this.lblRemoveISBN.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRemoveISBN.Location = new System.Drawing.Point(62, 32);
            this.lblRemoveISBN.Name = "lblRemoveISBN";
            this.lblRemoveISBN.Size = new System.Drawing.Size(35, 13);
            this.lblRemoveISBN.TabIndex = 6;
            this.lblRemoveISBN.Text = "ISBN:";
            // 
            // btnModify
            // 
            this.btnModify.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModify.Location = new System.Drawing.Point(143, 73);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(107, 25);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRemove.Location = new System.Drawing.Point(256, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 25);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 746);
            this.Controls.Add(this.btnLoadXML);
            this.Controls.Add(this.grpBxISBNInformation);
            this.Controls.Add(this.grpBxSelectedNodeInformation);
            this.Controls.Add(this.trVw);
            this.Name = "MainFrm";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.grpBxSelectedNodeInformation.ResumeLayout(false);
            this.grpBxSelectedNodeInformation.PerformLayout();
            this.grpBxReviews.ResumeLayout(false);
            this.grpBxReviews.PerformLayout();
            this.grpBxAuthors.ResumeLayout(false);
            this.grpBxAuthors.PerformLayout();
            this.grpBxISBNInformation.ResumeLayout(false);
            this.grpBxISBNInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trVw;
        private System.Windows.Forms.GroupBox grpBxSelectedNodeInformation;
        private System.Windows.Forms.Label lblAppendices;
        private System.Windows.Forms.Label lblChapters;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.GroupBox grpBxReviews;
        private System.Windows.Forms.GroupBox grpBxAuthors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBxAppendices;
        private System.Windows.Forms.TextBox txtBxChapters;
        private System.Windows.Forms.TextBox txtBxPages;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.TextBox txtBxPublisher;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.TextBox txtBxISBN;
        private System.Windows.Forms.TextBox txtBxText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtBxEval;
        private System.Windows.Forms.Label lblEval;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLoadXML;
        private System.Windows.Forms.GroupBox grpBxISBNInformation;
        private System.Windows.Forms.Label lblRemoveISBN;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbBxIsbn;
    }
}

