using Catalog.Domain.Entities;

namespace Catalog.Application.Responses.CatalogItemResponses;

public record class GetCatalogItemsByBrandTitleResult(IEnumerable<CatalogItem> CatalogItems);
