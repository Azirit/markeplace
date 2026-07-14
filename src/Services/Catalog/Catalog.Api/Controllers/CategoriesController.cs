using Catalog.Application.Queries.CategoryQueries;
using Catalog.Application.Responses.CategoryResponses;
using System.Net;

namespace Catalog.Api.Controllers;

public class CategoriesController : ApiController
{
    [HttpGet]
    [ProducesResponseType(typeof(GetCategoriesResult), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetCategoriesResult>> GetAll()
        => Ok(await Mediator.Send(new GetCategoriesQuery()));
}
