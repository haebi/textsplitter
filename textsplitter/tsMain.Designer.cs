namespace charbytearray
{
    partial class Form1
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
            this.pnlMainBG = new System.Windows.Forms.Panel();
            this.pnlMainBottom = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlMainTop = new System.Windows.Forms.Panel();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.txtCodePage = new System.Windows.Forms.TextBox();
            this.btnByteArr = new System.Windows.Forms.Button();
            this.btnCharArr = new System.Windows.Forms.Button();
            this.pnlMainBGG = new System.Windows.Forms.Panel();
            this.pnlMainBG.SuspendLayout();
            this.pnlMainBottom.SuspendLayout();
            this.pnlMainTop.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMainBGG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainBG
            // 
            this.pnlMainBG.Controls.Add(this.pnlMainBottom);
            this.pnlMainBG.Controls.Add(this.pnlMainTop);
            this.pnlMainBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainBG.Location = new System.Drawing.Point(0, 0);
            this.pnlMainBG.Name = "pnlMainBG";
            this.pnlMainBG.Size = new System.Drawing.Size(519, 540);
            this.pnlMainBG.TabIndex = 0;
            // 
            // pnlMainBottom
            // 
            this.pnlMainBottom.Controls.Add(this.txtLog);
            this.pnlMainBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainBottom.Location = new System.Drawing.Point(0, 100);
            this.pnlMainBottom.Name = "pnlMainBottom";
            this.pnlMainBottom.Size = new System.Drawing.Size(519, 440);
            this.pnlMainBottom.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(519, 440);
            this.txtLog.TabIndex = 0;
            // 
            // pnlMainTop
            // 
            this.pnlMainTop.Controls.Add(this.txtMsg);
            this.pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMainTop.Name = "pnlMainTop";
            this.pnlMainTop.Size = new System.Drawing.Size(519, 100);
            this.pnlMainTop.TabIndex = 0;
            // 
            // txtMsg
            // 
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsg.Location = new System.Drawing.Point(0, 0);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(519, 100);
            this.txtMsg.TabIndex = 0;
            this.txtMsg.Text = "Input text here.\r\n이곳에 메시지를 입력하세요.";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.groupBox1);
            this.pnlButton.Controls.Add(this.btnCharArr);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButton.Location = new System.Drawing.Point(519, 0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(190, 540);
            this.pnlButton.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHex);
            this.groupBox1.Controls.Add(this.txtCodePage);
            this.groupBox1.Controls.Add(this.btnByteArr);
            this.groupBox1.Location = new System.Drawing.Point(6, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkHex
            // 
            this.chkHex.AutoSize = true;
            this.chkHex.Location = new System.Drawing.Point(6, 65);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(130, 16);
            this.chkHex.TabIndex = 2;
            this.chkHex.Text = "show as hex code";
            this.chkHex.UseVisualStyleBackColor = true;
            // 
            // txtCodePage
            // 
            this.txtCodePage.Location = new System.Drawing.Point(6, 38);
            this.txtCodePage.Name = "txtCodePage";
            this.txtCodePage.Size = new System.Drawing.Size(166, 21);
            this.txtCodePage.TabIndex = 2;
            // 
            // btnByteArr
            // 
            this.btnByteArr.Location = new System.Drawing.Point(4, 10);
            this.btnByteArr.Name = "btnByteArr";
            this.btnByteArr.Size = new System.Drawing.Size(168, 23);
            this.btnByteArr.TabIndex = 0;
            this.btnByteArr.Text = "To byte array";
            this.btnByteArr.UseVisualStyleBackColor = true;
            this.btnByteArr.Click += new System.EventHandler(this.btnByteArr_Click);
            // 
            // btnCharArr
            // 
            this.btnCharArr.Location = new System.Drawing.Point(6, 12);
            this.btnCharArr.Name = "btnCharArr";
            this.btnCharArr.Size = new System.Drawing.Size(178, 23);
            this.btnCharArr.TabIndex = 0;
            this.btnCharArr.Text = "To char array";
            this.btnCharArr.UseVisualStyleBackColor = true;
            this.btnCharArr.Click += new System.EventHandler(this.btnCharArr_Click);
            // 
            // pnlMainBGG
            // 
            this.pnlMainBGG.Controls.Add(this.pnlMainBG);
            this.pnlMainBGG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainBGG.Location = new System.Drawing.Point(0, 0);
            this.pnlMainBGG.Name = "pnlMainBGG";
            this.pnlMainBGG.Size = new System.Drawing.Size(519, 540);
            this.pnlMainBGG.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 540);
            this.Controls.Add(this.pnlMainBGG);
            this.Controls.Add(this.pnlButton);
            this.Name = "Form1";
            this.Text = "text splitter v0.1";
            this.pnlMainBG.ResumeLayout(false);
            this.pnlMainBottom.ResumeLayout(false);
            this.pnlMainBottom.PerformLayout();
            this.pnlMainTop.ResumeLayout(false);
            this.pnlMainTop.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMainBGG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainBG;
        private System.Windows.Forms.Panel pnlMainBottom;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel pnlMainTop;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnByteArr;
        private System.Windows.Forms.Button btnCharArr;
        private System.Windows.Forms.Panel pnlMainBGG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodePage;
        private System.Windows.Forms.CheckBox chkHex;
    }
}

