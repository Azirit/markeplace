using Catalog.Domain.Entities;

namespace Catalog.Application.Responses.CatalogItemResponses;

public record class GetCatalogItemByIdResult(CatalogItem? CatalogItem);
