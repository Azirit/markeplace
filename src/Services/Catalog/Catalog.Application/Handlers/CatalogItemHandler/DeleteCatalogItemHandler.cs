using Catalog.Application.Commands.CatalogItemCommands;
using Catalog.Application.Responses.CatalogItemResponses;

namespace Catalog.Application.Handlers.CatalogItemHandler;

public class DeleteCatalogItemHandler(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<DeleteCatalogItemCommand, DeleteCatalogItemResult>
{
    public async Task<DeleteCatalogItemResult> Handle(
        DeleteCatalogItemCommand request,
        CancellationToken cancellationToken)
    {
        var isSuccess = await catalogItemRepository.DeleteCatalogItemAsync(request.Id);

        return new DeleteCatalogItemResult(isSuccess);
    }
}
