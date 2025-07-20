using AzureCleanArch.Application.UseCases.GetOrder;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace AzureCleanArch.Functions.UseCases;

public class GetOrderFunction
{
    private readonly ILogger<GetOrderFunction> _logger;
    private readonly IMediator _mediator;

    public GetOrderFunction(ILogger<GetOrderFunction> logger,
        IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [Function("GetOrder")]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var query = new GetOrderQuery(Guid.NewGuid());
        var orderDto = await _mediator.Send(query);

        return new OkObjectResult(orderDto);
    }
}