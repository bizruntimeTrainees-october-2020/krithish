using System;
using System.Text;
using System.Net;
using System.Net.Sockets;



namespace UdpClientt
{
    class ClientSide
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client is Now Ready You Can Send Your Message");

            UdpClient client2 = new UdpClient();
            client2.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
            Console.Write(">");
            string inputs = Console.ReadLine();
            if (inputs != null)
            {
                byte[] bytesent = Encoding.ASCII.GetBytes(inputs);
                client2.Send(bytesent, bytesent.Length);
                Console.WriteLine(">Status:successfully message sent");
                client2.Close();
                Console.ReadLine();

            }
        }
    }
}
