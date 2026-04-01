# 💬 LocalChat

A real-time, multi-user chat application running over a local network using **TCP sockets**. Built with .NET 8, the solution consists of two projects: **ChatServer** (console app) and **ChatClient** (Windows Forms).

---

## 📁 Project Structure

```
LocalChat/
├── ChatServer/          # TCP server application (.NET 8 Console)
│   ├── Program.cs       # Server logic, client management, message broadcasting
│   ├── Dockerfile       # Docker support
│   └── ChatServer.csproj
│
├── ChatClient/          # Windows Forms client application (.NET 8)
│   ├── Form1.cs         # Connection and messaging logic
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   └── ChatClient.csproj
│
└── LocalChat.sln        # Visual Studio Solution file
```

---

## ⚙️ Requirements

| Requirement | Version |
|---|---|
| .NET SDK | 8.0+ |
| Visual Studio | 2022+ (optional) |
| Operating System | Windows (for ChatClient) |
| Docker | Optional (for ChatServer) |

---

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/LocalChat.git
cd LocalChat
```

### 2. Start the ChatServer

```bash
cd ChatServer
dotnet run
```

Expected output:
```
Server Started, port 5000...
```

### 3. Start the ChatClient (open a separate window per user)

```bash
cd ChatClient
dotnet run
```

> ⚠️ **Important:** Make sure the server is running before launching any client.

---

## 🐳 Running with Docker (Server only)

```bash
cd ChatServer

# Build the image
docker build -t localchat-server .

# Run the container
docker run -p 5000:5000 localchat-server
```

---

## 🖥️ How to Use

1. Start **ChatServer** (keep the console window open).
2. Launch one or more **ChatClient** windows.
3. Enter your **username** in the text field.
4. Click the **Connect** button.
5. Type a message and press **Send** or hit **Enter**.
6. Messages are instantly broadcast to all connected clients.

---

## 🔧 How It Works

### Server (ChatServer)

- Listens on **port 5000** using `TcpListener`.
- Spawns a new async `Task` for each incoming connection.
- When a message arrives from one client, it **broadcasts** it to all other connected clients.
- Automatically removes a client from the list when it disconnects.

```
[Client A] ──► [Server] ──► [Client B]
                        ──► [Client C]
```

### Client (ChatClient)

- Connects to `127.0.0.1:5000` using `TcpClient`.
- Runs a background `Task` that continuously listens for incoming messages.
- Message format: `[Username]: Message content`
- Sent messages appear locally as `[Me]: Message`

---

## 🌐 Network Configuration

By default, the client connects to `127.0.0.1` (localhost). To connect from a different machine on the same network, update the IP address in `Form1.cs`:

```csharp
// Form1.cs - btnBaglan_Click method
await client.ConnectAsync("127.0.0.1", 5000);  // Replace with the server's IP address
```

To find the server's local IP address:

```bash
# Windows
ipconfig

# Linux / macOS
ip addr
```

> Make sure **port 5000** is allowed through the firewall on the server machine.

---

## ✨ Features

- ✅ Real-time messaging over TCP/IP
- ✅ Multi-user support (unlimited clients)
- ✅ Fully asynchronous I/O (async/await)
- ✅ Custom username support
- ✅ Send messages with Enter key
- ✅ Disconnect notification
- ✅ Docker support (server)
- ✅ Windows Forms GUI

---

## 🛠️ Tech Stack

| Technology | Purpose |
|---|---|
| C# / .NET 8 | Core language & runtime |
| System.Net.Sockets | TCP socket communication |
| Windows Forms | Client GUI |
| async / await | Asynchronous programming |
| Docker | Server containerization |

---

## 📌 Notes

- **ChatClient** runs on **Windows only** due to the Windows Forms dependency.
- **ChatServer** is cross-platform and runs on Linux and macOS as well.
- You can open multiple ChatClient windows on the same machine for local testing.
- Port 5000 must be open on the server machine's firewall for remote connections.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
