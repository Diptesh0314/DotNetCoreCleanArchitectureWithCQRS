# DotNet Core API using Clean Architecture With CQRS

A simple .NET Core API project demonstrating **Clean Architecture** and **CQRS (Command Query Responsibility Segregation)** patterns.

## Project Overview

This project serves as a learning resource for building scalable and maintainable APIs using modern .NET patterns and best practices.

## Project Structure

```
ProductWithCQRSandClean/
├── Core/                    # Domain models (Product entity)
├── Application/             # Business logic, commands, queries, and validators
│   ├── Features/           # Product features (Commands, Queries)
│   ├── Behaviors/          # Pipeline behaviors (e.g., ValidationBehavior)
│   └── Interfaces/         # Repository abstractions
├── Persistence/            # Database access and repositories
│   └── Repositories/       # Product repository implementation
├── Infrastructure/         # Infrastructure services (if any)
└── ProductAPI/             # REST API controllers and entry point
    └── Controllers/        # Product endpoints
```

## What is referencing what? 
```
ProductAPI
 ├── references Application
 ├── references Persistence
 └── references Infrastructure

 Application
 └── references Core

 Persistence
 ├── references Application
 └── references Core

 Infrastructure
 ├── references Application
 └── references Core

 Core
 └── references nobody

 ```

## Tech Stack

- **.NET 10.0** - Latest .NET runtime
- **CQRS Pattern** - Separation of read and write operations
- **Clean Architecture** - Layered architecture for maintainability
- **MediatR** - Pipeline behavior and request handling (implied by CQRS structure)
- **Fluent Validation** - Data validation (ProductValidator, CreateProductValidator)

## Getting Started

### Prerequisites
- .NET 10.0 SDK or later
- Visual Studio 2024 / VS Code with C# extension

### Build the Project
```bash
dotnet build
```

### Run the API in http profile
```bash
dotnet run --project ProductAPI
```

Http profile will be available at
http://localhost:5093

### Run the API in https profile 
```bash
dotnet run --project ProductAPI --launch-profile https
```
Http profile will be available at
http://localhost:7209

For more details check `ProductAPI/Properties/launchSettings.json`

## Features

- **Product Management**
  - Create products via `CreateProductCommand`
  - Retrieve all products via `GetAllProductsQuery`
  - Color validation for products

- **Validation**
  - Product creation validation via `CreateProductValidator`
  - Color field validation via `ProductColorValidator`
  - Built-in validation pipeline behavior

- **Clean Architecture**
  - Separation of concerns across layers
  - Dependency injection configuration in each layer
  - Repository pattern for data access

## Configuration

Application settings are configured in:
- `ProductAPI/appsettings.json` - Production settings
- `ProductAPI/appsettings.Development.json` - Development settings

## Learning Resources

This project demonstrates:
- How to structure a .NET application using Clean Architecture
- Implementation of CQRS pattern with commands and queries
- Validation pipeline behavior
- Dependency injection setup across layers
- Repository pattern usage
- You can refer to this article https://celepbeyza.medium.com/introduction-to-clean-architecture-acf25ffe0310

## License

This is a learning project. Feel free to use it as a reference.
