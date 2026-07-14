using Catalog.Application.Queries.BrandQueries;
using Catalog.Application.Responses.BrandResponses;
using Catalog.Domain.Entities;

namespace Catalog.Application.Handlers.BrandHandler;


public class GetBrandsQueryHandler(IBrandRepository brandRepository) : IRequestHandler<GetBrandsQuery, GetBrandsResult>
{
    public async Task<GetBrandsResult> Handle(GetBrandsQuery query, CancellationToken cancellationToken)
    {
        IEnumerable<Brand> brandList = await brandRepository.GetAllAsync();

        return new(brandList);
    }

}

