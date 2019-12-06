using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sales.Domain.Vehicle;

namespace Sales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class vehicleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public vehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> Get(string registration)
        {
            var response = await _mediator.Send(new VehicleQuery(registration));
            return Ok(response);
        }
    }
}
