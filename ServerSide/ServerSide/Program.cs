using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ServerSide
{
    class MyServer
    {
        static void Main(string[] args)
        {
            int port = 13000;
            string IpAddress = "127.0.0.1";
            Socket ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAddress), port);
            ServerListener.Bind(ep);
            ServerListener.Listen(100);
            Console.WriteLine("Server is Listening and Ready....");
            Socket ClientSocket = default(Socket);
            int counter = 0; // TO SHOW NO OF CLIENTS 
            MyServer ms = new MyServer();
            while (true)
            {
                counter++;
                ClientSocket = ServerListener.Accept();
                Console.WriteLine(counter + "Client is Connected");
                Thread UserThread = new Thread(new ThreadStart(() => ms.User(ClientSocket)));
                UserThread.Start();
            }

         }

        public void User(Socket client)
        {
            while (true)
            {
                byte[] msg = new byte[1024];
                int size = client.Receive(msg);
                client.Send(msg, 0, size, SocketFlags.None);
            }
        }
    }
}
