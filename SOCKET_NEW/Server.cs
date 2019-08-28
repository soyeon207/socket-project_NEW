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
        TcpListener server = null;
        TcpClient clientSocket = null;
        static int counter = 0;
        int p;

        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public Server()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            p = Int32.Parse(port.Text);
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        public void NameChange(string str)
        {
            clientSocket = server.AcceptTcpClient();
            NetworkStream stream = clientSocket.GetStream();
            byte[] buffer = new byte[1024];
            int bytes = stream.Read(buffer, 0, buffer.Length);
            string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
            user_name = user_name.Substring(0, user_name.IndexOf("$"));

            clientList.Add(clientSocket, user_name);
        }
        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Parse(ip.Text), p);
            clientSocket = default(TcpClient);
            server.Start();
            DisplayText(">> Server Started");

            while (true)
            {
                try
                {
                    counter++;
                    clientSocket = server.AcceptTcpClient();
                    DisplayText(">> Accept connection from client");

                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                    user_name = user_name.Substring(0, user_name.IndexOf("$"));

                    clientList.Add(clientSocket, user_name);

                    // send message all user
                    SendMessageAll(user_name + " Joined ", "", false);

                    handleClient h_client = new handleClient();
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
            server.Stop();
        }

        void h_client_OnDisconnected(TcpClient clientSocket)
        {
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }

        private void OnReceived(string message, string user_name)
        {
            string displayMessage = "From client : " + user_name + " : " + message;
            DisplayText(displayMessage);
            SendMessageAll(message, user_name, true);
        }

        public void SendMessageAll(string message, string user_name, bool flag)
        {
            foreach (var pair in clientList)
            {
                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                    buffer = Encoding.Unicode.GetBytes(user_name + " says : " + message);
                }
                else
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }

                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }

        private void DisplayText(string text)
        {
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
        {
            this.Dispose();
        }

        private void Ip_chk_Click(object sender, EventArgs e)
        {
            ip_txt.Text = Get_MyIP();
        }

        public string Get_MyIP()
        {
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            string myip = host.AddressList[0].ToString();
            return myip;
        }
    }
}
