```
Employee CRUD API (.NET Core)

A simple Employee Management CRUD API built with ASP.NET Core Web API and Entity Framework Core, using SQL Server as the database.  

This project demonstrates basic Create, Read, Update, Delete (CRUD) operations on an Employee resource.

---

🚀 Features
- Get all employees
- Get employee by ID
- Add new employee
- Update employee
- Delete employee

---

🛠️ Tech Stack
- .NET 8 / ASP.NET Core Web API**
- Entity Framework Core**
- SQL Server**
- Swagger (API testing)**

---

📂 Project Structure

EmployeeAdminPortal/
├── Controllers/
│   └── EmployeesController.cs   # CRUD endpoints
├── Data/
│   └── ApplicationDbContext.cs  # EF Core DbContext
├── Models/
│   ├── AddEmployeeDto.cs
│   ├── UpdateEmployeeDto.cs
│   └── Entities/Employee.cs     # Employee entity
└── Program.cs                   # Startup config

---

⚡ API Endpoints

| Method | Endpoint               | Description              |
|--------|-------------------------|--------------------------|
| GET    | `/api/employees`        | Get all employees        |
| GET    | `/api/employees/{id}`   | Get employee by ID       |
| POST   | `/api/employees`        | Add new employee         |
| PUT    | `/api/employees/{id}`   | Update employee by ID    |
| DELETE | `/api/employees/{id}`   | Delete employee by ID    |

---

🔧 How to Run

1. Clone this repo
   ```bash
   git clone https://github.com/your-username/dotnetcore-employee-crud-api.git
   cd dotnetcore-employee-crud-api

2. Update the connection string in `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=EmployeeDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }

3. Start the project:
   ```bash
   dotnet run


✅ Example Usage

- GET /api/employees** → Returns list of employees
- POST /api/employees** → Adds a new employee
- PUT /api/employees/{id}** → Updates an employee
- DELETE /api/employees/{id}** → Deletes an employee

