// See https://using System.Net;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static List<TcpClient> clients = new();

    static async Task Main()
    {
        var listener = new TcpListener(IPAddress.Any, 5000);
        listener.Start();
        Console.WriteLine("Server Started, port 5000...");

        while (true)
        {
            var client = await listener.AcceptTcpClientAsync();
            clients.Add(client);
            Console.WriteLine("The new user connected!");
            _ = Task.Run(() => HandleClient(client));
        }
    }

    static async Task HandleClient(TcpClient sender)
    {
        var stream = sender.GetStream();
        var buffer = new byte[1024];

        try
        {
            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer);
                if (bytesRead == 0) break;

                string mesaj = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Message Received: {mesaj}");

                
                foreach (var client in clients)
                {
                    if (client != sender && client.Connected)
                    {
                        var data = Encoding.UTF8.GetBytes(mesaj);
                        await client.GetStream().WriteAsync(data);
                    }
                }
            }
        }
        catch { }
        finally
        {
            clients.Remove(sender);
            Console.WriteLine("User disconnected.");
        }
    }
}