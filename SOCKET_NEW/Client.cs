using System;
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
        string name_save;
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public Client() // 기본 생성자
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e) // 종료 누르면
        {
            byte[] buffer = Encoding.Unicode.GetBytes("leaveChat" + "$"); // leaveChat을 날려주고
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            this.Dispose(); // 창을 닫음
        }

        private void Open_Click(object sender, EventArgs e) // 열기 버튼을 누르면 
        {
            
            clientSocket.Connect(ip.Text, Int32.Parse(port.Text)); // 아이피와 포트 번호로 socket에 연결
            stream = clientSocket.GetStream();
            
            message = "Connected to Chat Server";
            DisplayText(message);
            name_save = this.name.Text;

            byte[] buffer = Encoding.Unicode.GetBytes(name_save + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread t_handler = new Thread(GetMessage);
            t_handler.IsBackground = true;
            t_handler.Start();
        }

        private void GetMessage() // 메세지를 받음
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

        private bool WordCheck(string str) // 본인의 이름과 보낸 문자의 이름을 비교
        {
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
        { // Server에 메세지 출력
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new MethodInvoker(delegate
                {

                    int length = richTextBox1.TextLength; 
                    richTextBox1.AppendText(text + Environment.NewLine); 

                    string[] t = text.Split();
                    if (WordCheck(t[0])) // 만일 같다면
                    {
                        richTextBox1.Select(length, text.Length);
                        richTextBox1.SelectionColor = Color.Blue; // 문장을 파란색으로 바꿔준다.
                    }
                }));
            }
            else
                richTextBox1.AppendText(text  + Environment.NewLine);
        }

        private void Send_Click(object sender, EventArgs e) // 보내기 버튼 눌렀을 때 
        {
            
            byte[] buffer = Encoding.Unicode.GetBytes(this.comment.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            comment.Text = ""; // comment에 있던 글자를 지워준다
            stream.Flush();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        { // 폼 닫을 때 실행되는 함수
            byte[] buffer = Encoding.Unicode.GetBytes("leaveChat" + "$"); // leaveChat을 날려줌
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            this.Dispose(); // 그리고 창을 닫음.
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
