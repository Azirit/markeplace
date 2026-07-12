using Catalog.Application.Queries.BrandQueries;
using Catalog.Application.Responses.BrandResponses;
using System.Net;


namespace Catalog.Api.Controllers;


public class BrandsController : ApiController
{
    [HttpGet]
    [ProducesResponseType(typeof(GetBrandsResult), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetBrandsResult>> GetAll()
        => Ok(await Mediator.Send(new GetBrandsQuery()));
}
