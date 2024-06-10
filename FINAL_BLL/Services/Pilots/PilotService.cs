using AutoMapper;
using FINAL_BLL.DTOS.Passengers;
using FINAL_BLL.DTOS.Pilots;
using FINAL_BLL.Services.GenericServices;
using FINAL_BLL.Services.PassengersServices;
using FINAL_DAL.Models;
using FINAL_DAL.Repositories.Passengers;
using FINAL_DAL.Repositories.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_BLL.Services.Pilots
{
    public class PilotService : GenericService<Pilot, PilotDto>, IPilotService
    {
        public readonly IPilotRepository _pilotRepository;
        public readonly IMapper _mapper;

        public PilotService(IPilotRepository pilotRepository, IMapper mapper) : base(pilotRepository, mapper)
        {
            _pilotRepository = pilotRepository;
            _mapper = mapper;
        }




    }
}
