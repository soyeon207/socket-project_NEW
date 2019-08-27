using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCKET_NEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) // 종료 버튼 눌렀을 때 
        {
            this.Dispose(); // 창 종료
        }

        private void Client_Click(object sender, EventArgs e) // Client 버튼 눌렀을 때
        {
            Client client = new Client(); // Client 실행
            client.Show();
        }

        private void Server_Click(object sender, EventArgs e) // Server 버튼 눌렀을 때
        {
            Server server = new Server(); // Server 실행
            server.Show();
        }
    }
}
