using Catalog.Domain.Entities;

namespace Catalog.Application.Responses.CatalogItemResponses;

public record class GetCatalogItemsByTitleResult(IEnumerable<CatalogItem> CatalogItems);
