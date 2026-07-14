
using Catalog.Application.Queries.CatalogItemQueries;
using Catalog.Application.Responses.CatalogItemResponses;
using System.Net;

namespace Catalog.Api.Controllers;

public class CatalogItemsController : ApiController
{
    [HttpGet]
    [ProducesResponseType(typeof(GetCatalogItemsResult), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetCatalogItemsResult>> GetAll()
        => Ok(await Mediator.Send(new GetCatalogItemsQuery()));
}
