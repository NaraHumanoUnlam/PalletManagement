using Application.UseCases.Pallets.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalletManagementController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public PalletManagementController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePallet([FromBody] CreatePalletCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
