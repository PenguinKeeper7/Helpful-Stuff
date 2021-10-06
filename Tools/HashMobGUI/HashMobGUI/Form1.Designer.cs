
namespace HashMobGUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.lblAPIKey = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnFindHashlist = new System.Windows.Forms.Button();
            this.lblHashlistLocation = new System.Windows.Forms.Label();
            this.txtHashlistLocation = new System.Windows.Forms.TextBox();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.txtOutputLocation = new System.Windows.Forms.TextBox();
            this.btnOutputHashlist = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.grpSearching = new System.Windows.Forms.GroupBox();
            this.linkAPIKey = new System.Windows.Forms.LinkLabel();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.lblETA = new System.Windows.Forms.Label();
            this.chkAlgoHashPass = new System.Windows.Forms.CheckBox();
            this.chkAppendOutput = new System.Windows.Forms.CheckBox();
            this.lblForgetAPIKey = new System.Windows.Forms.LinkLabel();
            this.grpSearching.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAPIKey.Location = new System.Drawing.Point(67, 34);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(216, 20);
            this.txtAPIKey.TabIndex = 2;
            this.txtAPIKey.Text = "Paste your API Key here (if you have one)";
            this.txtAPIKey.TextChanged += new System.EventHandler(this.txtAPIKey_TextChanged);
            this.txtAPIKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtAPIKey_MouseDown);
            // 
            // lblAPIKey
            // 
            this.lblAPIKey.AutoSize = true;
            this.lblAPIKey.Location = new System.Drawing.Point(13, 37);
            this.lblAPIKey.Name = "lblAPIKey";
            this.lblAPIKey.Size = new System.Drawing.Size(48, 13);
            this.lblAPIKey.TabIndex = 3;
            this.lblAPIKey.Text = "API Key:";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Location = new System.Drawing.Point(13, 136);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(0, 13);
            this.lblUserInfo.TabIndex = 4;
            // 
            // btnFindHashlist
            // 
            this.btnFindHashlist.Location = new System.Drawing.Point(289, 82);
            this.btnFindHashlist.Name = "btnFindHashlist";
            this.btnFindHashlist.Size = new System.Drawing.Size(75, 20);
            this.btnFindHashlist.TabIndex = 5;
            this.btnFindHashlist.Text = "Find Hashlist";
            this.btnFindHashlist.UseVisualStyleBackColor = true;
            this.btnFindHashlist.Click += new System.EventHandler(this.btnFindHashfile_Click);
            // 
            // lblHashlistLocation
            // 
            this.lblHashlistLocation.AutoSize = true;
            this.lblHashlistLocation.Location = new System.Drawing.Point(13, 85);
            this.lblHashlistLocation.Name = "lblHashlistLocation";
            this.lblHashlistLocation.Size = new System.Drawing.Size(47, 13);
            this.lblHashlistLocation.TabIndex = 7;
            this.lblHashlistLocation.Text = "Hashlist:";
            // 
            // txtHashlistLocation
            // 
            this.txtHashlistLocation.Location = new System.Drawing.Point(67, 82);
            this.txtHashlistLocation.Name = "txtHashlistLocation";
            this.txtHashlistLocation.Size = new System.Drawing.Size(216, 20);
            this.txtHashlistLocation.TabIndex = 0;
            // 
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Location = new System.Drawing.Point(1, 111);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(61, 13);
            this.lblOutputLocation.TabIndex = 10;
            this.lblOutputLocation.Text = "Output File:";
            // 
            // txtOutputLocation
            // 
            this.txtOutputLocation.Location = new System.Drawing.Point(67, 108);
            this.txtOutputLocation.Name = "txtOutputLocation";
            this.txtOutputLocation.Size = new System.Drawing.Size(216, 20);
            this.txtOutputLocation.TabIndex = 1;
            // 
            // btnOutputHashlist
            // 
            this.btnOutputHashlist.Location = new System.Drawing.Point(289, 108);
            this.btnOutputHashlist.Name = "btnOutputHashlist";
            this.btnOutputHashlist.Size = new System.Drawing.Size(75, 20);
            this.btnOutputHashlist.TabIndex = 8;
            this.btnOutputHashlist.Text = "Find Output";
            this.btnOutputHashlist.UseVisualStyleBackColor = true;
            this.btnOutputHashlist.Click += new System.EventHandler(this.btnOutputHashlist_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(289, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 38);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search Hashes";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Location = new System.Drawing.Point(13, 168);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(0, 13);
            this.lblFileInfo.TabIndex = 12;
            // 
            // grpSearching
            // 
            this.grpSearching.Controls.Add(this.linkAPIKey);
            this.grpSearching.Location = new System.Drawing.Point(4, 12);
            this.grpSearching.Name = "grpSearching";
            this.grpSearching.Size = new System.Drawing.Size(369, 201);
            this.grpSearching.TabIndex = 13;
            this.grpSearching.TabStop = false;
            this.grpSearching.Text = "Searching";
            // 
            // linkAPIKey
            // 
            this.linkAPIKey.AutoSize = true;
            this.linkAPIKey.Enabled = false;
            this.linkAPIKey.Location = new System.Drawing.Point(286, 22);
            this.linkAPIKey.Name = "linkAPIKey";
            this.linkAPIKey.Size = new System.Drawing.Size(65, 26);
            this.linkAPIKey.TabIndex = 0;
            this.linkAPIKey.TabStop = true;
            this.linkAPIKey.Text = "Get API Key\r\n/Credits";
            this.linkAPIKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAPIKey_LinkClicked);
            // 
            // grpOptions
            // 
            this.grpOptions.CausesValidation = false;
            this.grpOptions.Controls.Add(this.lblForgetAPIKey);
            this.grpOptions.Controls.Add(this.chkAppendOutput);
            this.grpOptions.Controls.Add(this.chkAlgoHashPass);
            this.grpOptions.Controls.Add(this.lblSeparator);
            this.grpOptions.Controls.Add(this.txtSeparator);
            this.grpOptions.Location = new System.Drawing.Point(379, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(172, 116);
            this.grpOptions.TabIndex = 14;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(8, 72);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(56, 13);
            this.lblSeparator.TabIndex = 16;
            this.lblSeparator.Text = "Separator:";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(65, 69);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(70, 20);
            this.txtSeparator.TabIndex = 15;
            this.txtSeparator.Text = ":";
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.Location = new System.Drawing.Point(379, 111);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(0, 13);
            this.lblETA.TabIndex = 15;
            // 
            // chkAlgoHashPass
            // 
            this.chkAlgoHashPass.AutoSize = true;
            this.chkAlgoHashPass.Location = new System.Drawing.Point(7, 20);
            this.chkAlgoHashPass.Name = "chkAlgoHashPass";
            this.chkAlgoHashPass.Size = new System.Drawing.Size(146, 17);
            this.chkAlgoHashPass.TabIndex = 17;
            this.chkAlgoHashPass.Text = "Format as algo hash:pass";
            this.chkAlgoHashPass.UseVisualStyleBackColor = true;
            this.chkAlgoHashPass.CheckedChanged += new System.EventHandler(this.chkAlgoHashPass_CheckedChanged);
            // 
            // chkAppendOutput
            // 
            this.chkAppendOutput.AutoSize = true;
            this.chkAppendOutput.Location = new System.Drawing.Point(7, 44);
            this.chkAppendOutput.Name = "chkAppendOutput";
            this.chkAppendOutput.Size = new System.Drawing.Size(110, 17);
            this.chkAppendOutput.TabIndex = 18;
            this.chkAppendOutput.Text = "Append to Output";
            this.chkAppendOutput.UseVisualStyleBackColor = true;
            this.chkAppendOutput.CheckedChanged += new System.EventHandler(this.chkAppendOutput_CheckedChanged);
            // 
            // lblForgetAPIKey
            // 
            this.lblForgetAPIKey.AutoSize = true;
            this.lblForgetAPIKey.Location = new System.Drawing.Point(6, 96);
            this.lblForgetAPIKey.Name = "lblForgetAPIKey";
            this.lblForgetAPIKey.Size = new System.Drawing.Size(78, 13);
            this.lblForgetAPIKey.TabIndex = 16;
            this.lblForgetAPIKey.TabStop = true;
            this.lblForgetAPIKey.Text = "Forget API Key";
            this.lblForgetAPIKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgetAPIKey_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 225);
            this.Controls.Add(this.lblETA);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblFileInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblOutputLocation);
            this.Controls.Add(this.txtOutputLocation);
            this.Controls.Add(this.btnOutputHashlist);
            this.Controls.Add(this.lblHashlistLocation);
            this.Controls.Add(this.txtHashlistLocation);
            this.Controls.Add(this.btnFindHashlist);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblAPIKey);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.grpSearching);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "HashMob GUI";
            this.grpSearching.ResumeLayout(false);
            this.grpSearching.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label lblAPIKey;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnFindHashlist;
        private System.Windows.Forms.Label lblHashlistLocation;
        private System.Windows.Forms.TextBox txtHashlistLocation;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.TextBox txtOutputLocation;
        private System.Windows.Forms.Button btnOutputHashlist;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.GroupBox grpSearching;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.LinkLabel linkAPIKey;
        private System.Windows.Forms.CheckBox chkAppendOutput;
        private System.Windows.Forms.CheckBox chkAlgoHashPass;
        private System.Windows.Forms.LinkLabel lblForgetAPIKey;
    }
}

