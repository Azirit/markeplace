using Catalog.Application.Responses.CatalogItemResponses;

namespace Catalog.Application.Queries.CatalogItemQueries;

public record class GetCatalogItemByIdQuery(Guid Id) : IRequest<GetCatalogItemByIdResult>;
