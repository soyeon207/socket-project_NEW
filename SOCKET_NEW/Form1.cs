﻿using System;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
        }
    }
}
