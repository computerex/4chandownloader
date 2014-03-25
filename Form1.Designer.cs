namespace googledownloader
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
            this.txtthreadurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndownload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtsavedir = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtthreadurl
            // 
            this.txtthreadurl.Location = new System.Drawing.Point(12, 25);
            this.txtthreadurl.Name = "txtthreadurl";
            this.txtthreadurl.Size = new System.Drawing.Size(277, 20);
            this.txtthreadurl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "thread url:";
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(223, 80);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(66, 23);
            this.btndownload.TabIndex = 9;
            this.btndownload.Text = "download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 26);
            this.progressBar1.TabIndex = 12;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(223, 51);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(66, 23);
            this.btnbrowse.TabIndex = 14;
            this.btnbrowse.Text = "browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtsavedir
            // 
            this.txtsavedir.Location = new System.Drawing.Point(12, 51);
            this.txtsavedir.Name = "txtsavedir";
            this.txtsavedir.Size = new System.Drawing.Size(196, 20);
            this.txtsavedir.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 134);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 258);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtsavedir);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtthreadurl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 296);
            this.MinimumSize = new System.Drawing.Size(317, 173);
            this.Name = "Form1";
            this.Text = "4chan downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtthreadurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtsavedir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

