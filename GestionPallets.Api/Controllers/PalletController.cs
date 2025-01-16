using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using GestionPallets.Application.Command.Create;
using GestionPallets.Application.Command.Update;
using GestionDepallet.Application.Queries;
using GestionPallets.Application.Command.Delete;

namespace GetionPallets.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PalletController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PalletController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] CreatePalletCommand registerStockCommand)
        {
            try
            {
                var stockId = await _mediator.Send(registerStockCommand);

                return Ok($"Stock registrado: {stockId}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("all")]
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns></returns>
        public async Task<IActionResult> GetAll()
        {
           return Ok(await _mediator.Send(new GetAll()));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStock([FromBody] UpdateStockCommand request)
        {
           return Ok(await _mediator.Send(request));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStock(int stockId)
        {
           var stockToDelete = new DeletePalletCommand { StockId = stockId };
            return Ok(await _mediator.Send(stockToDelete));
        }
    }
}
