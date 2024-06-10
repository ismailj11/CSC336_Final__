using AutoMapper;
using FINAL_BLL.DTOS.Airplanes;
using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.DTOS.Pilots;
using FINAL_BLL.DTOS.Reservations;
using FINAL_BLL.DTOS.Reservationwithflightandpassenger;
using FINAL_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Mapping
{
    public class MappingProfile :Profile
    {

        public MappingProfile()
        {

            CreateMap<Airplane, AirplaneDto>().ReverseMap();
            CreateMap<Flight, FlightDto>().ReverseMap();
            CreateMap<Pilot, PilotDto>().ReverseMap();
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<Passenger, PassengerDto>().ReverseMap();



            CreateMap<Reservation, ReservationWithFlightAndPassengerDto>();
            CreateMap<Flight, ReservationWithFlightAndPassengerDto>();
            CreateMap<Passenger, ReservationWithFlightAndPassengerDto>();



        }



    }
}
