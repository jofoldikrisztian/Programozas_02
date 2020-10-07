namespace TrackBar
{
    partial class FrmTrackBar
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
            this.pctrBxColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.trckBrBlue = new System.Windows.Forms.TrackBar();
            this.trckBrGreen = new System.Windows.Forms.TrackBar();
            this.trckBrRed = new System.Windows.Forms.TrackBar();
            this.lblCurrentColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxColor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrRed)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBxColor
            // 
            this.pctrBxColor.BackColor = System.Drawing.Color.Blue;
            this.pctrBxColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBxColor.Location = new System.Drawing.Point(12, 12);
            this.pctrBxColor.Name = "pctrBxColor";
            this.pctrBxColor.Size = new System.Drawing.Size(448, 107);
            this.pctrBxColor.TabIndex = 0;
            this.pctrBxColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick your slider here:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBlue);
            this.panel1.Controls.Add(this.lblGreen);
            this.panel1.Controls.Add(this.lblRed);
            this.panel1.Controls.Add(this.trckBrBlue);
            this.panel1.Controls.Add(this.trckBrGreen);
            this.panel1.Controls.Add(this.trckBrRed);
            this.panel1.Location = new System.Drawing.Point(16, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 178);
            this.panel1.TabIndex = 2;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(71, 120);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(31, 13);
            this.lblBlue.TabIndex = 5;
            this.lblBlue.Text = "Blue:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(63, 69);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 13);
            this.lblGreen.TabIndex = 4;
            this.lblGreen.Text = "Green:";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(72, 18);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 13);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Red:";
            // 
            // trckBrBlue
            // 
            this.trckBrBlue.Location = new System.Drawing.Point(108, 120);
            this.trckBrBlue.Maximum = 255;
            this.trckBrBlue.Name = "trckBrBlue";
            this.trckBrBlue.Size = new System.Drawing.Size(311, 45);
            this.trckBrBlue.TabIndex = 5;
            this.trckBrBlue.Scroll += new System.EventHandler(this.trckBr_Scroll);
            // 
            // trckBrGreen
            // 
            this.trckBrGreen.Location = new System.Drawing.Point(108, 69);
            this.trckBrGreen.Maximum = 255;
            this.trckBrGreen.Name = "trckBrGreen";
            this.trckBrGreen.Size = new System.Drawing.Size(311, 45);
            this.trckBrGreen.TabIndex = 4;
            this.trckBrGreen.Scroll += new System.EventHandler(this.trckBr_Scroll);
            // 
            // trckBrRed
            // 
            this.trckBrRed.Location = new System.Drawing.Point(108, 18);
            this.trckBrRed.Maximum = 255;
            this.trckBrRed.Name = "trckBrRed";
            this.trckBrRed.Size = new System.Drawing.Size(311, 45);
            this.trckBrRed.TabIndex = 3;
            this.trckBrRed.Scroll += new System.EventHandler(this.trckBr_Scroll);
            // 
            // lblCurrentColor
            // 
            this.lblCurrentColor.AutoSize = true;
            this.lblCurrentColor.Location = new System.Drawing.Point(13, 374);
            this.lblCurrentColor.Name = "lblCurrentColor";
            this.lblCurrentColor.Size = new System.Drawing.Size(71, 13);
            this.lblCurrentColor.TabIndex = 3;
            this.lblCurrentColor.Text = "Current Color:";
            // 
            // FrmTrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 415);
            this.Controls.Add(this.lblCurrentColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctrBxColor);
            this.Name = "FrmTrackBar";
            this.Text = "TrackBar";
            this.Load += new System.EventHandler(this.FrmTrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxColor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBrRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TrackBar trckBrBlue;
        private System.Windows.Forms.TrackBar trckBrGreen;
        private System.Windows.Forms.TrackBar trckBrRed;
        private System.Windows.Forms.Label lblCurrentColor;
    }
}

