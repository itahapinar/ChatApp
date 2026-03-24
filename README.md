# 💬 LocalChat - TCP Chat Application

> A simple real-time chat application built with C# using TCP sockets and Windows Forms.

---

## 📌 Overview

**LocalChat** is a desktop-based chat system that enables real-time communication between users over a local network.

The project demonstrates:

* TCP socket programming
* Asynchronous communication
* Multi-threaded message handling
* Windows Forms UI integration

---

## ⚙️ Technologies Used

* 💻 **C# (.NET 8 - WinForms)**
* 🌐 **TCP Sockets (TcpClient / NetworkStream)**
* 🧵 **Async / Await (Asynchronous Programming)**
* 🖥️ **Windows Forms UI**

---

## ✨ Features

* 🔗 Connect to server via IP and port
* 👤 Custom username support
* 💬 Real-time messaging
* ⌨️ Press **Enter** to send message
* 🔄 Continuous message listening (async)
* 🖥️ Simple and clean chat interface

---

## 🏗️ Project Structure

```
LocalChat/
│
├── ChatServer/
│   ├── Program.cs              # Server-side logic and startup point
│   └── ChatServer.csproj       # Server project file
│
├── ChatClient/
│   ├── Form1.cs                # Client-side chat logic
│   ├── Form1.Designer.cs       # Client UI design
│   └── ChatClient.csproj       # Client project file
│
└── LocalChat.sln               # Solution file containing both projects
```

---

## 🚀 How It Works

1. User enters a username
2. Clicks **Connect**
3. Client connects to server (`127.0.0.1:5000`)
4. Messages are:

   * Sent via `NetworkStream`
   * Received asynchronously in background thread
5. Chat is displayed in real-time

---

## 🔌 Connection Details

```csharp
await client.ConnectAsync("127.0.0.1", 5000);
```

> ⚠️ Make sure the **Chat Server is running** before connecting.

---

## ▶️ How to Run

### 1. Open Project

* Open `LocalChat.sln` in **Visual Studio**

### 2. Start Server

* Run your TCP server (required)

### 3. Run Client

* Start the ChatClient project

### 4. Connect & Chat

* Enter username
* Click **Connect**
* Start messaging 🚀

---

## 🧠 Key Concepts Demonstrated

* TCP Client-Server Architecture
* NetworkStream data transfer
* UTF-8 message encoding
* Thread-safe UI updates (`Invoke`)
* Async message listening loop

---

## ⚠️ Notes

* Works on **local network (localhost)**
* Server must be running first
* No encryption (educational project)

---

## 🔮 Possible Improvements

* 🔐 Add authentication system
* 🌍 Multi-client server support
* 🗂️ Message history (database)
* 🎨 Improved UI (DevExpress / Modern UI)
* 📡 Online user list
* 🔔 Notifications


---

## 📜 License

This project is for educational purposes.
