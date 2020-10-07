namespace DataGridView
{
    partial class PhoneBookFrm
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
            this.components = new System.ComponentModel.Container();
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DataGridView.AppData();
            this.pnl = new System.Windows.Forms.Panel();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxFullName = new System.Windows.Forms.TextBox();
            this.mskdTxtBxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.bttnNew = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBxSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.AllowUserToAddRows = false;
            this.dtGrdVw.AutoGenerateColumns = false;
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dtGrdVw.DataSource = this.phoneBookBindingSource;
            this.dtGrdVw.Location = new System.Drawing.Point(14, 290);
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.RowHeadersWidth = 51;
            this.dtGrdVw.Size = new System.Drawing.Size(655, 150);
            this.dtGrdVw.TabIndex = 11;
            this.dtGrdVw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtGrdVw_KeyUp);
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneBookBindingSource
            // 
            this.phoneBookBindingSource.DataMember = "PhoneBook";
            this.phoneBookBindingSource.DataSource = this.appData;
            this.phoneBookBindingSource.CurrentChanged += new System.EventHandler(this.phoneBookBindingSource_CurrentChanged);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.txtBxAddress);
            this.pnl.Controls.Add(this.txtBxEmail);
            this.pnl.Controls.Add(this.txtBxFullName);
            this.pnl.Controls.Add(this.mskdTxtBxPhoneNumber);
            this.pnl.Controls.Add(this.lblAddress);
            this.pnl.Controls.Add(this.lblEmail);
            this.pnl.Controls.Add(this.lblFullName);
            this.pnl.Controls.Add(this.lblPhoneNumber);
            this.pnl.Location = new System.Drawing.Point(14, 12);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(552, 230);
            this.pnl.TabIndex = 2;
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Address", true));
            this.txtBxAddress.Location = new System.Drawing.Point(98, 116);
            this.txtBxAddress.Multiline = true;
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.Size = new System.Drawing.Size(336, 98);
            this.txtBxAddress.TabIndex = 5;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "Email", true));
            this.txtBxEmail.Location = new System.Drawing.Point(98, 85);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(183, 20);
            this.txtBxEmail.TabIndex = 4;
            // 
            // txtBxFullName
            // 
            this.txtBxFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "FullName", true));
            this.txtBxFullName.Location = new System.Drawing.Point(98, 52);
            this.txtBxFullName.Name = "txtBxFullName";
            this.txtBxFullName.Size = new System.Drawing.Size(183, 20);
            this.txtBxFullName.TabIndex = 3;
            // 
            // mskdTxtBxPhoneNumber
            // 
            this.mskdTxtBxPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBookBindingSource, "PhoneNumber", true));
            this.mskdTxtBxPhoneNumber.Location = new System.Drawing.Point(98, 18);
            this.mskdTxtBxPhoneNumber.Mask = "(999) 000-0000";
            this.mskdTxtBxPhoneNumber.Name = "mskdTxtBxPhoneNumber";
            this.mskdTxtBxPhoneNumber.Size = new System.Drawing.Size(183, 20);
            this.mskdTxtBxPhoneNumber.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 116);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(14, 55);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(55, 13);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full name:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(14, 26);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // bttnNew
            // 
            this.bttnNew.Location = new System.Drawing.Point(331, 455);
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(75, 23);
            this.bttnNew.TabIndex = 12;
            this.bttnNew.Text = "New";
            this.bttnNew.UseVisualStyleBackColor = true;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(412, 455);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(75, 23);
            this.bttnEdit.TabIndex = 13;
            this.bttnEdit.Text = "Edit";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(493, 455);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 14;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(574, 455);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 23);
            this.bttnSave.TabIndex = 15;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.Location = new System.Drawing.Point(112, 248);
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(454, 20);
            this.txtBxSearch.TabIndex = 16;
            this.txtBxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxSearch_KeyUp);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(31, 249);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(44, 13);
            this.Search.TabIndex = 17;
            this.Search.Text = "Search:";
            // 
            // PhoneBookFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 492);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtBxSearch);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnNew);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.dtGrdVw);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhoneBookFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.PhoneBookFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVw;
        private System.Windows.Forms.BindingSource phoneBookBindingSource;
        private AppData appData;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxFullName;
        private System.Windows.Forms.MaskedTextBox mskdTxtBxPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button bttnNew;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBxSearch;
        private System.Windows.Forms.Label Search;
    }
}

