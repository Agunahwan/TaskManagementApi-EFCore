# TaskManagementApi-EFCore

A hands-on tutorial project for **AA Programming Video #04**, demonstrating how to build an ASP.NET Core Web API with Entity Framework Core and SQL Server.

This project continues the Task Management API from Video #01 and replaces in-memory storage with persistent database storage.

## Features

- ASP.NET Core Web API using controllers
- Entity Framework Core with SQL Server
- Database migrations
- Asynchronous CRUD operations
- Postman and `.http` request examples
- Data persists when the API restarts

## Technology Stack

- .NET 10
- C#
- Entity Framework Core 10
- Microsoft SQL Server
- Postman

## Prerequisites

- .NET 10 SDK
- A running SQL Server instance
- Postman (optional, for API testing)
- EF Core CLI

Install the EF Core CLI if needed:

```powershell
dotnet tool install --global dotnet-ef --version 10.0.12
```

If it is already installed, update it with:

```powershell
dotnet tool update --global dotnet-ef --version 10.0.12
```

## 1. Configure the SQL Server connection

The sample connection string in `appsettings.json` uses Windows Integrated Authentication and assumes SQL Server is available at `localhost`:

```text
Server=localhost;Database=TaskManagementDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true
```

Adjust `Server` to match your SQL Server instance. For SQL Server Express, for example, the server might be `localhost\\SQLEXPRESS`.

If you use SQL Server authentication, use a local secret/configuration override instead of committing a real username or password to Git. For example, configure the `ConnectionStrings:DefaultConnection` setting through .NET User Secrets or an environment variable.

PowerShell environment-variable example (replace the placeholders locally; do not share real credentials):

```powershell
$env:ConnectionStrings__DefaultConnection = "Server=localhost;Database=TaskManagementDb;User Id=<USERNAME>;Password=<PASSWORD>;TrustServerCertificate=True;Encrypt=True"
```

## 2. Restore and build

From the directory containing `TaskManagementApi.csproj`:

```powershell
dotnet restore
dotnet build
```

## 3. Apply the database migration

This repository already includes the initial migration. After configuring the SQL Server connection, apply it:

```powershell
dotnet ef database update
```

The migration creates the `TaskItems` table. When you make future model changes, create a new migration with a descriptive name before updating the database.

To demonstrate migration creation from scratch while recording the tutorial, use a clean copy of the source without the `Migrations` folder and run:

```powershell
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 4. Run the API

```powershell
dotnet run
```

The included launch profile uses `http://localhost:5180`. Check the terminal output for the actual listening URL.

In Development, the OpenAPI document is available at:

```text
http://localhost:5180/openapi/v1.json
```

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/tasks` | Get all tasks |
| GET | `/api/tasks/{id}` | Get a task by ID |
| POST | `/api/tasks` | Create a task |
| PUT | `/api/tasks/{id}` | Update a task |
| DELETE | `/api/tasks/{id}` | Delete a task |

### Example request body

```json
{
  "title": "Learn Entity Framework Core",
  "isCompleted": false
}
```

`title` is required and has a maximum length of 200 characters.

## Verify Persistence

1. Start the API.
2. Send a `POST /api/tasks` request from Postman.
3. Confirm the row exists in SQL Server's `TaskItems` table.
4. Stop the API and start it again.
5. Send `GET /api/tasks`.
6. Confirm that the created task is still returned.

The task should remain available because it is stored in SQL Server rather than an in-memory list.

## Related Repository

**Video #01 — ASP.NET Core REST API CRUD**

https://github.com/Agunahwan/TaskManagementApi

## Security Notes

- Never commit real database credentials or secrets.
- Do not show passwords or sensitive connection details in screen recordings.
- The sample enables `TrustServerCertificate=True` to simplify local development. Review TLS certificate validation settings for production.
- Review migrations before applying schema changes to important databases.

## About AA Programming

AA Programming shares practical programming tutorials covering APIs, databases, application development, and debugging.

Follow the channel for more tutorials, including JWT Authentication in Video #05.
