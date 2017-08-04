namespace InternetChecker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.postTb = new System.Windows.Forms.TextBox();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statuslb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sentlb = new System.Windows.Forms.Label();
            this.checklb = new System.Windows.Forms.Label();
            this.cbPost = new System.Windows.Forms.CheckBox();
            this.cbCheck = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // postTb
            // 
            this.postTb.Location = new System.Drawing.Point(16, 33);
            this.postTb.Name = "postTb";
            this.postTb.Size = new System.Drawing.Size(156, 20);
            this.postTb.TabIndex = 1;
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(16, 69);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(156, 20);
            this.urlTb.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statuslb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.urlTb);
            this.groupBox1.Controls.Add(this.postTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebInfo";
            // 
            // statuslb
            // 
            this.statuslb.AutoSize = true;
            this.statuslb.Location = new System.Drawing.Point(15, 106);
            this.statuslb.Name = "statuslb";
            this.statuslb.Size = new System.Drawing.Size(37, 13);
            this.statuslb.TabIndex = 6;
            this.statuslb.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL Check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL Post";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mailTb);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Url";
            // 
            // mailTb
            // 
            this.mailTb.Location = new System.Drawing.Point(16, 33);
            this.mailTb.Name = "mailTb";
            this.mailTb.Size = new System.Drawing.Size(156, 20);
            this.mailTb.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Start Post";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sentlb
            // 
            this.sentlb.AutoSize = true;
            this.sentlb.Location = new System.Drawing.Point(12, 238);
            this.sentlb.Name = "sentlb";
            this.sentlb.Size = new System.Drawing.Size(35, 13);
            this.sentlb.TabIndex = 6;
            this.sentlb.Text = "sentlb";
            // 
            // checklb
            // 
            this.checklb.AutoSize = true;
            this.checklb.Location = new System.Drawing.Point(12, 263);
            this.checklb.Name = "checklb";
            this.checklb.Size = new System.Drawing.Size(45, 13);
            this.checklb.TabIndex = 7;
            this.checklb.Text = "checklb";
            // 
            // cbPost
            // 
            this.cbPost.AutoSize = true;
            this.cbPost.Location = new System.Drawing.Point(5, 279);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(92, 17);
            this.cbPost.TabIndex = 8;
            this.cbPost.Text = "Autostart Post";
            this.cbPost.UseVisualStyleBackColor = true;
            // 
            // cbCheck
            // 
            this.cbCheck.AutoSize = true;
            this.cbCheck.Location = new System.Drawing.Point(114, 279);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Size = new System.Drawing.Size(102, 17);
            this.cbCheck.TabIndex = 9;
            this.cbCheck.Text = "Autostart Check";
            this.cbCheck.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Still running";
            this.notifyIcon1.BalloonTipTitle = "RUNNING";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Internt Checker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 333);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.cbPost);
            this.Controls.Add(this.checklb);
            this.Controls.Add(this.sentlb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "InternetChecker";
            this.Resize += new System.EventHandler(this.ImportStatusForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox postTb;
        private System.Windows.Forms.TextBox urlTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sentlb;
        private System.Windows.Forms.Label checklb;
        private System.Windows.Forms.Label statuslb;
        private System.Windows.Forms.CheckBox cbPost;
        private System.Windows.Forms.CheckBox cbCheck;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

