using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Commands.CatalogItemCommands;

public record CreateCatalogItemCommand
(
    string? Title,
    string? ShortDescription,
    string? FullDescription,
    string? ImageUrl,
    decimal Price,
    Brand? Brand,
    Category? Category
    ) : IRequest<CreateCatalogItemResult>;
