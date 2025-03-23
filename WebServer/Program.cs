using System.Net;
using System.Net.Sockets;
using System.Text;

// listener, accept any IP, 8080 as port
TcpListener server = new TcpListener(IPAddress.Any, 8080);
server.Start();

// waiting for the client to connect..
TcpClient client = server.AcceptTcpClient();

NetworkStream stream = client.GetStream();

// read binary data sent by client, convert it to string
byte[] buffer = new byte[1024];
int bytesRead = stream.Read(buffer, 0, buffer.Length);
string requestText = Encoding.UTF8.GetString(buffer, 0, bytesRead);
