using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.DTOS.Reservations;
using FINAL_BLL.Services.FlightsServices;
using FINAL_BLL.Services.ReservationsServices;
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



    }
}
