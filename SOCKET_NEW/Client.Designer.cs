namespace SOCKET_NEW
{
    partial class Client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(387, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅창 정보";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(72, 105);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(266, 21);
            this.name.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "name";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(72, 64);
            this.port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(266, 21);
            this.port.TabIndex = 8;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(72, 22);
            this.ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(266, 21);
            this.ip.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
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
            // open
            // 
            this.open.Location = new System.Drawing.Point(402, 18);
            this.open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(151, 42);
            this.open.TabIndex = 0;
            this.open.Text = "열기";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(402, 76);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(151, 42);
            this.exit.TabIndex = 1;
            this.exit.Text = "종료";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 155);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(544, 196);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(11, 355);
            this.comment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(473, 21);
            this.comment.TabIndex = 11;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(490, 355);
            this.send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(66, 18);
            this.send.TabIndex = 12;
            this.send.Text = "보내기";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 397);
            this.Controls.Add(this.send);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.open);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
    }
}