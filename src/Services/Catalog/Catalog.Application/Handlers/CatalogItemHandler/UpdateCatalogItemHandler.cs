using Catalog.Application.Commands.CatalogItemCommands;
using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;
using Mapster;

namespace Catalog.Application.Handlers.CatalogItemHandler;

public class UpdateCatalogItemHandler(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<UpdateCatalogItemCommand, UpdateCatalogItemResult>
{
    public async Task<UpdateCatalogItemResult> Handle(
        UpdateCatalogItemCommand command, CancellationToken cancellationToken)
    {
        var existItem = await catalogItemRepository.GetCatalogItemAsync(command.Id);

        if (existItem is null)
        {
            return new UpdateCatalogItemResult(false);
        }

        var catalogItem = command.Adapt<CatalogItem>();

        var isSuccess = await catalogItemRepository.UpdateCatalogItemAsync(catalogItem);

        return new UpdateCatalogItemResult(isSuccess);
    }
}
