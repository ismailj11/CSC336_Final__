using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.DTOS.Passengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.DTOS.Reservationwithflightandpassenger
{
    public class ReservationWithFlightAndPassengerDto
    {



        public int ReservationId { get; set; }

        public int? FlightId { get; set; }

        public int? PassengerId { get; set; }

        public string? SeatNumber { get; set; }

        public DateTime? ReservationDate { get; set; }



      public PassengerDto? Passenger { get; set; } 


        public FlightDto? Flight { get; set; }


    }
}
