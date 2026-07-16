using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Commands.CatalogItemCommands;

public record UpdateCatalogItemCommand
(
    Guid Id,
    string? Title,
    string? ShortDescription,
    string? FullDescription,
    string? ImageUrl,
    decimal Price,
    Brand? Brand,
    Category? Category
    ) : IRequest<UpdateCatalogItemResult>;
