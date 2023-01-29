using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDES_Client.Client
{
    public static class ServerClient
    {
        // Partially referenced MSDN for TCP Client implementation
        // Url: https://learn.microsoft.com/en-us/dotnet/api/system.net.sockets.tcpclient?view=net-6.0
        public static JObject Request(JObject jsonData, string? Token = null)
        {
            using TcpClient client = new TcpClient("127.0.0.1", (Int32)11000);

            String message = JsonConvert.SerializeObject(jsonData);

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            // Get a client stream for reading and writing.
            NetworkStream stream = client.GetStream();

            // Send the message to the connected TcpServer.
            stream.Write(data, 0, data.Length);

            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Received: {0}", responseData);

            return (JObject)JsonConvert.SerializeObject(responseData, Formatting.Indented);
        }
    }
}
