﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace SOCKET_NEW
{
    public partial class Client : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);
        string message = string.Empty;
        string before_name;
        string name_save;
        int sw = 0;
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public Client()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e) // 종료 누르면
        {
            this.Dispose();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            
            clientSocket.Connect(ip.Text, Int32.Parse(port.Text));
            stream = clientSocket.GetStream();
            
            message = "Connected to Chat Server";
            DisplayText(message);
            name_save = this.name.Text;
            before_name = name_save;

            byte[] buffer = Encoding.Unicode.GetBytes(name_save + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread t_handler = new Thread(GetMessage);
            t_handler.IsBackground = true;
            t_handler.Start();
        }

        private void GetMessage()
        {
            while (true)
            {
                stream = clientSocket.GetStream();
                int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[BUFFERSIZE];
                int bytes = stream.Read(buffer, 0, buffer.Length);

                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                
                DisplayText(message);
            }
        }

        private bool WordCheck(string str)
        {
            //192.168.19.1
            if (str.Equals(name_save))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void DisplayText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new MethodInvoker(delegate
                {

                    if (sw == 1)
                    {
                        text = name_save + text.Substring(before_name.Length);
                    }

                    int length = richTextBox1.TextLength;
                    richTextBox1.AppendText(text + Environment.NewLine);

                    

                    string[] t = text.Split();
                    if (WordCheck(t[0]))
                    {
                        richTextBox1.Select(length, text.Length);
                        richTextBox1.SelectionColor = Color.Blue;
                    }
                }));
            }
            else
                richTextBox1.AppendText(text  + Environment.NewLine);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            
            byte[] buffer = Encoding.Unicode.GetBytes(this.comment.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            comment.Text = "";
            stream.Flush();
        }

       
    }
}
