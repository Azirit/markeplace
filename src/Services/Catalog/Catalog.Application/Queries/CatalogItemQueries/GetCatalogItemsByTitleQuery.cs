using Catalog.Application.Responses.CatalogItemResponses;

namespace Catalog.Application.Queries.CatalogItemQueries;

public record class GetCatalogItemsByTitleQuery(string Title)
    : IRequest<GetCatalogItemsByTitleResult>;
