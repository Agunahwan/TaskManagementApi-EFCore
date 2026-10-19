# TaskManagementApi

A simple Task Management REST API built with ASP.NET Core and .NET 10.

This project is created as part of the **AA Programming** YouTube tutorial series.

## 📺 YouTube Tutorials

### Video #01 — ASP.NET Core REST API: Dari Nol sampai CRUD

In this tutorial, we build a simple REST API for managing tasks using ASP.NET Core.

Topics covered:

- ASP.NET Core Web API
- Controllers
- REST API
- CRUD operations
- OpenAPI
- Postman

### Short #01 — Dependency Injection di ASP.NET Core

In this short, we refactor the API by moving business logic from the Controller into a Service and applying Dependency Injection.

Topics covered:

- Service Pattern
- Interface
- Dependency Injection
- `ITaskService`
- `TaskService`
- `AddScoped`

## 🛠️ Technologies

- .NET 10
- ASP.NET Core Web API
- C#
- OpenAPI

## 📁 Project Structure

```text
TaskManagementApi
├── Controllers
│   └── TasksController.cs
├── Models
│   └── TaskItem.cs
├── Services
│   ├── ITaskService.cs
│   └── TaskService.cs
├── Properties
├── Program.cs
└── TaskManagementApi.csproj
```

## 🚀 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/tasks` | Get all tasks |
| GET | `/api/tasks/{id}` | Get task by ID |
| POST | `/api/tasks` | Create a task |
| PUT | `/api/tasks/{id}` | Update a task |
| DELETE | `/api/tasks/{id}` | Delete a task |

## ▶️ Running the Project

Clone the repository:

```bash
git clone https://github.com/Agunahwan/TaskManagementApi.git
```

Go to the project directory:

```bash
cd TaskManagementApi
```

Run the application:

```bash
dotnet run
```

The API will be available at the URL shown in the terminal.

## 📌 Source Code Versions

This repository contains source code used throughout the AA Programming tutorial series.

- `v1.0.0` — Video #01: REST API CRUD
- `v1.1.0` — Short #01: Dependency Injection

Check out the appropriate version if you want to follow a specific tutorial.

## 📺 AA Programming

YouTube:
https://www.youtube.com/@aaprogrammingid

Programming tutorials about:

- .NET
- ASP.NET Core
- Flutter
- React Native
- PHP
- REST API
- Database
- Debugging
- Developer Experience

---

Made for **AA Programming** 🎯
