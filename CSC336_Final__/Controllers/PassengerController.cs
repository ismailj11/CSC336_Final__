using FINAL_BLL.DTOS.Airplanes;
using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.Services.Airplanes;
using FINAL_BLL.Services.PassengersServices;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final__.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PassengerController : GenericController<PassengerDto>
    {
        private readonly IPassengerService _passengerService;
        public PassengerController(IPassengerService service) : base(service)
        {
            _passengerService = service;
        }



    }
}
