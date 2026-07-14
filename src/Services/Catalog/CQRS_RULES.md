# CQRS Naming Conventions

## Operation Types

| Тип | Назначение | Пример |
|---|---|---|
| **Query** | Получение данных (GET) | `GetBrandsQuery` |
| **Command** | Изменение данных (POST, PUT, DELETE) | `CreateBrandCommand` |

## Naming Pattern

```
{Действие}{Сущность}{Тип}
```

### Query (получение данных)

| Элемент | Формат | Пример |
|---|---|---|
| Query | `Get{Entity}Query` | `GetBrandsQuery` |
| Query by ID | `Get{Entity}ByIdQuery` | `GetCatalogItemByIdQuery` |
| Handler | `Get{Entity}QueryHandler` | `GetBrandsQueryHandler` |
| Response | `Get{Entity}Result` | `GetBrandsResult` |

### Command (изменение данных)

| Элемент | Формат | Пример |
|---|---|---|
| Create | `Create{Entity}Command` | `CreateBrandCommand` |
| Update | `Update{Entity}Command` | `UpdateBrandCommand` |
| Delete | `Delete{Entity}Command` | `DeleteBrandCommand` |
| Handler | `{Action}{Entity}CommandHandler` | `CreateBrandCommandHandler` |
| Response | `{Action}{Entity}Result` | `CreateBrandResult` |

## Folder Structure

```
Catalog.Application/
├── Handlers/
│   ├── BrandHandler/
│   │   ├── GetBrandsQueryHandler.cs
│   │   └── CreateBrandCommandHandler.cs
│   └── CategoryHandler/
│       ├── GetCategoriesQueryHandler.cs
│       └── CreateCategoryCommandHandler.cs
├── Queries/
│   ├── BrandQueries/
│   │   ├── GetBrandsQuery.cs
│   │   └── GetBrandByIdQuery.cs
│   └── CategoryQueries/
│       ├── GetCategoriesQuery.cs
│       └── GetCategoryByIdQuery.cs
├── Commands/
│   ├── BrandCommands/
│   │   └── CreateBrandCommand.cs
│   └── CategoryCommands/
│       └── CreateCategoryCommand.cs
└── Responses/
    ├── BrandResponses/
    │   ├── GetBrandsResult.cs
    │   └── CreateBrandResult.cs
    └── CategoryResponses/
        ├── GetCategoriesResult.cs
        └── CreateCategoryResult.cs
```

## Namespace Rules

- Namespace совпадает с папкой: `Catalog.Application.Handlers.BrandHandler`
- Handlers в единственном числе: `BrandHandler`, не `BrandHandlers`
- Queries/Commands/Responses — во множественном: `BrandQueries`, `BrandResponses`

## Code Examples

### Query + Handler

```csharp
// Query
public record class GetBrandsQuery : IRequest<GetBrandsResult>;

// Handler
public class GetBrandsQueryHandler(IBrandRepository brandRepository) 
    : IRequestHandler<GetBrandsQuery, GetBrandsResult>
{
    public async Task<GetBrandsResult> Handle(GetBrandsQuery query, CancellationToken ct)
    {
        var brands = await brandRepository.GetAllAsync();
        return new(brands);
    }
}

// Response
public record class GetBrandsResult(IEnumerable<Brand> Brands);
```

### Command + Handler

```csharp
// Command
public record class CreateBrandCommand(string Title) : IRequest<CreateBrandResult>;

// Handler
public class CreateBrandCommandHandler(IBrandRepository brandRepository) 
    : IRequestHandler<CreateBrandCommand, CreateBrandResult>
{
    public async Task<CreateBrandResult> Handle(CreateBrandCommand command, CancellationToken ct)
    {
        var brand = new Brand { Title = command.Title };
        await brandRepository.AddAsync(brand);
        return new(brand.Id);
    }
}

// Response
public record class CreateBrandResult(Guid Id);
```

## Common Mistakes

| Ошибка | Правильно |
|---|---|
| `GetBrandsHandler` | `GetBrandsQueryHandler` |
| `CreateBrandHandler` | `CreateBrandCommandHandler` |
| `BrandHandlers` (папка) | `BrandHandler` |
| `IEnumerable<Brand> Brand` | `IEnumerable<Brand> Brands` |
