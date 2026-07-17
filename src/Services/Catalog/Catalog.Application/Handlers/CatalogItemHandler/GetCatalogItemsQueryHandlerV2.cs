using Catalog.Application.Queries.CatalogItemQueries;
using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;
using Catalog.Domain.Specifications;

namespace Catalog.Application.Handlers.CatalogItemHandler;

public class GetCatalogItemsQueryHandlerV2(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<GetCatalogItemsQueryV2, GetCatalogItemsResultV2>
{
    public async Task<GetCatalogItemsResultV2> Handle(GetCatalogItemsQueryV2 query, CancellationToken cancellationToken)
    {
        var catalogItemList = await catalogItemRepository.GetAllAsync();

        var count = catalogItemList.Count();
        var items = catalogItemList
            .Skip((query.PageIndex - 1) * query.PageSize)
            .Take(query.PageSize)
            .ToList();


        var pagination = new Pagination<CatalogItem>(
            PageIndex: query.PageIndex,
            PageSize: query.PageSize,
            PageCount: count,
            Items: items
        );

        return new GetCatalogItemsResultV2(pagination);
    }
}
