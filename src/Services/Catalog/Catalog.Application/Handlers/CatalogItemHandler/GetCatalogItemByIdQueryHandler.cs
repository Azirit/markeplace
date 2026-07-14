using Catalog.Application.Queries.CatalogItemQueries;
using Catalog.Application.Responses.CatalogItemResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Handlers.CatalogItemHandler;

public class GetCatalogItemByIdQueryHandler(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<GetCatalogItemByIdQuery, GetCatalogItemByIdResult>
{
    public async Task<GetCatalogItemByIdResult> Handle(GetCatalogItemByIdQuery query, CancellationToken cancellationToken)
    {
        CatalogItem catalogItem = await catalogItemRepository.GetCatalogItemAsync(query.Id);

        return new GetCatalogItemByIdResult(catalogItem);
    }
}
