using Catalog.Domain.Entities;

namespace Catalog.Application.Responses.CategoryResponses;

public record class GetCategoriesResult(IEnumerable<Category> Categories);
