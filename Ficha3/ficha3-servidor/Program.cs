using EI.SI;
using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ficha3_servidor
{
    class Program
    {
        private const int port = 10000;
        static void Main(string[] args)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
            TcpListener tcpListener = new TcpListener(endPoint);

            tcpListener.Start();
            Console.WriteLine("servidor pronto");
            int countClientes = 0;

            
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                countClientes++;
                Console.WriteLine("cliente {0} connected", countClientes);

            }
        }
    }
    class ClientHandler
    {
        private TcpClient client;
        private int clientID;

        public ClientHandler(TcpClient client,int clientID)
        {
            this.client = client;
            this.clientID = clientID;
        }

        public void Hndle()
        {
            Thread tread = new Thread(treadHandler);

        }

        private void treadHandler()
        {
            NetworkStream networkStream = this.client.GetStream();
            ProtocolSI protocolSI = new ProtocolSI();
        }

    }

}
