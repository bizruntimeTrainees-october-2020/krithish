using System;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace UdpServe
{
    class UdpServerr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server Waiting for the Connection"); // Print Statement
            UdpClient client =  new UdpClient(8080); //Establishes the udp connection
            IPEndPoint remoteip = new IPEndPoint(IPAddress.Any,8080); //Access the Port and IP Address
            byte[] receivedbytes = client.Receive(ref remoteip); // Receives from Client 
            if (receivedbytes != null)
            {
                string message = Encoding.ASCII.GetString(receivedbytes); //Decodes the Data
                Console.WriteLine("RECEIVED MESSAGE " + message);
            }
            else
            {
                Console.WriteLine("Empty Message Received ");
            }
            Console.ReadLine();
        }
    }
}
