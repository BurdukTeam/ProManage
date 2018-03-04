namespace ProManage
{
    partial class ServerForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textSIP = new System.Windows.Forms.TextBox();
            this.textSPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(547, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(98, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Server";
            // 
            // labelIp
            // 
            this.labelIp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(158, 84);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(41, 32);
            this.labelIp.TabIndex = 2;
            this.labelIp.Text = "IP";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(588, 84);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(67, 32);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // textSIP
            // 
            this.textSIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSIP.Location = new System.Drawing.Point(220, 84);
            this.textSIP.Name = "textSIP";
            this.textSIP.Size = new System.Drawing.Size(336, 38);
            this.textSIP.TabIndex = 6;
            // 
            // textSPort
            // 
            this.textSPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSPort.Location = new System.Drawing.Point(661, 84);
            this.textSPort.Name = "textSPort";
            this.textSPort.Size = new System.Drawing.Size(336, 38);
            this.textSPort.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(164, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(335, 52);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartServer);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLog.Location = new System.Drawing.Point(164, 228);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(833, 373);
            this.textBoxLog.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(164, 627);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(649, 97);
            this.textBox2.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Location = new System.Drawing.Point(835, 627);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(162, 97);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Recieve);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Send);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.Location = new System.Drawing.Point(629, 145);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(335, 52);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.StopServer);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 1010);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textSPort);
            this.Controls.Add(this.textSIP);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.labelTitle);
            this.Name = "ServerForm";
            this.Text = "ProMng Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textSIP;
        private System.Windows.Forms.TextBox textSPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBoxLog;      //log text (errors, conctions, etc...)
        private System.Windows.Forms.TextBox textBox2;      //for testing
        private System.Windows.Forms.Button btnSend;        //for testing
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnStop;
    }
}

