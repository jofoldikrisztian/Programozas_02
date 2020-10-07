namespace TreeView
{
    partial class NewNodeForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxText = new System.Windows.Forms.TextBox();
            this.txtBxTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(195, 111);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(17, 50);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text:";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(18, 78);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 3;
            this.lblTag.Text = "Tag:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(54, 19);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(228, 20);
            this.txtBxName.TabIndex = 4;
            // 
            // txtBxText
            // 
            this.txtBxText.Location = new System.Drawing.Point(54, 47);
            this.txtBxText.Name = "txtBxText";
            this.txtBxText.Size = new System.Drawing.Size(228, 20);
            this.txtBxText.TabIndex = 5;
            // 
            // txtBxTag
            // 
            this.txtBxTag.Location = new System.Drawing.Point(54, 75);
            this.txtBxTag.Name = "txtBxTag";
            this.txtBxTag.Size = new System.Drawing.Size(228, 20);
            this.txtBxTag.TabIndex = 6;
            // 
            // NewNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 150);
            this.Controls.Add(this.txtBxTag);
            this.Controls.Add(this.txtBxText);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSubmit);
            this.Name = "NewNodeForm";
            this.Text = "NewNodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxText;
        private System.Windows.Forms.TextBox txtBxTag;
    }
}