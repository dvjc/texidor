namespace texidor
{
    partial class Texidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Texidor));
            this.grpCommon = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIcon = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.lbFormats = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnUpdateBrowser = new System.Windows.Forms.Button();
            this.lbBrowse = new System.Windows.Forms.ListBox();
            this.lbMirth = new System.Windows.Forms.ListBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.grpCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCommon
            // 
            this.grpCommon.Controls.Add(this.btnClear);
            this.grpCommon.Controls.Add(this.btnIcon);
            this.grpCommon.Controls.Add(this.checkBox1);
            this.grpCommon.Controls.Add(this.btnSave);
            this.grpCommon.Controls.Add(this.btnOpen);
            this.grpCommon.Location = new System.Drawing.Point(1, 0);
            this.grpCommon.Name = "grpCommon";
            this.grpCommon.Size = new System.Drawing.Size(79, 129);
            this.grpCommon.TabIndex = 0;
            this.grpCommon.TabStop = false;
            this.grpCommon.Text = "Common";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(10, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnIcon
            // 
            this.btnIcon.Location = new System.Drawing.Point(6, 129);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(58, 23);
            this.btnIcon.TabIndex = 2;
            this.btnIcon.Text = "Iconize";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Hide";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 42);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(63, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(86, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(505, 286);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(86, 2);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(505, 20);
            this.txtFileName.TabIndex = 2;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(7, 168);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(73, 50);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(10, 224);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(63, 23);
            this.btnFormat.TabIndex = 4;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // lbFormats
            // 
            this.lbFormats.FormattingEnabled = true;
            this.lbFormats.Items.AddRange(new object[] {
            "",
            "XML",
            "C#/Java",
            "Document",
            "Serialize",
            "Mirth"});
            this.lbFormats.Location = new System.Drawing.Point(7, 255);
            this.lbFormats.Name = "lbFormats";
            this.lbFormats.Size = new System.Drawing.Size(73, 30);
            this.lbFormats.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(86, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(505, 279);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(10, 289);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnUpdateBrowser
            // 
            this.btnUpdateBrowser.Location = new System.Drawing.Point(543, 1);
            this.btnUpdateBrowser.Name = "btnUpdateBrowser";
            this.btnUpdateBrowser.Size = new System.Drawing.Size(24, 21);
            this.btnUpdateBrowser.TabIndex = 8;
            this.btnUpdateBrowser.Text = "->";
            this.btnUpdateBrowser.UseVisualStyleBackColor = true;
            this.btnUpdateBrowser.Visible = false;
            this.btnUpdateBrowser.Click += new System.EventHandler(this.btnUpdateBrowser_Click);
            // 
            // lbBrowse
            // 
            this.lbBrowse.FormattingEnabled = true;
            this.lbBrowse.Location = new System.Drawing.Point(7, 321);
            this.lbBrowse.Name = "lbBrowse";
            this.lbBrowse.Size = new System.Drawing.Size(73, 30);
            this.lbBrowse.TabIndex = 9;
            this.lbBrowse.Click += new System.EventHandler(this.lbBrowse_Click);
            // 
            // lbMirth
            // 
            this.lbMirth.FormattingEnabled = true;
            this.lbMirth.Items.AddRange(new object[] {
            "Block Dude"});
            this.lbMirth.Location = new System.Drawing.Point(7, 321);
            this.lbMirth.Name = "lbMirth";
            this.lbMirth.Size = new System.Drawing.Size(73, 30);
            this.lbMirth.TabIndex = 10;
            this.lbMirth.Visible = false;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(568, 1);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(24, 21);
            this.btnAddToList.TabIndex = 11;
            this.btnAddToList.Text = "!!";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Visible = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // Texidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 319);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.lbMirth);
            this.Controls.Add(this.lbBrowse);
            this.Controls.Add(this.btnUpdateBrowser);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lbFormats);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.grpCommon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(610, 357);
            this.Name = "Texidor";
            this.Text = "Texidor";
            this.grpCommon.ResumeLayout(false);
            this.grpCommon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCommon;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.ListBox lbFormats;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnUpdateBrowser;
        private System.Windows.Forms.ListBox lbBrowse;
        private System.Windows.Forms.ListBox lbMirth;
        private System.Windows.Forms.Button btnAddToList;

    }
}

