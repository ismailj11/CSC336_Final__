using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.DTOS.Reservations;
using FINAL_BLL.DTOS.Reservationwithflightandpassenger;
using FINAL_BLL.Services.FlightsServices;
using FINAL_BLL.Services.ReservationsServices;
using FINAL_BLL.Wrapping.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_Final__.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReservationController : GenericController<ReservationDto>
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService service) : base(service)
        {
            _reservationService = service;
        }


        [HttpPost("AddResWithFlightPass")]
        public ActionResult<ApiResponse<ReservationWithFlightAndPassengerDto>> Add(ReservationWithFlightAndPassengerDto dto)
        {
            var response = _reservationService.AddResWithFlightPass(dto);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
