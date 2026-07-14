using Catalog.Application.Responses.CatalogItemResponses;

namespace Catalog.Application.Queries.CatalogItemQueries;

public record class GetCatalogItemsQuery : IRequest<GetCatalogItemsResult>;
