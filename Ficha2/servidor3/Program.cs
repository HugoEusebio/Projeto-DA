using System;

namespace servidor3
{
    class Program
    {
        private static string decifrarcomcesar(string message, int shift)
        {
            char[] buffer = message.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                letter = (char)(letter -shift)

            buffer[i] = letter;
        }
        return new string (buffer);
    }

        static void Main(string[] args)
        {
            Console.WriteLine("A iniciar servidor ");

            tcplistener tcplisterner = null;

            tcpClient tcpclient = null;

            networkstream networkstream = null;

            try
            {
                Console.WriteLine(" a aguardar");

                ipendpoint endpoint = new ipendpoint(IPAddress.loopback);

                tcplisterner = new tcplistener(endpoint);

                tcplisterner.start();
                tcpclient = tcplisterner.accepttcpclient();


                    }
        }
    }
}
