
using Catalog.Application.Commands.CatalogItemCommands;
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

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetCatalogItemByIdResult), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetCatalogItemByIdResult>> GetById(Guid id)
    => Ok(await Mediator.Send(new GetCatalogItemByIdQuery(id)));

    [HttpGet("search/{title}")]
    [ProducesResponseType(typeof(GetCatalogItemsByTitleResult), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetCatalogItemsByTitleResult>> GetByTitle(string title)
    => Ok(await Mediator.Send(new GetCatalogItemsByTitleQuery(title)));

    [HttpGet("brand/{title}")]
    [ProducesResponseType(typeof(GetCatalogItemsByBrandTitleResult), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetCatalogItemsByBrandTitleResult>> GetByBrandTitle(string title)
    => Ok(await Mediator.Send(new GetCatalogItemsByBrandTitleQuery(title)));

    [HttpPost]
    [ProducesResponseType(typeof(CreateCatalogItemResult), (int)HttpStatusCode.Created)]
    public async Task<ActionResult<GetCatalogItemsResult>> CreateCatalogItem(
        [FromBody] CreateCatalogItemCommand command)
    {
        var result = await Mediator.Send(command);
        return CreatedAtAction(
            nameof(GetById),
            new { id = result.Id },
            result
        );
    }
}
