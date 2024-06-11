using System;
using getflightsbackend.RepositoryModels;
using Microsoft.AspNetCore.Mvc;

namespace getflightsbackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightsController: ControllerBase
	{
		public IFlightsServices _flightSerivces;
		public FlightsController(IFlightsServices flightSerivces)
		{
			_flightSerivces = flightSerivces;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			try {
				var flights = _flightSerivces.GetFlights();
				return Ok(flights);

			}catch(Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}

		}
	}
}

