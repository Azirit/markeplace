using Catalog.Application.Queries.BrandQueries;
using Catalog.Application.Responses.BrandResponses;


namespace Catalog.Api.Controllers;


public class BrandsController : ApiController
{
    [HttpGet]
    public async Task<ActionResult<GetBrandsResult>> GetAll()
        => Ok(await Mediator.Send(new GetBrandsQuery()));
}
