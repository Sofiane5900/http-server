# HTTP Server in C# (Console)

A minimal HTTP server built from scratch using C# and `HttpListener`.  
This project runs from the console and serves HTTP responses (HTML/JSON) to any client (browser, Postman, curl...).

---

## 📌 Features

- ✅ Listens on `http://localhost:8080/`
- ✅ Handles incoming HTTP requests (GET)
- ✅ Sends basic HTML responses
- ✅ UTF-8 response encoding
- ✅ Pure console / no external dependencies

---

## 🛠 Technologies

- Language: C#
- Runtime: .NET 6+
- Core API: `System.Net.HttpListener`

---

## 🚀 Getting Started

```bash
git clone https://github.com/your-username/http-server-csharp.git
cd http-server-csharp
dotnet run
