using Catalog.Application.Queries.CategoryQueries;
using Catalog.Application.Responses.CategoryResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Handlers.CategoryHandlers;

public class GetCategoriesQueryHandler(ICategoryRepository categoryRepository) : IRequestHandler<GetCategoriesQuery, GetCategoriesResult>
{
    public async Task<GetCategoriesResult> Handle(GetCategoriesQuery query, CancellationToken cancellationToken)
    {
        IEnumerable<Category> categoryList = await categoryRepository.GetAllAsync();

        return new(categoryList);
    }

}
