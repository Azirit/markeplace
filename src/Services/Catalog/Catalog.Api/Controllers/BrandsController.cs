using Catalog.Application.Queries.BrandQueries;
using Catalog.Application.Responses.BrandResponses;


namespace Catalog.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrandsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<GetBrandsResult>> GetAll()
        => Ok(await mediator.Send(new GetBrandsQuery()));
}
