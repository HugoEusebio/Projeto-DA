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

namespace Ficha2_TS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string EnviarDados(string mensagem,string IP ,string porto)
        {
            TcpClient tcpclient = null;

            NetworkStream networkStream = null;

            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IP),
                    int.Parse(porto));

                tcpclient = new TcpClient();
                networkStream = tcpclient.GetStream();

                int bytesread = 0;

                byte[] msgBytes = Encoding.UTF8.GetBytes(mensagem);

                networkStream.Write(msgBytes, 0, msgBytes.Length);

                byte[] ack = new byte[tcpclient.ReceiveBufferSize];

                bytesread = networkStream.Read(ack, 0, ack.Length);

                string response  = Encoding.UTF8.GetString(ack);

                if (response = "")
                {
                    return "erro -resposta vazia";
                }
                return mensagem;

            }
            catch (Exception)
            {
                return "erro- nao foi possivel ligar ao servdor";
            }

            finally
            {
                if(networkStream != null)
                {
                    networkStream.Close();
                }
                if(tcpclient != null)
                {
                    tcpclient.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string response = EnviarDados(richTextBoxmsg.Text,
                textBoxcliente.Text, textBoxservidor.Text);

            richTextBoxmsg.AppendText("resposta do servidor : " + response + Environment.NewLine());
        }
    }
}
