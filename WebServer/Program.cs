using System.Net;
using System.Net.Sockets;
using System.Text;

while (true)
{
    TcpListener server = new TcpListener(IPAddress.Any, 8080);
    server.Start();
    TcpClient client = server.AcceptTcpClient();

    NetworkStream stream = client.GetStream();

    byte[] buffer = new byte[1024];
    int bytesRead = stream.Read(buffer, 0, buffer.Length);
    string requestText = Encoding.UTF8.GetString(buffer, 0, bytesRead);
    Console.WriteLine("Request: " + requestText);
    string[] lines = requestText.Split("\n");
    string requestLines = lines[0];

    // will be sent to client
    string html = "<html><body><h1><h1>Hello from Sofiane :D</h1></body></html>";

    string response =
        "HTTP/1.1 200 OK\r\n"
        + "Content-Type: text/html\r\n"
        + $"Content-Length: {Encoding.UTF8.GetByteCount(html)}\r\n"
        + "Connection: close\r\n"
        + "\r\n"
        + html;

    byte[] responseBytes = Encoding.UTF8.GetBytes(response);

    stream.Write(responseBytes, 0, responseBytes.Length);
    stream.Close();
    client.Close();
    server.Stop();
}
