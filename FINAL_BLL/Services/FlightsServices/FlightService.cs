using AutoMapper;
using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.Services.GenericServices;
using FINAL_BLL.Services.PassengersServices;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.Flights;
using FINAL_DAL.Repositories.Passengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.FlightsServices
{
    public class FlightService : GenericService<Flight, FlightDto>, IFlightService
    {
        public readonly IFlightRepository _flightRepository;
        public readonly IMapper _mapper;

        public FlightService(IFlightRepository flightRepository, IMapper mapper) : base(flightRepository, mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }




    }
}
