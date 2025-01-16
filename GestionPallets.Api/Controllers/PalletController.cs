using Microsoft.AspNetCore.Mvc;
using MediatR;
using GetionPallets.Application.Command.Create;
using GetionPallets.Application.Queries;
using GetionPallets.Application.Command.Update;
using GetionPallets.Application.Command.Delete;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<IActionResult> GetAllStocks()
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
