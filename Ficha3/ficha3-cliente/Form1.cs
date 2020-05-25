using EI.SI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha3_cliente
{
    public partial class Form1 : Form
    {

        private const int PORT = 10000;
        NetworkStream networkstream;
        ProtocolSI protocolSI;
        TcpClient client;
        public Form1()
        {
            InitializeComponent();
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, Port);
            client = new TcpClient();
            client.Connect(endpoint);
            networkstream = client.GetStream();
            protocolSI = new ProtocolSI();


        }
        public int Port{ get; }
      
        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string msg = textBox1.Text;
            textBox1.Clear();
            byte[] packet = protocolSI.Make(ProtocolSICmdType.DATA, msg);
            networkstream.Write(packet, 0, packet.Length);
            while (protocolSI.GetCmdType() != ProtocolSICmdType.ACK)
            {
                networkstream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            }

        }

        private void CloseClient()
        {
            byte[] eot =protocolSI.Make(ProtocolSICmdType.EOT);
            networkstream.Write(eot, 0, eot.Length);
            networkstream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            networkstream.Close();
            client.Close();


        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            CloseClient();
            this.Close();
        }

        private void client_formClosing(object sender, FormClosingEventArgs e)
        {
            CloseClient();
        }
    }
}
