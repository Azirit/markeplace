using Catalog.Application.Commands.CatalogItemCommands;
using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;
using Mapster;

namespace Catalog.Application.Handlers.CatalogItemHandler;

public class CreateCatalogItemHandler(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<CreateCatalogItemCommand, CreateCatalogItemResult>
{
    public async Task<CreateCatalogItemResult> Handle(
        CreateCatalogItemCommand command, CancellationToken cancellationToken)
    {
        var catalogItem = command.Adapt<CatalogItem>();
        catalogItem.Id = Guid.NewGuid();
        await catalogItemRepository.CreateCatalogItemAsync(catalogItem);
        return new CreateCatalogItemResult(catalogItem.Id);
    }
}
