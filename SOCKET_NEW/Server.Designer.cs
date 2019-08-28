namespace SOCKET_NEW
{
    partial class Server
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.ip_chk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 171);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(579, 267);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.open);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(578, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅창 정보";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(484, 19);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 47);
            this.exit.TabIndex = 10;
            this.exit.Text = "종료";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(403, 19);
            this.open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 47);
            this.open.TabIndex = 9;
            this.open.Text = "열기";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(72, 46);
            this.port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(314, 21);
            this.port.TabIndex = 8;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(72, 22);
            this.ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(314, 21);
            this.ip.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ip_chk);
            this.groupBox2.Controls.Add(this.ip_txt);
            this.groupBox2.Location = new System.Drawing.Point(10, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "본인 ip 확인하기";
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(6, 20);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(462, 21);
            this.ip_txt.TabIndex = 0;
            // 
            // ip_chk
            // 
            this.ip_chk.Location = new System.Drawing.Point(474, 18);
            this.ip_chk.Name = "ip_chk";
            this.ip_chk.Size = new System.Drawing.Size(75, 23);
            this.ip_chk.TabIndex = 1;
            this.ip_chk.Text = "확인";
            this.ip_chk.UseVisualStyleBackColor = true;
            this.ip_chk.Click += new System.EventHandler(this.Ip_chk_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ip_chk;
        private System.Windows.Forms.TextBox ip_txt;
    }
}