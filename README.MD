# https://stepik.org/lesson/1938776/step/1?unit=1965512
# Marketplace

Online marketplace built with Clean Architecture (.NET 10).

## Architecture

The solution follows Clean Architecture principles with a modular monolith approach, organized by business capabilities:

```
src/
  Services/
    Catalog/          # Product catalog service
      Catalog.Api          - API layer (controllers, middleware)
      Catalog.Application  - Use cases, DTOs, interfaces
      Catalog.Domain       - Entities, value objects, enums
      Catalog.Infrastructure - Data access, external services
```

## Tech Stack

- .NET 10
- Clean Architecture
- CQRS with MediatR
- Entity Framework Core
- PostgreSQL
- FluentValidation

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- Docker Desktop (for local PostgreSQL)

## Getting Started

```bash
# Clone the repository
git clone <repo-url>
cd Marketplace

# Restore dependencies
dotnet restore

# Run database migrations (from Catalog.Infrastructure)
dotnet ef database update -s src/Services/Catalog/Catalog.Api

# Run the API
dotnet run --project src/Services/Catalog/Catalog.Api
```

## Project Status

Active development — part of the Clean Architecture course.

## Author

Sergey Zalygin
