using Catalog.Application.Responses.CatalogItemResponses;

namespace Catalog.Application.Commands.CatalogItemCommands;

public record DeleteCatalogItemCommand(Guid Id) : IRequest<DeleteCatalogItemResult>; 
