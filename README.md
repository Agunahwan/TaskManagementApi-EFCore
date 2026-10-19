# TaskManagementApi-EFCore

A hands-on tutorial project for **AA Programming Video #04**, demonstrating how to integrate ASP.NET Core Web API with Entity Framework Core and SQL Server to persist data.

This project builds on the REST API CRUD example from Video #01 and extends it to store task data in a SQL Server database.

## Features

- ASP.NET Core Web API
- Entity Framework Core integration
- SQL Server database
- Database migrations
- CRUD operations (Create, Read, Update, Delete)
- API testing with Postman
- Persistent data storage

## Tech Stack

- C#
- ASP.NET Core Web API
- Entity Framework Core
- Microsoft SQL Server
- Postman

## Prerequisites

Before running this project, make sure you have:

- A compatible .NET SDK
- Microsoft SQL Server
- EF Core CLI (`dotnet-ef`)
- Postman (for API testing)

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/Agunahwan/TaskManagementApi-EFCore.git
cd TaskManagementApi-EFCore
```

### 2. Configure the Database Connection

Configure the SQL Server connection in your local application settings.

Do not commit passwords, credentials, or other secrets to this repository.

### 3. Restore Dependencies

```bash
dotnet restore
```

### 4. Build the Project

```bash
dotnet build
```

### 5. Apply Database Migrations

After configuring the database connection, apply the EF Core migrations:

```bash
dotnet ef database update
```

Make sure the EF Core CLI is installed and compatible with the project's EF Core version.

### 6. Run the API

```bash
dotnet run
```

Use the application URL and endpoints displayed in the terminal to test the API.

## Testing with Postman

Use Postman to test the CRUD endpoints available in the project:

- **Create:** Create a new task.
- **Read:** Retrieve tasks from the database.
- **Update:** Update an existing task.
- **Delete:** Delete a task.

### Verify Data Persistence

To verify that data is stored persistently:

1. Create a task using Postman.
2. Confirm that the task is stored in SQL Server.
3. Stop and restart the API.
4. Retrieve the task again using Postman.
5. Verify that the task still exists.

Data should remain available after the API restarts, provided it has not been deleted from the database.

## What You'll Learn

By following this project, you'll learn how to:

- Connect an ASP.NET Core Web API to SQL Server.
- Use Entity Framework Core for database operations.
- Configure a `DbContext`.
- Apply database migrations.
- Implement CRUD operations using persistent storage.
- Test API endpoints with Postman.

## Related Repository

**Video #01 — ASP.NET Core REST API CRUD**

https://github.com/Agunahwan/TaskManagementApi

## Security Notes

- Never commit database passwords or credentials.
- Use local configuration or .NET User Secrets for development when appropriate.
- Avoid exposing connection strings containing credentials in screenshots or recordings.
- Review database migrations before applying them to important environments.

## About AA Programming

**AA Programming** shares practical programming tutorials covering application development, REST APIs, databases, and debugging.

Follow the channel for more hands-on tutorials, including JWT Authentication in Video #05.

If this repository helps you, feel free to give it a ⭐.