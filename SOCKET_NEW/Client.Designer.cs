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
            this.open = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Controls.Add(this.ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "채팅창 정보";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(460, 23);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(173, 52);
            this.open.TabIndex = 0;
            this.open.Text = "열기";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(460, 95);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(173, 52);
            this.exit.TabIndex = 1;
            this.exit.Text = "종료";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "port";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(82, 27);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(304, 25);
            this.ip.TabIndex = 7;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(82, 80);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(304, 25);
            this.port.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 211);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 244);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(82, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(304, 25);
            this.name.TabIndex = 10;
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(12, 471);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(540, 25);
            this.comment.TabIndex = 11;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(558, 471);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 12;
            this.send.Text = "보내기";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 520);
            this.Controls.Add(this.send);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.open);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button send;
    }
}