using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chat_Client
{
    public partial class Form1 : Form
    {
        byte[] data = new byte[1024];
        string input, stringData;
        IPEndPoint ipep;
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            txtServerIP = ipep.ToString();
        }

        private void btnSendClient_Click(object sender, EventArgs e)
        {

        }
    }
}
