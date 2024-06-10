using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.DTOS.Reservations;
using FINAL_BLL.DTOS.Reservationwithflightandpassenger;
using FINAL_BLL.Services.GenericServices;
using FINAL_BLL.Wrapping.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.ReservationsServices
{
    public interface IReservationService : IGenericService<ReservationDto>
    {
        
        ApiResponse<ReservationWithFlightAndPassengerDto> AddResWithFlightPass(ReservationWithFlightAndPassengerDto dto);

    }
}
