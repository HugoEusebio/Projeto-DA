using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iniciar servidor...");

            TcpListener tcplistener = null;

            TcpClient tcpClient = null;

            NetworkStream networkStream = null;


            while (true)
            {
                try
                {

                    Console.WriteLine(" A ativar os portos...");

                    IPEndPoint endPoinit = new IPEndPoint(IPAddress.Loopback, 50001);

                    tcplistener = new TcpListener(endPoinit);

                    Console.WriteLine("A ESPERA DE LIGAÇAO");

                    tcplistener.Start();

                   tcpClient = tcplistener.AcceptTcpClient();

                    Console.WriteLine("NOVO CLIENTE");

                    networkStream = tcpClient.GetStream();

                    int byteRead = 0;

                    byte[] buffer = new byte[tcpClient.ReceiveBufferSize];

                    byteRead = networkStream.Read(buffer, 0, buffer.Length);


                    Console.WriteLine("informaçao recebida " + Encoding.UTF8.GetString(buffer, 0, buffer.Length));

                    float result = (int.Parse(Encoding.UTF8.GetString(buffer, 0, buffer.Length)) + 2) * 3;

                    byte[] ack = Encoding.UTF8.GetBytes(" ok!" + result);

                    networkStream.Write(ack, 0, ack.Length);

                }



                catch (Exception ex)
                {

                    Console.WriteLine(" errro " + ex.ToString());

                }

                finally
                {
                    if (networkStream != null)
                    {
                        networkStream.Close();

                    }
                    if (tcpClient != null)
                    {
                        tcpClient.Close();
                    }

                    if (tcplistener != null)
                    {
                        tcplistener.Stop();
                    }
                }
            }
        }

    }
}
    
