using Catalog.Domain.Entities;

namespace Catalog.Application.Responses.BrandResponses;

public record class GetBrandsResult(IEnumerable<Brand> Brands);
