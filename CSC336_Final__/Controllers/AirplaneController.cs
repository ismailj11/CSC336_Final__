using FINAL_BLL.DTOS.Airplanes;
using FINAL_BLL.Services.Airplanes;
using FINAL_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final__.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AirplaneController : GenericController<AirplaneDto>
    {
        private readonly IAirplaneService _airplaneService;
        public AirplaneController(IAirplaneService service) : base(service)
        {
            _airplaneService = service;
        }

        

    }
}
