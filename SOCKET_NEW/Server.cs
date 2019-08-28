using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SOCKET_NEW
{
    public partial class Server : Form
    {
        TcpListener server = null; // 서버
        TcpClient clientSocket = null; // 소켓
        static int counter = 0; // 사용자 수
        int p;
        string date; // 날자 저장하는 변수

        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public Server()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e) // 열기 버튼을 누르면 실행
        {
            p = Int32.Parse(port.Text);
            Thread t = new Thread(InitSocket); // Thread 생성
            t.IsBackground = true;
            t.Start(); // Thread 실행
        }

        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Parse(ip.Text), p);
            clientSocket = default(TcpClient); // 소켓을 설정함
            server.Start(); // 서버 시작
            DisplayText(">> Server Started");

            while (true)
            {
                try
                {
                    counter++; // 사용자 수 증가
                    clientSocket = server.AcceptTcpClient();
                    DisplayText(">> Accept connection from client");

                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                    user_name = user_name.Substring(0, user_name.IndexOf("$")); // 사용자 명

                    clientList.Add(clientSocket, user_name); // 이름 저장

                    SendMessageAll(user_name + " 님이 방에 들어왔습니다 ", "", false); // 모든 사용자에게 보낸다.

                    handleClient h_client = new handleClient(); // 클라이언트 추가
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
                    h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);
                    h_client.startClient(clientSocket, clientList);
                }
                catch (SocketException se)
                {
                    break;
                }
                catch (Exception ex)
                {
                    break;
                }
            }

            clientSocket.Close(); 
            server.Stop(); // 서버 종료
        }

        void h_client_OnDisconnected(TcpClient clientSocket)
        { // 클라이언트 접속 해제
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }

        private void OnReceived(string message, string user_name) // 문자가 오면 
        {
            if (message.Equals("leaveChat"))
            { // leaveChat을 받으면 채팅창을 떠난것이니깐 메세지로 표시해줌.
                string displayMessage = "leave user : " + user_name;
                DisplayText(displayMessage);
                SendMessageAll("leaveChat", user_name, true);
            }

            else
            {
                string displayMessage = "From client : " + user_name + " : " + message;
                DisplayText(displayMessage); // Server단에 출력
                SendMessageAll(message, user_name, true); // 모든 Client에게 전송
            }
        }

        public void SendMessageAll(string message, string user_name, bool flag)
        {
            foreach (var pair in clientList)

            {
                date = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss"); // 현재 날짜 받기

                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                    if (message.Equals("leaveChat"))
                        buffer = Encoding.Unicode.GetBytes(user_name + " 님이 대화방을 나갔습니다.");
                    else
                        buffer = Encoding.Unicode.GetBytes( user_name + " : " + message + " [" + date + "] "); //메세지를 보낸 날짜를 뒤에 표시
                }

                else
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }

                stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                stream.Flush();
            }

        }

        private void DisplayText(string text)
        { // Server 화면에 출력
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new MethodInvoker(delegate
                {
                    richTextBox1.AppendText(text + Environment.NewLine);
                }));
            }
            else
                richTextBox1.AppendText(text + Environment.NewLine);
        }

        private void Exit_Click(object sender, EventArgs e)
        { // 종료 버튼을 누르면
            this.Dispose(); // 창을 닫아줌
        }

        private void Ip_chk_Click(object sender, EventArgs e) // 본인 IP 확인하기를 누르면 
        {
            ip_txt.Text = Get_MyIP(); 
        }

        public string Get_MyIP() // 아이피 확인
        {
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            string myip = host.AddressList[0].ToString();
            return myip;
        }
    }
}
