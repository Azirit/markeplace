using Catalog.Application.Queries.CatalogItemQueries;
using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Handlers.CatalogItemHandlers;

public class GetCatalogItemsQueryHandler(ICatalogItemRepository catalogItemRepository) : IRequestHandler<GetCatalogItemsQuery, GetCatalogItemsResult>
{
    public async Task<GetCatalogItemsResult> Handle(GetCatalogItemsQuery query, CancellationToken cancellationToken)
    {
        IEnumerable<CatalogItem> catalogItemList = await catalogItemRepository.GetAllAsync();

        return new(catalogItemList);
    }
}
