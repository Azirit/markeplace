using Catalog.Application.Queries.CatalogItemQueries;
using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Handlers.CatalogItemHandler;

public class GetCatalogItemsByTitleQueryHandler(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<GetCatalogItemsByTitleQuery, GetCatalogItemsByTitleResult>
{
    public async Task<GetCatalogItemsByTitleResult> Handle(GetCatalogItemsByTitleQuery query, CancellationToken cancellationToken)
    {
        IEnumerable<CatalogItem> catalogItemList =
            await catalogItemRepository.GetCatalogItemsByTitleAsync(query.Title);

        return new(catalogItemList);
    }
}
