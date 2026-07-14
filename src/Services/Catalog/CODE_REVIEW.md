# Code Review Checklist

## Naming Conventions

### Folders
- Папки в единственном числе: `BrandHandlers`, `BrandQueries`, `BrandResponses`
- Не смешивать singular/plural:❌ `CategoriesQueries`, ✅ `CategoryQueries`

### Namespaces
- Namespace совпадает с именем папки: `Catalog.Application.Queries.BrandQueries`
- Не использовать plural в namespace если папка singular

### Classes & Records
- Query: `Get{Entity}Query` (record class)
- Handler: `Get{Entity}QueryHandler` (class)
- Response: `Get{Entity}Result` (record class)
- Свойства в Response — во множественном числе: `IEnumerable<Brand> Brands`, не `Brand`

### Files
- Имя файла = имя класса: `GetBrandsQuery.cs`, `GetBrandsQueryHandler.cs`

## CQRS Structure

```
Catalog.Application/
├── Handlers/{Entity}Handlers/
│   └── Get{Entities}QueryHandler.cs
├── Queries/{Entity}Queries/
│   └── Get{Entities}Query.cs
└── Responses/{Entity}Responses/
    └── Get{Entities}Result.cs
```

## Code Style

### Primary constructors
- Использовать primary constructors для Handler'ов:
  ```csharp
  public class GetBrandsQueryHandler(IBrandRepository brandRepository) : IRequestHandler<GetBrandsQuery, GetBrandsResult>
  ```

### Records
- Query и Response — `record class`, не `class`:
  ```csharp
  public record class GetBrandsQuery : IRequest<GetBrandsResult>;
  public record class GetBrandsResult(IEnumerable<Brand> Brands);
  ```

### Global Usings
- Общие using'и в `GlobalUsings.cs` проекта
- Локальные using'и в файле, если специфичны для него

### Controllers
- Наследуются от `ApiController`
- Используют `Mediator` (из базового класса)
- `[ProducesResponseType]` для документирования ответа

## Consistency Rules

1. **Единообразие** — если для Brand используется `BrandQueries`, то и для Category — `CategoryQueries`
2. **Plural в свойствах** — коллекции называть во множественном: `Brands`, `Categories`, `Items`
3. **Singular в папках/namespace** — `CategoryHandlers`, не `CategoriesHandlers`
4. **Паттерн повторяется** — каждый новый Entity копирует структуру существующего

## Common Mistakes

| Ошибка | Правильно |
|---|---|
| `CategoriesQueries` (папка) | `CategoryQueries` |
| `IEnumerable<Category> Category` | `IEnumerable<Category> Categories` |
| `class GetBrandsQuery` | `record class GetBrandsQuery` |
| `public class Handler : IRequestHandler` | `public class Handler(ICategoryRepository repo) : IRequestHandler` |
