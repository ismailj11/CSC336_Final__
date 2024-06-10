using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.DTOS.Pilots;
using FINAL_BLL.Services.PassengersServices;
using FINAL_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final__.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PilotController : GenericController<PilotDto>
    {
        private readonly IPilotService _pilotService;
        public PilotController(IPilotService service) : base(service)
        {
            _pilotService = service;
        }



    }
}
