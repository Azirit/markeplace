using Catalog.Application.Queries.CatalogItemQueries;
using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Handlers.CatalogItemHandler;

public class GetCatalogItemsByBrandTitleQueryHandler(
    ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<GetCatalogItemsByBrandTitleQuery, GetCatalogItemsByBrandTitleResult>
{
    public async Task<GetCatalogItemsByBrandTitleResult> Handle(
        GetCatalogItemsByBrandTitleQuery query,
        CancellationToken cancellationToken)
    {

        IEnumerable<CatalogItem> catalogItemList = await catalogItemRepository.GetCatalogItemsByBrandAsync(query.BrandTitle);

        return new GetCatalogItemsByBrandTitleResult(catalogItemList);
    }
}
