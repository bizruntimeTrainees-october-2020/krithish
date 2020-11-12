using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace ClientSide
{
    class MyClient
    {
        static void Main(string[] args)
        {
            int port = 13000;
            string IpAddress = "127.0.0.1";
            Socket ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAddress), port);
            ClientSocket.Connect(ep);
            Console.WriteLine("Client Is Ready Type your Message....");
            
            
            while (true)
            {
                string messageFromClient = null;
                Console.WriteLine("Enter the Message");
                messageFromClient = Console.ReadLine();
                ClientSocket.Send(System.Text.Encoding.ASCII.GetBytes(messageFromClient), 0,
                    messageFromClient.Length, SocketFlags.None);
                
                byte[] MsgFromServer = new byte[1024];
                int size = ClientSocket.Receive(MsgFromServer);
                Console.WriteLine("Server" + System.Text.Encoding.ASCII.GetString(MsgFromServer, 0, size));

            }

        }
    }
   
} 
