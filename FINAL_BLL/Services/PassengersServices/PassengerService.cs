using AutoMapper;
using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.Services.GenericServices;
using FINAL_BLL.Services.PassengersServices;
using FINAL_BLL.Wrapping.Exceptions;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.Passengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.PassengersServices
{
    public class PassengerService : GenericService<Passenger, PassengerDto>, IPassengerService
    {
        public readonly IPassengerRepository _passengerRepository;
        public readonly IMapper _mapper;

        public PassengerService(IPassengerRepository passengerRepository, IMapper mapper) : base(passengerRepository, mapper)
        {
            _passengerRepository = passengerRepository;
            _mapper = mapper;
        }

        


    }
}
