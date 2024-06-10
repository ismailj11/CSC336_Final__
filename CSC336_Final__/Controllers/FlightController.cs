using FINAL_BLL.DTOS.Airplanes;
using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.Services.Airplanes;
using FINAL_BLL.Services.FlightsServices;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final__.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FlightController : GenericController<FlightDto>
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService service) : base(service)
        {
            _flightService = service;
        }



    }
}
