using Catalog.Domain.Entities;

namespace Catalog.Application.Responses.CatalogItemResponses;

public record class GetCatalogItemsResult(IEnumerable<CatalogItem> CatalogItems);
