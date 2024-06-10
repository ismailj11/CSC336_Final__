using AutoMapper;
using FINAL_BLL.DTOS.Airplanes;
using FINAL_BLL.DTOS.Flights;
using FINAL_BLL.Services.FlightsServices;
using FINAL_BLL.Services.GenericServices;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.Airplanes;
using FINAL_DAL.Repositories.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.Airplanes
{
    public class AirplaneService : GenericService<Airplane, AirplaneDto>, IAirplaneService
    {
        public readonly IAirplaneRepository _airplaneRepository;
        public readonly IMapper _mapper;

        public AirplaneService(IAirplaneRepository airplaneRepository, IMapper mapper) : base(airplaneRepository, mapper)
        {
            _airplaneRepository = airplaneRepository;
            _mapper = mapper;
        }




    }
}
