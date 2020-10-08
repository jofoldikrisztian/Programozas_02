namespace Serializer
{
    partial class Serializer
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
            this.lstBxOriginalContent = new System.Windows.Forms.ListBox();
            this.lstBxLoadedContent = new System.Windows.Forms.ListBox();
            this.lblOriginalContent = new System.Windows.Forms.Label();
            this.lblLoadedContent = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBxSerializationType = new System.Windows.Forms.GroupBox();
            this.grpBxLoad = new System.Windows.Forms.GroupBox();
            this.rdBtnLoadXml = new System.Windows.Forms.RadioButton();
            this.rdBtnLoadBinary = new System.Windows.Forms.RadioButton();
            this.rdBtnLoadSoapXml = new System.Windows.Forms.RadioButton();
            this.grpBxSave = new System.Windows.Forms.GroupBox();
            this.rdBtnSaveXml = new System.Windows.Forms.RadioButton();
            this.rdBtnSoapXml = new System.Windows.Forms.RadioButton();
            this.rdBtnBinary = new System.Windows.Forms.RadioButton();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.grpBxSerializationType.SuspendLayout();
            this.grpBxLoad.SuspendLayout();
            this.grpBxSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxOriginalContent
            // 
            this.lstBxOriginalContent.FormattingEnabled = true;
            this.lstBxOriginalContent.Location = new System.Drawing.Point(24, 58);
            this.lstBxOriginalContent.Name = "lstBxOriginalContent";
            this.lstBxOriginalContent.Size = new System.Drawing.Size(241, 329);
            this.lstBxOriginalContent.TabIndex = 0;
            // 
            // lstBxLoadedContent
            // 
            this.lstBxLoadedContent.FormattingEnabled = true;
            this.lstBxLoadedContent.Location = new System.Drawing.Point(280, 58);
            this.lstBxLoadedContent.Name = "lstBxLoadedContent";
            this.lstBxLoadedContent.Size = new System.Drawing.Size(241, 329);
            this.lstBxLoadedContent.TabIndex = 1;
            // 
            // lblOriginalContent
            // 
            this.lblOriginalContent.AutoSize = true;
            this.lblOriginalContent.Location = new System.Drawing.Point(21, 39);
            this.lblOriginalContent.Name = "lblOriginalContent";
            this.lblOriginalContent.Size = new System.Drawing.Size(82, 13);
            this.lblOriginalContent.TabIndex = 2;
            this.lblOriginalContent.Text = "Original Content";
            // 
            // lblLoadedContent
            // 
            this.lblLoadedContent.AutoSize = true;
            this.lblLoadedContent.Location = new System.Drawing.Point(277, 39);
            this.lblLoadedContent.Name = "lblLoadedContent";
            this.lblLoadedContent.Size = new System.Drawing.Size(83, 13);
            this.lblLoadedContent.TabIndex = 3;
            this.lblLoadedContent.Text = "Loaded Content";
            this.lblLoadedContent.Click += new System.EventHandler(this.lblLoadedContent_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(878, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(878, 126);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(878, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // grpBxSerializationType
            // 
            this.grpBxSerializationType.Controls.Add(this.grpBxLoad);
            this.grpBxSerializationType.Controls.Add(this.grpBxSave);
            this.grpBxSerializationType.Location = new System.Drawing.Point(554, 58);
            this.grpBxSerializationType.Name = "grpBxSerializationType";
            this.grpBxSerializationType.Size = new System.Drawing.Size(298, 329);
            this.grpBxSerializationType.TabIndex = 7;
            this.grpBxSerializationType.TabStop = false;
            this.grpBxSerializationType.Text = "Serialization Type";
            // 
            // grpBxLoad
            // 
            this.grpBxLoad.Controls.Add(this.rdBtnLoadXml);
            this.grpBxLoad.Controls.Add(this.rdBtnLoadBinary);
            this.grpBxLoad.Controls.Add(this.rdBtnLoadSoapXml);
            this.grpBxLoad.Location = new System.Drawing.Point(7, 167);
            this.grpBxLoad.Name = "grpBxLoad";
            this.grpBxLoad.Size = new System.Drawing.Size(285, 146);
            this.grpBxLoad.TabIndex = 1;
            this.grpBxLoad.TabStop = false;
            this.grpBxLoad.Text = "Load";
            // 
            // rdBtnLoadXml
            // 
            this.rdBtnLoadXml.AutoSize = true;
            this.rdBtnLoadXml.Location = new System.Drawing.Point(19, 107);
            this.rdBtnLoadXml.Name = "rdBtnLoadXml";
            this.rdBtnLoadXml.Size = new System.Drawing.Size(47, 17);
            this.rdBtnLoadXml.TabIndex = 5;
            this.rdBtnLoadXml.TabStop = true;
            this.rdBtnLoadXml.Text = "XML";
            this.rdBtnLoadXml.UseVisualStyleBackColor = true;
            // 
            // rdBtnLoadBinary
            // 
            this.rdBtnLoadBinary.AutoSize = true;
            this.rdBtnLoadBinary.Location = new System.Drawing.Point(19, 40);
            this.rdBtnLoadBinary.Name = "rdBtnLoadBinary";
            this.rdBtnLoadBinary.Size = new System.Drawing.Size(54, 17);
            this.rdBtnLoadBinary.TabIndex = 3;
            this.rdBtnLoadBinary.TabStop = true;
            this.rdBtnLoadBinary.Text = "Binary";
            this.rdBtnLoadBinary.UseVisualStyleBackColor = true;
            this.rdBtnLoadBinary.CheckedChanged += new System.EventHandler(this.rdLoad_CheckedChanged);
            // 
            // rdBtnLoadSoapXml
            // 
            this.rdBtnLoadSoapXml.AutoSize = true;
            this.rdBtnLoadSoapXml.Location = new System.Drawing.Point(19, 74);
            this.rdBtnLoadSoapXml.Name = "rdBtnLoadSoapXml";
            this.rdBtnLoadSoapXml.Size = new System.Drawing.Size(79, 17);
            this.rdBtnLoadSoapXml.TabIndex = 4;
            this.rdBtnLoadSoapXml.TabStop = true;
            this.rdBtnLoadSoapXml.Text = "SOAP-XML";
            this.rdBtnLoadSoapXml.UseVisualStyleBackColor = true;
            // 
            // grpBxSave
            // 
            this.grpBxSave.Controls.Add(this.rdBtnSaveXml);
            this.grpBxSave.Controls.Add(this.rdBtnSoapXml);
            this.grpBxSave.Controls.Add(this.rdBtnBinary);
            this.grpBxSave.Location = new System.Drawing.Point(7, 20);
            this.grpBxSave.Name = "grpBxSave";
            this.grpBxSave.Size = new System.Drawing.Size(285, 146);
            this.grpBxSave.TabIndex = 0;
            this.grpBxSave.TabStop = false;
            this.grpBxSave.Text = "Save";
            // 
            // rdBtnSaveXml
            // 
            this.rdBtnSaveXml.AutoSize = true;
            this.rdBtnSaveXml.Location = new System.Drawing.Point(19, 99);
            this.rdBtnSaveXml.Name = "rdBtnSaveXml";
            this.rdBtnSaveXml.Size = new System.Drawing.Size(47, 17);
            this.rdBtnSaveXml.TabIndex = 2;
            this.rdBtnSaveXml.TabStop = true;
            this.rdBtnSaveXml.Text = "XML";
            this.rdBtnSaveXml.UseVisualStyleBackColor = true;
            this.rdBtnSaveXml.CheckedChanged += new System.EventHandler(this.rdSave_CheckedChange);
            // 
            // rdBtnSoapXml
            // 
            this.rdBtnSoapXml.AutoSize = true;
            this.rdBtnSoapXml.Location = new System.Drawing.Point(19, 66);
            this.rdBtnSoapXml.Name = "rdBtnSoapXml";
            this.rdBtnSoapXml.Size = new System.Drawing.Size(79, 17);
            this.rdBtnSoapXml.TabIndex = 1;
            this.rdBtnSoapXml.TabStop = true;
            this.rdBtnSoapXml.Text = "SOAP-XML";
            this.rdBtnSoapXml.UseVisualStyleBackColor = true;
            this.rdBtnSoapXml.CheckedChanged += new System.EventHandler(this.rdSave_CheckedChange);
            // 
            // rdBtnBinary
            // 
            this.rdBtnBinary.AutoSize = true;
            this.rdBtnBinary.Location = new System.Drawing.Point(19, 32);
            this.rdBtnBinary.Name = "rdBtnBinary";
            this.rdBtnBinary.Size = new System.Drawing.Size(54, 17);
            this.rdBtnBinary.TabIndex = 0;
            this.rdBtnBinary.TabStop = true;
            this.rdBtnBinary.Text = "Binary";
            this.rdBtnBinary.UseVisualStyleBackColor = true;
            this.rdBtnBinary.CheckedChanged += new System.EventHandler(this.rdSave_CheckedChange);
            // 
            // Serializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 414);
            this.Controls.Add(this.grpBxSerializationType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLoadedContent);
            this.Controls.Add(this.lblOriginalContent);
            this.Controls.Add(this.lstBxLoadedContent);
            this.Controls.Add(this.lstBxOriginalContent);
            this.Name = "Serializer";
            this.Text = "Serializer";
            this.grpBxSerializationType.ResumeLayout(false);
            this.grpBxLoad.ResumeLayout(false);
            this.grpBxLoad.PerformLayout();
            this.grpBxSave.ResumeLayout(false);
            this.grpBxSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxOriginalContent;
        private System.Windows.Forms.ListBox lstBxLoadedContent;
        private System.Windows.Forms.Label lblOriginalContent;
        private System.Windows.Forms.Label lblLoadedContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBxSerializationType;
        private System.Windows.Forms.GroupBox grpBxLoad;
        private System.Windows.Forms.RadioButton rdBtnLoadXml;
        private System.Windows.Forms.RadioButton rdBtnLoadBinary;
        private System.Windows.Forms.RadioButton rdBtnLoadSoapXml;
        private System.Windows.Forms.GroupBox grpBxSave;
        private System.Windows.Forms.RadioButton rdBtnSaveXml;
        private System.Windows.Forms.RadioButton rdBtnSoapXml;
        private System.Windows.Forms.RadioButton rdBtnBinary;
        private System.Windows.Forms.SaveFileDialog sfdSave;
    }
}

