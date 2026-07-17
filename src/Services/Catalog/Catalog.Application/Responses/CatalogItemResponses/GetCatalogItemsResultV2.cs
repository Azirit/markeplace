using Catalog.Domain.Specifications;
using Catalog.Domain.Entities;

namespace Catalog.Application.Responses.CatalogItemResponses;

public record class GetCatalogItemsResultV2(Pagination<CatalogItem> CatalogItems);
