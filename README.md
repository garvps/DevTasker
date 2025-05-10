# 🧠 DevTasker

**DevTasker** is a clean and extensible task management REST API built with ASP.NET Core (.NET 9). Designed as a learning and portfolio project, it demonstrates best practices in building scalable backend systems using minimal APIs, Entity Framework Core (SQLite), Swagger, and clean architecture principles.

---

## 🚀 Features

- Full CRUD support for tasks (`GET`, `POST`, `PUT`, `DELETE`)
- Minimal API style (.NET 9)
- Entity Framework Core (SQLite)
- Clean separation of concerns (Domain, Infrastructure, API)
- Swagger UI for testing and documentation
- Repository pattern and dependency injection

---

## 🛠 Tech Stack

- **Language**: C# (.NET 9)
- **Framework**: ASP.NET Core Minimal API
- **Database**: SQLite via EF Core
- **Documentation**: Swagger (Swashbuckle)

---

## 📁 Project Structure
DevTasker/
├── DevTasker.Api/ # ASP.NET Core API (entry point)
├── DevTasker.Domain/ # Entity models and interfaces
├── DevTasker.Infrastructure/ # Data access (EF Core, DbContext, Repositories)
├── DevTasker.Application/ # Reserved for business logic (currently minimal)
└── DevTasker.sln # Solution file

---

## 🧪 How to Run Locally

### 1. Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/DevTasker.git
cd DevTasker
dotnet restore
dotnet build
dotnet ef migrations add InitialCreate -p DevTasker.Infrastructure -s DevTasker.Api
dotnet ef database update -p DevTasker.Infrastructure -s DevTasker.Api
dotnet run --project DevTasker.Api
http://localhost:<your-port>/swagger ```




