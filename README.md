# DevTasker

**DevTasker** is a clean and extensible task management REST API built with ASP.NET Core (.NET 9). Designed as a learning and portfolio project, it demonstrates best practices in building scalable backend systems using minimal APIs, Entity Framework Core (SQLite), Swagger, and clean architecture principles.

---

## Features

- Full CRUD support for tasks (`GET`, `POST`, `PUT`, `DELETE`)
- Minimal API style (.NET 9)
- Entity Framework Core (SQLite)
- Clean separation of concerns (Domain, Infrastructure, API)
- Swagger UI for testing and documentation
- Repository pattern and dependency injection

---

## Tech Stack

- **Language**: C# (.NET 9)
- **Framework**: ASP.NET Core Minimal API
- **Database**: SQLite via EF Core
- **Documentation**: Swagger (Swashbuckle)

---

## Project Structure

\`\`\`
DevTasker/
├── DevTasker.Api/             # ASP.NET Core API (entry point)
├── DevTasker.Domain/          # Entity models and interfaces
├── DevTasker.Infrastructure/  # Data access (EF Core, DbContext, Repositories)
├── DevTasker.Application/     # Reserved for business logic (currently minimal)
└── DevTasker.sln              # Solution file
\`\`\`

---

## How to Run Locally

### 1. Clone the Repository

\`\`\`bash
git clone https://github.com/YOUR_USERNAME/DevTasker.git
cd DevTasker
\`\`\`

### 2. Build the Project

\`\`\`bash
dotnet restore
dotnet build
\`\`\`

### 3. Run Database Migrations

\`\`\`bash
dotnet ef migrations add InitialCreate -p DevTasker.Infrastructure -s DevTasker.Api
dotnet ef database update -p DevTasker.Infrastructure -s DevTasker.Api
\`\`\`

### 4. Start the API

\`\`\`bash
dotnet run --project DevTasker.Api
\`\`\`

### 5. Open Swagger UI

Once the app is running, visit:

\`\`\`
http://localhost:<your-port>/swagger
\`\`\`

_Default port is printed in the terminal, e.g. \`http://localhost:5238/swagger\`_

---

## Sample API Request

### Create a Task

\`\`\`http
POST /tasks
\`\`\`

**Request Body:**

\`\`\`json
{
  "title": "Finish README",
  "description": "Add docs to the DevTasker repo",
  "dueDate": "2025-05-15T18:00:00",
  "isCompleted": false
}
\`\`\`

---

## 📬 Endpoints

| Method | Route         | Description        |
|--------|---------------|--------------------|
| GET    | \/tasks\      | Get all tasks      |
| GET    | \/tasks/{id}\ | Get task by ID     |
| POST   | \/tasks\      | Create new task    |
| PUT    | \/tasks/{id}\ | Update existing    |
| DELETE | \/tasks/{id}\ | Delete task        |

---

## Author

**Garv Singh**  
Intern-ready full stack developer  

---

## License

This project is licensed under the MIT License.
EOF
