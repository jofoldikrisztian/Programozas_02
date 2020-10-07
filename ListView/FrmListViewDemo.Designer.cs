namespace ListViewDemo
{
    partial class FrmListViewDemo
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lstVw = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBxId = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(43, 16);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 48);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lstVw
            // 
            this.lstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chName});
            this.lstVw.FullRowSelect = true;
            this.lstVw.GridLines = true;
            this.lstVw.HideSelection = false;
            this.lstVw.Location = new System.Drawing.Point(16, 127);
            this.lstVw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVw.Name = "lstVw";
            this.lstVw.Size = new System.Drawing.Size(507, 163);
            this.lstVw.TabIndex = 6;
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "ID";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // txtBxId
            // 
            this.txtBxId.Location = new System.Drawing.Point(101, 12);
            this.txtBxId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxId.Name = "txtBxId";
            this.txtBxId.Size = new System.Drawing.Size(132, 22);
            this.txtBxId.TabIndex = 2;
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(101, 44);
            this.txtBxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(132, 22);
            this.txtBxName.TabIndex = 3;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(101, 89);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(100, 28);
            this.bttnAdd.TabIndex = 4;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnRemove
            // 
            this.bttnRemove.Location = new System.Drawing.Point(211, 89);
            this.bttnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnRemove.Name = "bttnRemove";
            this.bttnRemove.Size = new System.Drawing.Size(100, 28);
            this.bttnRemove.TabIndex = 5;
            this.bttnRemove.Text = "Remove";
            this.bttnRemove.UseVisualStyleBackColor = true;
            this.bttnRemove.Click += new System.EventHandler(this.bttnRemove_Click);
            // 
            // FrmListViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 303);
            this.Controls.Add(this.bttnRemove);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.txtBxId);
            this.Controls.Add(this.lstVw);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListViewDemo";
            this.Text = "ListViewDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.TextBox txtBxId;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnRemove;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chName;
    }
}

