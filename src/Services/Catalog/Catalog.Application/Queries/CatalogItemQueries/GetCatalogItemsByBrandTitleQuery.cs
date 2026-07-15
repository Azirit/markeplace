using Catalog.Application.Responses.CatalogItemResponses;

namespace Catalog.Application.Queries.CatalogItemQueries;

public record class GetCatalogItemsByBrandTitleQuery(string BrandTitle)
    : IRequest<GetCatalogItemsByBrandTitleResult>;
