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

namespace Chat_Server
{
    public partial class Form1 : Form
    {
        IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
        Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] data = new byte[1024];
        //Socket client = newsock.Accept();
        //IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            newsock.Bind(ipep);
            newsock.Listen(10);
        }

        private void btnSendServer_Click(object sender, EventArgs e)
        {
            listBox1Server.Items.Add("Server: " + txtMessageServer.Text);
            txtMessageServer.Clear();
        }
    }
}
