# .Net-8-API-with-Dapper
# Overview

This project is a basic CRUD API built with ASP.NET Core. It uses Entity Framework Core for database schema generation and Dapper for optimized querying. The project is designed to demonstrate how to use both Entity Framework and Dapper within a single application.

The project includes a simple example of a VideoGame entity, providing the following operations:

    Create
    Read (Retrieve all video games)
    Update
    Delete

Features

    ASP.NET Core: Modern web framework for building APIs.
    Entity Framework Core: Used to generate the database schema (only).
    Dapper: Lightweight ORM for optimized database queries.
    SQL Scripts: SQL queries are stored in external .sql files and executed dynamically.
    Dependency Injection: Configured to inject services and repositories.

Prerequisites

Make sure you have the following installed:

    .NET 6+ SDK
    SQL Server
    Visual Studio or VS Code

Setup Instructions

Configure the database connection string in appsettings.json:

json
        
        {
          "ConnectionStrings": {
            "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;"
          }
        }

# Key Files

    Models/VideoGame.cs: Defines the VideoGame entity.
    
    Repositories/VideoGameRepository.cs: Implements the repository using Dapper for data operations.
    
    SQLScripts/: Stores the SQL queries.
    
    Program.cs: Configures services and dependency injection.

# API Endpoints
```
    GET: /api/Videogames	Retrieve all video games
    
    GET: /api/Videogames/{id}	Retrieve a single video game
    
    POST: /api/Videogames	Create a new video game
    
    PUT: /api/Videogames/{id}	Update an existing video game
    
    DELETE: /api/Videogames/{id}	Delete a video game
```
  
# Technologies Used

    ASP.NET Core: A cross-platform framework for building web applications and APIs.
    
    Entity Framework Core: ORM used only for database schema generation.
    
    Dapper: Lightweight ORM for executing optimized SQL queries.
    
    SQL Server: The relational database management system used to store data.

# How to Use External SQL Files

SQL queries are stored in the SQLScripts directory. Each query is executed dynamically within the repository. For example, in the VideoGameRepository:

```C#```

      var sql = ReadSqlFile("SQLScripts/GetAllVideoGames.sql");
      var videoGames = await connection.QueryAsync<VideoGame>(sql);

This approach helps keep SQL queries organized and separate from your codebase.
License

This project is licensed under the MIT License - see the LICENSE file for details.
